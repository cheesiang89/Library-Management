using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Li Dan

namespace SA45_Team10a_LibraryManagement
{
    public partial class frmManageMember : frmDetails
    {
        PGPLibraryEntities context = new PGPLibraryEntities();
        Navigation n;
        public frmManageMember()
        {
            InitializeComponent();
        }
        public frmManageMember(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
        }

        private void frmManageMember_Load(object sender, EventArgs e)
        {
            n = new Navigation();
            lblUser.Text=$"{UserCategory}: {UserNameFromLogin}";
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            //NEED ADD LOGIC!!
            n.GofrmDashboardLibrarian(this, UserNameFromLogin, UserCategory);
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            if (UserCategory == "Member")
            {
                n.GofrmProfile(this, UserNameFromLogin, UserCategory);
            }
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            n.GofrmLogin(this);
        }

        private void txtMIDUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                retrieveinfo();
            }
        }

        private void retrieveinfo()
        {
            if (txtMIDUpdate.Text != string.Empty && IsNumber())
            {
                if (IsMidExist())
                {
                    int mid = Convert.ToInt32(txtMIDUpdate.Text);
                    Member nMember = context.Members.Where(x => x.MemberID == mid).First();
                    txtBoxFnameUpdate.Text = nMember.FirstName.ToString();
                    txtBoxLNameUpdate.Text = nMember.LastName.ToString();
                    cboBoxMCategoryUpdate.SelectedItem = nMember.MemberCategory.ToString();
                    cboBoxNRICUpdate.SelectedItem = nMember.NRIC;
                    txtSalutationUpdate.Text = nMember.Salutation.ToString();
                    txtAddressUpdate.Text = nMember.Address.ToString();
                    cboBoxDOBUpdate.Value = nMember.DateOfBirth;
                    txtPostCodeUpdate.Text = nMember.Postcode.ToString();
                    txtEmailUpdate.Text = nMember.Email.ToString();
                    txtPhoneUpdate.Text = nMember.Phone.ToString();
                    txtUserNameUpdate.Text = nMember.Username.ToString();
                    txtPasswordUpdate.Text = nMember.Password.ToString();
                }

            }
            else if (txtMIDUpdate.Text == string.Empty)
            {
                MessageBox.Show("Please input a Member ID.");
            }
        }
        private bool IsNumber()
        {
            bool isNumber = true;
            int mid;
            isNumber = int.TryParse(txtMIDUpdate.Text, out mid);
            if (!isNumber)
            {
                isNumber = false;
                MessageBox.Show("Member ID should be an integer.");
            }
            return isNumber;
        }
        private bool IsMidExist()
        {
            bool isMidExist = true;
            if (txtMIDUpdate.Text != string.Empty && IsNumber())
            {
                try
                {
                    var input = Convert.ToInt32(txtMIDUpdate.Text);
                    context.Members.Where(x => x.MemberID == input).First();
                }
                catch (System.InvalidOperationException)
                {
                    isMidExist = false;
                    MessageBox.Show("This member doesn't exist.");
                }
            }
            return isMidExist;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!UpdateGotEmptyField())
            {
                var mid = Convert.ToInt32(txtMIDUpdate.Text);
                Member nMember = context.Members.Where(x => x.MemberID == mid).First();
                nMember.FirstName = txtBoxFnameUpdate.Text;
                nMember.LastName = txtBoxLNameUpdate.Text;
                nMember.MemberCategory = cboBoxMCategoryUpdate.SelectedItem.ToString();
                nMember.NRIC = cboBoxNRICUpdate.SelectedItem.ToString();
                nMember.Salutation = txtSalutationUpdate.Text;
                nMember.Address = txtAddressUpdate.Text;
                nMember.DateOfBirth = cboBoxDOBUpdate.Value;
                nMember.Postcode = Convert.ToInt32(txtPostCodeUpdate.Text);
                nMember.Email = txtEmailUpdate.Text;
                nMember.Phone = Convert.ToInt32(txtPhoneUpdate.Text);
                nMember.Username = txtUserNameUpdate.Text;
                nMember.Password = txtPasswordUpdate.Text;
                MessageBox.Show("Update Successfully.");
            }
            context.SaveChanges();
        }
        private bool UpdateGotEmptyField()
        {
            // Each textBox should not be null
            bool IsEmpty = false;
            if (
            //txtMIDUpdate.Text==string.Empty||
            txtBoxFnameUpdate.Text == string.Empty ||
            txtBoxLNameUpdate.Text == string.Empty ||
            cboBoxMCategoryUpdate.SelectedItem.ToString() == string.Empty ||
            cboBoxNRICUpdate.SelectedItem.ToString() == string.Empty ||
            txtSalutationUpdate.Text == string.Empty ||
            txtAddressUpdate.Text == string.Empty ||
            cboBoxDOBUpdate.Value == null ||
            txtPostCodeUpdate.Text == string.Empty ||
            txtEmailUpdate.Text == string.Empty ||
            txtPhoneUpdate.Text == string.Empty ||
            txtUserNameUpdate.Text == string.Empty ||
            txtPasswordUpdate.Text == string.Empty
                )
            {
                IsEmpty = true;
                MessageBox.Show("Each field cannot be empty.");
            }
            return IsEmpty;
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            txtMIDUpdate.Text = string.Empty;
            txtBoxFnameUpdate.Text = string.Empty;
            txtBoxLNameUpdate.Text = string.Empty;
            cboBoxMCategoryUpdate.SelectedIndex = -1;
            cboBoxNRICUpdate.SelectedIndex = -1;
            txtSalutationUpdate.Text = string.Empty;
            txtAddressUpdate.Text = string.Empty;
            cboBoxDOBUpdate.Value = DateTime.Now;
            txtPostCodeUpdate.Text = string.Empty;
            txtEmailUpdate.Text = string.Empty;
            txtPhoneUpdate.Text = string.Empty;
            txtUserNameUpdate.Text = string.Empty;
            txtPasswordUpdate.Text = string.Empty;
        }

        private void txtMIDDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                retrieveinfo2();
            }
        }
        private void retrieveinfo2()
        {
            if (txtMIDDelete.Text != string.Empty && IsNumber2())
            {
                if (IsMidExist2())
                {
                    int mid = Convert.ToInt32(txtMIDDelete.Text);
                    Member nMember = context.Members.Where(x => x.MemberID == mid).First();
                    txtBoxFnameDelete.Text = nMember.FirstName.ToString();
                    txtBoxLNameDelete.Text = nMember.LastName.ToString();
                    cboBoxMCategoryDelete.SelectedItem = nMember.MemberCategory.ToString();
                    cboBoxNRICDelete.SelectedItem = nMember.NRIC;
                    txtSalutationDelete.Text = nMember.Salutation.ToString();
                    txtAddressDelete.Text = nMember.Address.ToString();
                    cboBoxDOBDelete.Value = nMember.DateOfBirth;
                    txtPostCodeDelete.Text = nMember.Postcode.ToString();
                    txtEmailDelete.Text = nMember.Email.ToString();
                    txtPhoneDelete.Text = nMember.Phone.ToString();
                    txtUserNameDelete.Text = nMember.Username.ToString();
                    txtPasswordDelete.Text = nMember.Password.ToString();
                }
            }
        }
        private bool IsMidExist2()
        {
            bool isMidExist = true;
            if (!DeleteGotEmptyField() && IsNumber2())
            {
                try
                {
                    int input = Convert.ToInt32(txtMIDDelete.Text);
                    context.Members.Where(x => x.MemberID == input).First();
                }
                catch (System.InvalidOperationException)
                {
                    isMidExist = false;
                    MessageBox.Show("This member doesn't exist.");
                }
            }
            return isMidExist;
        }
        private bool IsNumber2()
        {
            bool isNumber = true;
            int mid;
            isNumber = int.TryParse(txtMIDDelete.Text, out mid);
            if (!isNumber)
            {
                isNumber = false;
                MessageBox.Show("Member ID should be an integer.");
            }
            return isNumber;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (!DeleteGotEmptyField() && IsMidExist2() && !DeleteGotEmptyField())
            {
                if (MessageBox.Show("Confirm to delete?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var mid = Convert.ToInt32(txtMIDDelete.Text);
                    Member nMember = context.Members.Where(x => x.MemberID == mid).First();
                    IssueTran issue = context.IssueTrans.Where(x => x.MemberID == mid).First();
                    context.IssueTrans.Remove(issue);
                    context.Members.Remove(nMember);
                    MessageBox.Show("Delete Successfully.");
                }
            }
            context.SaveChanges();
        }
        private bool DeleteGotEmptyField()
        {
            // Each textBox should not be null
            bool IsEmpty = false;
            if (
            txtMIDDelete.Text == string.Empty
                )
            {
                IsEmpty = true;
                MessageBox.Show("Please input a Member ID.");
            }
            return IsEmpty;
        }

        private void btnCancelDelete_Click(object sender, EventArgs e)
        {
            txtMIDDelete.Text = string.Empty;
            txtBoxFnameDelete.Text = string.Empty;
            txtBoxLNameDelete.Text = string.Empty;
            cboBoxMCategoryDelete.SelectedIndex = -1;
            cboBoxNRICDelete.SelectedIndex = -1;
            txtSalutationDelete.Text = string.Empty;
            txtAddressDelete.Text = string.Empty;
            cboBoxDOBDelete.Value = DateTime.Now;
            txtPostCodeDelete.Text = string.Empty;
            txtEmailDelete.Text = string.Empty;
            txtPhoneDelete.Text = string.Empty;
            txtUserNameDelete.Text = string.Empty;
            txtPasswordDelete.Text = string.Empty;
        }

   

        private void btnDeleteTab_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnUpdateTab_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}

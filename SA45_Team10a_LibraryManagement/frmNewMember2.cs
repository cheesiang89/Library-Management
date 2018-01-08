using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

//Author: Lee Chee Siang

namespace SA45_Team10a_LibraryManagement
{
    public partial class frmNewMember2 : frmDetails
    {
        Navigation n;
        PGPLibraryEntities context;

        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //Declare attributes:
        string firstName;
        string lastName;
        string memberCategory;
        string salutation;
        string NRIC;
        string address;
        DateTime dateOfBirth;
        int postCode;
        string email;
        int phoneNumber;

        //CurrentNumberOnLoan & Remarks are empty, set to 0
        int currentNumberOnLoan = 0;
        string remarks = "Nil";

        bool isSubmitClicked;
        //Only allow this class to be constructed with Username/Password passed in
        public frmNewMember2(string username, string password)
        {
            InitializeComponent();
            UserName = username;
            Password = password;

        }

        private void frmNewMember2_Load(object sender, EventArgs e)
        {
            HideWarningLabels();
            n = new Navigation();
            context = new PGPLibraryEntities();
            isSubmitClicked = false;
        }
        
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            HideWarningLabels();
            //1. Get details from user
            //2. Validate data
            //3. Commit details + username/password

            //Steps 1 + 2: Get details and validate
            //Make sure all fields filled

            //First Name (no check needed)
            bool anyFieldsWrong = true;
            int trueCount = 0;
            if (txtBoxFName.Text!="")
            {
                anyFieldsWrong = false;
                trueCount++;
                firstName = txtBoxFName.Text;
            }
            else
            {
                anyFieldsWrong = true;
                lblFirstNameEmpty.Show();
            }

            //Last Name (no check needed)
            if (txtBoxLName.Text!="")
            {
                anyFieldsWrong = false;
                trueCount++;
                lastName = txtBoxLName.Text;
            }
            else
            {
                anyFieldsWrong = true;
                lblLastNameEmpty.Show();
            }
            //Category (dropdown list)
            if (cboBoxMCategory.SelectedItem!=null)
            {
               
                if ((string)cboBoxMCategory.SelectedItem == "Basic")
                {
                    anyFieldsWrong = false;
                    trueCount++;
                    memberCategory = "B";
                }
                else
                {
                    anyFieldsWrong = false;
                    trueCount++;
                    memberCategory = "P";      
                }
            }
            else
            {
                anyFieldsWrong = true;
                lblCategoryEmpty.Show();
            }
            //Salutation (dropdown list)
            if (cboBoxSalutation.SelectedItem!=null)
            {
                anyFieldsWrong = false;
                trueCount++;
                salutation = (string)cboBoxSalutation.SelectedItem;
            }
            else
            {
                anyFieldsWrong = true;
                lblSalutationEmpty.Show();
            }
           
            //NRIC: Validation check- must be format S1234567X
            NRIC = txtBoxNRIC.Text;
            int dummy;
            //Check 1: Length: 9 digits
            if (NRIC.Length != 9)
            {
                anyFieldsWrong = true;
                lblNRICWarning.Show();
            }
            else
            {
              //Check 2: Start with S, end with Letter
                if (NRIC.Substring(0, 1).ToUpper() != "S"
                    || Char.IsLetter(NRIC[8]) == false
                    || !Int32.TryParse(NRIC.Substring(1, 7), out dummy))
                {
                    anyFieldsWrong = true;
                    lblNRICWarning.Show();
                }
                else
                {
                    trueCount++;
                    anyFieldsWrong = false;
                }
              }
            //Address (no check needed)
            if (txtBoxAddress.Text!="")
            {
                trueCount++;
                anyFieldsWrong = false;
                address = txtBoxAddress.Text;
            }
            else
            {
                anyFieldsWrong = true;
                lblAddressEmpty.Show();
            }

            //DOB: Validation check - Min 6 years old
            
            TimeSpan ts = DateTime.Now - dtpdateOfBirth.Value.Date;
            if (ts.Days/365>=6)
            {
                trueCount++;
                anyFieldsWrong = false;
                dateOfBirth = dtpdateOfBirth.Value.Date;

            }
            else
            {
                anyFieldsWrong = true;
                lblDOBMin.Show();
            }
                
                //Postcode:Validation check - Make sure 6 digits
          
            if (txtBoxPostCode.Text!="")
            {
                if (Int32.TryParse(txtBoxPostCode.Text, out postCode))
                {
                    if (txtBoxPostCode.Text.Length!=6)
                    {
                        anyFieldsWrong = true;
                        lblPostCodeWarning.Show();
                    }
                    else
                    {
                        trueCount++;
                        anyFieldsWrong = false;
                    }
                }
                else
                {
                    anyFieldsWrong = true;
                    lblPostCodeWarning.Show();
                }
            }
            else
            {
                anyFieldsWrong = true;
                lblPostCodeEmpty.Show();
            }
            //Email: Validation check - format: xxx@xxxx.com
            if (txtBoxEmail.Text!="")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxEmail.Text, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"))
                {
                    anyFieldsWrong = true;
                    lblEmailWarning.Show();
                }
                else
                {
                    trueCount++;
                    anyFieldsWrong = false;
                    email = txtBoxEmail.Text;
                }

            }
            else
            {
                anyFieldsWrong = true;
                lblEmailEmpty.Show();
            }
            //Phone format: Int only
           
            if (txtBoxPhone.Text!="")
            {
                if (Int32.TryParse(txtBoxPhone.Text, out phoneNumber))
                {
                    if (txtBoxPhone.Text.Length < 8)
                    {
                        anyFieldsWrong = true;
                        lblPhoneWarning.Show();
                    }
                    else
                    {
                        trueCount++;
                        anyFieldsWrong = false;
                    }
                }
                else
                {
                    anyFieldsWrong = true;
                    lblPhoneWarning.Show();
                }
            }
            else
            {
                anyFieldsWrong = true;
                lblPhoneEmpty.Show();
            }
     

            //Step 3:Commit data
            if (!anyFieldsWrong && trueCount == 10)
            {
                if (isSubmitClicked == false)
                {
                    CommitTransaction();
                    MessageBox.Show("User created!");
                    isSubmitClicked = true;
                    trueCount = 0;

                }
                else
                {
                    MessageBox.Show("User account already created!");
                }
               
            }
            else
            {
                //No action till all fields filled
            }

            }

        private void txtBoxNRIC_TextChanged(object sender, EventArgs e)
        {
            if (lblNRICWarning.Visible==true)
            {
                lblNRICWarning.Hide();
            }
           
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (lblEmailWarning.Visible == true || lblEmailEmpty.Visible ==true)
            {
                lblEmailWarning.Hide();
                lblEmailEmpty.Hide();
            }
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (lblPhoneWarning.Visible == true)
            {
                lblPhoneWarning.Hide();
            }
        }

        private void txtBoxPostCode_TextChanged(object sender, EventArgs e)
        {
            if (lblPostCodeWarning.Visible == true || lblPostCodeEmpty.Visible == true)
            {
                lblPostCodeWarning.Hide();
                lblPostCodeEmpty.Hide();
            }
         
        }
        //Additional functions
        private void HideWarningLabels()
        {
            //Hide all warning labels
            lblEmailWarning.Hide();
            lblNRICWarning.Hide();
            lblPhoneWarning.Hide();
            lblPostCodeWarning.Hide();

            lblFirstNameEmpty.Hide();
            lblLastNameEmpty.Hide();
            lblCategoryEmpty.Hide();
            lblSalutationEmpty.Hide();
            lblAddressEmpty.Hide();
            lblDOBMin.Hide();
            lblPostCodeEmpty.Hide();
            lblEmailEmpty.Hide();
            lblPhoneEmpty.Hide();
        }
        private void CommitTransaction()
        {
           
            using (TransactionScope ts = new TransactionScope())
            {
                Member m = new Member();
                var MemberIDToUse = context.ControlTables.Where(x => x.NumberType == "MemberID").First();
                m.MemberID = MemberIDToUse.FirstFreeNo;
                m.FirstName = firstName;
                m.LastName = lastName;
                m.MemberCategory = memberCategory;
                m.NRIC=NRIC;
                m.Salutation=salutation;
                m.Address=address;
                m.DateOfBirth=dateOfBirth;
                m.Postcode=postCode;
                m.Email=email;
                m.Phone=phoneNumber;
                m.CurrentNumberOnLoan = currentNumberOnLoan;
                m.Remarks = remarks;
                m.Username = UserName;

                //For password, store the Hashed version

                //1. Generate salt, and store salt
                m.Salt = LoginHashing.CreateSalt(50);
                //2. Hash(salt+password), Store hashed password + salt
               m.Password = LoginHashing.CreatePasswordHash(Password, m.Salt);
                   
                //Commit Changes
                 context.Members.Add(m);

                 ControlTable c = MemberIDToUse;
                c.FirstFreeNo++;

                context.SaveChanges();

                ts.Complete();
            }

            //Show notification, go back LogIn Page
            //txtUsername.Text = "";
            //        txtPassword.Text = "";
            //        txtPasswordCheck.Text = "";
            //        MessageBox.Show("User created! Next page!");
               
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            n.GofrmNewMember(this);
        }
    }

    }


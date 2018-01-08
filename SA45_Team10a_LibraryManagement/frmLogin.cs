using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Lee Chee Siang
namespace SA45_Team10a_LibraryManagement
{
    
    public partial class frmLogin : frmDetails
    {
      
        PGPLibraryEntities  context;
        Navigation n;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Checks:
            //1. If username or password wrong, give error
            //Password entry:
            //1. Password is masked
            //2. Password does not register space
            if (cboBoxStatus.Text == "Member")
            {
                var chkUser = context.Members.Where(x => x.Username == txtBoxUsername.Text).SingleOrDefault();
                if (chkUser != null)
                {
                    Member m = chkUser;
                    //Check against DB: Username match and Hash(Salt+Password) match

                    if (LoginHashing.CreatePasswordHash(txtBoxPassword.Text, m.Salt) == m.Password)
                    {
                        UserNameFromLogin = txtBoxUsername.Text;
                        UserCategory = (string) cboBoxStatus.SelectedItem;
                        n.GofrmDashboardMember(this, UserNameFromLogin, UserCategory);

                    }
                    else
                    {
                        MessageBox.Show("Username/Password is incorrect!");
                    }
                }
                else MessageBox.Show("Username/Password is incorrect!");
            }
            else if (cboBoxStatus.Text == "Librarian")
            {
                var chkUser = context.Librarians.Where(x => x.Username == txtBoxUsername.Text).SingleOrDefault();
                if (chkUser != null)
                {
                    Librarian m = chkUser;
                    //Check against DB: Username match and Hash(Salt+Password) match

                    if (LoginHashing.CreatePasswordHash(txtBoxPassword.Text, m.Salt) == m.Password)
                    {
                       UserNameFromLogin = txtBoxUsername.Text;
                        UserCategory = (string) cboBoxStatus.SelectedItem;
                        n.GofrmDashboardLibrarian(this,UserNameFromLogin, UserCategory);

                    }
                    else
                    {
                        MessageBox.Show("Username/Password is incorrect!");
                    }
                }
                else MessageBox.Show("Username/Password is incorrect!");
            }
            else { };
        }
            

        private void frmLogin_Load(object sender, EventArgs e)
        {
            context = new PGPLibraryEntities();
            n = new Navigation();
            txtBoxPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        private void chkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShowPassword.Checked)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else txtBoxPassword.UseSystemPasswordChar = true;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            n.GofrmNewMember(this);
        }
    }
}

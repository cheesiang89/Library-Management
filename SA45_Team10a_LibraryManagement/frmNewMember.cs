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
    public partial class frmNewMember : frmDetails
    {
        Navigation n;
        PGPLibraryEntities context;
        public frmNewMember()
        {
            InitializeComponent();
        }
        //public frmNewMember(string userNameFromLogin, string userCategory)
        //{
        //    InitializeComponent();
        //    // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
        //    UserNameFromLogin = userNameFromLogin;
        //    UserCategory = userCategory;
        //}

        private void frmNewMember_Load(object sender, EventArgs e)
        {
            
            context = new PGPLibraryEntities();
            n = new Navigation();
            txtBoxPassword.UseSystemPasswordChar = true;
            txtBoxPasswordCheck.UseSystemPasswordChar = true;
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            n.GofrmLogin(this);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
         
         //Checks:
          //1. If fields are blank, give error
          //2. If username already exists, give error
          //3. If passwords dont match, give error

            //Password entry:
            //1. Password is masked
            //2. Password does not register space

            if ((txtBoxUsername.Text == "" || txtBoxPassword.Text == "") || txtBoxPasswordCheck.Text == "")
            {
                MessageBox.Show("Fields cannot be blank!");
            }
            else
            {
                var chkUser = context.Members.Where(x => x.Username == txtBoxUsername.Text).FirstOrDefault();
                if (chkUser == null)
                {
                    if (txtBoxPassword.Text != txtBoxPasswordCheck.Text)
                    {
                        MessageBox.Show("Passwords dont match!");
                    }
                    else
                    {
                         if (txtBoxPassword.Text.Length < 6)
                            {
                                MessageBox.Show("Password too short!");
                            }
                          
                            else
                            {
                            n.GofrmNewMember2(this,txtBoxUsername.Text, txtBoxPassword.Text);
                            }
                        }

                    
                }

                else
                {
                    MessageBox.Show("User already exists!");
                }
            }

        
    }

        private void chkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShowPassword.Checked)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
                txtBoxPasswordCheck.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
                txtBoxPasswordCheck.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        private void txtPasswordCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        private void txtBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

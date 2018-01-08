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
    public partial class frmDashboardMember : frmDetails
    {
        PGPLibraryEntities context;
        Navigation n;
        public frmDashboardMember()
        {
            InitializeComponent();
        }
        public frmDashboardMember(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            //Login Form will pass in 2 strings: userNameFromLogin & userCategory
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            context = new PGPLibraryEntities();
            n = new Navigation();
           lblUserDetails.Text = $"{UserCategory}: {UserNameFromLogin}" ;
            

        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            n.GofrmSearchBook(this,UserNameFromLogin,UserCategory);
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            n.GofrmBorrowBooks(this, UserNameFromLogin, UserCategory);
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            n.GofrmLogin(this);
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            if (UserCategory == "Member")
            {
                n.GofrmProfile(this, UserNameFromLogin, UserCategory);
            }
        }
    }
}

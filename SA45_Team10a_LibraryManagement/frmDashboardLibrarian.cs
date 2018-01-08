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
    public partial class frmDashboardLibrarian : frmDetails
    {
        PGPLibraryEntities context;
        Navigation n;
        public frmDashboardLibrarian()
        {
            InitializeComponent();
        }
        public frmDashboardLibrarian(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            //Login Form will pass in 2 strings: userNameFromLogin & userCategory
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
        }

        private void frmDashboardLibrarian_Load(object sender, EventArgs e)
        {
            context = new PGPLibraryEntities();
            n = new Navigation();
            lblUserDetails.Text = $"{UserCategory}: {UserNameFromLogin}";
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            n.GofrmLogin(this);
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
        
            n.GofrmSearchBook(this, UserNameFromLogin, UserCategory);
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            n.GofrmBorrowBooks(this, UserNameFromLogin, UserCategory);
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            n.GofrmReturnBook(this, UserNameFromLogin, UserCategory);
        }

        private void btnManageBook_Click(object sender, EventArgs e)
        {
            n.GofrmManageBooks(this, UserNameFromLogin, UserCategory);
        }

        private void btnManageMember_Click(object sender, EventArgs e)
        {
            n.GofrmManageMember(this, UserNameFromLogin, UserCategory);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            n.GofrmReport(this, UserNameFromLogin, UserCategory);
        }
    }
}

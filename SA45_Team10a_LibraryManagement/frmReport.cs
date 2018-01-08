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
    public partial class frmReport : frmDetails
    {
        Navigation n;
        public frmReport()
        {
            InitializeComponent();
        }
        public frmReport(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            n = new Navigation();
            lblUser.Text=$"{UserCategory}: {UserNameFromLogin}";
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            //NEED ADD LOGIC!!
            n.GofrmDashboardLibrarian(this, UserNameFromLogin, UserCategory);
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

        private void btnMreport_Click(object sender, EventArgs e)
        {
            n.GofrmBorrowTrendReport(this, UserNameFromLogin, UserCategory);
        }

        private void btnTransReport_Click(object sender, EventArgs e)
        {
            n.GofrmBorrowReceipt(this, UserNameFromLogin, UserCategory);
        }

        private void btnBookReport_Click(object sender, EventArgs e)
        {
            n.GofrmListofBook(this, UserNameFromLogin, UserCategory);
        }

        private void btnBookType_Click(object sender, EventArgs e)
        {
            n.GofrmPopularBook(this, UserNameFromLogin, UserCategory);
        }
    }
}

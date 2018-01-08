using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Poh Huey Ching

namespace SA45_Team10a_LibraryManagement
{
    public partial class frmProfile : frmDetails
    {
        Navigation n;
        public frmProfile()
        {
            InitializeComponent();
        }
        public frmProfile(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
        }
        private void frmProfile_Load(object sender, EventArgs e)
        {
            n = new Navigation();
            lblUserDetails.Text = $"{UserCategory}: {UserNameFromLogin}";
            PGPLibraryEntities context = new PGPLibraryEntities();
            if (UserCategory=="Member")
            {
                var s = from x in context.Members
                        where x.Username == UserNameFromLogin
                        select new { x.MemberID };
                int memberID = Convert.ToInt32(s.FirstOrDefault().MemberID);

                //MemberID is int
                var q = from x in context.IssueTrans
                        from y in context.BookListings
                        where x.BookID == y.BookID && x.LoanStatus == "OUT" && x.MemberID == memberID
                        select new { x.TransactionID, x.MemberID, x.BookID, y.BookTitle, x.DateBorrow, x.DateDue, x.OverdueFine };
                dgvProfile.DataSource = q.ToList();
            }

          
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            if (UserCategory=="Member")
            {
                n.GofrmDashboardMember(this, UserNameFromLogin, UserCategory);
            }
            else if (UserCategory =="Librarian")
            {
                n.GofrmDashboardLibrarian(this, UserNameFromLogin, UserCategory);
            }
            else //For testing
            {
                n.GofrmDashboardMember(this, UserNameFromLogin, UserCategory);
            }
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            n.GofrmLogin(this);
        }

        private void lblUserDetails_Click(object sender, EventArgs e)
        {
            n.GofrmProfile(this,UserNameFromLogin, UserCategory);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Lee Chee Siang

namespace SA45_Team10a_LibraryManagement
{
    public class Navigation
    {
        public void GofrmBorrowBooks(frmDetails f, string userNameFromLogin, string userCategory)
        {
            f.Hide();
            frmBorrowBook frm = new frmBorrowBook(userNameFromLogin, userCategory);
            frm.ShowDialog();
            f.Close();
        }
        public void GofrmBorrowBooks_BookID(frmDetails f, string userNameFromLogin, string userCategory)
        {
            f.Hide();
            frmBorrowBook_BookID frm = new frmBorrowBook_BookID(userNameFromLogin, userCategory);
            frm.ShowDialog();
            f.Close();
        }
    
        public void GofrmDashboardMember(frmDetails f, string userNameFromLogin, string userCategory)
        {
            f.Hide();
            frmDashboardMember frm = new frmDashboardMember(userNameFromLogin, userCategory);
            frm.ShowDialog();
            f.Close();
            
        }
        public void GofrmDashboardLibrarian(frmDetails f, string userNameFromLogin, string userCategory)
        {
            f.Hide();
            frmDashboardLibrarian frm = new frmDashboardLibrarian(userNameFromLogin,userCategory);
            frm.ShowDialog();
            f.Close();

        }
        //Form Login is SPECIAL CASE: No user details
        public void GofrmLogin(frmDetails f)
        {

            f.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            f.Close();
        }
        public void GofrmManageBooks(frmDetails f, string userNameFromLogin, string userCategory)
        {

            f.Hide();
            frmManageBook frm = new frmManageBook(userNameFromLogin, userCategory);
            frm.ShowDialog();
            f.Close();
        }
        public void GofrmManageMember(frmDetails f, string userNameFromLogin, string userCategory)
        {
            f.Hide();
            frmManageMember frm = new frmManageMember(userNameFromLogin, userCategory);
            frm.ShowDialog();
            f.Close();
        }
        public void GofrmNewMember(frmDetails f)
        {
            f.Hide();
            frmNewMember frm = new frmNewMember();
            frm.ShowDialog();
            f.Close();
        }
        //Special Case: Pass in Username and Password
        public void GofrmNewMember2(frmDetails f, string userName, string password)
        {
            f.Hide();
            frmNewMember2 frm = new frmNewMember2(userName,password);
            frm.ShowDialog();
            f.Close();
        }
        public void GofrmProfile(frmDetails f, string userNameFromLogin, string userCategory)
        {
            f.Hide();
            frmProfile frm = new frmProfile(userNameFromLogin,userCategory);
            frm.ShowDialog();
            f.Close();
        }
        public void GofrmReport(frmDetails f, string userNameFromLogin, string userCategory)
        {
            f.Hide();
            frmReport frm = new frmReport(userNameFromLogin, userCategory);
            frm.ShowDialog();
            f.Close();
        }
        public void GofrmReturnBook(frmDetails f, string userNameFromLogin, string userCategory)
        {
            f.Hide();
            frmReturnBook frm = new frmReturnBook(userNameFromLogin, userCategory);
            frm.ShowDialog();
            f.Close();
        }

        public void GofrmSearchBook(frmDetails f, string userNameFromLogin, string userCategory)
        {
            f.Hide();
            frmSearchBook frm = new frmSearchBook(userNameFromLogin, userCategory);
            frm.ShowDialog();
            f.Close();
        }
        public void GofrmBorrowTrendReport(frmDetails f, string userNameFromLogin, string userCategory)
        {
           // f.Hide();
            frmBorrowTrendReport frm = new frmBorrowTrendReport(userNameFromLogin, userCategory);
            frm.ShowDialog();
            //f.Close();
        }

        public void GofrmListofBook(frmDetails f, string userNameFromLogin, string userCategory)
        {
            //f.Hide();
            frmListofBook frm = new frmListofBook(userNameFromLogin, userCategory);
            frm.ShowDialog();
           // f.Close();
        }

        public void GofrmPopularBook(frmDetails f, string userNameFromLogin, string userCategory)
        {
            //f.Hide();
            frmPopularBook frm = new frmPopularBook(userNameFromLogin, userCategory);
            frm.ShowDialog();
           // f.Close();
        }

        public void GofrmBorrowReceipt(frmDetails f, string userNameFromLogin, string userCategory)
        {
           // f.Hide();
            frmBorrowReceipt frm = new frmBorrowReceipt(userNameFromLogin, userCategory);
            frm.ShowDialog();
            //f.Close();
        }
    }
}

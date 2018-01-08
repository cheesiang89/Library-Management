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

    public partial class frmBorrowBook : frmDetails
    {
        Navigation n;
        PGPLibraryEntities context;
        int fieldsCorrect = 0; //For ensuring all fields correct before updating
        public frmBorrowBook()
        {

            InitializeComponent();
        }
        public frmBorrowBook(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;

        }
        private void frmBorrowBook_Load(object sender, EventArgs e)
        {

            n = new Navigation();
            context = new PGPLibraryEntities();
            lblUserDetails.Text = $"{UserCategory}: {UserNameFromLogin}";
            int? a = context.Members.Where(x => x.Username.ToUpper() == UserNameFromLogin.ToUpper()).Select(x => x.MemberID).FirstOrDefault();
            if (a != null)
            {
                txtBoxMemberID.Text = a.ToString();
                var firstName = context.Members.Where(x => x.Username.ToUpper() == UserNameFromLogin.ToUpper()).Select(x => x.FirstName).First();
                var lastName = context.Members.Where(x => x.Username.ToUpper() == UserNameFromLogin.ToUpper()).Select(x => x.LastName).First();
                txtBoxMemberName.Text = $"{firstName} {lastName}";
            }
            dtpBorrow.Value = DateTime.Now;
            dtpDue.Value = DateTime.Now.AddMonths(1);
            lblNoBooksWarning.Visible = false;
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {   //Have condition here: Member or Librarian?
            n.GofrmDashboardMember(this, UserNameFromLogin, UserCategory);
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            if (UserCategory=="Member")
            {
                n.GofrmProfile(this, UserNameFromLogin, UserCategory);
            }
           
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            n.GofrmLogin(this);
        }

        private void btnSearchBID_Click(object sender, EventArgs e)
        {
            //n.GofrmBorrowBooks_BookID(this, UserNameFromLogin, UserCategory);
            frmBorrowBook_BookID frm = new frmBorrowBook_BookID();
            DialogResult r = frm.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtBoxBookID.Text = frm.SelectedBookID;
                txtBoxBookName.Text = frm.SelectedBookTitle;
                int booksQuantityAvailable = GetAvailableQuantity();
                txtBoxAvailableQuantity.Text = booksQuantityAvailable.ToString();
            }
            // We get here when newform's DialogResult gets set
        }



        private void txtBoxBookID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var a = context.BookListings.Where(x => x.BookID == txtBoxBookID.Text).Select(x => x.BookTitle).First();
                    txtBoxBookName.Text = a.ToString();
                    int booksQuantityAvailable = GetAvailableQuantity();
                    txtBoxAvailableQuantity.Text = booksQuantityAvailable.ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("We don't have this book");
                }

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {//Book borrowing logic
         // 1. Check book is available: NumberLoaned +1 <=TotalStock

            if (txtBoxBookName.Text != "")
            {
                var booksAvailability = context.BookListings
               .Where(x => x.BookID == txtBoxBookID.Text)
               .Select(y => new { y.TotalStock, y.NumberLoaned });
                if (booksAvailability.Any())
                {
                    int booksQuantityAvailable = GetAvailableQuantity();
                    if (booksQuantityAvailable > 0)
                    {
                        fieldsCorrect++;
                    }
                    else
                    {
                        lblNoBooksWarning.Visible = true;
                    }
                }
                else
                {
                    txtBoxBookName.Text = "";
                    txtBoxAvailableQuantity.Text = "";
                }
                

               
            }
            //2.Check member haven't reached quota

            int newNumberOnLoan = context
                .Members
                .Where(x => x.MemberID.ToString() == txtBoxMemberID.Text)
                .Select(x => x.CurrentNumberOnLoan).First() + 1;

            var userMemberCategory = context.Members
                .Where(x => x.MemberID.ToString() == txtBoxMemberID.Text)
                .Select(x => x.MemberCategory).First().ToString();
            int bookQuota = 0;
            if (userMemberCategory == "B")
            {
                bookQuota = 6;
            }
            else if (userMemberCategory == "P")
            {
                bookQuota = 12;
            }
            if (newNumberOnLoan <= bookQuota)
            {
                fieldsCorrect++;
            }
            else
            {

            }

            //Commit only if pass the 2 checks: Book available + Member haven't reached quota
            if (fieldsCorrect == 2)
            {
                CommitTransaction();
                MessageBox.Show("Book borrowed!");
                ResetFields();
                fieldsCorrect = 0;
            }

        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
        private void ResetFields()
        {
            txtBoxBookID.Text = "";
            txtBoxBookName.Text = "";
            txtBoxAvailableQuantity.Text = "";
        }
        private int GetAvailableQuantity()
        {
            var booksAvailability = context.BookListings
           .Where(x => x.BookID == txtBoxBookID.Text)
           .Select(y => new { y.TotalStock, y.NumberLoaned }).First();

            int booksQuantityAvailable = booksAvailability.TotalStock - booksAvailability.NumberLoaned;
            return booksQuantityAvailable;
        }
        private void CommitTransaction()
        {

            using (TransactionScope ts = new TransactionScope())
            {
                // 3. Update IssueTrans table
                IssueTran it = new IssueTran();
                it.MemberID = Int32.Parse(txtBoxMemberID.Text);
                it.BookID = txtBoxBookID.Text;
                it.DateBorrow = dtpBorrow.Value.Date;
                it.DateDue = dtpDue.Value.Date;
                it.LoanStatus = "OUT";
                it.Remarks = "NIL";
                it.OverdueFine = 0;
                it.FinePaymentStatus = "NA";
                context.IssueTrans.Add(it);

                //4. Update Member table : CurentNumberOnLoan
                Member m = context.Members
                    .Where(x => x.MemberID.ToString() == txtBoxMemberID.Text)
                    .First();

                int newNumberOnLoan = context
               .Members
               .Where(x => x.MemberID.ToString() == txtBoxMemberID.Text)
               .Select(x => x.CurrentNumberOnLoan).First() + 1;

                m.CurrentNumberOnLoan = newNumberOnLoan;


                //5. Update Book Listing table: NumberLoaned ++
                BookListing b = context.BookListings
                    .Where(x => x.BookID.ToString() == txtBoxBookID.Text)
                    .First();
                b.NumberLoaned++;

                //Commit Changes
                context.SaveChanges();

                ts.Complete();
            }
        }
    }
}

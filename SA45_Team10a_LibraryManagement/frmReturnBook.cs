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

//Author: Poh Huey Ching

namespace SA45_Team10a_LibraryManagement
{
    public partial class frmReturnBook : frmDetails
    {
        ////private float fineAmount;
        Navigation n;
        private bool isMIDMatch;
        private bool isInteger;
        private bool hasEmptyField;
        PGPLibraryEntities context = new PGPLibraryEntities();
        private bool hasOutstandingBook;
        private int memberID;
        private int dvgRowCounter;
        private DateTime dateBorrow;
        private DateTime dateDue;
        private int transactionID;
        private string bookID;
        private float fineAmount;

        public frmReturnBook()
        {
            InitializeComponent();
        }
        public frmReturnBook(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;

            dtpDateReturn.MaxDate = DateTime.Now.Date;

        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {
            n = new Navigation();
            lblUser.Text = $"{UserCategory}: {UserNameFromLogin}";
            lblMIDWarning.Visible = false;
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

        private void txtBoxMID_KeyUp(object sender, KeyEventArgs e)
        {
            lblMIDWarning.Visible = false;
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                checkMIDInfo();
                if (isMIDMatch)
                {
                    checkBorrowStatus();
                }
            }
        }

        private bool checkMIDInfo()
        {
            isMIDMatch = false;
            if (txtBoxMID.TextLength == 0)
            {
                //isMIDMatch = false;
                //MessageBox.Show("You have not entered anythinng. Please re-enter the Member ID.");
                lblMIDWarning.Visible = true;
                lblMIDWarning.Text = "You have not entered anythinng.Please re-enter the Member ID.";
            }
            else if (txtBoxMID.TextLength == 4)
            {
                checkInputDataType();
                checkMatchingMID();
            }
            else
            {
                //isMIDMatch = false;
                //MessageBox.Show("The Member ID is a 4-digit integer number. Please enter again");
                lblMIDWarning.Visible = true;
                lblMIDWarning.Text = "The Member ID is a 4-digit integer number. Please enter again";
            }
            return isMIDMatch;
        }


        private bool checkInputDataType()
        {
            isInteger = false;
            int memberID;
            isInteger = int.TryParse(txtBoxMID.Text, out memberID);
            if (isInteger)
            {
                isInteger = true;
            }
            else
            {
                //MessageBox.Show("You did not enter an integer. Please re-enter 4-digit integer.");
                lblMIDWarning.Visible = true;
                lblMIDWarning.Text = "You did not enter an integer. Please re-enter 4-digit integer.";

            }
            return isInteger;
        }

        private bool checkMatchingMID()
        {
            //isMIDMatch = false;
            if (isInteger)
            {
                try
                {
                    var input = Convert.ToInt32(txtBoxMID.Text);
                    context.Members.Where(x => x.MemberID == input).First();
                    isMIDMatch = true;
                }
                catch (System.InvalidOperationException)
                {
                    //isMIDMatch = false;
                    //MessageBox.Show("This member ID doesn't exist.");
                    lblMIDWarning.Visible = true;
                    lblMIDWarning.Text = "This member ID doesn't exist.";

                }
            }
            return isMIDMatch;
        }

        public int MemberID
        {
            get
            {
                if (isMIDMatch == true)
                {
                    memberID = Convert.ToInt32(txtBoxMID.Text);
                }

                return memberID;
            }
        }

        public DateTime DateBorrow
        {
            get { return dateBorrow; }
        }

        public DateTime DateDue
        {
            get { return dateDue; }
        }

        public string BookID
        {
            get { return bookID; }
        }

        public int TransactionID
        {
            get
            {
                if (isMIDMatch == true && dvgRowCounter > 0)
                {
                    transactionID = Int32.Parse(dgvReturn.CurrentRow.Cells[0].Value.ToString());
                }
                return transactionID;
            }

        }

        private bool checkBorrowStatus()
        {
            hasOutstandingBook = true;
            var q = from x in context.IssueTrans
                    from y in context.BookListings
                    where x.BookID == y.BookID && x.LoanStatus == "OUT" && x.MemberID == MemberID
                    select new { x.TransactionID, x.BookID, y.BookTitle, y.BookType, y.AuthorID, y.PublisherID, x.DateBorrow, x.DateDue, y.TotalStock, y.NumberLoaned, y.Notes };

            dgvReturn.DataSource = q.ToList();
            dvgRowCounter = dgvReturn.Rows.Count;
            if (dvgRowCounter == 0)
            {
                //MessageBox.Show("This member has not borrowed any book. Please enter a new MemberID to return book.");
                lblMIDWarning.Visible = true;
                lblMIDWarning.Text = "This member has not borrowed any book. Please enter a new MemberID to return book.";
                hasOutstandingBook = false;
            }

            return hasOutstandingBook;

        }

        private void dgvReturn_SelectionChanged(object sender, EventArgs e)
        {
            dateBorrow = Convert.ToDateTime(dgvReturn.CurrentRow.Cells[6].Value.ToString());
            dateDue = Convert.ToDateTime(dgvReturn.CurrentRow.Cells[7].Value.ToString());
            txtBoxDateBorrow.Text = String.Format("{0:dd-MMM-yyyy}", (DateTime)DateBorrow);
            txtBoxDateDue.Text = String.Format("{0:dd-MMM-yyyy}", (DateTime)DateDue);
            dtpDateReturn.MinDate = dateBorrow;
            transactionID = Int32.Parse(dgvReturn.CurrentRow.Cells[0].Value.ToString());
            bookID = dgvReturn.CurrentRow.Cells[1].Value.ToString();

        }

        private void dtpDateReturn_Leave(object sender, EventArgs e)
        {
            DateTime DateActualReturn = dtpDateReturn.Value.Date;

            if (DateActualReturn > DateDue)
            {
                fineAmount = (DateActualReturn.Date - DateDue.Date).Days * 0.5f;
                txtFine.Text = String.Format("{0:c}", fineAmount);
                cboBoxPaymentStatus.SelectedIndex = 1;
            }
            else
            {
                fineAmount = 0;
                txtFine.Text = String.Format("{0:c}", fineAmount);
                cboBoxPaymentStatus.SelectedIndex = 0;
            }
        }


        public DateTime DateActualReturn
        {
            get { return dtpDateReturn.Value.Date; }
        }

        private bool hasFieldEmpty()
        {
            hasEmptyField = false;
            if (txtBoxMID.TextLength == 0 || cboBoxPaymentStatus.SelectedIndex == -1 || txtRemark.TextLength == 0 || txtFine.TextLength == 0)
            {
                hasEmptyField = true;
                //MessageBox.Show("All fields must be filled/selected. Please indicate NA if no remarks to be made. ");

            }
            return hasEmptyField;
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMIDWarning.Visible = false;
            if (hasFieldEmpty() == true)
            {
                MessageBox.Show("All fields must be filled/selected. Please indicate NA if no remarks to be made. ");
            }
            else
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    try
                    {
                        IssueTran IT = context.IssueTrans.Where(x => x.TransactionID == TransactionID).First();
                        IT.DateActualReturn = DateActualReturn;
                        IT.LoanStatus = "IN";
                        IT.Remarks = txtRemark.Text;
                        IT.OverdueFine = fineAmount;
                        IT.FinePaymentStatus = cboBoxPaymentStatus.SelectedItem.ToString();
                        IT.BookID = bookID;

                        Member ML = context.Members.Where(x => x.MemberID == MemberID).First();
                        BookListing BL = context.BookListings.Where(x => x.BookID == bookID).First();

                        if (BL.NumberLoaned > 0 && ML.CurrentNumberOnLoan > 0)
                        {
                            BL.NumberLoaned--;
                            ML.CurrentNumberOnLoan--;

                            MessageBox.Show("Book Return is successful.");
                        }
                        else
                        {
                            MessageBox.Show("There is an error in the number of books on loan. Please check on transaction record.");
                        }

                        context.SaveChanges();
                        ts.Complete();
                    }
                    catch (TransactionException ex)
                    {
                        ts.Dispose();
                        MessageBox.Show("Transaction Exception Occured");
                    }

                }
            }
        }

        private void txtBoxMID_TextChanged(object sender, EventArgs e)
        {
            lblMIDWarning.Visible = false;
        }
    }
}

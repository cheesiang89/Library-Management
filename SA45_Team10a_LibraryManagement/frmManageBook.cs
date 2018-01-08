using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Li Dan

namespace SA45_Team10a_LibraryManagement
{
    public partial class frmManageBook : frmDetails
    {
        PGPLibraryEntities context = new PGPLibraryEntities();
        Navigation n;
        public frmManageBook()
        {
            InitializeComponent();
        }
        public frmManageBook(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
        }
        private void frmManageBook_Load(object sender, EventArgs e)
        {
            n = new Navigation();
            lblUser.Text = $"{UserCategory}: {UserNameFromLogin}";
      
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PGPLibraryEntities context = new PGPLibraryEntities();
            BookListing nbook = new BookListing();
            BookAdjustment adjust = new BookAdjustment();
            if (!GotEmptyField() && AdddataType() && IsAddMore())
            {
                //Update Booklisting Table
                nbook.ISBN = txtISBNAdd.Text;
                nbook.BookTitle = txtBookTitleAdd.Text;
                nbook.CallNumber = txtCallNoAdd.Text;
                nbook.Notes = txtNoteAdd.Text;
                nbook.BookType = cboBoxBookTypeAdd.SelectedItem.ToString();
                nbook.Language = cboBoxLanguageAdd.SelectedItem.ToString();
                Author author = context.Authors.Where(x => x.AuthorName == cboBoxAuthorAdd.SelectedItem.ToString()).First();
                nbook.AuthorID = author.AuthorID;
                Publisher publisher = context.Publishers.Where(x => x.PublisherName == cboBoxPublisherAdd.SelectedItem.ToString()).First();
                nbook.PublisherID = publisher.PublisherID;
                nbook.Section = cboBoxSectionAdd.SelectedItem.ToString();
                nbook.BookID = "B00" + context.ControlTables.Where(x => x.NumberType == "BookID").Select(x => x.FirstFreeNo).First();
                nbook.NumberLoaned = 0;

                //Update BookAdjustment Table
                adjust.BookID = "B00" + context.ControlTables.Where(x => x.NumberType == "BookID").Select(x => x.FirstFreeNo).First();
                adjust.DateAdjust = DateTime.Now;
                //Librarian librarian = context.Librarians.Where(x => x.Username == lblUser.Text).First();
                //adjust.WhoAdjust = librarian.LibrarianID;
                adjust.WhoAdjust = Convert.ToInt32("4000");
                adjust.AdjustmentReason = "Buy new books";
                adjust.AdjustmentQty = Convert.ToInt32(txtQuantityAdd.Text);
                nbook.TotalStock = Convert.ToInt32(txtQuantityAdd.Text);
                ////Update ControlNumber
                //ControlTable control = context.ControlTables.Where(x => x.NumberType == "BookID").First();
                //control.FirstFreeNo += 1;
                MessageBox.Show("Add book successfully.");
                context.BookAdjustments.Add(adjust);
                context.BookListings.Add(nbook);
                context.SaveChanges();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update booklisting table
            if (!UpdateGotEmptyField())
            {
                var bid = txtBookNameUpdate.Text;
                BookListing nbook = context.BookListings.Where(x => x.BookID == bid).First();
                nbook.ISBN = txtISBNUpdate.Text;
                nbook.BookTitle = txtBookTitleUpdate.Text;
                nbook.BookType = cboBoxBookTypeUpdate.SelectedItem.ToString();
                nbook.Language = cboBoxLanguageUpdate.SelectedItem.ToString();
                nbook.CallNumber = txtCallNoUpdate.Text;
                nbook.Section = cboBoxSectionUpdate.SelectedItem.ToString();
                nbook.Notes = txtNoteUpdate.Text;
                Author author = context.Authors.Where(x => x.AuthorName == cboBoxAuthorUpdate.SelectedItem.ToString()).First();
                nbook.AuthorID = author.AuthorID;
                Publisher publisher = context.Publishers.Where(x => x.PublisherName == cboBoxPublisherUpdate.SelectedItem.ToString()).First();
                nbook.PublisherID = publisher.PublisherID;
                //Update adjustment table
                BookAdjustment adjust = new BookAdjustment();
                adjust.BookID = nbook.BookID;
                adjust.DateAdjust = DateTime.Now;
                adjust.WhoAdjust = Convert.ToInt32("4000");
    
                if (UpdatedataType())
                {
                    int quantity = Convert.ToInt32(txtQuantityUpdate.Text);
                    int totalStock = nbook.TotalStock;
                    int noLoaned = nbook.NumberLoaned;
                    if (quantity > 0 || (quantity < 0 && Math.Abs(quantity) < totalStock - noLoaned))
                    {
                        nbook.TotalStock = Convert.ToInt32(txtQuantityUpdate.Text) + nbook.TotalStock;
                        adjust.AdjustmentQty = Convert.ToInt32(txtQuantityUpdate.Text);
                        MessageBox.Show("Update book Successfully.");
                    }
                    else if (quantity < 0 && Math.Abs(quantity) > totalStock - noLoaned)
                    {
                        MessageBox.Show("Number of books in library is not enough");
                    }
                }
                if (adjust.AdjustmentQty > 0)
                {
                    adjust.AdjustmentReason = "Buy new books";
                }
                else if (adjust.AdjustmentQty < 0)
                {
                    adjust.AdjustmentReason = "Book damaged";
                }
                else
                {
                    adjust.AdjustmentReason = "Update book information";
                }
                //Update ControlNumber
                //Save Changes
                context.BookAdjustments.Add(adjust);
                context.SaveChanges();
            }
        }
        private void retrieveinfo()
        {
            if (IsBidExist() && txtBookNameUpdate.Text != string.Empty)
            {
                var bid = txtBookNameUpdate.Text;
                BookListing nbook = context.BookListings.Where(x => x.BookID == bid).First();
                txtISBNUpdate.Text = nbook.ISBN.ToString();
                txtBookTitleUpdate.Text = nbook.BookTitle.ToString();
                cboBoxBookTypeUpdate.SelectedItem = nbook.BookType.ToString();
                cboBoxLanguageUpdate.SelectedItem = nbook.Language.ToString();
                txtCallNoUpdate.Text = nbook.CallNumber.ToString();
                cboBoxSectionUpdate.SelectedItem = nbook.Section.ToString();
                txtNoteUpdate.Text = nbook.Notes.ToString();
                var aid = nbook.AuthorID;
                Author author = context.Authors.Where(x => x.AuthorID == aid).First();
                cboBoxAuthorUpdate.SelectedItem = author.AuthorName.ToString();
                var pid = nbook.PublisherID;
                Publisher publisher = context.Publishers.Where(x => x.PublisherID == pid).First();
                cboBoxPublisherUpdate.SelectedItem = publisher.PublisherName.ToString();
            }
            else if (txtBookNameUpdate.Text == string.Empty)
            {
                MessageBox.Show("Please input a Book ID.");
            }
        }
        private void txtBookNameUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                retrieveinfo();
            }
        }
        private bool GotEmptyField()
        {
            bool fieldIsEmpty = false;
            // Each textBox should not be null
            if (txtISBNAdd.Text == string.Empty ||
            txtBookTitleAdd.Text == string.Empty ||
            txtCallNoAdd.Text == string.Empty ||
            txtNoteAdd.Text == string.Empty ||
            cboBoxBookTypeAdd.SelectedItem.ToString() == string.Empty ||
            cboBoxLanguageAdd.SelectedItem.ToString() == string.Empty ||
            cboBoxAuthorAdd.SelectedItem.ToString() == string.Empty ||
            cboBoxPublisherAdd.SelectedItem.ToString() == string.Empty ||
            cboBoxSectionAdd.SelectedItem.ToString() == string.Empty ||
            txtQuantityAdd.Text == string.Empty)
            {
                fieldIsEmpty = true;
                MessageBox.Show("Each field cannot be empty.");
            }
            return fieldIsEmpty;
        }
        private bool UpdateGotEmptyField()
        {
            // Each textBox should not be null
            bool IsEmpty = false;
            if (
            txtBookNameUpdate.Text == string.Empty ||
            txtISBNUpdate.Text == string.Empty ||
            txtBookTitleUpdate.Text == string.Empty ||
            txtCallNoUpdate.Text == string.Empty ||
            txtNoteUpdate.Text == string.Empty ||
            cboBoxBookTypeUpdate.SelectedItem.ToString() == string.Empty ||
            cboBoxLanguageUpdate.SelectedItem.ToString() == string.Empty ||
            cboBoxAuthorUpdate.SelectedItem.ToString() == string.Empty ||
            cboBoxPublisherUpdate.SelectedItem.ToString() == string.Empty ||
            cboBoxSectionUpdate.SelectedItem.ToString() == string.Empty ||
            txtQuantityUpdate.Text == string.Empty
                )
            {
                IsEmpty = true;
                MessageBox.Show("Each field cannot be empty.");
            }
            return IsEmpty;
        }

        private bool AdddataType()
        {
            int quantity;
            bool AddisNum = true;
            AddisNum = int.TryParse(txtQuantityAdd.Text, out quantity);
            if (!AddisNum)
            {
                AddisNum = false;
                MessageBox.Show("Quantity should be an integer.");
            }
            return AddisNum;
        }
        private bool IsAddMore()
        {
            bool isAddMore = false;
            int quantity = Convert.ToInt32(txtQuantityAdd.Text);
            if (quantity > 0)
            {
                isAddMore = true;
            }
            else
            {
                isAddMore = false;
                MessageBox.Show("Add at least 1 book.");
            }
            return isAddMore;
        }
        private bool UpdatedataType()
        {
            int quantity;
            bool UpdateisNum = true;
            UpdateisNum = int.TryParse(txtQuantityUpdate.Text, out quantity);
            if (UpdateisNum == false)
            {
                UpdateisNum = false;
                MessageBox.Show("Quantity should be an integer.");
            }
            return UpdateisNum;
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            txtISBNAdd.Text = string.Empty;
            txtBookTitleAdd.Text = string.Empty;
            txtCallNoAdd.Text = string.Empty;
            txtNoteAdd.Text = string.Empty;
            cboBoxBookTypeAdd.SelectedItem = null;
            cboBoxLanguageAdd.SelectedItem = null;
            cboBoxAuthorAdd.SelectedItem = null;
            cboBoxPublisherAdd.SelectedItem = null;
            cboBoxSectionAdd.SelectedItem = null;
            txtQuantityAdd.Text = string.Empty;
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            txtBookNameUpdate.Text = string.Empty;
            txtISBNUpdate.Text = string.Empty;
            txtBookTitleUpdate.Text = string.Empty;
            txtCallNoUpdate.Text = string.Empty;
            txtNoteUpdate.Text = string.Empty;
            cboBoxBookTypeUpdate.SelectedItem = null;
            cboBoxLanguageUpdate.SelectedItem = null;
            cboBoxAuthorUpdate.SelectedItem = null;
            cboBoxPublisherUpdate.SelectedItem = null;
            cboBoxSectionUpdate.SelectedItem = null;
            txtQuantityUpdate.Text = string.Empty;
        }
        private bool IsBidExist()
        {
            bool isBidExist = true;
            if (txtBookNameUpdate.Text != string.Empty)
            {
                string input = txtBookNameUpdate.Text;
                try
                {
                    context.BookListings.Where(x => x.BookID == input).First();
                }
                catch (System.InvalidOperationException)
                {
                    isBidExist = false;
                    MessageBox.Show("This book doesn't exist.");
                }
            }
            return isBidExist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}

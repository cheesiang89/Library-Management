using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Pang Zhi Hao

namespace SA45_Team10a_LibraryManagement
{
    public partial class frmSearchBook : frmDetails
    {
        PGPLibraryEntities context = new PGPLibraryEntities();
        Navigation n;
        bool bookFound = false;

        public frmSearchBook()
        {
            InitializeComponent();
        }
        public frmSearchBook(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
        }

        private void frmSearchBook_Load(object sender, EventArgs e)
        {
            n = new Navigation();
            PGPLibraryEntities context = new PGPLibraryEntities();
            lblUser.Text = $"{UserCategory}: {UserNameFromLogin}";
            lblBookNotFound.Visible = false;
            lblBookAvailble.Visible = false;
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            if (UserCategory == "Member")
            {
                n.GofrmDashboardMember(this, UserNameFromLogin, UserCategory);
            }
            else if (UserCategory == "Librarian")
            {
                n.GofrmDashboardLibrarian(this, UserNameFromLogin, UserCategory);
            }
            else //For Testing
            {
                n.GofrmDashboardMember(this, UserNameFromLogin, UserCategory);
            }

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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            UpdateDGV();
            UpdateDateDueBox();

        }

        public string bookIDValue
        {
            get
            {
                return dgvSearch.CurrentRow.Cells["BookID"].Value.ToString();
            }

        }

        private void dgvSearch_SelectionChanged(object sender, EventArgs e)
        {
            lblBookAvailble.Visible = false;
            if (bookFound == true) // Clear and update ListBox
            {
                UpdateDateDueBox();
            }
            else //Clear only, don't update ListBox
            {
                listBoxDateDue.Items.Clear();
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            lblBookNotFound.Visible = false;
            lblBookAvailble.Visible = false;
            dgvSearch.DataSource = null;
            listBoxDateDue.Items.Clear();
        }
        private void UpdateDateDueBox()
        {
            if (bookFound)
            {
                if (IsBookAvailable())
                { // Book available
                    listBoxDateDue.Items.Clear();
                    lblBookAvailble.Visible = true;
                }
                else
                { //Book not available
                    listBoxDateDue.Items.Clear();

                    var rd = context.IssueTrans.Where(x => x.BookID == bookIDValue).Select(x => new { x.DateDue });
                    foreach (var item in rd)
                    {
                        listBoxDateDue.Items.Add(item.DateDue.ToString("dd-MMM-yyyy"));
                    }
                }
            }


        }
        private void UpdateDGV()
        {
            var q = from x in context.BookListings
                    from y in context.BookAvailabilities
                    where (x.BookID == y.BookID) &&
                    ((x.BookTitle.Contains(txtBoxSearch.Text)) || (x.BookType.Contains(txtBoxSearch.Text))
                    || (x.Author.AuthorName.Contains(txtBoxSearch.Text)))
                    select new
                    {
                        x.BookID,
                        x.ISBN,
                        x.BookTitle,
                        x.BookType,
                        x.Language,
                        x.Author.AuthorName,
                        x.Publisher.PublisherName,
                        y.QuantityAvailable,
                        x.Notes,
                        x.Section,
                        x.CallNumber
                    };

            if (q.Any())
            {

                dgvSearch.DataSource = q.ToList();
                listBoxDateDue.Items.Clear();
                bookFound = true;
            }
            else
            {
                dgvSearch.DataSource = null;
                bookFound = false;
                lblBookNotFound.Visible = true;
                listBoxDateDue.Items.Clear();
            }
        }
        private bool IsBookAvailable()
        {
            if (context.BookAvailabilities.Where(x => x.BookID == bookIDValue).Select(x => x.QuantityAvailable).First() > 0)
            { // Book available
                return true;
            }
            else
            {// Book not available
                return false;
            }
        }
    }
}

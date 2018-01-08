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
    public partial class frmBorrowBook_BookID : frmDetails
    {
        Navigation n;
        PGPLibraryEntities context;
        public string SelectedBookID
        {
            get { return dgvSearchBookID.CurrentRow.Cells["BookID"].Value.ToString(); }
        }
        public string SelectedBookTitle
        {
            get { return dgvSearchBookID.CurrentRow.Cells["BookTitle"].Value.ToString(); }
        }
        public frmBorrowBook_BookID()
        {
            InitializeComponent();
        }
        public frmBorrowBook_BookID(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
            dgvSearchBookID.AutoGenerateColumns = false;
        }


        private void frmBorrowBook_BookID_Load(object sender, EventArgs e)
        {
            n = new Navigation();
            context = new PGPLibraryEntities();
            var a = context.BookListings.Select(x =>
            new
            {
                x.BookID,
                x.ISBN,
                x.BookTitle,
                x.BookType,
                x.Language,
                x.AuthorID,
                x.PublisherID,
                x.TotalStock,
                x.NumberLoaned,
                x.Section,
                x.CallNumber,
                x.Notes,
                x.Publisher.PublisherName,
                x.Author.AuthorName
            });


            if (a != null)
            {
                dgvSearchBookID.DataSource = a.ToList();
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}

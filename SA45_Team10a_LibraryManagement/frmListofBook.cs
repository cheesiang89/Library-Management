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
    public partial class frmListofBook : frmDetails
    {
        public frmListofBook()
        {
            InitializeComponent();
        }
        public frmListofBook(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
        }

        private void frmListofBook_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.BookListTableAdapter bra = new DataSetTableAdapters.BookListTableAdapter();
            bra.Fill(ds.BookList);
            CR_Booklisting br = new CR_Booklisting();
            br.SetDataSource(ds);
            crystalReportViewer1.ReportSource = br;
        }
    }
}

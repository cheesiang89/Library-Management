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
    public partial class frmPopularBook : frmDetails
    {
        public frmPopularBook()
        {
            InitializeComponent();
        }
        public frmPopularBook(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
        }
        private void frmPopularBook_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.BorrowReceiptTableAdapter bra = new DataSetTableAdapters.BorrowReceiptTableAdapter();
            bra.Fill(ds.BorrowReceipt);
            popularBook pb = new popularBook();
            pb.SetDataSource(ds);
            crystalReportViewer1.ReportSource = pb;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

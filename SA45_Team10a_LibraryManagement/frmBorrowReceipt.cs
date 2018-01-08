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
    public partial class frmBorrowReceipt : frmDetails
    {
        public frmBorrowReceipt()
        {
            InitializeComponent();
        }
        public frmBorrowReceipt(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
        }


        private void frmBorrowReceipt_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.BorrowReceiptTableAdapter bra = new DataSetTableAdapters.BorrowReceiptTableAdapter();
            bra.Fill(ds.BorrowReceipt);
            CR_BorrowReceipt br = new CR_BorrowReceipt();
            br.SetDataSource(ds);
            crystalReportViewer1.ReportSource = br;
        }
    }
}

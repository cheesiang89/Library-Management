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
    public partial class frmBorrowTrendReport : frmDetails
    {
        public frmBorrowTrendReport()
        {
            InitializeComponent();
        }
        public frmBorrowTrendReport(string userNameFromLogin, string userCategory)
        {
            InitializeComponent();
            // Assign the properties UserNameFromLogin & UserCategory respectively when form is contructed
            UserNameFromLogin = userNameFromLogin;
            UserCategory = userCategory;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.BookBorrowAnalysisTableAdapter br = new DataSetTableAdapters.BookBorrowAnalysisTableAdapter();
            br.Fill(ds.BookBorrowAnalysis);

            CR_BookBorrowTrend brt = new CR_BookBorrowTrend();
            brt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = brt;
        }
    }
}

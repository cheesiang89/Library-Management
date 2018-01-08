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
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }
        private string _userCategory="X";

        public string UserCategory
        {
            get { return _userCategory; }
            set { _userCategory = value; }
        }

        private string _userNameFromLogin="X";
        public string UserNameFromLogin
        {
            get { return _userNameFromLogin; }
            set { _userNameFromLogin = value; }
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTACustInfo : Form
    {
        private string sCallID = "";
        public FrmTACustInfo()
        {
            InitializeComponent();
        }

        public FrmTACustInfo(string strCallID)
        {
            InitializeComponent();
            sCallID = strCallID;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class FrmTAPay : Form
    {
        //订单编号
        private string chkNum = "";
        public FrmTAPay()
        {
            InitializeComponent();
        }

        public FrmTAPay(string strChkNum)
        {
            InitializeComponent();
            chkNum = strChkNum;
        }

        #region 退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void FrmTAPay_Load(object sender, EventArgs e)
        {

        }
    }
}

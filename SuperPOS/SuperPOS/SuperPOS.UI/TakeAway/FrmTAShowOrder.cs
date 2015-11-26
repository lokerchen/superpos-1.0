using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Domain.Entities;
using SuperPOS.UI.TakeAway;

namespace SuperPOS.UI
{
    public partial class FrmTAShowOrder : Form
    {
        private UserInfo userInfo = new UserInfo();

        public FrmTAShowOrder()
        {
            InitializeComponent();
        }

        public FrmTAShowOrder(UserInfo user)
        {
            InitializeComponent();
            userInfo = user;
        }

        #region 窗口加载事件
        private void FrmShowOrder_Load(object sender, EventArgs e)
        {
            txtCurrentDate.Text = DateTime.Now.ToShortDateString();
            txtCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region Timer控件循环事件
        private void timerCurrent_Tick(object sender, EventArgs e)
        {
            txtCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region btnExit Click事件
        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSelectMenu frmSelectMenu = new FrmSelectMenu(userInfo);
            frmSelectMenu.ShowDialog();
        }
        #endregion

        #region btnCustInfo Click事件
        private void btnCustInfo_Click(object sender, EventArgs e)
        {
            FrmTACustInfo frmTaCustInfo = new FrmTACustInfo();
            frmTaCustInfo.ShowDialog();
        }
        #endregion
    }
}

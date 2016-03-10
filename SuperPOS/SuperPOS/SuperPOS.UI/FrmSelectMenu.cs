using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Domain.Entities;
using SuperPOS.UI.Admin;
using SuperPOS.UI.TakeAway;

namespace SuperPOS.UI
{
    public partial class FrmSelectMenu : Form
    {
        private UserInfo userInfo = new UserInfo();

        #region 构造函数
        public FrmSelectMenu()
        {
            InitializeComponent();
        }

        public FrmSelectMenu(UserInfo user)
        {
            InitializeComponent();
            userInfo = user;
        }

        #endregion

        #region 事件

        #region 窗口加载
        private void FrmSelectMenu_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region Takeaway按钮
        private void btnTakeaway_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTAMain frmTaMain = new FrmTAMain(userInfo);
            frmTaMain.ShowDialog();
        }
        #endregion

        #region Eat In按钮
        private void btnEatIn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region QuickFood按钮
        private void btnQuickFood_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 登出
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogon frmLogon = new FrmLogon();
            frmLogon.ShowDialog();
        }
        #endregion

        #region Control Panel按钮
        private void btnCtlPanel_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdminControlPanel frmAdminControl = new FrmAdminControlPanel(userInfo);
            frmAdminControl.ShowDialog();
        }
        #endregion

        #region Show Order按钮
        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTAShowOrder frmShowOrder = new FrmTAShowOrder(userInfo);
            frmShowOrder.ShowDialog();
        }
        #endregion

        #region 秒表变化
        private void timerShow_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region 按钮变化

        #region Takeaway按钮特效，鼠标经过时变更按钮颜色
        private void btnTakeaway_MouseMove(object sender, MouseEventArgs e)
        {
            btnTakeaway.BackColor = Color.RoyalBlue;
        }
        #endregion

        #region Takeaway按钮特效，鼠标离开时变回原颜色
        private void btnTakeaway_MouseLeave(object sender, EventArgs e)
        {
            btnTakeaway.BackColor = Color.Silver;
        }
        #endregion

        #region Eat In按钮特效，鼠标经过时变更按钮颜色
        private void btnEatIn_MouseMove(object sender, MouseEventArgs e)
        {
            btnEatIn.BackColor = Color.RoyalBlue;
        }
        #endregion

        #region Eat In按钮特效，鼠标离开时变回原颜色
        private void btnEatIn_MouseLeave(object sender, EventArgs e)
        {
            btnEatIn.BackColor = Color.Silver;
        }
        #endregion

        #region Quick Food按钮特效，鼠标经过时变更按钮颜色
        private void btnQuickFood_MouseMove(object sender, MouseEventArgs e)
        {
            btnQuickFood.BackColor = Color.RoyalBlue;
        }
        #endregion

        #region Quick Food按钮特效，鼠标离开时变回原颜色
        private void btnQuickFood_MouseLeave(object sender, EventArgs e)
        {
            btnQuickFood.BackColor = Color.Silver;
        }
        #endregion

        #endregion

        #endregion
    }
}

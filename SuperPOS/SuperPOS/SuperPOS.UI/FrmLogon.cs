using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Common;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;
using SuperPOS.UI.Admin;

namespace SuperPOS.UI
{
    public partial class FrmLogon : Form
    {
        private readonly EntityControl _control = new EntityControl();
        public FrmLogon()
        {
            InitializeComponent();

            btnA.Click += btn_Click;
            btnB.Click += btn_Click;
            btnC.Click += btn_Click;
            btnD.Click += this.btn_Click;
            btn1.Click += this.btn_Click;
            btn2.Click += this.btn_Click;
            btn3.Click += this.btn_Click;
            btn4.Click += this.btn_Click;
            btn5.Click += this.btn_Click;
            btn6.Click += this.btn_Click;
            btn7.Click += this.btn_Click;
            btn8.Click += this.btn_Click;
            btn9.Click += this.btn_Click;
            btn0.Click += this.btn_Click;
        }

        private void FrmLogon_Load(object sender, EventArgs e)
        {
            picBoxLogo.Image = Image.FromFile(CommonBase.IMG_PATH_DEFAULT + CommonBase.IMG_FILE_LOGO_LOGON);
            picBoxLogoCust.Image = Image.FromFile(CommonBase.IMG_PATH_DEFAULT + CommonBase.IMG_FILE_CUSTOMER_LOGO);

            //lblDate.Text = "";
            //lblTime.Text = "";
            //lblSession.Text = "";
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();

            new OnLoadSystemCommonData().GetShiftCodeList();
            ShiftCodeInfo scInfo = new ShiftCodeInfo();
            scInfo = CommonData.ShiftCodeList.FirstOrDefault(sc =>
                            DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), Convert.ToDateTime(sc.DtFrom)) >= 0
                            &&
                            DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), Convert.ToDateTime(sc.DtTo)) <= 0);

            if (scInfo != null) lblSession.Text = scInfo.ShiftName;

            //foreach (var sc in CommonData.ShiftCodeList)
            //{
            //    Console.WriteLine(@"SystemKey:" + sc.SystemKey
            //                        + @" Shift Code:" + sc.ShiftCode
            //                        + @" Shift Name:" + sc.ShiftName
            //                        + @" Other Name:" + sc.OtherName
            //                        + @" DtFrom: " + sc.DtFrom
            //                        + @" DtTo: " + sc.DtTo
            //                        + @" SpecialPriceEnable: " + sc.SpecialPriceEnable);   
            //}
        }

        #region 按钮输入事件
        /// <summary>
        /// 按钮输入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPwd.Text += btn.Text;
        }
        #endregion

        #region 秒表变化，负责更改lblTime中的值
        private void timerForTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region 清楚txtPwd中的值
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPwd.Text = "";
        }
        #endregion

        #region 退出系统
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 登录
        private void btnOK_Click(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetSysConfigList();

            if (CommonData.UsrList.Any(s => s.UsrPwd.Equals(txtPwd.Text)) || txtPwd.Text.Equals(CommonBase.SYS_CONTROL_PWD))
            {
                if (CommonData.SysConfigList.Count <= 0)
                {
                    MessageBox.Show("No restaurant, please first add first");
                    FrmSysConfig frmSysConfig = new FrmSysConfig(0);
                    frmSysConfig.ShowDialog();
                }

                Hide();

                var uList = CommonData.UsrList.FirstOrDefault(s => s.UsrPwd.Equals(txtPwd.Text));
                if (uList == null) //超级管理员
                {
                    if (txtPwd.Text.Equals(CommonBase.SYS_CONTROL_PWD))
                    {
                        UserInfo user = new UserInfo();
                        user.SystemKey = Guid.NewGuid();
                        user.UsrCode = "888";
                        user.UsrName = "888";
                        user.UsrPwd = CommonBase.SYS_CONTROL_PWD;
                        user.Remark = 0;
                        _control.AddEntity(user);
                        new OnLoadSystemCommonData().GetUserList();
                        uList = CommonData.UsrList.FirstOrDefault(s => s.UsrPwd.Equals(txtPwd.Text));
                    }
                    else
                    {
                        txtPwd.Text = "";
                        return;
                    }
                }

                var fPage = CommonData.SysConfigList.FirstOrDefault();
                switch (fPage.DefaultOrderInputPage)
                {
                    case "System Control":
                        FrmAdminControlPanel frmAdminMain = new FrmAdminControlPanel(uList, txtPwd.Text.Equals(CommonBase.SYS_CONTROL_PWD));
                        frmAdminMain.ShowDialog();
                        break;
                    case "Takeaway":
                    case "Eat In":
                        FrmSelectMenu frmSelectMenu = new FrmSelectMenu(CommonData.UsrList.FirstOrDefault(s => s.UsrPwd.Equals(txtPwd.Text)));
                        frmSelectMenu.ShowDialog();
                        break;
                    case "Quick Food":
                        break;
                }
            }
        }
        #endregion
    }
}

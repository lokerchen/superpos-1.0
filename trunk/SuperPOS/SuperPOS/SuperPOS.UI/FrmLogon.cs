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
using SuperPOS.UI.Admin;

namespace SuperPOS.UI
{
    public partial class FrmLogon : Form
    {
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

            foreach (var sc in CommonData.ShiftCodeList)
            {
                Console.WriteLine(@"SystemKey:" + sc.SystemKey
                                    + @" Shift Code:" + sc.ShiftCode
                                    + @" Shift Name:" + sc.ShiftName
                                    + @" Other Name:" + sc.OtherName
                                    + @" DtFrom: " + sc.DtFrom
                                    + @" DtTo: " + sc.DtTo
                                    + @" SpecialPriceEnable: " + sc.SpecialPriceEnable);   
            }
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CommonData.UsrList.Any(s => s.UsrPwd.Equals(txtPwd.Text)))
            {
                Hide();
                FrmAdminControlPanel frmAdminMain = new FrmAdminControlPanel();
                frmAdminMain.ShowDialog();
            }
        }
    }
}

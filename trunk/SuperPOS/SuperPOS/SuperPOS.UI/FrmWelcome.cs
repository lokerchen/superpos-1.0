using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Common;
using SuperPOS.DAL;

namespace SuperPOS.UI
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void timerPgBarInit_Tick(object sender, EventArgs e)
        {
            if (pgBarInit.Value < pgBarInit.Maximum)
            {
                pgBarInit.Value++;
                lblPgBarMsg.Text = "Loading system data..." + pgBarInit.Value + @"%";
            }
            else
            {
                timerPgBarInit.Enabled = false;
                this.Hide();
                FrmMainShow frmMain = new FrmMainShow();
                frmMain.ShowDialog();

            }
        }

        private void FrmWelcome_Load_1(object sender, EventArgs e)
        {
            //进度条初始值
            pgBarInit.Value = 0;
            pgBarInit.Minimum = 0;

            //加载系统数据
            DALCommon.GetAllInfoList();

            string strImgWelcome = "";
            strImgWelcome = CommonFunction.GetSysImg("1");
            picBoxLogo.Image = File.Exists(strImgWelcome) ? Image.FromFile(strImgWelcome) : null;

            timerPgBarInit.Enabled = false;

            timerPgBarInit.Enabled = true;
        }
    }
}

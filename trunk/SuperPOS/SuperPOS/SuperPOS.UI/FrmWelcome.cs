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
            lblPgBarMsg.Text = "Loading system necessary images...";

            timerPgBarInit.Enabled = false;
            if (!File.Exists(CommonBase.IMG_PATH_DEFAULT + CommonBase.IMG_FILE_LOGO_MY))
            {
                MessageBox.Show("Can not found the system image,NAME=" + CommonBase.IMG_FILE_LOGO_MY);
                this.Close();
            }

            if (!File.Exists(CommonBase.IMG_PATH_DEFAULT + CommonBase.IMG_FILE_LOGO_MY))
            {
                MessageBox.Show("Can not fount the system image, NAME=" + CommonBase.IMG_FILE_LOGO_MY);
                this.Close();
            }

            //加载LOGO
            picBoxLogo.Image = Image.FromFile(CommonBase.IMG_PATH_DEFAULT + CommonBase.IMG_FILE_LOGO_MY);
            timerPgBarInit.Enabled = true;

            //加载系统数据
            DALCommon.GetAllInfoList();
        }
    }
}

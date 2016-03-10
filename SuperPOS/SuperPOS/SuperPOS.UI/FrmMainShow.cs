using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using SuperPOS.Common;
using SuperPOS.DAL;

namespace SuperPOS.UI
{
    public partial class FrmMainShow : Form
    {
        public FrmMainShow()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //picBoxLogo.Image = Image.FromFile(CommonBase.IMG_PATH_DEFAULT + CommonBase.IMG_FILE_LOGO_MY);
            string strImgWelcome = CommonFunction.GetSysImg("1");

            picBoxLogo.Image = File.Exists(strImgWelcome) ? Image.FromFile(strImgWelcome) : null;
        }

        private void lblSuperPOS_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogon frmLogon = new FrmLogon();
            frmLogon.ShowDialog();
        }

        private void lblRemote_Click(object sender, EventArgs e)
        {
            //打开TeamView
            string strTVPath = CommonFunction.GetSysImg("4");
            Process.Start(strTVPath);
        }

        private void lblNetShop_Click(object sender, EventArgs e)
        {
            //打开网上订餐
            string strUrl = CommonFunction.GetSysImg("5");
            Process.Start(@"http://" + strUrl);
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            //升级怎样来做？
        }
    }
}

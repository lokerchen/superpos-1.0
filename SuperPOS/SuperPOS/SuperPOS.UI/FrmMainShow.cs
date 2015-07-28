using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using SuperPOS.Common;

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
            picBoxLogo.Image = Image.FromFile(CommonBase.IMG_PATH_DEFAULT + CommonBase.IMG_FILE_LOGO_MY);
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
            Process.Start(CommonBase.FILE_TEAMVIEW_DEFAULT_X64 + CommonBase.FILE_TEAMVIEW_NAME);
        }

        private void lblNetShop_Click(object sender, EventArgs e)
        {
            //打开网上订餐
            Process.Start(CommonBase.URL_DEFAULT);
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            //升级怎样来做？
        }
    }
}

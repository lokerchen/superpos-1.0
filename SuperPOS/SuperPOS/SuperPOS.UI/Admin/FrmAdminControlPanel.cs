﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.Admin
{
    public partial class FrmAdminControlPanel : Form
    {
        private UserInfo usrInfo = new UserInfo();

        public FrmAdminControlPanel()
        {
            InitializeComponent();
        }

        public FrmAdminControlPanel(UserInfo uInfo)
        {
            InitializeComponent();
            usrInfo = uInfo;
        }

        private void FrmAdminControlPanel_Load(object sender, EventArgs e)
        {
            if (usrInfo.UsrRight == 1)
                gupBoxEatInSetting.Visible = false;
        }
    }
}
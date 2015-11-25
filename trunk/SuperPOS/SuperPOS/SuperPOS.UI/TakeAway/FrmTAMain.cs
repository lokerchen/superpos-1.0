using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAMain : Form
    {
        private UserInfo userInfo = new UserInfo();

        public FrmTAMain()
        {
            InitializeComponent();
        }

        public FrmTAMain(UserInfo user)
        {
            InitializeComponent();
            userInfo = user;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI
{
    public partial class FrmShowOrder : Form
    {
        private UserInfo userInfo = new UserInfo();

        public FrmShowOrder()
        {
            InitializeComponent();
        }

        public FrmShowOrder(UserInfo user)
        {
            InitializeComponent();
            userInfo = user;
        }
    }
}

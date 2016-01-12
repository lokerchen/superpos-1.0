using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAMenuItem : Form
    {
        public FrmTAMenuItem()
        {
            InitializeComponent();
        }

        private void FrmTAMenuItem_Load(object sender, EventArgs e)
        {
            btn1.Click += btn_Click;
            btn2.Click += btn_Click;
            btn3.Click += btn_Click;
            btn4.Click += btn_Click;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

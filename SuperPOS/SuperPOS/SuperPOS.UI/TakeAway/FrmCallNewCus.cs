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
    public partial class FrmCallNewCus : Form
    {
        //送餐类型，默认为Delivery
        private string dType = "D";
        public FrmCallNewCus()
        {
            InitializeComponent();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            btnCollection.BackColor = Color.Gray;
            dType = "D";
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            btnDelivery.BackColor = Color.Gray;
            dType = "C";
        }
    }
}

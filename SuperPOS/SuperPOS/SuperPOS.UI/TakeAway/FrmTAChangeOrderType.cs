using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperPOS.Common;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAChangeOrderType : Form
    {
        public string strOrderType = "";
        public FrmTAChangeOrderType()
        {
            InitializeComponent();
        }

        public FrmTAChangeOrderType(string OrderType)
        {
            InitializeComponent();
            strOrderType = OrderType;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            strOrderType = CommonBase.ORDER_TYPE_SHOP;
            Hide();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            strOrderType = CommonBase.ORDER_TYPE_DELIVERY;
            Hide();
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            strOrderType = CommonBase.ORDER_TYPE_COLLECTION;
            Hide();
        }
    }
}

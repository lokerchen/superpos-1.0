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
        //默认为DELIVERY
        public string strOrderType = CommonBase.ORDER_TYPE_DELIVERY;

        public string ValueString
        {
            get { return strOrderType; }
            set { ValueString = value; }
        }

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
            this.DialogResult = DialogResult.OK;
            Hide();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            strOrderType = CommonBase.ORDER_TYPE_DELIVERY;
            this.DialogResult = DialogResult.OK;
            Hide();
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            strOrderType = CommonBase.ORDER_TYPE_COLLECTION;
            this.DialogResult = DialogResult.OK;
            Hide();
        }
    }
}

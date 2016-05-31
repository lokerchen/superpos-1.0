using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTASearchMeal : Form
    {
        public string ValueString
        {
            get { return txtKeyWord.Text; }
            set { ValueString = value; }
        }

        public FrmTASearchMeal()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Hide();
        }
    }
}

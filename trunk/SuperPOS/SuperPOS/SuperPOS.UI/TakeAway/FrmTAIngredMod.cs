using System;
using System.Collections;
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
    public partial class FrmTAIngredMod : Form
    {
        private string strValue = ""; 

        public FrmTAIngredMod()
        {
            InitializeComponent();
        }

        public string ValueString
        {
            get { return strValue; }
            set { ValueString = value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            strValue = "X";
            this.DialogResult = DialogResult.OK;
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            strValue = "+";
            this.DialogResult = DialogResult.OK;
            Hide();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            strValue = "/";
            this.DialogResult = DialogResult.OK;
            Hide();
        }

        private void btnNoAction_Click(object sender, EventArgs e)
        {
            strValue = " ";
            this.DialogResult = DialogResult.OK;
            Hide();
        }
    }
}

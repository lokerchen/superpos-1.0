using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperPOS.DAL;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAKeyPad : Form
    {
        private Button[] btnNum = new Button[10];
        private Button[] btnWord = new Button[10];
        private Button[] btnQty = new Button[5];

        private int iType = 1;

        public string DisCode
        {
            get { return txtDishCode.Text; }
            set { DisCode = value; }
        }

        public string Qty
        {
            get { return txtQty.Text; }
            set { Qty = value; }
        }

        public FrmTAKeyPad()
        {
            InitializeComponent();
        }

        private void BtnNumWord_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            txtDishCode.Text += btn.Text;
        }

        private void BtnQty_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            txtQty.Text = "";
            txtQty.Text = btn.Text;
        }

        private void FrmTAKeyPad_Load(object sender, EventArgs e)
        {
            txtQty.Text = "X1";
            #region 控件数组赋值
            btnNum[0] = btnN1;
            btnNum[1] = btnN2;
            btnNum[2] = btnN3;
            btnNum[3] = btnN4;
            btnNum[4] = btnN5;
            btnNum[5] = btnN6;
            btnNum[6] = btnN7;
            btnNum[7] = btnN8;
            btnNum[8] = btnN9;
            btnNum[9] = btnN10;

            btnWord[0] = btnW1;
            btnWord[1] = btnW2;
            btnWord[2] = btnW3;
            btnWord[3] = btnW4;
            btnWord[4] = btnW5;
            btnWord[5] = btnW6;
            btnWord[6] = btnW7;
            btnWord[7] = btnW8;
            btnWord[8] = btnW9;
            btnWord[9] = btnW10;

            btnQty[0] = btnQ1;
            btnQty[1] = btnQ2;
            btnQty[2] = btnQ3;
            btnQty[3] = btnQ4;
            btnQty[4] = btnQ5;

            string[] strKeyPad = new string [11];
            new OnLoadSystemCommonData().GetSysConfigList();
            if (CommonData.SysConfigList.Any())
            {
                var lstSysConf = CommonData.SysConfigList.FirstOrDefault();

                strKeyPad = lstSysConf.KeypadSet.Split(new char[] { ',' });
            }

            if (strKeyPad.Length > 0)
            {
                for (int i = 1; i < 11; i++)
                {
                    if (!string.IsNullOrEmpty(strKeyPad[i])) btnWord[i - 1].Text = strKeyPad[i];
                    else btnWord[i - 1].Enabled = false;
                }
            }


            for (int i = 0; i < 10; i++)
            {
                btnNum[i].Click += BtnNumWord_Click;
                btnWord[i].Click += BtnNumWord_Click;
            }

            for (int i = 0; i < 5; i++)
            {
                btnQty[i].Click += BtnQty_Click;
            }
            #endregion
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtDishCode.Text = txtDishCode.Text.Substring(0, txtDishCode.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (iType == 1) txtDishCode.Text = "";
            else txtQty.Text = "";
        }

        private void txtDishCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            iType = 1;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            iType = 2;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Hide();
        }
    }
}

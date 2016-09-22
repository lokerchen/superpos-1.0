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
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAChangePrice : Form
    {
        private string strDishCode = "";
        private string strOriPrice = "0.0";

        private Button[] btnDP = new Button[9];
        private Button[] btnNum = new Button[10];

        private string strCtlName = "txtDiscount";

        private TAMenuItemInfo taMenuItemInfo = null;

        public string ValueString
        {
            get { return txtNewPrice.Text; }
            set { ValueString = value; }
        }

        public FrmTAChangePrice()
        {
            InitializeComponent();
        }

        public FrmTAChangePrice(string sDCode, string sOriPrice)
        {
            InitializeComponent();

            strDishCode = sDCode;

            strOriPrice = sOriPrice;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtNewPrice.Text = txtOrigPrice.Text;
            this.DialogResult = DialogResult.OK;
            Hide();
        }

        private void FrmTAChangePrice_Load(object sender, EventArgs e)
        {
            #region 查询初始值

            new OnLoadSystemCommonData().GetTAMenuItemList();
            var lstMI = CommonData.TaMenuItemList.Where(s => s.DishCode.Equals(strDishCode));

            if (lstMI.Any())
            {
                TAMenuItemInfo miMenuItem = lstMI.FirstOrDefault();

                taMenuItemInfo = lstMI.FirstOrDefault();

                txtEngName.Text = miMenuItem.EnglishName;
                txtOtherName.Text = miMenuItem.OtherName;
                //txtOrigPrice.Text = miMenuItem.wRegular;
                txtOrigPrice.Text = strOriPrice;

                txtDiscount.Text = "0.0";
                txtIncre.Text = "0.0";
                //txtNewPrice.Text = miMenuItem.wRegular;
                txtNewPrice.Text = txtOrigPrice.Text;
            }

            #endregion

            #region 控件数组赋值

            btn0.Click += BtnNum_Click;
            btn1.Click += BtnNum_Click;
            btn2.Click += BtnNum_Click;
            btn3.Click += BtnNum_Click;
            btn4.Click += BtnNum_Click;
            btn5.Click += BtnNum_Click;
            btn6.Click += BtnNum_Click;
            btn7.Click += BtnNum_Click;
            btn8.Click += BtnNum_Click;
            btn9.Click += BtnNum_Click;
            btnPoint.Click += BtnNum_Click;

            btnP1.Click += BtnDisPer_Click;
            btnP2.Click += BtnDisPer_Click;
            btnP3.Click += BtnDisPer_Click;
            btnP4.Click += BtnDisPer_Click;
            btnP5.Click += BtnDisPer_Click;
            btnP6.Click += BtnDisPer_Click;
            btnP7.Click += BtnDisPer_Click;
            btnP8.Click += BtnDisPer_Click;
            btnP9.Click += BtnDisPer_Click;

            btnNum[0] = btn0;
            btnNum[1] = btn1;
            btnNum[2] = btn2;
            btnNum[3] = btn3;
            btnNum[4] = btn4;
            btnNum[5] = btn5;
            btnNum[6] = btn6;
            btnNum[7] = btn7;
            btnNum[8] = btn8;
            btnNum[9] = btn9;

            btnDP[0] = btnP1;
            btnDP[1] = btnP2;
            btnDP[2] = btnP3;
            btnDP[3] = btnP4;
            btnDP[4] = btnP5;
            btnDP[5] = btnP6;
            btnDP[6] = btnP7;
            btnDP[7] = btnP8;
            btnDP[8] = btnP9;

            #endregion
        }

        //private string GetCtlName()
        //{
        //    if (txtDiscount.Focused) return "txtDiscount";
        //    else if (txtIncre.Focused) return "txtIncre";
        //    else return "";
        //}

        private void BtnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;

            bool bP = btn.Text.Equals(".");
            bool bPer = btn.Text.Equals("%");

            if (strCtlName.Equals("txtDiscount"))
            {
                if (txtDiscount.Text.Equals("0.00") || txtDiscount.Text.Equals("0.0")
                    || txtDiscount.Text.Equals("0") || string.IsNullOrEmpty(txtDiscount.Text))
                    txtDiscount.Text = btn.Text;
                else if (bP && !txtDiscount.Text.Contains(".")) txtDiscount.Text += ".";
                else
                {
                    if (bPer)
                    {
                        if (txtDiscount.Text.Contains("%"))
                            txtDiscount.Text = txtDiscount.Text.Substring(0, txtDiscount.TextLength - 1) + btn.Text;
                        else txtDiscount.Text += btn.Text;
                    }
                    else
                        txtDiscount.Text += btn.Text;
                }
            }
            else if (strCtlName.Equals("txtIncre"))
            {
                if (txtIncre.Text.Equals("0.00") || txtIncre.Text.Equals("0.0")
                    || txtIncre.Text.Equals("0") || string.IsNullOrEmpty(txtIncre.Text))
                    txtIncre.Text = btn.Text;
                else if (bP && !txtIncre.Text.Contains(".")) txtIncre.Text += ".";
                else
                {
                    if (bPer)
                    {
                        if (txtIncre.Text.Contains("%"))
                            txtIncre.Text = txtIncre.Text.Substring(0, txtIncre.TextLength - 1) + btn.Text;
                        else txtIncre.Text += btn.Text;
                    }
                    else
                        txtDiscount.Text += btn.Text;
                }
            }
            else if (strCtlName.Equals("txtNewPrice"))
            {
                if (txtNewPrice.Text.Equals("0.00") || txtNewPrice.Text.Equals("0.0")
                    || txtNewPrice.Text.Equals("0") || string.IsNullOrEmpty(txtNewPrice.Text))
                    txtNewPrice.Text = btn.Text;
                else if (bP && !txtNewPrice.Text.Contains(".")) txtNewPrice.Text += ".";
                else
                {
                    if (bPer)
                    {
                        if (txtNewPrice.Text.Contains("%"))
                            txtNewPrice.Text = txtNewPrice.Text.Substring(0, txtNewPrice.TextLength - 1) + btn.Text;
                        else txtNewPrice.Text += btn.Text;
                    }
                    else
                        txtNewPrice.Text += btn.Text;
                }
            }
        }

        private void BtnDisPer_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            txtDiscount.Text = btn.Text;
        }

        private string GetNewPrice()
        {
            //原价
            decimal dOP;
            dOP = string.IsNullOrEmpty(txtOrigPrice.Text) ? 0.0m : Convert.ToDecimal(txtOrigPrice.Text);

            ////折扣
            //decimal dDis;
            //if (txtDiscount.Text.EndsWith("%"))
            //{
            //    dDis = Convert.ToDecimal(txtDiscount.Text.Substring(0, txtDiscount.Text.Length - 1)) / 100;
            //}
            //else
            //{
            //    dDis = Convert.ToDecimal(txtDiscount.Text);
            //}
            //增长
            decimal dInc;

            if (txtIncre.Text.EndsWith(".")) dInc = string.IsNullOrEmpty(txtIncre.Text) ? 0.0m : Convert.ToDecimal(txtIncre.Text.Substring(0, txtIncre.Text.Length - 1));
            else dInc = string.IsNullOrEmpty(txtIncre.Text) ? 0.0m : Convert.ToDecimal(txtIncre.Text);

            //新价格
            decimal dNewPrice;
            decimal dDis;

            int d1 = 0;
            int d2 = 0;

            if (string.IsNullOrEmpty(txtDiscount.Text)) txtDiscount.Text = "0.00";

            if (txtDiscount.Text.EndsWith("%"))
            {
                dNewPrice = txtDiscount.Text.Substring(0, txtDiscount.Text.Length - 1).EndsWith(".")
                    ? (1 - Convert.ToDecimal(txtDiscount.Text.Substring(0, txtDiscount.Text.Length - 2))/100)*dOP + dInc
                    : (1 - Convert.ToDecimal(txtDiscount.Text.Substring(0, txtDiscount.Text.Length - 1))/100)*dOP + dInc;
            }
            else if (txtDiscount.Text.EndsWith("."))
            {
                dNewPrice = dOP - Convert.ToDecimal(txtDiscount.Text.Substring(0, txtDiscount.Text.Length - 1)) + dInc;
            }
            else
                dNewPrice = dOP - Convert.ToDecimal(txtDiscount.Text) + dInc;

            if (dNewPrice <= 0.0m) dNewPrice = 0.0m;

            return dNewPrice.ToString("0.00");
        }

        private void txtDiscount_MouseDown(object sender, MouseEventArgs e)
        {
            strCtlName = "txtDiscount";
            //txtDiscount.SelectAll();
        }

        private void txtIncre_MouseDown(object sender, MouseEventArgs e)
        {
            strCtlName = "txtIncre";
            //txtIncre.SelectAll();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            txtNewPrice.Text = GetNewPrice();
        }

        private void txtIncre_TextChanged(object sender, EventArgs e)
        {
            txtNewPrice.Text = GetNewPrice();
        }

        private void txtNewPrice_TextChanged(object sender, EventArgs e)
        {
            //txtNewPrice.Text = GetNewPrice();
            if (string.IsNullOrEmpty(txtNewPrice.Text)) txtNewPrice.Text = txtOrigPrice.Text;
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = "0.00";
            txtIncre.Text = "0.00";
            txtNewPrice.Text = "0.00";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Hide();
        }

        private void txtNewPrice_MouseDown(object sender, MouseEventArgs e)
        {
            strCtlName = "txtNewPrice";
            //txtNewPrice.SelectAll();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (strCtlName.Equals("txtDiscount"))
            {
                if (!txtDiscount.Text.Contains("%")) txtDiscount.Text += "%";
            }
            else if (strCtlName.Equals("txtIncre"))
            {
                if (!txtIncre.Text.Contains("%")) txtIncre.Text += "%";
            }
            else if (strCtlName.Equals("txtNewPrice"))
            {
                if (!txtNewPrice.Text.Contains("%")) txtNewPrice.Text += "%";
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (strCtlName.Equals("txtDiscount"))
                txtDiscount.Text = "0.00";
            else if (strCtlName.Equals("txtIncre"))
                txtIncre.Text = "0.00";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = "0.00";
            txtIncre.Text = "0.00";
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            if (taMenuItemInfo != null)
            {
                txtOrigPrice.Text = string.IsNullOrEmpty(taMenuItemInfo.wLarge) ? taMenuItemInfo.wRegular : taMenuItemInfo.wLarge;
            }
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            if (taMenuItemInfo != null)
            {
                txtOrigPrice.Text = string.IsNullOrEmpty(taMenuItemInfo.wSmall) ? taMenuItemInfo.wRegular : taMenuItemInfo.wSmall;
            }
        }
    }
}

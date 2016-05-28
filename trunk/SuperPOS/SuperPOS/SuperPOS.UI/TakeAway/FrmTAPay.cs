﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAPay : Form
    {
        //订单编号
        private string chkNum = "";
        //会员编号
        private string CustNum = "";

        //private string sSurcharge1 = @"0.0";
        //private string sSurcharge2 = @"0.0";
        //private string sSurcharge3 = @"0.0";
        private string[] sSurcharge = new string[3];
        

        private TextBox[] txtPay = new TextBox[3];
        private Label[] lblPaySurcharge = new Label[3];
        private Label[] lblPayType = new Label[3];
        private Button[] btnDriver = new Button[6];
        private Label[] lblSCharge = new Label[3];

        //默认焦点放置在txtDelivery上
        private string strCtlName = "txtDelivery";

        public FrmTAPay()
        {
            InitializeComponent();
        }

        public FrmTAPay(string strChkNum, string strCustNum)
        {
            InitializeComponent();
            chkNum = strChkNum;
            CustNum = strCustNum;
        }

        #region 退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void FrmTAPay_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAPayType();
            onLoadSystemCommonData.GetTAOrderItem();
            onLoadSystemCommonData.GetTAPaymentList();

            #region 各种附件事件
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

            txtPay1.MouseDown += txtPay_Click;
            txtPay2.MouseDown += txtPay_Click;
            txtPay3.MouseDown += txtPay_Click;
            #endregion

            #region 查询会员
            //查询会员
            new OnLoadSystemCommonData().GetTACust();

            var custList = CommonData.TaCustList.Where(s => s.SystemKey.ToString().Equals(CustNum));

            if (custList.Any())
            {
                TACustInfo taCustInfo = custList.FirstOrDefault();
                txtPhone.Text = taCustInfo.Phone1;
                txtName.Text = taCustInfo.Name;
                txtHouseNo.Text = taCustInfo.HouseNo;
                txtAddress.Text = taCustInfo.Address1;
                txtPostcode.Text = taCustInfo.Postcode1;
                txtDistance.Text = taCustInfo.Distance;
                txtPCZone.Text = taCustInfo.PcZone;
                txtDelCharge.Text = taCustInfo.DelCharge;
                txtReadyTime.Text = taCustInfo.ReadyTime;
                txtIntNotes.Text = taCustInfo.IntNotes;
                txtNotes.Text = taCustInfo.NotesOnBill;
                chkBlackListed.Checked = taCustInfo.IsBlackListed.Equals("Y");
            }
            #endregion

            #region Delivery / Collection Note
            new OnLoadSystemCommonData().GetTAPreDefined();
            var cmbList = CommonData.TaPreDefinedList.Select(lstPD => new { Prevalue = lstPD.PreTxtValue });
            cmbNote.DataSource = cmbList.ToList();
            cmbNote.ValueMember = "Prevalue";
            cmbNote.DisplayMember = "Prevalue";
            #endregion

            #region 控件数组
            lblPayType[0] = lblPayType1;
            lblPayType[1] = lblPayType2;
            lblPayType[2] = lblPayType3;

            txtPay[0] = txtPay1;
            txtPay[1] = txtPay2;
            txtPay[2] = txtPay3;

            lblPaySurcharge[0] = lblSurcharge1;
            lblPaySurcharge[1] = lblSurcharge2;
            lblPaySurcharge[2] = lblSurcharge3;

            btnDriver[0] = btnDriver1;
            btnDriver[1] = btnDriver2;
            btnDriver[2] = btnDriver3;
            btnDriver[3] = btnDriver4;
            btnDriver[4] = btnDriver5;
            btnDriver[5] = btnDriver6;

            lblSCharge[0] = lblSCharge1;
            lblSCharge[1] = lblSCharge2;
            lblSCharge[2] = lblSCharge3;

            //付款
            int i = 0;
            foreach (var taPayTypeInfo in CommonData.TaPayTypeList)
            {
                if (i >= 3) break;

                lblSCharge[i].Visible = true;
                lblPaySurcharge[i].Visible = true;
                txtPay[i].Visible = true;
                lblPayType[i].Visible = true;
                lblPayType[i].Text = taPayTypeInfo.PaymentType;

                i++;
            }

            for (int j = i + 1; j <= 2; j++)
            {
                lblSCharge[j].Visible = false;
                lblPaySurcharge[j].Visible = false;
                txtPay[j].Visible = false;
                lblPayType[j].Visible = false;
            }
            
            //司机清单
            if (!string.IsNullOrEmpty(GetWeek(DateTime.Today.DayOfWeek.ToString())))
            {
                i = 0;
                foreach (var driverSet in CommonData.TaDriverSetUpList.Where(s => s.DriverWorkDay.Contains(GetWeek(DateTime.Today.DayOfWeek.ToString()))).TakeWhile(driverSet => i < 6))
                {
                    btnDriver[i].Text = driverSet.DriverName;
                }

                for (int j = i + 1; j < btnDriver.Length; j++)
                {
                    btnDriver[j].Visible = false;
                }
            }

            #endregion

            #region 查询账单
            if (CommonData.TAPaymentList.Any(s => s.ChkNum.Equals(chkNum) && s.IsPaid.Equals("N")))
            {
                var payList = CommonData.TAPaymentList.Where(s => s.ChkNum.Equals(chkNum) && s.IsPaid.Equals("N"));

                TAPaymentInfo taPaymentInfo = payList.FirstOrDefault();
                txtNotPaid.Text = taPaymentInfo.NotPaid;
                txtDelivery.Text = taPaymentInfo.Delivery;
                txtDiscount.Text = taPaymentInfo.Discount;
                txtSurcharge.Text = taPaymentInfo.Surcharge;
                txtToPay.Text = taPaymentInfo.ToPay;

                if (lblSCharge[0].Visible)
                {
                    txtPay[0].Text = taPaymentInfo.PayType1;
                    lblPaySurcharge[0].Text = taPaymentInfo.PayTypeSurCharge1;
                }
                if (lblSCharge[1].Visible)
                {
                    txtPay[1].Text = taPaymentInfo.PayType2;
                    lblPaySurcharge[1].Text = taPaymentInfo.PayTypeSurCharge2;
                }
                if (lblSCharge[2].Visible)
                {
                    txtPay[2].Text = taPaymentInfo.PayType3;
                    lblPaySurcharge[2].Text = taPaymentInfo.PayTypeSurCharge3;
                }
            }
            else
            {
                return;
            }
            #endregion
        }

        private string GetWeek(string weekName)
        {
            switch (weekName)
            {
                case "Sunday":
                    return "7";
                case "Monday":
                    return "1";
                case "Tuesday":
                    return "2";
                case "Wednesday":
                    return "3";
                case "Thursday":
                    return "4";
                case "Friday":
                    return "5";
                case "Saturday":
                    return "6";
                default:
                    return "";
            }
        }

        private void txtPay_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox) sender;
            strCtlName = txt.Name;

            txt.SelectAll();
        }

        private void BtnNum_Click(object sender,  EventArgs e)
        {
            Button btn = (Button)sender;
            //txt.Text += btn.Text;

            if (strCtlName.Equals("txtPay1"))
            {
                txtPay1.Text += btn.Text;
            }
            else if (strCtlName.Equals("txtPay2"))
            {
                txtPay2.Text += btn.Text;
            }
            else if (strCtlName.Equals("txtPay3"))
            {
                txtPay3.Text += btn.Text;
            }
            else if (strCtlName.Equals("txtDelivery"))
            {
                txtDelivery.Text += btn.Text;
            }
            else if (strCtlName.Equals("txtDiscount"))
            {
                txtDiscount.Text += btn.Text;
            }
            else if (strCtlName.Equals("txtSurcharge"))
            {
                txtSurcharge.Text += btn.Text;
            }
            else if (strCtlName.Equals("txtTendered"))
            {
                txtTendered.Text += btn.Text;
            }
            else if (strCtlName.Equals("txtToPay"))
            {
                txtToPay.Text += btn.Text;
            }
        }

        private void txtDelivery_MouseDown(object sender, MouseEventArgs e)
        {
            strCtlName = "txtDelivery";
            txtDelivery.SelectAll();
        }

        private void txtDiscount_MouseDown(object sender, MouseEventArgs e)
        {
            strCtlName = "txtDiscount";
            txtDiscount.SelectAll();
        }

        private void txtSurcharge_MouseDown(object sender, MouseEventArgs e)
        {
            strCtlName = "txtSurcharge";
            txtSurcharge.SelectAll();
        }

        private void txtTendered_MouseDown(object sender, MouseEventArgs e)
        {
            strCtlName = "txtTendered";
            txtTendered.SelectAll();
        }

        private void txtToPay_MouseDown(object sender, MouseEventArgs e)
        {
            strCtlName = "txtToPay";
            txtToPay.SelectAll();
        }

        #region 小键盘，Clear按钮
        private void btnC_Click(object sender, EventArgs e)
        {
            if (strCtlName.Equals("txtPay1"))
            {
                txtPay1.Text = "";
            }
            else if (strCtlName.Equals("txtPay2"))
            {
                txtPay2.Text = "";
            }
            else if (strCtlName.Equals("txtPay3"))
            {
                txtPay3.Text = "";
            }
            else if (strCtlName.Equals("txtDelivery"))
            {
                txtDelivery.Text = "";
            }
            else if (strCtlName.Equals("txtDiscount"))
            {
                txtDiscount.Text = "";
            }
            else if (strCtlName.Equals("txtSurcharge"))
            {
                txtSurcharge.Text = "";
            }
            else if (strCtlName.Equals("txtTendered"))
            {
                txtTendered.Text = "";
            }
            else if (strCtlName.Equals("txtToPay"))
            {
                txtToPay.Text = "";
            }
        }
        #endregion

        #region 折扣Discount
        private void btnP_Click(object sender, EventArgs e)
        {
            if (strCtlName.Equals("txtDiscount"))
            {
                txtDiscount.Text += txtDiscount.Text;
            }
        }
        #endregion

        #region 数字小键盘 Del
        private void btnD_Click(object sender, EventArgs e)
        {
            if (strCtlName.Equals("txtPay1"))
            {
                txtPay1.Text = txtPay1.Text.Length > 0 ? txtPay1.Text.Substring(0, txtPay1.TextLength - 1) : "";
            }
            else if (strCtlName.Equals("txtPay2"))
            {
                txtPay2.Text = txtPay2.Text.Length > 0 ? txtPay2.Text.Substring(0, txtPay2.TextLength - 1) : "";;
            }
            else if (strCtlName.Equals("txtPay3"))
            {
                txtPay3.Text = txtPay3.Text.Length > 0 ? txtPay3.Text.Substring(0, txtPay3.TextLength - 1) : "";;
            }
            else if (strCtlName.Equals("txtDelivery"))
            {
                txtDelivery.Text = txtDelivery.Text.Length > 0 ? txtDelivery.Text.Substring(0, txtDelivery.TextLength - 1) : "";;
            }
            else if (strCtlName.Equals("txtDiscount"))
            {
                txtDiscount.Text = txtDiscount.Text.Length > 0 ? txtDiscount.Text.Substring(0, txtDiscount.TextLength - 1) : "";;
            }
            else if (strCtlName.Equals("txtSurcharge"))
            {
                txtSurcharge.Text = txtSurcharge.Text.Length > 0 ? txtSurcharge.Text.Substring(0, txtSurcharge.TextLength - 1) : "";;
            }
            else if (strCtlName.Equals("txtTendered"))
            {
                txtTendered.Text = txtTendered.Text.Length > 0 ? txtTendered.Text.Substring(0, txtTendered.TextLength - 1) : "";;
            }
            else if (strCtlName.Equals("txtToPay"))
            {
                txtToPay.Text= txtToPay.Text.Length > 0 ? txtToPay.Text.Substring(0, txtToPay.TextLength - 1) : "";;
            }
        }
        #endregion

        private void txtPay1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GetAmount()
        {
            //获得不同付款方式的结算

            //获得Delivery付款，默认为0

            //Discount计算方式

            //获得总钱数
        }
    }
}

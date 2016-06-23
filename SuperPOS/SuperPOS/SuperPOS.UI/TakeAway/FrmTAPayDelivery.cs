﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Common;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;
using SuperPOS.UI.Print;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAPayDelivery : Form
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

        //默认实际需付款
        private decimal AcctPay = 0.00m;
        //折扣的实际数额
        private decimal DisValue = 0.00m;

        //三种不同付款方式
        private decimal Pay1 = 0.00m;
        private decimal Pay2 = 0.00m;
        private decimal Pay3 = 0.00m;

        //司机名
        private string strDriverName = "";

        private bool IsPaid = false;

        private readonly EntityControl _control = new EntityControl();

        private Hashtable htPay = new Hashtable();
        public bool ValueString
        {
            get { return IsPaid; }
            set { ValueString = value; }
        }

        public FrmTAPayDelivery()
        {
            InitializeComponent();
        }

        public FrmTAPayDelivery(string strChkNum, string strCustNum, Hashtable htDetail)
        {
            InitializeComponent();
            chkNum = strChkNum;
            CustNum = strCustNum;
            htPay = htDetail;
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

            strCtlName = "txtPay1";

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

            btnDriver1.Click += BtnDriver_Click;
            btnDriver2.Click += BtnDriver_Click;
            btnDriver3.Click += BtnDriver_Click;
            btnDriver4.Click += BtnDriver_Click;
            btnDriver5.Click += BtnDriver_Click;
            btnDriver6.Click += BtnDriver_Click;

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
            var cmbList = CommonData.TaPreDefinedList.Select(lstPD => new {Prevalue = lstPD.PreTxtValue});
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
                foreach (
                    var driverSet in
                        CommonData.TaDriverSetUpList.Where(
                            s => s.DriverWorkDay.Contains(GetWeek(DateTime.Today.DayOfWeek.ToString())))
                            .TakeWhile(driverSet => i < 6))
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
                txtDiscount.Text = taPaymentInfo.Discount;
                txtSurcharge.Text = taPaymentInfo.Surcharge;
                txtToPay.Text = taPaymentInfo.ToPay;
                txtNotPaid.Text = taPaymentInfo.NotPaid;
                txtDelivery.Text = taPaymentInfo.Delivery;
                txtTendered.Text = taPaymentInfo.Tendered;
                
                AcctPay = Convert.ToDecimal(taPaymentInfo.AcctPay);

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

        private void BtnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
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
                if (!txtDiscount.Text.EndsWith("%")) txtDiscount.Text += "%";

                if (txtDiscount.Text.Contains("%")) return;
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
                txtPay2.Text = txtPay2.Text.Length > 0 ? txtPay2.Text.Substring(0, txtPay2.TextLength - 1) : "";
                ;
            }
            else if (strCtlName.Equals("txtPay3"))
            {
                txtPay3.Text = txtPay3.Text.Length > 0 ? txtPay3.Text.Substring(0, txtPay3.TextLength - 1) : "";
                ;
            }
            else if (strCtlName.Equals("txtDelivery"))
            {
                txtDelivery.Text = txtDelivery.Text.Length > 0
                    ? txtDelivery.Text.Substring(0, txtDelivery.TextLength - 1)
                    : "";
                ;
            }
            else if (strCtlName.Equals("txtDiscount"))
            {
                txtDiscount.Text = txtDiscount.Text.Length > 0
                    ? txtDiscount.Text.Substring(0, txtDiscount.TextLength - 1)
                    : "";
                ;
            }
            else if (strCtlName.Equals("txtSurcharge"))
            {
                txtSurcharge.Text = txtSurcharge.Text.Length > 0
                    ? txtSurcharge.Text.Substring(0, txtSurcharge.TextLength - 1)
                    : "";
                ;
            }
            else if (strCtlName.Equals("txtTendered"))
            {
                txtTendered.Text = txtTendered.Text.Length > 0
                    ? txtTendered.Text.Substring(0, txtTendered.TextLength - 1)
                    : "";
                ;
            }
            else if (strCtlName.Equals("txtToPay"))
            {
                txtToPay.Text = txtToPay.Text.Length > 0 ? txtToPay.Text.Substring(0, txtToPay.TextLength - 1) : "";
                ;
            }
        }

        #endregion

        private void txtPay1_TextChanged(object sender, EventArgs e)
        {
            GetPayType();
            txtTendered.Text = (Pay1 + Pay2 + Pay3).ToString();

            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAPayType();

            if (CommonData.TaPayTypeList.Any(s => s.PaymentType.Equals(lblPayType1.Text)))
            {
                TAPayTypeInfo taPayType = CommonData.TaPayTypeList.FirstOrDefault(s => s.PaymentType.Equals(lblPayType1.Text));

                try
                {
                    decimal d1 = 0.00m;
                    decimal d2 = 0.00m;
                    decimal d3 = 0.00m;

                    d1 = Convert.ToDecimal(taPayType.SurchargeThreshold);
                    d2 = Convert.ToDecimal(taPayType.SurchargeAmount);
                    d3 = Convert.ToDecimal(taPayType.SurchargePercent);

                    if (d1 > 0)
                    {
                        if (Pay1 > d1)
                        {
                            lblSurcharge1.Text = d2 > 0 ? d2.ToString() : ((d3 / 100) * Pay1).ToString();
                        }
                    }
                    else
                    {
                        lblSurcharge1.Text = d2 > 0 ? d2.ToString() : ((d3/100) * Pay1).ToString();
                    }
                }
                catch (Exception)
                {
                    lblSurcharge1.Text = "0.00";
                    throw;
                }
            }

            GetAmount();
        }

        #region 计算账单
        private void GetAmount()
        {
            decimal dDiscount = 0.00m;
            decimal dDelivery = 0.00m;
            decimal dSurChargeTotal = 0.00m;

            //获得不同付款方式的结算
            GetPayType();

            //获得Delivery付款，默认为0
            dDelivery = GetDelivery();
            
            //Surcharge附加费
            dSurChargeTotal = GetSurCharge();

            //Discount计算方式
            DisValue = dDiscount = GetDiscount(AcctPay);

            //获得总钱数
            decimal total = AcctPay + dDelivery - Pay1 - Pay2 - Pay3 - dDiscount + dSurChargeTotal;

            //需要付款
            txtToPay.Text = (AcctPay + dDelivery + dSurChargeTotal - dDiscount).ToString();

            //已经付款
            txtTendered.Text = (Pay1 + Pay2 + Pay3).ToString();

            //找零
            decimal dChange = Pay1 + Pay2 + Pay3 - AcctPay - dDelivery + dDiscount - dSurChargeTotal;
            txtChange.Text = dChange <= 0 ? "0.00" : dChange.ToString();

            if (total <= 0) total = 0.00m;

            //未付款
            txtNotPaid.Text = total.ToString();
        }
        #endregion

        #region 获得Delivery

        private decimal GetDelivery()
        {
            return 0.00m;
        }

        #endregion

        #region 获得折扣信息

        private decimal GetDiscount(decimal dTotal)
        {
            decimal dis = 0.00m;

            if (txtDiscount.Text.EndsWith("%"))
            {
                try
                {
                    string strDis = txtDiscount.Text;
                    if (string.IsNullOrEmpty(txtDiscount.Text)) strDis = "0.00";
                    //百分比折扣
                    decimal disDetail = (Convert.ToDecimal(strDis.Substring(0, strDis.Length - 1)))/100;
                    dis = dTotal*disDetail;
                }
                catch (Exception)
                {
                    MessageBox.Show("Discount Computational failure!");
                    txtDiscount.Focus();
                    //throw;
                }
            }
            else
            {
                try
                {
                    //具体折扣
                    //decimal disDetail = 0.00m;
                    //disDetail = Convert.ToDecimal(txtDiscount.Text);
                    //dis = dTotal - disDetail;
                    string strDis = txtDiscount.Text;
                    if (string.IsNullOrEmpty(strDis)) strDis = "0.00";
                    dis = Convert.ToDecimal(strDis);
                }
                catch (Exception)
                {
                    MessageBox.Show("Discount Computational failure!");
                    txtDiscount.Focus();
                    //throw;
                }
            }

            return dis;
        }

        #endregion

        #region 获得不同付款方式的付款

        private void GetPayType()
        {
            if (lblSCharge1.Visible)
            {
                try
                {
                    string sPay1 = txtPay1.Text;
                    if (string.IsNullOrEmpty(txtPay1.Text)) sPay1 = "0.00";
                    Pay1 = Convert.ToDecimal(sPay1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Payment failure!");
                    //throw;
                }
            }

            if (lblSCharge2.Visible)
            {
                try
                {
                    string sPay2 = txtPay2.Text;
                    if (string.IsNullOrEmpty(txtPay2.Text)) sPay2 = "0.00";
                    Pay2 = Convert.ToDecimal(sPay2);
                }
                catch (Exception)
                {
                    MessageBox.Show("Payment failure!");
                    //throw;
                }
            }

            if (lblSCharge3.Visible)
            {
                try
                {
                    string sPay3 = txtPay3.Text;
                    if (string.IsNullOrEmpty(txtPay3.Text)) sPay3 = "0.00";
                    Pay3 = Convert.ToDecimal(sPay3);
                }
                catch (Exception)
                {
                    MessageBox.Show("Payment failure!");
                    //throw;
                }
            }
        }

        #endregion

        #region 获得附加费
        private decimal GetSurCharge()
        {
            //decimal dTotal = 0.00m;
            decimal s = 0.00m;
            decimal s1 = 0.00m;
            decimal s2 = 0.00m;
            decimal s3 = 0.00m;

            new OnLoadSystemCommonData().GetTAPayType();

            try
            {
                s = Convert.ToDecimal(txtSurcharge.Text);
                s1 = Convert.ToDecimal(lblSurcharge1.Text);
                s2 = Convert.ToDecimal(lblSurcharge2.Text);
                s3 = Convert.ToDecimal(lblSurcharge3.Text);
            }
            catch (Exception)
            {
                
                //throw;
            }


            return s + s1 + s2 + s3;
        }
        #endregion

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            //if (txtDiscount.Text.Contains("%")) return;
            //if (txtDiscount.Text.EndsWith("%")) return;

            GetAmount();
        }

        private void txtTendered_TextChanged(object sender, EventArgs e)
        {
            decimal dChange = Convert.ToDecimal(txtTendered.Text) - Convert.ToDecimal(txtToPay.Text);
            txtChange.Text = dChange <= 0 ? "0.00" : dChange.ToString();
        }

        private void txtSurcharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != (char) 8 && e.KeyChar != '.') e.Handled = true;
        }

        private void txtTendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != (char) 8 && e.KeyChar != '.') e.Handled = true;
        }

        private void txtPay1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != (char) 8 && e.KeyChar != '.') e.Handled = true;
        }

        private void txtPay2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != (char) 8 && e.KeyChar != '.') e.Handled = true;
        }

        private void txtPay3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != (char) 8 && e.KeyChar != '.') e.Handled = true;
        }

        private void txtPay2_TextChanged(object sender, EventArgs e)
        {
            GetPayType();
            txtTendered.Text = (Pay1 + Pay2 + Pay3).ToString();

            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAPayType();

            if (CommonData.TaPayTypeList.Any(s => s.PaymentType.Equals(lblPayType2.Text)))
            {
                TAPayTypeInfo taPayType = CommonData.TaPayTypeList.FirstOrDefault(s => s.PaymentType.Equals(lblPayType2.Text));

                try
                {
                    decimal d1 = 0.00m;
                    decimal d2 = 0.00m;
                    decimal d3 = 0.00m;

                    d1 = Convert.ToDecimal(taPayType.SurchargeThreshold);
                    d2 = Convert.ToDecimal(taPayType.SurchargeAmount);
                    d3 = Convert.ToDecimal(taPayType.SurchargePercent);

                    if (d1 > 0)
                    {
                        if (Pay2 > d1)
                        {
                            lblSurcharge2.Text = d2 > 0 ? d2.ToString() : ((d3 / 100) * Pay2).ToString();
                        }
                    }
                    else
                    {
                        lblSurcharge2.Text = d2 > 0 ? d2.ToString() : ((d3 / 100) * Pay2).ToString();
                    }
                }
                catch (Exception)
                {
                    lblSurcharge2.Text = "0.00";
                    //throw;
                }
            }

            GetAmount();
        }

        private void txtPay3_TextChanged(object sender, EventArgs e)
        {
            GetPayType();
            txtTendered.Text = (Pay1 + Pay2 + Pay3).ToString();

            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAPayType();

            if (CommonData.TaPayTypeList.Any(s => s.PaymentType.Equals(lblPayType3.Text)))
            {
                TAPayTypeInfo taPayType = CommonData.TaPayTypeList.FirstOrDefault(s => s.PaymentType.Equals(lblPayType3.Text));

                try
                {
                    decimal d1 = 0.00m;
                    decimal d2 = 0.00m;
                    decimal d3 = 0.00m;

                    d1 = Convert.ToDecimal(taPayType.SurchargeThreshold);
                    d2 = Convert.ToDecimal(taPayType.SurchargeAmount);
                    d3 = Convert.ToDecimal(taPayType.SurchargePercent);

                    if (d1 > 0)
                    {
                        if (Pay3 > d1)
                        {
                            lblSurcharge3.Text = d2 > 0 ? d2.ToString() : ((d3 / 100) * Pay3).ToString();
                        }
                    }
                    else
                    {
                        lblSurcharge3.Text = d2 > 0 ? d2.ToString() : ((d3 / 100) * Pay3).ToString();
                    }
                }
                catch (Exception)
                {
                    lblSurcharge3.Text = "0.00";
                    //throw;
                }
            }

            GetAmount();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetTAPaymentList();
            if (CommonData.TAPaymentList.Any(s => s.ChkNum.Equals(chkNum) && s.IsPaid.Equals("N")))
            {
                var payList = CommonData.TAPaymentList.Where(s => s.ChkNum.Equals(chkNum) && s.IsPaid.Equals("N"));

                TAPaymentInfo taPaymentInfo = payList.FirstOrDefault();

                taPaymentInfo.Discount = txtDiscount.Text;
                taPaymentInfo.DiscountValue = DisValue.ToString();
                taPaymentInfo.Surcharge = txtSurcharge.Text;
                taPaymentInfo.ToPay = txtToPay.Text;
                taPaymentInfo.NotPaid = txtNotPaid.Text;
                taPaymentInfo.Delivery = txtDelivery.Text;
                taPaymentInfo.Tendered = txtTendered.Text;
                taPaymentInfo.ForChange = txtChange.Text;
                taPaymentInfo.DCNote = cmbNote.Text;

                if (taPaymentInfo.NotPaid.Equals("0.00"))
                {
                    taPaymentInfo.IsPaid = "Y";
                    IsPaid = true;

                    this.DialogResult = DialogResult.OK;
                    Hide();
                }

                taPaymentInfo.DriverName = strDriverName;
                
                if (lblSCharge[0].Visible)
                {
                    taPaymentInfo.PayType1 = txtPay[0].Text;
                    taPaymentInfo.PayTypeSurCharge1 = lblPaySurcharge[0].Text;
                }
                else
                {
                    taPaymentInfo.PayType1 = "0.00";
                    taPaymentInfo.PayTypeSurCharge1 = "0.00";

                }

                if (lblSCharge[1].Visible)
                {
                    taPaymentInfo.PayType2 = txtPay[1].Text;
                    taPaymentInfo.PayTypeSurCharge2 = lblPaySurcharge[1].Text;
                }
                else
                {
                    taPaymentInfo.PayType2 = "0.00";
                    taPaymentInfo.PayTypeSurCharge2 = "0.00";

                }

                if (lblSCharge[2].Visible)
                {
                    taPaymentInfo.PayType3 = txtPay[2].Text;
                    taPaymentInfo.PayTypeSurCharge3 = lblPaySurcharge[2].Text;
                }
                else
                {
                    taPaymentInfo.PayType2 = "0.00";
                    taPaymentInfo.PayTypeSurCharge2 = "0.00";

                }

                _control.UpdateEntity(taPaymentInfo);
            }
        }

        private void BtnDriver_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            strDriverName = btn.Text;
        }

        private void txtSurcharge_TextChanged(object sender, EventArgs e)
        {
            GetAmount();
        }

        private void btnPrtBillOnly_Click(object sender, EventArgs e)
        {
            htPay["Tendered"] = txtTendered.Text;
            htPay["Change"] = txtChange.Text;

            new OnLoadSystemCommonData().GetTAOrderItem();
            var lstOI = CommonData.TaOrderItemList.Where(s => s.CheckCode.Equals(chkNum)).ToList();
            //List<TAOrderItemInfo> lstOI = new List<TAOrderItemInfo>();
            PrtPrint.PrtBillBilingual(lstOI, htPay);
        }
    }
}
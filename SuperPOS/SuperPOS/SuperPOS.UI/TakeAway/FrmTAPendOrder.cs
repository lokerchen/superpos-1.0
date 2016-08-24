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
using SuperPOS.Common;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;
using SuperPOS.UI.Print;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAPendOrder : Form
    {
        private UserInfo userInfo;

        private readonly EntityControl _control = new EntityControl();

        public FrmTAPendOrder()
        {
            InitializeComponent();
        }

        public FrmTAPendOrder(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
        }

        private void FrmPendOrder_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAPaymentList();
            onLoadSystemCommonData.GetTACust();
            onLoadSystemCommonData.GetTAOrderItem();
            onLoadSystemCommonData.GetTADriverSetUp();

            if (!string.IsNullOrEmpty(GetWeek(DateTime.Today.DayOfWeek.ToString())))
            {
                IList<string> lstDriver = CommonData.TaDriverSetUpList.Where(
                            s => s.DriverWorkDay.Contains(GetWeek(DateTime.Today.DayOfWeek.ToString()))).Select(s => s.DriverName).ToList();

                cmbDriver.DataSource = lstDriver;
            }

            GetDB(1, "ALL");

            #region DGV设置
            //dgvPendOrder.DataSource = lstTest;

            dgvPendOrder.Columns[0].Visible = false;
            dgvPendOrder.Columns[0].Width = 5;
            dgvPendOrder.Columns[1].HeaderText = @"Order No";
            dgvPendOrder.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[2].HeaderText = @"Time";
            dgvPendOrder.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[2].Width = 40;
            dgvPendOrder.Columns[3].HeaderText = @"Postcode";
            dgvPendOrder.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[3].Width = 50;
            dgvPendOrder.Columns[4].HeaderText = @"Postcode Zone";
            dgvPendOrder.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[4].Width = 40;
            dgvPendOrder.Columns[5].HeaderText = @"Address";
            dgvPendOrder.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[5].Width = 40;
            dgvPendOrder.Columns[6].HeaderText = @"Type";
            dgvPendOrder.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[6].Width = 40;
            dgvPendOrder.Columns[7].HeaderText = @"Customer Name";
            dgvPendOrder.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[7].Width = 40;
            dgvPendOrder.Columns[8].HeaderText = @"Phone Number";
            dgvPendOrder.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[9].HeaderText = @"Total";
            dgvPendOrder.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[9].Width = 40;
            dgvPendOrder.Columns[10].HeaderText = @"Staff";
            dgvPendOrder.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[10].Width = 40;
            dgvPendOrder.Columns[11].HeaderText = @"Driver";
            dgvPendOrder.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[11].Width = 40;
            dgvPendOrder.Columns[12].Visible = false;

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

        private void GetDB(int iType, string sParam)
        {
            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAPaymentList();
            onLoadSystemCommonData.GetTACust();
            onLoadSystemCommonData.GetTAOrderItem();
            onLoadSystemCommonData.GetTADriverSetUp();

            var lstDb = from pay in CommonData.TAPaymentList
                join cust in CommonData.TaCustList
                    on pay.CustInfo equals cust.SystemKey.ToString()
                join user in CommonData.UsrList
                    on pay.OpUsr equals user.SystemKey.ToString()
                where pay.IsPaid.Equals("N")
                select new
                {
                    OrderSysKey = pay.SystemKey,
                    OrderNo = pay.ChkNum,
                    PTime = pay.PayTime,
                    Postcode = cust.Postcode1,
                    PostcodeZone = cust.PcZone,
                    CustAddr = cust.Address1,
                    OType = pay.OrderType,
                    CustName = cust.Name,
                    PhoneNum = cust.Phone1,
                    PTotal = pay.Total,
                    OrderUsr = user.UsrName,
                    Driver = pay.DriverName,
                    CustID = cust.SystemKey
                };

            //付款类型
            if (iType == 1)
            {
                dgvPendOrder.DataSource = sParam.Equals("ALL") ? lstDb.ToList() : lstDb.Where(s => s.OType.Equals(sParam)).ToList();
            }
            else
            {
                //已分配司机
                if (sParam.Equals("1"))
                    dgvPendOrder.DataSource = lstDb.Where(s => s.OType.Equals(CommonBase.ORDER_TYPE_DELIVERY) && !string.IsNullOrEmpty(s.Driver)).ToList();
                else if (sParam.Equals("0")) //未分配司机
                    dgvPendOrder.DataSource = lstDb.Where(s => s.OType.Equals(CommonBase.ORDER_TYPE_DELIVERY) && string.IsNullOrEmpty(s.Driver)).ToList();
                else    //所有
                    dgvPendOrder.DataSource = lstDb.Where(s => s.OType.Equals(CommonBase.ORDER_TYPE_DELIVERY)).ToList();
                    
            }


            //dgvPendOrder.DataSource = lstDb.ToList();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetTAOrderItem();
            string sChkKey = "";
            var lstCk = CommonData.TaOrderItemList.Where(s => s.CheckCode.Equals(dgvPendOrder.CurrentRow.Cells[1].Value.ToString()));
            if (lstCk.Any()) sChkKey = lstCk.FirstOrDefault().CheckKey;

            if (!string.IsNullOrEmpty(sChkKey))
            {
                FrmTAMain frmTaMain = new FrmTAMain(userInfo, true, sChkKey, dgvPendOrder.CurrentRow.Cells[1].Value.ToString(), dgvPendOrder.CurrentRow.Cells[6].Value.ToString());
                frmTaMain.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTAMain frmTaMain = new FrmTAMain(userInfo);
            frmTaMain.ShowDialog();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            GetDB(1, CommonBase.ORDER_TYPE_DELIVERY);
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            GetDB(1, CommonBase.ORDER_TYPE_COLLECTION);
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            GetDB(1, CommonBase.ORDER_TYPE_SHOP);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            GetDB(1, "ALL");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            GetDB(0, "2");
        }

        private void btnShowAssign_Click(object sender, EventArgs e)
        {
            GetDB(0, "1");
        }

        private void btnShowUnAssign_Click(object sender, EventArgs e)
        {
            GetDB(0, "0");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string sChkNum = dgvPendOrder.CurrentRow.Cells[1].Value.ToString();
            string sOrderType = dgvPendOrder.CurrentRow.Cells[6].Value.ToString();
            string sCallID = dgvPendOrder.CurrentRow.Cells[12].Value.ToString();

            Hashtable htPay = new Hashtable();
            htPay["Staff"] = userInfo.UsrName;
            htPay["ItemQty"] = GetOrderItemCount(sChkNum);
            htPay["SubTotal"] = GetDgvItemTotalPrice(sChkNum);
            htPay["Total"] = GetDgvItemTotalPrice(sChkNum);
            htPay["PayType"] = "CASH";
            htPay["OrderNo"] = sChkNum;

            
            if (sOrderType.Equals(CommonBase.ORDER_TYPE_DELIVERY))
            {
                //Delivery
                FrmTAPayDelivery frmTaPay = new FrmTAPayDelivery(sChkNum, sCallID, userInfo, sOrderType, htPay);
                //frmTaPay.ShowDialog();
                if (frmTaPay.ShowDialog() == DialogResult.OK)
                {
                    bool IsPaid = frmTaPay.ValueString;

                    if (IsPaid)
                    {
                        GetDB(1, "ALL");
                    }
                }

            }
            else if (sOrderType.Equals(CommonBase.ORDER_TYPE_COLLECTION))
            {
                FrmTAPayCollection frmTaPayCollection = new FrmTAPayCollection(sChkNum, sCallID, userInfo, sOrderType, htPay);
                //frmTaPay.ShowDialog();
                if (frmTaPayCollection.ShowDialog() == DialogResult.OK)
                {
                    bool IsPaid = frmTaPayCollection.ValueString;

                    if (IsPaid)
                    {
                        GetDB(1, "ALL");
                    }
                }
            }
            else if (sOrderType.Equals(CommonBase.ORDER_TYPE_SHOP))
            {
                //Shop
                //FrmTAPay frmTaPay = new FrmTAPay("", "06f8d669-ba19-4922-b84d-43b23b1632e5");
                //frmTaPay.ShowDialog();
                //Delivery
                FrmTAPayShop frmTaPayShop = new FrmTAPayShop(sChkNum, sCallID, userInfo, sOrderType, htPay);
                //frmTaPay.ShowDialog();
                if (frmTaPayShop.ShowDialog() == DialogResult.OK)
                {
                    bool IsPaid = frmTaPayShop.ValueString;

                    if (IsPaid)
                    {
                        GetDB(1, "ALL");
                    }
                }
            }
        }

        private int GetOrderItemCount(string strChkCode)
        {
            //int sumItem = 0;

            //foreach (var orderItem in CommonData.TaOrderItemList.Where(s => s.CheckCode.Equals(strChkCode)))
            //{
            //    if (!orderItem.ItemType.Equals("1")) continue;

            //    sumItem += Convert.ToInt32(orderItem.ItemQty);
            //}

            //return sumItem;

            return CommonData.TaOrderItemList.Where(s => s.CheckCode.Equals(strChkCode)).Where(orderItem => orderItem.ItemType.Equals("1")).Sum(orderItem => Convert.ToInt32(orderItem.ItemQty));
        }

        #region 获得OrderItem所有菜品价格总和
        private decimal GetDgvItemTotalPrice(string strChkCode)
        {
            //foreach (var orderItem in CommonData.TaOrderItemList.Where(s => s.CheckCode.Equals(strChkCode)))
            //{
            //    sumItem += Convert.ToDecimal(orderItem.ItemTotalPrice);
            //}
            //return sumItem;

            return CommonData.TaOrderItemList.Where(s => s.CheckCode.Equals(strChkCode)).Sum(orderItem => Convert.ToDecimal(orderItem.ItemTotalPrice));
        }

        #endregion

        private void btnDriver_Click(object sender, EventArgs e)
        {
            string sSysKey = dgvPendOrder.CurrentRow.Cells[0].Value.ToString();
            string sOrderType = dgvPendOrder.CurrentRow.Cells[6].Value.ToString();

            if (!sOrderType.Equals(CommonBase.ORDER_TYPE_DELIVERY)) return;

            var lst = CommonData.TAPaymentList.Where(s => s.SystemKey.ToString().Equals(sSysKey));

            TAPaymentInfo taPaymentInfo = new TAPaymentInfo();
            if (lst.Any())
            {
                taPaymentInfo = lst.FirstOrDefault();
                taPaymentInfo.DriverName = cmbDriver.Text;
                _control.UpdateEntity(taPaymentInfo);
            }

            GetDB(1, "ALL");
        }

        private void btnPrtBill_Click(object sender, EventArgs e)
        {
            string sChkNum = dgvPendOrder.CurrentRow.Cells[1].Value.ToString();

            Hashtable htPay = new Hashtable();
            htPay["Staff"] = userInfo.UsrName;
            htPay["ItemQty"] = GetOrderItemCount(sChkNum);
            htPay["SubTotal"] = GetDgvItemTotalPrice(sChkNum);
            htPay["Total"] = GetDgvItemTotalPrice(sChkNum);
            htPay["PayType"] = "CASH";
            htPay["OrderNo"] = sChkNum;

            htPay["Tendered"] = "0.00";
            htPay["Change"] = "0.00";

            new OnLoadSystemCommonData().GetTAOrderItem();
            var lstOI = CommonData.TaOrderItemList.Where(s => s.CheckCode.Equals(sChkNum)).ToList();
            //List<TAOrderItemInfo> lstOI = new List<TAOrderItemInfo>();
            PrtPrint.PrtBillBilingual(lstOI, htPay);
        }

        private void btnPrtKit_Click(object sender, EventArgs e)
        {
            string sChkNum = dgvPendOrder.CurrentRow.Cells[1].Value.ToString();

            Hashtable htPay = new Hashtable();
            htPay["Staff"] = userInfo.UsrName;
            htPay["ItemQty"] = GetOrderItemCount(sChkNum);
            htPay["SubTotal"] = GetDgvItemTotalPrice(sChkNum);
            htPay["Total"] = GetDgvItemTotalPrice(sChkNum);
            htPay["PayType"] = "CASH";
            htPay["OrderNo"] = sChkNum;

            new OnLoadSystemCommonData().GetTAOrderItem();
            var lstOI = CommonData.TaOrderItemList.Where(s => s.CheckCode.Equals(sChkNum)).ToList();

            //打印厨房单
            htPay["ChkNum"] = sChkNum;
            PrtPrint.PrtKitchen(lstOI, htPay);
        }

        private void btnPrtReceipt_Click(object sender, EventArgs e)
        {
            string sChkNum = dgvPendOrder.CurrentRow.Cells[1].Value.ToString();
            string sTotal = dgvPendOrder.CurrentRow.Cells[9].Value.ToString();

            Hashtable htPay = new Hashtable();
            htPay["Staff"] = userInfo.UsrName;
            htPay["ItemQty"] = GetOrderItemCount(sChkNum);
            htPay["SubTotal"] = GetDgvItemTotalPrice(sChkNum);
            htPay["Total"] = GetDgvItemTotalPrice(sChkNum);
            htPay["PayType"] = "CASH";
            htPay["OrderNo"] = sChkNum;

            htPay["Tendered"] = "0.00";
            htPay["Change"] = "0.00";

            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAOrderItem();
            onLoadSystemCommonData.GetSysConfigList();
            onLoadSystemCommonData.GetTAMenuItemList();

            var lstOrderItem = CommonData.TaOrderItemList.Where(s => s.CheckCode.Equals(sChkNum));
            var lstOI = lstOrderItem.ToList();

            #region VAT计算
            if (CommonData.SysConfigList.Any())
            {
                //税率
                htPay["Rate1"] = CommonData.SysConfigList.FirstOrDefault().VATPerct + "%";

                var lstVAT = from o in lstOI
                             join m in CommonData.TaMenuItemList on o.ItemCode equals m.DishCode
                             where !string.IsNullOrEmpty(m.IsWithoutVAT) && m.IsWithoutVAT.Equals("Y")
                             select new
                             {
                                 itemTotalPrice = o.ItemTotalPrice
                             };

                decimal dTotal = 0;
                decimal dVatTmp = 0;
                decimal dVat = 0;
                if (lstVAT.Any())
                {
                    dTotal = lstVAT.ToList().Sum(vat => Convert.ToDecimal(vat.itemTotalPrice));
                    //交税
                    dVatTmp = (Convert.ToDecimal(CommonData.SysConfigList.FirstOrDefault().VATPerct) / 100) * dTotal;

                    dVat = Math.Round(dVatTmp, 2, MidpointRounding.AwayFromZero);
                }

                htPay["VAT-A"] = dVat.ToString();
                //税前
                htPay["Net1"] = (dTotal - dVat).ToString();
                //总价
                htPay["Gross1"] = dTotal.ToString();
                htPay["Rate2"] = "0.00%";
                htPay["Net2"] = (Convert.ToDecimal(sTotal) - dTotal).ToString();
                htPay["VAT-B"] = "0.00";
                htPay["Gross2"] = (Convert.ToDecimal(sTotal) - dTotal).ToString();
            }
            else
            {
                htPay["Rate1"] = "0.00%";
                htPay["Net1"] = "0.00";
                htPay["VAT-A"] = "0.00";
                htPay["Gross1"] = "0.00";
                htPay["Rate2"] = "0.00%";
                htPay["Net2"] = "0.00";
                htPay["VAT-B"] = "0.00";
                htPay["Gross2"] = "0.00";
            }
            #endregion

            PrtPrint.PrtReceipt(lstOI, htPay);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Linq;
using SuperPOS.Common;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAMain : Form
    {
        private UserInfo userInfo = new UserInfo();

        private int I_MI_PAGE = 1;
        private int I_MC_PAGE = 1;

        //记录Menu Cate值
        private string strBtnText = "";

        //Language语言状态值,1为英文状态，2为其他
        private int I_LAN = 1;

        private string strCallID = "";

        private string strOrderType = "";
        //public string StrOrderType { set { strOrderType = value; } }

        private readonly EntityControl _control = new EntityControl();

        private string strMenuSetID = "";

        #region 定义
        Button[] btnMI = new Button[16];
        Button[] btnMC = new Button[35];

        private string ChkKey1 = "";
        private string ChkNum1 = "";
        private string ChkKey2 = "";
        private string ChkNum2 = "";
        private string ChkKey3 = "";
        private string ChkNum3 = "";
        //当前Check SystemKey和Check Number
        private string ChkKey = "";
        private string ChkNum = "";

        //点餐类型，Delivery,Shop,Collection三种中的任意一个，默认为Delivery
        private string ORDER_TYPE = "";

        #endregion

        public FrmTAMain()
        {
            InitializeComponent();
        }

        public FrmTAMain(UserInfo user)
        {
            InitializeComponent();
            userInfo = user;
        }

        private void FrmTAMain_Load(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetTAMenuItemList();

            if (string.IsNullOrEmpty(ChkKey1)) ChkKey1 = Guid.NewGuid().ToString();

            ChkNum1 = CommonFunction.GetChkCode();

            //Order Type，默认为Delivery
            ORDER_TYPE = CommonBase.ORDER_TYPE_DELIVERY;
            btnMode1.Text = ORDER_TYPE;
            //Console.Out.WriteLine(ChkNum);
            //string g = Guid.NewGuid().ToString();
            //Console.Out.WriteLine(g);

            ChkKey = ChkKey1;
            ChkNum = ChkNum1;

            #region MenuItem按钮 
            btnMI[0] = btnMI1;
            btnMI[1] = btnMI2;
            btnMI[2] = btnMI3;
            btnMI[3] = btnMI4;
            btnMI[4] = btnMI5;
            btnMI[5] = btnMI6;
            btnMI[6] = btnMI7;
            btnMI[7] = btnMI8;
            btnMI[8] = btnMI9;
            btnMI[9] = btnMI10;
            btnMI[10] = btnMI11;
            btnMI[11] = btnMI12;
            btnMI[12] = btnMI13;
            btnMI[13] = btnMI14;
            btnMI[14] = btnMI15;
            btnMI[15] = btnMI16;
            #endregion

            #region Menu Category
            btnMC[0] = btnMC1;
            btnMC[1] = btnMC2;
            btnMC[2] = btnMC3;
            btnMC[3] = btnMC4;
            btnMC[4] = btnMC5;
            btnMC[5] = btnMC6;
            btnMC[6] = btnMC7;
            btnMC[7] = btnMC8;
            btnMC[8] = btnMC9;
            btnMC[9] = btnMC10;
            btnMC[10] = btnMC11;
            btnMC[11] = btnMC12;
            btnMC[12] = btnMC13;
            btnMC[13] = btnMC14;
            btnMC[14] = btnMC15;
            btnMC[15] = btnMC16;
            btnMC[16] = btnMC17;
            btnMC[17] = btnMC18;
            btnMC[18] = btnMC19;
            btnMC[19] = btnMC20;
            btnMC[20] = btnMC21;
            btnMC[21] = btnMC22;
            btnMC[22] = btnMC23;
            btnMC[23] = btnMC24;
            btnMC[24] = btnMC25;
            btnMC[25] = btnMC26;
            btnMC[26] = btnMC27;
            btnMC[27] = btnMC28;
            btnMC[28] = btnMC29;
            btnMC[29] = btnMC30;
            btnMC[30] = btnMC31;
            btnMC[31] = btnMC32;
            btnMC[32] = btnMC33;
            btnMC[33] = btnMC34;
            btnMC[34] = btnMC35;
            #endregion

            #region Menu Item按钮填充

            SetMenuItem(1, 1, "", strMenuSetID);
            SetMenuCate(1, 1, strMenuSetID);

            #endregion

            #region Menu Category按钮事件
            for (int i = 0; i < 35; i++) { btnMC[i].Click += btnMC_Click; }
            #endregion

            #region Menu Item按钮事件
            for (int i = 0; i < 16; i++) { btnMI[i].Click += btnMI_Click; }
            #endregion

            #region DGV设置
            dgvMenuItem.DataSource = CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ToList();

            dgvMenuItem.Columns[0].Visible = false;
            dgvMenuItem.Columns[0].Width = 10;
            dgvMenuItem.Columns[1].HeaderText = @"Qty";
            dgvMenuItem.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMenuItem.Columns[1].Width = 30;
            dgvMenuItem.Columns[2].HeaderText = @"Dish Name";
            dgvMenuItem.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMenuItem.Columns[2].Width = 180;
            dgvMenuItem.Columns[3].HeaderText = @"Price";
            dgvMenuItem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMenuItem.Columns[3].Width = 50;
            dgvMenuItem.Columns[4].HeaderText = @"Code";
            dgvMenuItem.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMenuItem.Columns[4].Width = 40;
            dgvMenuItem.Columns[5].Visible = false;
            dgvMenuItem.Columns[6].Visible = false;
            dgvMenuItem.Columns[7].Visible = false;
            dgvMenuItem.Columns[8].Visible = false;
            dgvMenuItem.Columns[9].Visible = false;
            dgvMenuItem.Columns[10].Visible = false;
            dgvMenuItem.Columns[11].Visible = false;
            #endregion
        }

        private void SetMenuItem(int i, int iPage, string strMenuCate, string strMenuSet)
        {
            var miList = DALCommon.GetListQueryPageMenuItem(iPage, strMenuCate, strMenuSet);

            int j = 0;
            foreach (var mi in miList)
            {
                btnMI[j].Text = i == 1 ? mi.EnglishName : mi.OtherName;
                j++;
            }

            if (j < 16) { for (int k = j; k < 16; k++) { btnMI[k].Text = ""; } }
        }

        private void SetMenuCate(int i, int iPage, string strMenuSet)
        {

            var mcList = DALCommon.GetListQueryPageMenuCate(iPage, strMenuSet);

            int j = 0;
            foreach (var mc in mcList)
            {
                btnMC[j].Text = i == 1 ? mc.EnglishName : mc.OtherName;
                j++;
            }

            if (j < 35) { for (int k = j; k < 35; k++) { btnMC[k].Text = ""; } }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnMIRight_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnMI[0].Text) && !string.IsNullOrEmpty(btnMI[15].Text)) I_MI_PAGE = I_MI_PAGE + 1;

            SetMenuItem(I_LAN, I_MI_PAGE, strBtnText, strMenuSetID);
        }

        private void btnMILeft_Click(object sender, EventArgs e)
        {
            I_MI_PAGE = I_MI_PAGE <= 1 ? 1 : (I_MI_PAGE <= 1 ? 1 : I_MI_PAGE - 1);
            SetMenuItem(I_LAN, I_MI_PAGE, strBtnText, strMenuSetID);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            strBtnText = btn.Text;
            if (I_LAN != 1)
            {
                var qEngName = CommonData.TaMenuCategoryList.Where(s => s.OtherName.Equals(strBtnText));
                if (qEngName.Any()) strBtnText = qEngName.FirstOrDefault().EnglishName;
            }

            I_MI_PAGE = 1;
            SetMenuItem(I_LAN, I_MI_PAGE, strBtnText, strMenuSetID);
            //SetMenuItem(1, 1, btn.Text);
        }

        private void btnMI_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string strTxt = btn.Text;

            TAOrderItemInfo taOrderItemInfo = new TAOrderItemInfo();
            taOrderItemInfo.SystemKey = Guid.NewGuid();

            IList<TAMenuItemInfo> qMiList = new List<TAMenuItemInfo>();

            qMiList = I_LAN != 1 ? CommonData.TaMenuItemList.Where(s => s.OtherName.Equals(strTxt)).ToList() : CommonData.TaMenuItemList.Where(s => s.EnglishName.Equals(strTxt)).ToList();
            TAMenuItemInfo taMiInfo = qMiList.FirstOrDefault();

            if (taMiInfo != null)
            {
                taOrderItemInfo.CheckKey = ChkKey;
                taOrderItemInfo.CheckCode = ChkNum;
                taOrderItemInfo.ItemCode = taMiInfo.DishCode;
                taOrderItemInfo.ItemDishName = taMiInfo.EnglishName;
                taOrderItemInfo.ItemPrice = taMiInfo.wRegular;
                taOrderItemInfo.ItemQty = "1";
                taOrderItemInfo.ItemTotalPrice = taMiInfo.wRegular;
                taOrderItemInfo.ItemType = "1";
                taOrderItemInfo.OrderTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                taOrderItemInfo.OrderType = ORDER_TYPE;

                //AddDataGridRow(taOrderItemInfo);
                CommonData.TaOrderItemList.Add(taOrderItemInfo);
                //dgvMenuItem.Refresh();
                dgvMenuItem.DataSource = CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ToList();
            }

            txtTotalCount.Text = GetDgvItemCount().ToString();
            txtTotalPrice.Text = GetDgvItemTotalPrice().ToString();
        }

        #region 语言切换
        private void btnLang_Click(object sender, EventArgs e)
        {
            if (I_LAN == 1)
            {
                I_LAN = 2;
                SetMenuItem(I_LAN, 1, "", strMenuSetID);
                SetMenuCate(I_LAN, 1, strMenuSetID);
            }
            else
            {
                I_LAN = 1;
                SetMenuItem(I_LAN, 1, "", strMenuSetID);
                SetMenuCate(I_LAN, 1, strMenuSetID);
            }
        }
        #endregion

        private void btnTasteHand_Click(object sender, EventArgs e)
        {
            //FrmTAMenuItem frmTaMenuItem = new FrmTAMenuItem(userInfo, true);
            ////frmTaMenuItem.tabCtlMenuItem.SelectedTab = frmTaMenuItem.tabPageTaste;
            ////frmTaMenuItem.tabCtlMenuItem.SelectedTab = frmTaMenuItem.tabPageTaste;
            //frmTaMenuItem.ShowDialog();

            if (dgvMenuItem.RowCount == 0) return;
            if (dgvMenuItem.CurrentRow?.Index < 0) return;

            string strParentKey = dgvMenuItem.CurrentRow.Cells[0].Value.ToString();

            var qList =
                CommonData.TaMenuItemList.Where(
                    s => s.EnglishName.Equals(dgvMenuItem.CurrentRow.Cells[2].Value.ToString()));
            string strMIKey = "";
            if (qList.Any()) strMIKey = qList.FirstOrDefault().SystemKey.ToString();


            FrmTATastHand frmTaTastHand = new FrmTATastHand(strMIKey);
            if (frmTaTastHand.ShowDialog() == DialogResult.OK)
            {
                //获得改码
                string sMod = frmTaTastHand.ValueString;

                //暂停秒表
                //timerMain.Enabled = false;

                string[] strMod = sMod.Split(';');

                for (int i = 0; i < strMod.Length; i++)
                {
                    //if(string.IsNullOrEmpty(strMod[i])) return;
                    if (string.IsNullOrEmpty(strMod[i])) break;

                    string[] sDetail = strMod[i].Split(',');

                    //if (sDetail.Length <= 0) return;
                    if (sDetail.Length <= 0) break;

                    TAOrderItemInfo taOrderItemInfo = new TAOrderItemInfo();
                    taOrderItemInfo.SystemKey = Guid.NewGuid();
                    taOrderItemInfo.CheckKey = ChkKey;
                    taOrderItemInfo.CheckCode = ChkNum;
                    taOrderItemInfo.ItemCode = "";
                    taOrderItemInfo.ItemDishName = sDetail[0];
                    taOrderItemInfo.ItemPrice = sDetail[1];
                    //taOrderItemInfo.ItemQty = "1";
                    taOrderItemInfo.ItemQty = dgvMenuItem.CurrentRow.Cells[1].Value.ToString();
                    taOrderItemInfo.ItemTotalPrice = (Convert.ToDecimal(sDetail[1]) * Convert.ToInt32(dgvMenuItem.CurrentRow.Cells[1].Value.ToString())).ToString() ;
                    taOrderItemInfo.ItemType = "2";
                    taOrderItemInfo.OrderTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    taOrderItemInfo.OrderType = ORDER_TYPE;
                    taOrderItemInfo.ParentItem = strParentKey;

                    CommonData.TaOrderItemList.Add(taOrderItemInfo);

                    //for (int j = 0; j < sDetail.Length; j++)
                    //{
                    //    if (string.IsNullOrEmpty(sDetail[j])) return;
                    //}

                    //dgvMenuItem.DataSource = CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ToList();
                }

                SetDgvData();

                txtTotalCount.Text = GetDgvItemCount().ToString();
                txtTotalPrice.Text = GetDgvItemTotalPrice().ToString();
            }
            ////启动秒表
            //timerMain.Enabled = true;
        }

        private void btnCustInfo_Click(object sender, EventArgs e)
        {
            FrmTACustInfo frmTaCust = new FrmTACustInfo(strCallID);
            frmTaCust.ShowDialog();

        }

        private void btnChangeOrderType_Click(object sender, EventArgs e)
        {
            FrmTAChangeOrderType frmTaChangeOrderType = new FrmTAChangeOrderType();
            frmTaChangeOrderType.ShowDialog();

            strOrderType = frmTaChangeOrderType.strOrderType;
        }

        private void btnMode2_Click(object sender, EventArgs e)
        {

        }

        private void btnMode3_Click(object sender, EventArgs e)
        {

        }

        private int GetDgvItemCount()
        {
            int sumItem = 0;
            for (int i = 0; i < dgvMenuItem.Rows.Count; i++)
            {
                if (!dgvMenuItem.Rows[i].Cells[9].Value.ToString().Equals("1")) continue;

                sumItem += string.IsNullOrEmpty(dgvMenuItem.Rows[i].Cells[1].Value.ToString())
                    ? 0
                    : Convert.ToInt32(dgvMenuItem.Rows[i].Cells[1].Value.ToString());
            }

            return sumItem;
        }

        private decimal GetDgvItemTotalPrice()
        {
            decimal sumItem = 0;
            for (int i = 0; i < dgvMenuItem.Rows.Count; i++)
            {
                sumItem += string.IsNullOrEmpty(dgvMenuItem.Rows[i].Cells[3].Value.ToString())
                    ? 0
                    : Convert.ToDecimal(dgvMenuItem.Rows[i].Cells[3].Value.ToString());
            }

            return sumItem;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvMenuItem.RowCount == 0) return;
            if (dgvMenuItem.CurrentRow?.Index < 0) return;

            //TAOrderItemInfo taOrderItem = new TAOrderItemInfo();

            string strParentKey = dgvMenuItem.CurrentRow.Cells[0].Value.ToString();
            var qList =
                CommonData.TaOrderItemList.Where(
                    s =>
                        s.CheckKey.Equals(ChkKey) &&
                        s.SystemKey.ToString().Equals(strParentKey));

            string strQty = "1";

            if (qList.Any())
            {
                strQty = qList.FirstOrDefault().ItemQty = (Convert.ToInt32(qList.FirstOrDefault().ItemQty) + 1).ToString();
                qList.FirstOrDefault().ItemTotalPrice =
                    ((Convert.ToInt32(qList.FirstOrDefault().ItemQty)) *
                     Convert.ToDecimal(qList.FirstOrDefault().ItemPrice)).ToString();

                //string strParentKey = qList.FirstOrDefault().SystemKey.ToString();
                //qList.FirstOrDefault().ItemQty;
                //var qChildList = CommonData.TaOrderItemList.Where(s => s.ParentItem.Equals(strParentKey));

                //if (qChildList.Any())
                //{
                    //foreach (var taOrderItemInfo in qChildList)
               
            }

            //改码数量自动改变
            foreach (var taOrderItemInfo in CommonData.TaOrderItemList)
            {
                if (taOrderItemInfo.ParentItem != null && taOrderItemInfo.ParentItem.Equals(strParentKey))
                {
                    taOrderItemInfo.ItemQty = strQty;
                    taOrderItemInfo.ItemTotalPrice = (Convert.ToInt32(taOrderItemInfo.ItemQty)*Convert.ToDecimal(taOrderItemInfo.ItemPrice)).ToString();
                }
            }

            dgvMenuItem.DataSource = CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ToList();

            txtTotalCount.Text = GetDgvItemCount().ToString();
            txtTotalPrice.Text = GetDgvItemTotalPrice().ToString();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            if (dgvMenuItem.RowCount == 0) return;
            if (dgvMenuItem.CurrentRow?.Index < 0) return;

            string strParentKey = dgvMenuItem.CurrentRow.Cells[0].Value.ToString();
            string strQty = "1";

            //TAOrderItemInfo taOrderItem = new TAOrderItemInfo();
            var qList =
                CommonData.TaOrderItemList.Where(
                    s =>
                        s.CheckKey.Equals(ChkKey) &&
                        s.SystemKey.ToString().Equals(strParentKey));

            if (qList.Any())
            {
                if (Convert.ToInt32(qList.FirstOrDefault().ItemQty) > 1)
                {
                    strQty = qList.FirstOrDefault().ItemQty = (Convert.ToInt32(qList.FirstOrDefault().ItemQty) - 1).ToString();
                    qList.FirstOrDefault().ItemTotalPrice =
                    ((Convert.ToInt32(qList.FirstOrDefault().ItemQty)) *
                     Convert.ToDecimal(qList.FirstOrDefault().ItemPrice)).ToString();
                }
                else
                {
                    //删除？
                    CommonData.TaOrderItemList.Remove(qList.FirstOrDefault());

                    //删除改码
                    for (int i = CommonData.TaOrderItemList.Count - 1; i >= 0; i--)
                    {
                        if (CommonData.TaOrderItemList[i].ParentItem != null &&
                            CommonData.TaOrderItemList[i].ParentItem.Equals(strParentKey))
                        {
                            CommonData.TaOrderItemList.Remove(CommonData.TaOrderItemList[i]);
                        }
                    }
                }
            }

            foreach (var taOrderItemInfo in CommonData.TaOrderItemList)
            {
                if (taOrderItemInfo.ParentItem != null && taOrderItemInfo.ParentItem.Equals(strParentKey))
                {
                    taOrderItemInfo.ItemQty = strQty;
                    taOrderItemInfo.ItemTotalPrice = (Convert.ToInt32(taOrderItemInfo.ItemQty) * Convert.ToDecimal(taOrderItemInfo.ItemPrice)).ToString();
                }
            }

            dgvMenuItem.DataSource = CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ToList();

            txtTotalCount.Text = GetDgvItemCount().ToString();
            txtTotalPrice.Text = GetDgvItemTotalPrice().ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvMenuItem.RowCount == 0) return;
            if (dgvMenuItem.CurrentRow?.Index < 0) return;

            string strParentKey = dgvMenuItem.CurrentRow.Cells[0].Value.ToString();

            var qList =
                CommonData.TaOrderItemList.Where(
                    s =>
                        s.CheckKey.Equals(ChkKey) &&
                        s.SystemKey.ToString().Equals(strParentKey));

            if (qList.Any())
            {
                CommonData.TaOrderItemList.Remove(qList.FirstOrDefault());
            }

            //删除改码
            for (int i = CommonData.TaOrderItemList.Count - 1; i >= 0; i--)
            {
                if (CommonData.TaOrderItemList[i].ParentItem != null &&
                    CommonData.TaOrderItemList[i].ParentItem.Equals(strParentKey))
                {
                    CommonData.TaOrderItemList.Remove(CommonData.TaOrderItemList[i]);
                }
            }

            dgvMenuItem.DataSource = CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ToList();

            txtTotalCount.Text = GetDgvItemCount().ToString();
            txtTotalPrice.Text = GetDgvItemTotalPrice().ToString();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            txtMainTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvMenuItem.RowCount <= 0) return;

            ORDER_TYPE = CommonBase.ORDER_TYPE_DELIVERY;
            strCallID = @"06f8d669-ba19-4922-b84d-43b23b1632e5";

            AddDgvData();

            new OnLoadSystemCommonData().GetTAPaymentList();
            bool isNew = false;
            TAPaymentInfo taPaymentInfo = new TAPaymentInfo();

            if (!CommonData.TAPaymentList.Any(s => s.ChkNum.Equals(ChkNum)))
            {
                isNew = true;
                taPaymentInfo.SystemKey = Guid.NewGuid();
            }
            taPaymentInfo.ChkNum = ChkNum;
            taPaymentInfo.PayType1 = @"0.00";
            taPaymentInfo.PayTypeSurCharge1 = @"0.00";
            taPaymentInfo.PayType2 = @"0.00";
            taPaymentInfo.PayTypeSurCharge2 = @"0.00";
            taPaymentInfo.PayType3 = @"0.00";
            taPaymentInfo.PayTypeSurCharge3 = @"0.00";
            taPaymentInfo.NotPaid = txtTotalPrice.Text;
            taPaymentInfo.Delivery = @"0.00";
            taPaymentInfo.Discount = @"0.00";
            taPaymentInfo.DiscountValue = @"0.00";
            taPaymentInfo.Surcharge = @"0.00";
            taPaymentInfo.Tendered = @"0.00";
            taPaymentInfo.ToPay = txtTotalPrice.Text;
            taPaymentInfo.ForChange = @"0.00";
            taPaymentInfo.DCNote = "";
            taPaymentInfo.CustInfo = strCallID;
            taPaymentInfo.IsPaid = "N";
            taPaymentInfo.AcctPay = txtTotalPrice.Text;
            taPaymentInfo.DriverName = "";
            taPaymentInfo.Remark = "";

            if (isNew) _control.AddEntity(taPaymentInfo);

            //FrmTAPay frmTaPay = new FrmTAPay("", "06f8d669-ba19-4922-b84d-43b23b1632e5");
            //frmTaPay.ShowDialog();
            if (ORDER_TYPE.Equals(CommonBase.ORDER_TYPE_DELIVERY))
            {
                //Delivery
                FrmTAPay frmTaPay = new FrmTAPay(ChkNum, strCallID);
                //frmTaPay.ShowDialog();
                if (frmTaPay.ShowDialog() == DialogResult.OK)
                {
                    bool IsPaid = frmTaPay.ValueString;

                    if (IsPaid)
                    {
                        //if (string.IsNullOrEmpty(ChkKey1))
                        ChkKey1 = Guid.NewGuid().ToString();
                        ChkNum1 = CommonFunction.GetChkCode();
                        //Order Type，默认为Delivery
                        ORDER_TYPE = CommonBase.ORDER_TYPE_DELIVERY;
                        btnMode1.Text = ORDER_TYPE;
                        ChkKey = ChkKey1;
                        ChkNum = ChkNum1;

                        dgvMenuItem.DataSource = CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ToList();
                    }

                    ClearDgvData();
                }

            }
            else if (ORDER_TYPE.Equals(CommonBase.ORDER_TYPE_COLLECTION))
            {
                //Collection
                //FrmTAPay frmTaPay = new FrmTAPay("", "06f8d669-ba19-4922-b84d-43b23b1632e5");
                //frmTaPay.ShowDialog();
            }
            else if (ORDER_TYPE.Equals(CommonBase.ORDER_TYPE_SHOP))
            {
                //Shop
                //FrmTAPay frmTaPay = new FrmTAPay("", "06f8d669-ba19-4922-b84d-43b23b1632e5");
                //frmTaPay.ShowDialog();
            }
        }

        private void SetDgvData()
        {
            //foreach (DataGridViewRow row in dgvMenuItem.Rows)
            //{
            //    row.Cells.Clear();
            //}

            List<TAOrderItemInfo> lstPOI = new List<TAOrderItemInfo>();
            List<TAOrderItemInfo> lstCOI = new List<TAOrderItemInfo>();
            CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).Where(s => s.ItemType.Equals("1")).ForEach(i => lstPOI.Add(i));
            CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).Where(s => s.ItemType.Equals("2")).ForEach(i => lstCOI.Add(i));

            //CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ToList().Clear();

            List<TAOrderItemInfo> lstTmp = new List<TAOrderItemInfo>();
            CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ForEach(i => lstTmp.Add(i));

            foreach (var taOrderItemInfo in lstTmp)
            {
                CommonData.TaOrderItemList.Remove(taOrderItemInfo);
            }


            //CommonData.TaOrderItemList.cl

            foreach (var taOI in lstPOI)
            {
                CommonData.TaOrderItemList.Add(taOI);

                var qList = lstCOI.Where(s => s.ParentItem.Equals(taOI.SystemKey.ToString()));
                if (qList.Any())
                {
                    foreach (var taOrderItemInfo in qList)
                    {
                        CommonData.TaOrderItemList.Add(taOrderItemInfo);
                    }
                }
            }

            dgvMenuItem.DataSource = CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ToList();

            //int i = 0;
            //var lstTaOI = lstOI.Where(s => s.ItemType.Equals("1"));
            //var lstTaOIMod = lstOI.Where(s => s.ItemType.Equals("2"));
            //foreach (var taOrderItemInfo in lstTaOI)
            //{
            //    string strParentKey = taOrderItemInfo.SystemKey.ToString();
            //    var qList = lstTaOIMod.Where(s => s.ParentItem.Equals(strParentKey));

            //    foreach (var taOIParent in qList)
            //    {
            //        int iParent = dgvMenuItem.Rows.Add();
            //        dgvMenuItem.Rows[iParent].Cells[0].Value = taOIParent.SystemKey;
            //        dgvMenuItem.Rows[iParent].Cells[1].Value = taOIParent.ItemQty;
            //        dgvMenuItem.Rows[iParent].Cells[2].Value = taOIParent.ItemDishName;
            //        dgvMenuItem.Rows[iParent].Cells[3].Value = taOIParent.ItemTotalPrice;
            //        dgvMenuItem.Rows[iParent].Cells[4].Value = taOIParent.ItemCode;
            //        dgvMenuItem.Rows[iParent].Cells[5].Value = taOIParent.ItemPrice;
            //        dgvMenuItem.Rows[iParent].Cells[6].Value = taOIParent.CheckKey;
            //        dgvMenuItem.Rows[iParent].Cells[7].Value = taOIParent.CheckCode;
            //        dgvMenuItem.Rows[iParent].Cells[8].Value = taOIParent.OrderTime;
            //        dgvMenuItem.Rows[iParent].Cells[9].Value = taOIParent.ItemType;
            //        dgvMenuItem.Rows[iParent].Cells[10].Value = taOIParent.OrderType;
            //        dgvMenuItem.Rows[iParent].Cells[11].Value = taOIParent.ParentItem;
            //        dgvMenuItem.Rows[iParent].Cells[12].Value = taOIParent.Remark;
            //    }

            //    int index = dgvMenuItem.Rows.Add();
            //    dgvMenuItem.Rows[index].Cells[0].Value = taOrderItemInfo.SystemKey;
            //    dgvMenuItem.Rows[index].Cells[1].Value = taOrderItemInfo.ItemQty;
            //    dgvMenuItem.Rows[index].Cells[2].Value = taOrderItemInfo.ItemDishName;
            //    dgvMenuItem.Rows[index].Cells[3].Value = taOrderItemInfo.ItemTotalPrice;
            //    dgvMenuItem.Rows[index].Cells[4].Value = taOrderItemInfo.ItemCode;
            //    dgvMenuItem.Rows[index].Cells[5].Value = taOrderItemInfo.ItemPrice;
            //    dgvMenuItem.Rows[index].Cells[6].Value = taOrderItemInfo.CheckKey;
            //    dgvMenuItem.Rows[index].Cells[7].Value = taOrderItemInfo.CheckCode;
            //    dgvMenuItem.Rows[index].Cells[8].Value = taOrderItemInfo.OrderTime;
            //    dgvMenuItem.Rows[index].Cells[9].Value = taOrderItemInfo.ItemType;
            //    dgvMenuItem.Rows[index].Cells[10].Value = taOrderItemInfo.OrderType;
            //    dgvMenuItem.Rows[index].Cells[11].Value = taOrderItemInfo.ParentItem;
            //    dgvMenuItem.Rows[index].Cells[12].Value = taOrderItemInfo.Remark;

            //}
        }

        private void ClearDgvData()
        { 
            List<TAOrderItemInfo> lstTmp = new List<TAOrderItemInfo>();
            CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ForEach(i => lstTmp.Add(i));

            foreach (var taOrderItemInfo in lstTmp)
            {
                CommonData.TaOrderItemList.Remove(taOrderItemInfo);
            }
        }

        #region AddDgvData

        private void AddDgvData()
        {
            List<TAOrderItemInfo> lstPOI = new List<TAOrderItemInfo>();
            CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ForEach(i => lstPOI.Add(i));

            new OnLoadSystemCommonData().GetTAOrderItem();

            foreach (var taOrderItem in lstPOI)
            {
                if (CommonData.TaOrderItemList.Any(s => s.SystemKey.Equals(taOrderItem.SystemKey)))
                {
                    _control.UpdateEntity(taOrderItem);
                }
                else
                {
                    _control.AddEntity(taOrderItem);
                }
            }
        }
        #endregion

        private void btnMenuSelect_Click(object sender, EventArgs e)
        {
            FrmTAMenuSelect frmTaMenuSelect = new FrmTAMenuSelect();
            if (frmTaMenuSelect.ShowDialog() == DialogResult.OK)
            {
                //获得菜谱参数
                strMenuSetID = frmTaMenuSelect.ValueString;
                
                SetMenuItem(I_LAN, 1, "", strMenuSetID);
                SetMenuCate(I_LAN, 1, strMenuSetID);
            }
        }
    }
}

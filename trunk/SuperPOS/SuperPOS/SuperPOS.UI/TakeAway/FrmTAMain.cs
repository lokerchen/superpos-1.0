using System;
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

            SetMenuItem(1, 1, "");
            SetMenuCate(1, 1);

            #endregion

            #region Menu Category按钮事件
            for (int i = 0; i < 35; i++) { btnMC[i].Click += btnMC_Click; }
            #endregion

            #region Menu Item按钮事件
            for (int i = 0; i < 16; i++) { btnMI[i].Click += btnMI_Click; }
            #endregion

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
        }

        private void SetMenuItem(int i, int iPage, string strMenuCate)
        {
            var miList = DALCommon.GetListQueryPageMenuItem(iPage, strMenuCate);

            int j = 0;
            foreach (var mi in miList)
            {
                btnMI[j].Text = i == 1 ? mi.EnglishName : mi.OtherName;
                j++;
            }

            if (j < 16) { for (int k = j; k < 16; k++) { btnMI[k].Text = ""; } }
        }

        private void SetMenuCate(int i, int iPage)
        {

            var mcList = DALCommon.GetListQueryPageMenuCate(iPage);

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

            SetMenuItem(I_LAN, I_MI_PAGE, strBtnText);
        }

        private void btnMILeft_Click(object sender, EventArgs e)
        {
            I_MI_PAGE = I_MI_PAGE <= 1 ? 1 : (I_MI_PAGE <= 1 ? 1 : I_MI_PAGE - 1);
            SetMenuItem(I_LAN, I_MI_PAGE, strBtnText);
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
            SetMenuItem(I_LAN, I_MI_PAGE, strBtnText);
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
                taOrderItemInfo.OrderTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

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
                SetMenuItem(I_LAN, 1, "");
                SetMenuCate(I_LAN, 1);
            }
            else
            {
                I_LAN = 1;
                SetMenuItem(I_LAN, 1, "");
                SetMenuCate(I_LAN, 1);
            }
        }
        #endregion

        private void btnTasteHand_Click(object sender, EventArgs e)
        {
            FrmTAMenuItem frmTaMenuItem = new FrmTAMenuItem(userInfo, true);
            //frmTaMenuItem.tabCtlMenuItem.SelectedTab = frmTaMenuItem.tabPageTaste;
            //frmTaMenuItem.tabCtlMenuItem.SelectedTab = frmTaMenuItem.tabPageTaste;
            frmTaMenuItem.ShowDialog();
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
            var qList =
                CommonData.TaOrderItemList.Where(
                    s =>
                        s.CheckKey.Equals(ChkKey) &&
                        s.SystemKey.ToString().Equals(dgvMenuItem.CurrentRow.Cells[0].Value.ToString()));

            if (qList.Any())
            {
                qList.FirstOrDefault().ItemQty = (Convert.ToInt32(qList.FirstOrDefault().ItemQty) + 1).ToString();
                qList.FirstOrDefault().ItemTotalPrice =
                    ((Convert.ToInt32(qList.FirstOrDefault().ItemQty)) *
                     Convert.ToDecimal(qList.FirstOrDefault().ItemPrice)).ToString();
            }

            dgvMenuItem.DataSource = CommonData.TaOrderItemList.Where(s => s.CheckKey.Equals(ChkKey)).ToList();

            txtTotalCount.Text = GetDgvItemCount().ToString();
            txtTotalPrice.Text = GetDgvItemTotalPrice().ToString();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            if (dgvMenuItem.RowCount == 0) return;
            if (dgvMenuItem.CurrentRow?.Index < 0) return;

            //TAOrderItemInfo taOrderItem = new TAOrderItemInfo();
            var qList =
                CommonData.TaOrderItemList.Where(
                    s =>
                        s.CheckKey.Equals(ChkKey) &&
                        s.SystemKey.ToString().Equals(dgvMenuItem.CurrentRow.Cells[0].Value.ToString()));

            if (qList.Any())
            {
                if (Convert.ToInt32(qList.FirstOrDefault().ItemQty) > 1)
                {
                    qList.FirstOrDefault().ItemQty = (Convert.ToInt32(qList.FirstOrDefault().ItemQty) - 1).ToString();
                    qList.FirstOrDefault().ItemTotalPrice =
                    ((Convert.ToInt32(qList.FirstOrDefault().ItemQty)) *
                     Convert.ToDecimal(qList.FirstOrDefault().ItemPrice)).ToString();
                }
                else
                {
                    //删除？
                    CommonData.TaOrderItemList.Remove(qList.FirstOrDefault());
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

            var qList =
                CommonData.TaOrderItemList.Where(
                    s =>
                        s.CheckKey.Equals(ChkKey) &&
                        s.SystemKey.ToString().Equals(dgvMenuItem.CurrentRow.Cells[0].Value.ToString()));

            if (qList.Any())
            {
                CommonData.TaOrderItemList.Remove(qList.FirstOrDefault());
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
            FrmTAPay frmTaPay = new FrmTAPay();
            frmTaPay.ShowDialog();
        }
    }
}

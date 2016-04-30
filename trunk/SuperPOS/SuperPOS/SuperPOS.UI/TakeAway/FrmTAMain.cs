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

        //Language语言状态值
        private int I_LAN = 1;

        private string strCallID = "";

        #region 定义
        Button[] btnMI = new Button[16];
        Button[] btnMC = new Button[35];
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
    }
}

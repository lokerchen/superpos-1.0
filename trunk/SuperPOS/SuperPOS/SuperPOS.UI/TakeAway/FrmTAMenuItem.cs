using System;
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
using SuperPOS.UI.Admin;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAMenuItem : Form
    {
        #region 定义
        private string btnID = "1";
        private UserInfo userInfo = new UserInfo();
        private Guid btnDAGuid = Guid.Empty;
        private Guid btnDAGuid1 = Guid.Empty;
        private Guid btnDAGuid2 = Guid.Empty;
        private Guid btnDAGuid3 = Guid.Empty;
        private Guid btnDAGuid4 = Guid.Empty;

        private Guid btnSCGuid = Guid.Empty;
        private Guid btnSCGuid1 = Guid.Empty;
        private Guid btnSCGuid2 = Guid.Empty;
        private Guid btnSCGuid3 = Guid.Empty;
        private Guid btnSCGuid4 = Guid.Empty;

        private Guid btnTCGuid = Guid.Empty;
        private Guid btnTCGuid1 = Guid.Empty;
        private Guid btnTCGuid2 = Guid.Empty;
        private Guid btnTCGuid3 = Guid.Empty;
        private Guid btnTCGuid4 = Guid.Empty;

        private Guid btnTHGuid = Guid.Empty;
        private Guid btnTHGuid1 = Guid.Empty;
        private Guid btnTHGuid2 = Guid.Empty;
        private Guid btnTHGuid3 = Guid.Empty;
        private Guid btnTHGuid4 = Guid.Empty;

        private string menuCate1 = "";
        private string menuCate2 = "";
        private string menuCate3 = "";

        private string menuShitCode = "";

        private int iStatus = 0;

        private TextBox[] scTxtEngName = new TextBox[17];
        private TextBox[] scTxtOtherName = new TextBox[17];
        private TextBox[] scTxtPricce = new TextBox[17];
        private CheckBox[] scChkApd = new CheckBox[17];

        private TextBox[] tcTxtEngName = new TextBox[17];
        private TextBox[] tcTxtOtherName = new TextBox[17];
        private TextBox[] tcTxtPricce = new TextBox[17];
        private CheckBox[] tcChkApd = new CheckBox[17];

        private TextBox[] thTxtEngName = new TextBox[17];
        private TextBox[] thTxtOtherName = new TextBox[17];
        private TextBox[] thTxtPricce = new TextBox[17];
        private CheckBox[] thChkApd = new CheckBox[17];

        private TextBox[] txtSubMenuEngName = new TextBox[15];
        private TextBox[] txtSubMenuOtherName = new TextBox[15];

        private int iSubMenuStatus = 0;

        private readonly EntityControl _control = new EntityControl();

        private bool isTastHand = false;
        #endregion

        public FrmTAMenuItem()
        {
            InitializeComponent();
        }

        public FrmTAMenuItem(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
        }

        public FrmTAMenuItem(UserInfo uInfo, bool isOpenTastHand)
        {
            InitializeComponent();
            userInfo = uInfo;
            isTastHand = isOpenTastHand;
        }

        private void FrmTAMenuItem_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAMenuCategory();
            onLoadSystemCommonData.GetTAMenuItemList();
            onLoadSystemCommonData.GetTAMenuItemSubMenuList();

            #region Menu Category下拉选择

            //cmbBoxMenuCate1.DataSource = CommonData.TaMenuCategoryList.Select(s => s.EnglishName).ToList();
            //cmbBoxMenuCate2.DataSource = CommonData.TaMenuCategoryList.Select(s => s.EnglishName).ToList();
            //cmbBoxMenuCate3.DataSource = CommonData.TaMenuCategoryList.Select(s => s.EnglishName).ToList();
            BindCmbData();

            #endregion

            //cmBoxDish.DataSource = CommonData.TaMenuCategoryList.Select(s => new {});

            #region  Dish Attributes Menu Set 按钮

            btnDA1.Click += btnDA_Click;
            btnDA2.Click += btnDA_Click;
            btnDA3.Click += btnDA_Click;
            btnDA4.Click += btnDA_Click;

            btnDA1.BackColor = Color.CornflowerBlue;
            btnDA2.BackColor = Color.Gray;
            btnDA3.BackColor = Color.Gray;
            btnDA4.BackColor = Color.Gray;

            onLoadSystemCommonData.GetTAMenuSet();

            foreach (var tsl in CommonData.TaMenuSetList.OrderBy(s => s.ID))
            {
                switch (tsl.ID)
                {
                    case "1":
                        btnDA1.Text = tsl.EnglishName;
                        btnDAGuid1 = tsl.SystemKey;
                        //默认值
                        btnDAGuid = btnDAGuid1;
                        break;
                    case "2":
                        btnDA2.Text = tsl.EnglishName;
                        btnDAGuid2 = tsl.SystemKey;
                        break;
                    case "3":
                        btnDA3.Text = tsl.EnglishName;
                        btnDAGuid3 = tsl.SystemKey;
                        break;
                    case "4":
                        btnDA4.Text = tsl.EnglishName;
                        btnDAGuid4 = tsl.SystemKey;
                        break;
                }
            }

            #endregion

            #region  Second Choices Menu Set 按钮

            btnSC1.Click += btnSC_Click;
            btnSC2.Click += btnSC_Click;
            btnSC3.Click += btnSC_Click;
            btnSC4.Click += btnSC_Click;

            btnSC1.BackColor = Color.CornflowerBlue;
            btnSC2.BackColor = Color.Gray;
            btnSC3.BackColor = Color.Gray;
            btnSC4.BackColor = Color.Gray;

            onLoadSystemCommonData.GetTAMenuSet();

            foreach (var tsl in CommonData.TaMenuSetList.OrderBy(s => s.ID))
            {
                switch (tsl.ID)
                {
                    case "1":
                        btnSC1.Text = tsl.EnglishName;
                        btnSCGuid1 = tsl.SystemKey;
                        //默认值
                        btnSCGuid = btnSCGuid1;
                        break;
                    case "2":
                        btnSC2.Text = tsl.EnglishName;
                        btnSCGuid2 = tsl.SystemKey;
                        break;
                    case "3":
                        btnSC3.Text = tsl.EnglishName;
                        btnSCGuid3 = tsl.SystemKey;
                        break;
                    case "4":
                        btnSC4.Text = tsl.EnglishName;
                        btnSCGuid4 = tsl.SystemKey;
                        break;
                }
            }

            #endregion

            #region  Third Choices Menu Set 按钮

            btnTC1.Click += btnTC_Click;
            btnTC2.Click += btnTC_Click;
            btnTC3.Click += btnTC_Click;
            btnTC4.Click += btnTC_Click;

            btnTC1.BackColor = Color.CornflowerBlue;
            btnTC2.BackColor = Color.Gray;
            btnTC3.BackColor = Color.Gray;
            btnTC4.BackColor = Color.Gray;

            onLoadSystemCommonData.GetTAMenuSet();

            foreach (var tsl in CommonData.TaMenuSetList.OrderBy(s => s.ID))
            {
                switch (tsl.ID)
                {
                    case "1":
                        btnTC1.Text = tsl.EnglishName;
                        btnTCGuid1 = tsl.SystemKey;
                        //默认值
                        btnTCGuid = btnTCGuid1;
                        break;
                    case "2":
                        btnTC2.Text = tsl.EnglishName;
                        btnTCGuid2 = tsl.SystemKey;
                        break;
                    case "3":
                        btnTC3.Text = tsl.EnglishName;
                        btnTCGuid3 = tsl.SystemKey;
                        break;
                    case "4":
                        btnTC4.Text = tsl.EnglishName;
                        btnTCGuid4 = tsl.SystemKey;
                        break;
                }
            }

            #endregion

            #region  Taste Handling Menu Set 按钮

            btnTH1.Click += btnTH_Click;
            btnTH2.Click += btnTH_Click;
            btnTH3.Click += btnTH_Click;
            btnTH4.Click += btnTH_Click;

            btnTH1.BackColor = Color.CornflowerBlue;
            btnTH2.BackColor = Color.Gray;
            btnTH3.BackColor = Color.Gray;
            btnTH4.BackColor = Color.Gray;

            onLoadSystemCommonData.GetTAMenuSet();

            foreach (var tsl in CommonData.TaMenuSetList.OrderBy(s => s.ID))
            {
                switch (tsl.ID)
                {
                    case "1":
                        btnTH1.Text = tsl.EnglishName;
                        btnTHGuid1 = tsl.SystemKey;
                        //默认值
                        btnTHGuid = btnTHGuid1;
                        break;
                    case "2":
                        btnTH2.Text = tsl.EnglishName;
                        btnTHGuid2 = tsl.SystemKey;
                        break;
                    case "3":
                        btnTH3.Text = tsl.EnglishName;
                        btnTHGuid3 = tsl.SystemKey;
                        break;
                    case "4":
                        btnTH4.Text = tsl.EnglishName;
                        btnTHGuid4 = tsl.SystemKey;
                        break;
                }
            }

            #endregion

            onLoadSystemCommonData.GetTAMenuCategory();

            #region Dish Attributes category Search下拉菜单

            cmDABoxDish.DataSource = CommonData.TaMenuCategoryList.Select(s => s.EnglishName).ToList();

            #endregion

            #region Second Choices category Search下拉菜单

            cmSCBoxDish.DataSource = CommonData.TaMenuCategoryList.Select(s => s.EnglishName).ToList();

            #endregion

            #region Third Choices category Search下拉菜单

            cmTCBoxDish.DataSource = CommonData.TaMenuCategoryList.Select(s => s.EnglishName).ToList();

            #endregion

            #region Taste Handling category Search下拉菜单

            cmTHBoxDish.DataSource = CommonData.TaMenuCategoryList.Select(s => s.EnglishName).ToList();

            #endregion

            #region dgvMenu

            onLoadSystemCommonData.GetTAMenuItemList();
            dgvDAMenu.DataSource = CommonData.TaMenuItemList;
            dgvSCMenu.DataSource = CommonData.TaMenuItemList;
            dgvTCMenu.DataSource = CommonData.TaMenuItemList;
            dgvTHMenu.DataSource = CommonData.TaMenuItemList;
            dgvSubMenu.DataSource = CommonData.TaMenuItemSubMenuList;

            #region DataGrid控制

            dgvDAMenu.Columns[0].Visible = false;
            dgvDAMenu.Columns[1].HeaderText = @"Code";
            dgvDAMenu.Columns[1].Width = 40;
            dgvDAMenu.Columns[2].Visible = false;
            dgvDAMenu.Columns[3].HeaderText = @"Item Name";
            for (int i = 4; i < 23; i++) { dgvDAMenu.Columns[i].Visible = false; }

            dgvSCMenu.Columns[0].Visible = false;
            dgvSCMenu.Columns[1].HeaderText = @"Code";
            dgvSCMenu.Columns[1].Width = 40;
            dgvSCMenu.Columns[2].Visible = false;
            dgvSCMenu.Columns[3].HeaderText = @"ItemName";
            for (int i = 4; i < 23; i++) { dgvSCMenu.Columns[i].Visible = false; }

            dgvTCMenu.Columns[0].Visible = false;
            dgvTCMenu.Columns[1].HeaderText = @"Code";
            dgvTCMenu.Columns[1].Width = 40;
            dgvTCMenu.Columns[2].Visible = false;
            dgvTCMenu.Columns[3].HeaderText = @"Item Name";
            for (int i = 4; i < 23; i++) { dgvTCMenu.Columns[i].Visible = false; }

            dgvTHMenu.Columns[0].Visible = false;
            dgvTHMenu.Columns[1].HeaderText = @"Code";
            dgvTHMenu.Columns[1].Width = 40;
            dgvTHMenu.Columns[2].Visible = false;
            dgvTHMenu.Columns[3].HeaderText = @"Item Name";
            for (int i = 4; i < 23; i++) { dgvTHMenu.Columns[i].Visible = false; }

            dgvSubMenu.Columns[0].Visible = false;
            dgvSubMenu.Columns[1].HeaderText = @"Code";
            dgvSubMenu.Columns[2].Visible = false;
            dgvSubMenu.Columns[3].HeaderText = @"Item Name";
            dgvSubMenu.Columns[4].Visible = false;
            dgvSubMenu.Columns[5].HeaderText = @"Price";
            for (int i = 6; i < 14; i++) { dgvSubMenu.Columns[i].Visible = false; }
            #endregion

            #endregion

            #region Second Choices文本框控件数组

            #region English Name

            scTxtEngName[0] = txtSCEngName1;
            scTxtEngName[1] = txtSCEngName2;
            scTxtEngName[2] = txtSCEngName3;
            scTxtEngName[3] = txtSCEngName4;
            scTxtEngName[4] = txtSCEngName5;
            scTxtEngName[5] = txtSCEngName6;
            scTxtEngName[6] = txtSCEngName7;
            scTxtEngName[7] = txtSCEngName8;
            scTxtEngName[8] = txtSCEngName9;
            scTxtEngName[9] = txtSCEngName10;
            scTxtEngName[10] = txtSCEngName11;
            scTxtEngName[11] = txtSCEngName12;
            scTxtEngName[12] = txtSCEngName13;
            scTxtEngName[13] = txtSCEngName14;
            scTxtEngName[14] = txtSCEngName15;
            scTxtEngName[15] = txtSCEngName16;
            scTxtEngName[16] = txtSCEngName17;

            #endregion

            #region Other Name

            scTxtOtherName[0] = txtSCOtherName1;
            scTxtOtherName[1] = txtSCOtherName2;
            scTxtOtherName[2] = txtSCOtherName3;
            scTxtOtherName[3] = txtSCOtherName4;
            scTxtOtherName[4] = txtSCOtherName5;
            scTxtOtherName[5] = txtSCOtherName6;
            scTxtOtherName[6] = txtSCOtherName7;
            scTxtOtherName[7] = txtSCOtherName8;
            scTxtOtherName[8] = txtSCOtherName9;
            scTxtOtherName[9] = txtSCOtherName10;
            scTxtOtherName[10] = txtSCOtherName11;
            scTxtOtherName[11] = txtSCOtherName12;
            scTxtOtherName[12] = txtSCOtherName13;
            scTxtOtherName[13] = txtSCOtherName14;
            scTxtOtherName[14] = txtSCOtherName15;
            scTxtOtherName[15] = txtSCOtherName16;
            scTxtOtherName[16] = txtSCOtherName17;

            #endregion

            #region Add. Price

            scTxtPricce[0] = txtSCAddPrice1;
            scTxtPricce[1] = txtSCAddPrice2;
            scTxtPricce[2] = txtSCAddPrice3;
            scTxtPricce[3] = txtSCAddPrice4;
            scTxtPricce[4] = txtSCAddPrice5;
            scTxtPricce[5] = txtSCAddPrice6;
            scTxtPricce[6] = txtSCAddPrice7;
            scTxtPricce[7] = txtSCAddPrice8;
            scTxtPricce[8] = txtSCAddPrice9;
            scTxtPricce[9] = txtSCAddPrice10;
            scTxtPricce[10] = txtSCAddPrice11;
            scTxtPricce[11] = txtSCAddPrice12;
            scTxtPricce[12] = txtSCAddPrice13;
            scTxtPricce[13] = txtSCAddPrice14;
            scTxtPricce[14] = txtSCAddPrice15;
            scTxtPricce[15] = txtSCAddPrice16;
            scTxtPricce[16] = txtSCAddPrice17;

            #endregion

            #region Auto Append

            scChkApd[0] = chkSCAutoAppend1;
            scChkApd[1] = chkSCAutoAppend2;
            scChkApd[2] = chkSCAutoAppend3;
            scChkApd[3] = chkSCAutoAppend4;
            scChkApd[4] = chkSCAutoAppend5;
            scChkApd[5] = chkSCAutoAppend6;
            scChkApd[6] = chkSCAutoAppend7;
            scChkApd[7] = chkSCAutoAppend8;
            scChkApd[8] = chkSCAutoAppend9;
            scChkApd[9] = chkSCAutoAppend10;
            scChkApd[10] = chkSCAutoAppend11;
            scChkApd[11] = chkSCAutoAppend12;
            scChkApd[12] = chkSCAutoAppend13;
            scChkApd[13] = chkSCAutoAppend14;
            scChkApd[14] = chkSCAutoAppend15;
            scChkApd[15] = chkSCAutoAppend16;
            scChkApd[16] = chkSCAutoAppend17;

            #endregion

            #endregion

            #region Third Choices文本框控件数组

            #region English Name

            tcTxtEngName[0] = txtTCEngName1;
            tcTxtEngName[1] = txtTCEngName2;
            tcTxtEngName[2] = txtTCEngName3;
            tcTxtEngName[3] = txtTCEngName4;
            tcTxtEngName[4] = txtTCEngName5;
            tcTxtEngName[5] = txtTCEngName6;
            tcTxtEngName[6] = txtTCEngName7;
            tcTxtEngName[7] = txtTCEngName8;
            tcTxtEngName[8] = txtTCEngName9;
            tcTxtEngName[9] = txtTCEngName10;
            tcTxtEngName[10] = txtTCEngName11;
            tcTxtEngName[11] = txtTCEngName12;
            tcTxtEngName[12] = txtTCEngName13;
            tcTxtEngName[13] = txtTCEngName14;
            tcTxtEngName[14] = txtTCEngName15;
            tcTxtEngName[15] = txtTCEngName16;
            tcTxtEngName[16] = txtTCEngName17;

            #endregion

            #region Other Name

            tcTxtOtherName[0] = txtTCOtherName1;
            tcTxtOtherName[1] = txtTCOtherName2;
            tcTxtOtherName[2] = txtTCOtherName3;
            tcTxtOtherName[3] = txtTCOtherName4;
            tcTxtOtherName[4] = txtTCOtherName5;
            tcTxtOtherName[5] = txtTCOtherName6;
            tcTxtOtherName[6] = txtTCOtherName7;
            tcTxtOtherName[7] = txtTCOtherName8;
            tcTxtOtherName[8] = txtTCOtherName9;
            tcTxtOtherName[9] = txtTCOtherName10;
            tcTxtOtherName[10] = txtTCOtherName11;
            tcTxtOtherName[11] = txtTCOtherName12;
            tcTxtOtherName[12] = txtTCOtherName13;
            tcTxtOtherName[13] = txtTCOtherName14;
            tcTxtOtherName[14] = txtTCOtherName15;
            tcTxtOtherName[15] = txtTCOtherName16;
            tcTxtOtherName[16] = txtTCOtherName17;

            #endregion

            #region Add. Price

            tcTxtPricce[0] = txtTCAddPrice1;
            tcTxtPricce[1] = txtTCAddPrice2;
            tcTxtPricce[2] = txtTCAddPrice3;
            tcTxtPricce[3] = txtTCAddPrice4;
            tcTxtPricce[4] = txtTCAddPrice5;
            tcTxtPricce[5] = txtTCAddPrice6;
            tcTxtPricce[6] = txtTCAddPrice7;
            tcTxtPricce[7] = txtTCAddPrice8;
            tcTxtPricce[8] = txtTCAddPrice9;
            tcTxtPricce[9] = txtTCAddPrice10;
            tcTxtPricce[10] = txtTCAddPrice11;
            tcTxtPricce[11] = txtTCAddPrice12;
            tcTxtPricce[12] = txtTCAddPrice13;
            tcTxtPricce[13] = txtTCAddPrice14;
            tcTxtPricce[14] = txtTCAddPrice15;
            tcTxtPricce[15] = txtTCAddPrice16;
            tcTxtPricce[16] = txtTCAddPrice17;

            #endregion

            #region Auto Append

            tcChkApd[0] = chkTCAutoAppend1;
            tcChkApd[1] = chkTCAutoAppend2;
            tcChkApd[2] = chkTCAutoAppend3;
            tcChkApd[3] = chkTCAutoAppend4;
            tcChkApd[4] = chkTCAutoAppend5;
            tcChkApd[5] = chkTCAutoAppend6;
            tcChkApd[6] = chkTCAutoAppend7;
            tcChkApd[7] = chkTCAutoAppend8;
            tcChkApd[8] = chkTCAutoAppend9;
            tcChkApd[9] = chkTCAutoAppend10;
            tcChkApd[10] = chkTCAutoAppend11;
            tcChkApd[11] = chkTCAutoAppend12;
            tcChkApd[12] = chkTCAutoAppend13;
            tcChkApd[13] = chkTCAutoAppend14;
            tcChkApd[14] = chkTCAutoAppend15;
            tcChkApd[15] = chkTCAutoAppend16;
            tcChkApd[16] = chkTCAutoAppend17;

            #endregion

            #endregion

            #region Taste Handling文本框控件数组

            #region English Name

            thTxtEngName[0] = txtTHEngName1;
            thTxtEngName[1] = txtTHEngName2;
            thTxtEngName[2] = txtTHEngName3;
            thTxtEngName[3] = txtTHEngName4;
            thTxtEngName[4] = txtTHEngName5;
            thTxtEngName[5] = txtTHEngName6;
            thTxtEngName[6] = txtTHEngName7;
            thTxtEngName[7] = txtTHEngName8;
            thTxtEngName[8] = txtTHEngName9;
            thTxtEngName[9] = txtTHEngName10;
            thTxtEngName[10] = txtTHEngName11;
            thTxtEngName[11] = txtTHEngName12;
            thTxtEngName[12] = txtTHEngName13;
            thTxtEngName[13] = txtTHEngName14;
            thTxtEngName[14] = txtTHEngName15;
            thTxtEngName[15] = txtTHEngName16;
            thTxtEngName[16] = txtTHEngName17;

            #endregion

            #region Other Name

            thTxtOtherName[0] = txtTHOtherName1;
            thTxtOtherName[1] = txtTHOtherName2;
            thTxtOtherName[2] = txtTHOtherName3;
            thTxtOtherName[3] = txtTHOtherName4;
            thTxtOtherName[4] = txtTHOtherName5;
            thTxtOtherName[5] = txtTHOtherName6;
            thTxtOtherName[6] = txtTHOtherName7;
            thTxtOtherName[7] = txtTHOtherName8;
            thTxtOtherName[8] = txtTHOtherName9;
            thTxtOtherName[9] = txtTHOtherName10;
            thTxtOtherName[10] = txtTHOtherName11;
            thTxtOtherName[11] = txtTHOtherName12;
            thTxtOtherName[12] = txtTHOtherName13;
            thTxtOtherName[13] = txtTHOtherName14;
            thTxtOtherName[14] = txtTHOtherName15;
            thTxtOtherName[15] = txtTHOtherName16;
            thTxtOtherName[16] = txtTHOtherName17;

            #endregion

            #region Add. Price

            thTxtPricce[0] = txtTHAddPrice1;
            thTxtPricce[1] = txtTHAddPrice2;
            thTxtPricce[2] = txtTHAddPrice3;
            thTxtPricce[3] = txtTHAddPrice4;
            thTxtPricce[4] = txtTHAddPrice5;
            thTxtPricce[5] = txtTHAddPrice6;
            thTxtPricce[6] = txtTHAddPrice7;
            thTxtPricce[7] = txtTHAddPrice8;
            thTxtPricce[8] = txtTHAddPrice9;
            thTxtPricce[9] = txtTHAddPrice10;
            thTxtPricce[10] = txtTHAddPrice11;
            thTxtPricce[11] = txtTHAddPrice12;
            thTxtPricce[12] = txtTHAddPrice13;
            thTxtPricce[13] = txtTHAddPrice14;
            thTxtPricce[14] = txtTHAddPrice15;
            thTxtPricce[15] = txtTHAddPrice16;
            thTxtPricce[16] = txtTHAddPrice17;

            #endregion

            #region Auto Append

            thChkApd[0] = chkTHAutoAppend1;
            thChkApd[1] = chkTHAutoAppend2;
            thChkApd[2] = chkTHAutoAppend3;
            thChkApd[3] = chkTHAutoAppend4;
            thChkApd[4] = chkTHAutoAppend5;
            thChkApd[5] = chkTHAutoAppend6;
            thChkApd[6] = chkTHAutoAppend7;
            thChkApd[7] = chkTHAutoAppend8;
            thChkApd[8] = chkTHAutoAppend9;
            thChkApd[9] = chkTHAutoAppend10;
            thChkApd[10] = chkTHAutoAppend11;
            thChkApd[11] = chkTHAutoAppend12;
            thChkApd[12] = chkTHAutoAppend13;
            thChkApd[13] = chkTHAutoAppend14;
            thChkApd[14] = chkTHAutoAppend15;
            thChkApd[15] = chkTHAutoAppend16;
            thChkApd[16] = chkTHAutoAppend17;

            #endregion

            #endregion

            #region SubMenu 文本框控件数组
            txtSubMenuEngName[0] = txtDishEngName1;
            txtSubMenuEngName[1] = txtDishEngName2;
            txtSubMenuEngName[2] = txtDishEngName3;
            txtSubMenuEngName[3] = txtDishEngName4;
            txtSubMenuEngName[4] = txtDishEngName5;
            txtSubMenuEngName[5] = txtDishEngName6;
            txtSubMenuEngName[6] = txtDishEngName7;
            txtSubMenuEngName[7] = txtDishEngName8;
            txtSubMenuEngName[8] = txtDishEngName9;
            txtSubMenuEngName[9] = txtDishEngName10;
            txtSubMenuEngName[10] = txtDishEngName11;
            txtSubMenuEngName[11] = txtDishEngName12;
            txtSubMenuEngName[12] = txtDishEngName13;
            txtSubMenuEngName[13] = txtDishEngName14;
            txtSubMenuEngName[14] = txtDishEngName15;

            txtSubMenuOtherName[0] = txtDishOtherName1;
            txtSubMenuOtherName[1] = txtDishOtherName2;
            txtSubMenuOtherName[2] = txtDishOtherName3;
            txtSubMenuOtherName[3] = txtDishOtherName4;
            txtSubMenuOtherName[4] = txtDishOtherName5;
            txtSubMenuOtherName[5] = txtDishOtherName6;
            txtSubMenuOtherName[6] = txtDishOtherName7;
            txtSubMenuOtherName[7] = txtDishOtherName8;
            txtSubMenuOtherName[8] = txtDishOtherName9;
            txtSubMenuOtherName[9] = txtDishOtherName10;
            txtSubMenuOtherName[10] = txtDishOtherName11;
            txtSubMenuOtherName[11] = txtDishOtherName12;
            txtSubMenuOtherName[12] = txtDishOtherName13;
            txtSubMenuOtherName[13] = txtDishOtherName14;
            txtSubMenuOtherName[14] = txtDishOtherName15;
            #endregion

            //dgvSCDetail.DataSource = CommonData.TaMenuItemSCList.Where(s => s.MenuSetID.Equals(btnSCGuid)).ToList();
            //dgvSCDetail.Columns[0].Visible = false;
            //dgvSCDetail.Columns[1].Visible = false;
            //dgvSCDetail.Columns[2].Visible = false;
            //dgvSCDetail.Columns[3].HeaderText = "English Name";
            //dgvSCDetail.Columns[4].HeaderText = "Other Name";
            //dgvSCDetail.Columns[5].HeaderText = "Add. Price";
            //dgvSCDetail.Columns[6].HeaderText = "Auto Append";
            //dgvSCDetail.Columns[7].Visible = false;
            //Console.Out.WriteLine(Guid.NewGuid());

            if (isTastHand) tabCtlMenuItem.SelectTab(tabPageTaste);
        }

        private void btnDA_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            switch (btn.Name)
            {
                case "btnDA1":
                    btnID = "1";
                    btn.BackColor = Color.CornflowerBlue;
                    btnDA2.BackColor = Color.Gray;
                    btnDA3.BackColor = Color.Gray;
                    btnDA4.BackColor = Color.Gray;
                    btnDAGuid = btnDAGuid1;
                    break;
                case "btnDA2":
                    btnID = "2";
                    btnDA1.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnDA3.BackColor = Color.Gray;
                    btnDA4.BackColor = Color.Gray;
                    btnDAGuid = btnDAGuid2;
                    break;
                case "btnDA3":
                    btnID = "3";
                    btnDA1.BackColor = Color.Gray;
                    btnDA2.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnDA4.BackColor = Color.Gray;
                    btnDAGuid = btnDAGuid3;
                    break;
                case "btnDA4":
                    btnID = "4";
                    btnDA1.BackColor = Color.Gray;
                    btnDA2.BackColor = Color.Gray;
                    btnDA3.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnDAGuid = btnDAGuid4;
                    break;
                default:
                    btnID = "1";
                    btn.BackColor = Color.CornflowerBlue;
                    btnDA2.BackColor = Color.Gray;
                    btnDA3.BackColor = Color.Gray;
                    btnDA4.BackColor = Color.Gray;
                    btnDAGuid = btnDAGuid1;
                    break;
            }
            dgvDAMenu.DataSource = CommonData.TaMenuItemList.Where(s => s.MenuSetID.Equals(btnDAGuid.ToString())).ToList();
            //if (btn1.BackColor = Color.Gray)
            //Console.Out.WriteLine(btnDAGuid.ToString());
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            switch (btn.Name)
            {
                case "btnSC1":
                    btnID = "1";
                    btn.BackColor = Color.CornflowerBlue;
                    btnSC2.BackColor = Color.Gray;
                    btnSC3.BackColor = Color.Gray;
                    btnSC4.BackColor = Color.Gray;
                    btnSCGuid = btnSCGuid1;
                    break;
                case "btnSC2":
                    btnID = "2";
                    btnSC1.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnSC3.BackColor = Color.Gray;
                    btnSC4.BackColor = Color.Gray;
                    btnSCGuid = btnSCGuid2;
                    break;
                case "btnSC3":
                    btnID = "3";
                    btnSC1.BackColor = Color.Gray;
                    btnSC2.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnSC4.BackColor = Color.Gray;
                    btnSCGuid = btnSCGuid3;
                    break;
                case "btnSC4":
                    btnID = "4";
                    btnSC1.BackColor = Color.Gray;
                    btnSC2.BackColor = Color.Gray;
                    btnSC3.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnSCGuid = btnSCGuid4;
                    break;
            }
            //if (btn1.BackColor = Color.Gray)
            //Console.Out.WriteLine(btnDAGuid.ToString());
            dgvSCMenu.DataSource = CommonData.TaMenuItemList.Where(s => s.MenuSetID.Equals(btnSCGuid.ToString())).ToList();
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            switch (btn.Name)
            {
                case "btnTC1":
                    btnID = "1";
                    btn.BackColor = Color.CornflowerBlue;
                    btnTC2.BackColor = Color.Gray;
                    btnTC3.BackColor = Color.Gray;
                    btnTC4.BackColor = Color.Gray;
                    btnTCGuid = btnTCGuid1;
                    break;
                case "btnTC2":
                    btnID = "2";
                    btnTC1.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnTC3.BackColor = Color.Gray;
                    btnTC4.BackColor = Color.Gray;
                    btnTCGuid = btnTCGuid2;
                    break;
                case "btnTC3":
                    btnID = "3";
                    btnTC1.BackColor = Color.Gray;
                    btnTC2.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnTC4.BackColor = Color.Gray;
                    btnTCGuid = btnTCGuid3;
                    break;
                case "btnTC4":
                    btnID = "4";
                    btnTC1.BackColor = Color.Gray;
                    btnTC2.BackColor = Color.Gray;
                    btnTC3.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnTCGuid = btnTCGuid4;
                    break;
            }
            //if (btn1.BackColor = Color.Gray)
            //Console.Out.WriteLine(btnDAGuid.ToString());
            dgvTCMenu.DataSource = CommonData.TaMenuItemList.Where(s => s.MenuSetID.Equals(btnTCGuid.ToString())).ToList();
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            switch (btn.Name)
            {
                case "btnTH1":
                    btnID = "1";
                    btn.BackColor = Color.CornflowerBlue;
                    btnTH2.BackColor = Color.Gray;
                    btnTH3.BackColor = Color.Gray;
                    btnTH4.BackColor = Color.Gray;
                    btnTHGuid = btnTHGuid1;
                    break;
                case "btnTH2":
                    btnID = "2";
                    btnTH1.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnTH3.BackColor = Color.Gray;
                    btnTH4.BackColor = Color.Gray;
                    btnTHGuid = btnTHGuid2;
                    break;
                case "btnTH3":
                    btnID = "3";
                    btnTH1.BackColor = Color.Gray;
                    btnTH2.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnTH4.BackColor = Color.Gray;
                    btnTHGuid = btnTHGuid3;
                    break;
                case "btnTH4":
                    btnID = "4";
                    btnTH1.BackColor = Color.Gray;
                    btnTH2.BackColor = Color.Gray;
                    btnTH3.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnTHGuid = btnTHGuid4;
                    break;
            }
            //if (btn1.BackColor = Color.Gray)
            //Console.Out.WriteLine(btnDAGuid.ToString());
            dgvTHMenu.DataSource = CommonData.TaMenuItemList.Where(s => s.MenuSetID.Equals(btnTHGuid.ToString())).ToList();
        }

        private void btnDAExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDADishCodeSearch_Click(object sender, EventArgs e)
        {
            dgvDAMenu.DataSource = !string.IsNullOrEmpty(txtDADishCode.Text)
                ? CommonData.TaMenuItemList.Where(s => s.DishCode.Equals(txtDADishCode.Text.Trim())).ToList()
                : CommonData.TaMenuItemList.ToList();
        }

        private void btnSCDishCodeSearch_Click(object sender, EventArgs e)
        {
            dgvDAMenu.DataSource = !string.IsNullOrEmpty(txtSCDishCode.Text)
                ? CommonData.TaMenuItemList.Where(s => s.DishCode.Equals(txtSCDishCode.Text.Trim())).ToList()
                : CommonData.TaMenuItemList.ToList();
        }

        private void btnTCDishCodeSearch_Click(object sender, EventArgs e)
        {
            dgvTCMenu.DataSource = !string.IsNullOrEmpty(txtTCDishCode.Text)
                ? CommonData.TaMenuItemList.Where(s => s.DishCode.Equals(txtTCDishCode.Text.Trim())).ToList()
                : CommonData.TaMenuItemList.ToList();
        }

        private void btnTHDishCodeSearch_Click(object sender, EventArgs e)
        {
            dgvTHMenu.DataSource = !string.IsNullOrEmpty(txtTHDishCode.Text)
                ? CommonData.TaMenuItemList.Where(s => s.DishCode.Equals(txtTHDishCode.Text.Trim())).ToList()
                : CommonData.TaMenuItemList.ToList();
        }

        private void btnDAAdd_Click(object sender, EventArgs e)
        {
            //iStatus = 1;

            txtDishCode.Text = "";
            txtDisPosition.Text = "";
            txtEngName.Text = "";
            txtOtherName.Text = "";
            txtWLarge.Text = "";
            txtWRegular.Text = "";
            txtWSmall.Text = "";
            txtSLarge.Text = "";
            txtSRegular.Text = "";
            txtSSmall.Text = "";

            //txtDishCode.Enabled = true;
            //txtDisPosition.Enabled = true;
            //txtEngName.Enabled = true;
            //txtOtherName.Enabled = true;
            //txtWLarge.Enabled = true;
            //txtWRegular.Enabled = true;
            //txtWSmall.Enabled = true;
            //txtSLarge.Enabled = true;
            //txtSRegular.Enabled = true;
            //txtSSmall.Enabled = true;

            //chkUnavailable.Enabled = true;
            //chkNegativePrice.Enabled = true;
            //chkDisountable.Enabled = true;
            //chkWithoutVAT.Enabled = true;
            //chkInventoryCheck.Enabled = true;
            chkUnavailable.Checked = false;
            chkNegativePrice.Checked = false;
            chkDisountable.Checked = false;
            chkWithoutVAT.Checked = false;
            chkInventoryCheck.Checked = false;

            //cmbBoxSplySft.Enabled = true;
            cmbBoxSplySft.SelectedIndex = 0;
            //chkBoxPrtOrderByDept.Enabled = true;
            chkBoxPrtOrderByDept.Checked = false;
            //chkBoxPrtOrderX.Enabled = true;
            chkBoxPrtOrderX.Checked = false;

            //cmbBoxMenuCate1.Enabled = true;
            //cmbBoxMenuCate2.Enabled = true;
            //cmbBoxMenuCate3.Enabled = true;
            cmbBoxMenuCate1.SelectedIndex = 0;
            cmbBoxMenuCate2.SelectedIndex = 0;
            cmbBoxMenuCate3.SelectedIndex = 0;

            //btnDAEdit.Enabled = false;
            btnDADel.Enabled = false;
            btnDACopy.Enabled = false;
            btnDASave.Enabled = true;
        }

        private void BindCmbData()
        {
            //foreach (var dc in CommonData.TaMenuCategoryList)
            //{
            //    if (!(!string.IsNullOrEmpty(dc.SystemKey.ToString()) && string.IsNullOrEmpty(dc.EnglishName)))
            //    {
            //        TAMenuItemInfo taMenuItemInfo = new TAMenuItemInfo();
            //        taMenuItemInfo.SystemKey = Guid.NewGuid();
            //        taMenuItemInfo.EnglishName = "";
            //        taMenuItemInfo.OtherName = "";
            //        taMenuItemInfo.DishCode = "";
            //        _control.AddEntity(taMenuItemInfo);
            //    }
            //}

            if (!CommonData.TaMenuCategoryList.Any(s => !string.IsNullOrEmpty(s.SystemKey.ToString()) && string.IsNullOrEmpty(s.EnglishName)))
            {
                TAMenuCategoryInfo taMenuCategoryInfo = new TAMenuCategoryInfo();
                taMenuCategoryInfo.SystemKey = Guid.NewGuid();
                taMenuCategoryInfo.EnglishName = "";
                taMenuCategoryInfo.OtherName = "";
                taMenuCategoryInfo.DishCode = "";
                _control.AddEntity(taMenuCategoryInfo);
            }


            new OnLoadSystemCommonData().GetTAMenuCategory();
            var lstDeptCate =
                CommonData.TaMenuCategoryList.OrderBy(s => s.DisplayPosition)
                    .Select(lstDC => new {DeptCode = lstDC.EnglishName, SysKey = lstDC.SystemKey});
            //cmbBoxDeptCode.DataSource = lstDeptCode.ToList();
            //lstDeptCode.ToList().Add(new { DeptCode = "", SysKey = Guid.Empty });

            cmbBoxMenuCate1.DataSource = lstDeptCate.ToList();
            cmbBoxMenuCate1.ValueMember = "SysKey";
            cmbBoxMenuCate1.DisplayMember = "DeptCode";

            cmbBoxMenuCate2.DataSource = lstDeptCate.ToList();
            cmbBoxMenuCate2.ValueMember = "SysKey";
            cmbBoxMenuCate2.DisplayMember = "DeptCode";

            cmbBoxMenuCate3.DataSource = lstDeptCate.ToList();
            cmbBoxMenuCate3.ValueMember = "SysKey";
            cmbBoxMenuCate3.DisplayMember = "DeptCode";

            var lstSupplySft = CommonData.ShiftCodeList.OrderBy(s => s.DtFrom)
                .Select(lstSS => new {sDate = lstSS.ShiftName, sSysKey = lstSS.SystemKey});
            cmbBoxSplySft.DataSource = lstSupplySft.ToList();
            cmbBoxSplySft.ValueMember = "sSysKey";
            cmbBoxSplySft.DisplayMember = "sDate";

            cmbSMSupplyShift.DataSource = lstSupplySft.ToList();
            cmbSMSupplyShift.ValueMember = "sSysKey";
            cmbSMSupplyShift.DisplayMember = "sDate";
        }

        private void cmbBoxMenuCate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.Out.WriteLine(cmbBoxMenuCate1.Text);
            //Console.Out.WriteLine(cmbBoxMenuCate1.SelectedValue);
            menuCate1 = cmbBoxMenuCate1.SelectedValue.ToString();
        }

        private void cmbBoxMenuCate2_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuCate2 = cmbBoxMenuCate2.SelectedValue.ToString();
        }

        private void cmbBoxMenuCate3_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuCate3 = cmbBoxMenuCate3.SelectedValue.ToString();
        }

        private void cmbBoxSplySft_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuShitCode = cmbBoxSplySft.SelectedValue.ToString();
        }

        private void btnDAEdit_Click(object sender, EventArgs e)
        {
            iStatus = 2;

            btnDAAdd.Enabled = false;
            btnDACopy.Enabled = false;
            btnDADel.Enabled = false;
            btnDASave.Enabled = true;

            txtDishCode.Enabled = true;
            txtDisPosition.Enabled = true;
            txtEngName.Enabled = true;
            txtOtherName.Enabled = true;
            txtWLarge.Enabled = true;
            txtWRegular.Enabled = true;
            txtWSmall.Enabled = true;
            txtSLarge.Enabled = true;
            txtSRegular.Enabled = true;
            txtSSmall.Enabled = true;

            chkUnavailable.Enabled = true;
            chkNegativePrice.Enabled = true;
            chkDisountable.Enabled = true;
            chkWithoutVAT.Enabled = true;
            chkInventoryCheck.Enabled = true;
            chkUnavailable.Checked = false;
            chkNegativePrice.Checked = false;
            chkDisountable.Checked = false;
            chkWithoutVAT.Checked = false;
            chkInventoryCheck.Checked = false;

            cmbBoxMenuCate1.Enabled = true;
            cmbBoxMenuCate2.Enabled = true;
            cmbBoxMenuCate3.Enabled = true;

            cmbBoxSplySft.Enabled = true;
            chkBoxPrtOrderByDept.Enabled = true;
            chkBoxPrtOrderX.Enabled = true;
        }

        private void dgvDAMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDAMenu.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvDAMenu.CurrentRow == null) return;

            if (dgvDAMenu.CurrentRow.Index < 0) return;

            txtDishCode.Text = dgvDAMenu.CurrentRow.Cells[1].Value.ToString();
            txtDisPosition.Text = dgvDAMenu.CurrentRow.Cells[2].Value?.ToString() ?? "";
            txtEngName.Text = dgvDAMenu.CurrentRow.Cells[3].Value.ToString();
            txtOtherName.Text = dgvDAMenu.CurrentRow.Cells[4].Value.ToString();
            txtWLarge.Text = dgvDAMenu.CurrentRow.Cells[5].Value?.ToString() ?? "";
            txtWRegular.Text = dgvDAMenu.CurrentRow.Cells[6].Value?.ToString() ?? "";
            txtWSmall.Text = dgvDAMenu.CurrentRow.Cells[7].Value?.ToString() ?? "";
            txtSLarge.Text = dgvDAMenu.CurrentRow.Cells[8].Value?.ToString() ?? "";
            txtSRegular.Text = dgvDAMenu.CurrentRow.Cells[9].Value?.ToString() ?? "";
            txtSSmall.Text = dgvDAMenu.CurrentRow.Cells[10].Value?.ToString() ?? "";

            string[] strMenuCate = dgvDAMenu.CurrentRow.Cells[22].Value.ToString().Split(',');
            if (strMenuCate.Length <= 0)
            {
                //cmbBoxMenuCate1.SelectedIndex = 0;
                //cmbBoxMenuCate2.SelectedIndex = 0;
                //cmbBoxMenuCate3.SelectedIndex = 0;
                cmbBoxMenuCate1.Text = "";
                cmbBoxMenuCate2.Text = "";
                cmbBoxMenuCate3.Text = "";
            }
            else if (strMenuCate.Length == 1)
            {
                cmbBoxMenuCate1.Text = strMenuCate[0];
                //cmbBoxMenuCate2.SelectedIndex = 0;
                //cmbBoxMenuCate3.SelectedIndex = 0;
                cmbBoxMenuCate2.Text = "";
                cmbBoxMenuCate3.Text = "";
            }
            else if (strMenuCate.Length == 2)
            {
                cmbBoxMenuCate1.Text = strMenuCate[0];
                cmbBoxMenuCate2.Text = strMenuCate[1];
                //cmbBoxMenuCate3.SelectedIndex = 0;
                cmbBoxMenuCate3.Text = "";
            }
            else if (strMenuCate.Length == 3)
            {
                cmbBoxMenuCate1.Text = strMenuCate[0];
                cmbBoxMenuCate2.Text = strMenuCate[1];
                cmbBoxMenuCate3.Text = strMenuCate[2];
            }
            //if (strMenuCate.Length == 2) cmbBoxMenuCate2.Text = strMenuCate[1];
            //if (strMenuCate.Length == 3) cmbBoxMenuCate3.Text = strMenuCate[2];

            cmbBoxSplySft.Text = dgvDAMenu.CurrentRow.Cells[12].Value?.ToString() ?? "";
            chkBoxPrtOrderByDept.Checked = dgvDAMenu.CurrentRow.Cells[13]?.ToString().Equals("Y") ?? false;
            chkBoxPrtOrderX.Checked = dgvDAMenu.CurrentRow.Cells[14]?.ToString().Equals("Y") ?? false;

            //chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[16].Value == null ? false : dgvDAMenu.CurrentRow.Cells[16].Value.ToString().Equals("Y");
            //chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[17].Value == null ? false : dgvDAMenu.CurrentRow.Cells[16].Value.ToString().Equals("Y");
            //chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[18].Value == null ? false : dgvDAMenu.CurrentRow.Cells[16].Value.ToString().Equals("Y");
            //chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[19].Value == null ? false : dgvDAMenu.CurrentRow.Cells[16].Value.ToString().Equals("Y");
            //chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[20].Value == null ? false : dgvDAMenu.CurrentRow.Cells[16].Value.ToString().Equals("Y");

            chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[16].Value?.ToString().Equals("Y") ?? false;
            chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[17].Value?.ToString().Equals("Y") ?? false;
            chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[18].Value?.ToString().Equals("Y") ?? false;
            chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[19].Value?.ToString().Equals("Y") ?? false;
            chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[20].Value?.ToString().Equals("Y") ?? false;
        }

        private void btnDASave_Click(object sender, EventArgs e)
        {
            TAMenuItemInfo taMenuItem = new TAMenuItemInfo();

            taMenuItem.DishCode = txtDishCode.Text;
            taMenuItem.DisplayPosition = txtDisPosition.Text;
            taMenuItem.EnglishName = txtEngName.Text;
            taMenuItem.OtherName = txtOtherName.Text;
            taMenuItem.wLarge = txtWLarge.Text;
            taMenuItem.wRegular = txtWRegular.Text;
            taMenuItem.wSmall = txtWSmall.Text;
            taMenuItem.SpecialLarge = txtSLarge.Text;
            taMenuItem.SpecialRegular = txtSRegular.Text;
            taMenuItem.SpecialSmall = txtSSmall.Text;

            taMenuItem.BtnColor = "";

            taMenuItem.IsUnavailable = chkUnavailable.Checked ? "Y" : "N";
            taMenuItem.IsNegativePrice = chkNegativePrice.Checked ? "Y" : "N";
            taMenuItem.IsDiscountable = chkDisountable.Checked ? "Y" : "N";
            taMenuItem.IsWithoutVAT = chkDisountable.Checked ? "Y" : "N";
            taMenuItem.IsInventoryCheck = chkInventoryCheck.Checked ? "Y" : "N";

            string strMenuCate = "";
            strMenuCate = cmbBoxMenuCate1.Text + "," + cmbBoxMenuCate2.Text + "," + cmbBoxMenuCate3.Text;
            taMenuItem.MenuCateID = strMenuCate;

            taMenuItem.SupplyShift = cmbBoxSplySft.Text;
            taMenuItem.PrinterName = chkBoxPrtOrderByDept.Checked ? "Y" : "N";
            taMenuItem.PrinterOrder = chkBoxPrtOrderX.Checked ? "Y" : "N";

            taMenuItem.Qty = "0";

            taMenuItem.MenuSetID = btnDAGuid.ToString();

            if (iStatus == 1)
            {
                taMenuItem.SystemKey = Guid.NewGuid();
                _control.AddEntity(taMenuItem);
            }
            else //if (iStatus == 2)
            {
                if (dgvDAMenu.CurrentRow != null)
                {
                    taMenuItem.SystemKey = new Guid(dgvDAMenu.CurrentRow.Cells[0].Value.ToString());
                    _control.UpdateEntity(taMenuItem);
                }
            }

            new OnLoadSystemCommonData().GetTAMenuItemList();
            dgvDAMenu.DataSource = CommonData.TaMenuItemList;

            btnDAAdd.Enabled = true;
            btnDACopy.Enabled = true;
            btnDADel.Enabled = true;
            //btnDASave.Enabled = false;
            //btnDAEdit.Enabled = true;

            //SetCtlEnable(false);

            iStatus = 0;
        }

        private void SetCtlEnable(bool bl)
        {
            //txtDishCode.Enabled = bl;
            //txtDisPosition.Enabled = bl;
            //txtEngName.Enabled = bl;
            //txtOtherName.Enabled = bl;
            //txtWLarge.Enabled = bl;
            //txtWRegular.Enabled = bl;
            //txtWSmall.Enabled = bl;
            //txtSLarge.Enabled = bl;
            //txtSRegular.Enabled = bl;
            //txtSSmall.Enabled = bl;

            //chkUnavailable.Enabled = bl;
            //chkNegativePrice.Enabled = bl;
            //chkDisountable.Enabled = bl;
            //chkWithoutVAT.Enabled = bl;
            //chkInventoryCheck.Enabled = bl;
            //chkUnavailable.Checked = bl;
            //chkNegativePrice.Checked = bl;
            //chkDisountable.Checked = bl;
            //chkWithoutVAT.Checked = bl;
            //chkInventoryCheck.Checked = bl;

            //cmbBoxSplySft.Enabled = bl;
            //chkBoxPrtOrderByDept.Enabled = bl;
            //chkBoxPrtOrderX.Enabled = bl;

            //cmbBoxMenuCate1.Enabled = bl;
            //cmbBoxMenuCate2.Enabled = bl;
            //cmbBoxMenuCate3.Enabled = bl;
        }

        private void btnDADel_Click(object sender, EventArgs e)
        {
            if (dgvDAMenu.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetTAMenuItemList();
            var taMenuItem =
                CommonData.TaMenuItemList.FirstOrDefault(s => s.SystemKey.Equals(dgvDAMenu.CurrentRow.Cells[0].Value));
            if (taMenuItem != null) _control.DeleteEntity(taMenuItem);

            //刷新数据
            new OnLoadSystemCommonData().GetTAMenuItemList();
            dgvDAMenu.DataSource = CommonData.TaMenuItemList;
        }

        private void btnDACopy_Click(object sender, EventArgs e)
        {
            iStatus = 1;

            txtDishCode.Text = "";

            btnDAAdd.Enabled = false;
            //btnDAEdit.Enabled = false;
            btnDACopy.Enabled = false;
            btnDADel.Enabled = false;
            btnDASave.Enabled = true;

            //txtDishCode.Enabled = true;
            //txtDisPosition.Enabled = true;
            //txtEngName.Enabled = true;
            //txtOtherName.Enabled = true;
            //txtWLarge.Enabled = true;
            //txtWRegular.Enabled = true;
            //txtWSmall.Enabled = true;
            //txtSLarge.Enabled = true;
            //txtSRegular.Enabled = true;
            //txtSSmall.Enabled = true;

            //chkUnavailable.Enabled = true;
            //chkNegativePrice.Enabled = true;
            //chkDisountable.Enabled = true;
            //chkWithoutVAT.Enabled = true;
            //chkInventoryCheck.Enabled = true;
            chkUnavailable.Checked = false;
            chkNegativePrice.Checked = false;
            chkDisountable.Checked = false;
            chkWithoutVAT.Checked = false;
            chkInventoryCheck.Checked = false;

            //cmbBoxMenuCate1.Enabled = true;
            //cmbBoxMenuCate2.Enabled = true;
            //cmbBoxMenuCate3.Enabled = true;

            //cmbBoxSplySft.Enabled = true;
            //chkBoxPrtOrderByDept.Enabled = true;
            //chkBoxPrtOrderX.Enabled = true;
        }

        private void cmDABoxDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDAMenu.DataSource = string.IsNullOrEmpty(cmDABoxDish.Text) ? CommonData.TaMenuItemList.ToList() : CommonData.TaMenuItemList.Where(s => s.MenuCateID.Contains(cmDABoxDish.Text)).ToList();
        }

        private void cmSCBoxDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSCMenu.DataSource = string.IsNullOrEmpty(cmSCBoxDish.Text) ? CommonData.TaMenuItemList.ToList() : CommonData.TaMenuItemList.Where(s => s.MenuCateID.Contains(cmSCBoxDish.Text)).ToList();
        }

        private void cmTCBoxDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgvTCMenu.DataSource = CommonData.TaMenuItemList.Where(s => s.MenuCateID.Contains(cmTCBoxDish.Text)).ToList();
            dgvTCMenu.DataSource = string.IsNullOrEmpty(cmTCBoxDish.Text) ? CommonData.TaMenuItemList.ToList() : CommonData.TaMenuItemList.Where(s => s.MenuCateID.Contains(cmTCBoxDish.Text)).ToList();
        }

        private void btnSCExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnTCExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnTHExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cmTHBoxDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTHMenu.DataSource =
                CommonData.TaMenuItemList.Where(s => s.MenuCateID.Contains(cmTHBoxDish.Text)).ToList();
        }

        private void dgvSCMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSCMenu.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvSCMenu.CurrentRow == null) return;

            if (dgvSCMenu.CurrentRow.Index < 0) return;

            new OnLoadSystemCommonData().GetTAMenuItemSCList();
            var scMenuList =
                CommonData.TaMenuItemSCList.Where(
                    s =>
                        s.MenuSetID.Equals(btnSCGuid.ToString()) &&
                        s.MenuItemID.Equals(dgvSCMenu.CurrentRow.Cells[0].Value.ToString()));

            if (scMenuList.Any())
            {
                int i = 0;
                foreach (var scMenu in scMenuList)
                {
                    scTxtEngName[i].Text = scMenu.EnglishName;
                    scTxtOtherName[i].Text = scMenu.OtherName;
                    scTxtPricce[i].Text = scMenu.AddPrice;
                    scChkApd[i].Checked = scMenu.AutoAppend.Equals("Y");

                    i++;
                }
                chkSCEnableChoices.Checked = scMenuList.FirstOrDefault().IsEnableChoices.Equals("Y");
            }
            else
            {
                for (int i = 0; i < 17; i++)
                {
                    scTxtEngName[i].Text = "";
                    scTxtOtherName[i].Text = "";
                    scTxtPricce[i].Text = "";
                    scChkApd[i].Checked = false;
                }
            }
        }

        private void btnSCSave_Click(object sender, EventArgs e)
        {
            //删除原有的关联
            var qDelList =
                CommonData.TaMenuItemSCList.Where(
                    s =>
                        s.MenuSetID.Equals(btnSCGuid.ToString()) &&
                        s.MenuItemID.Equals(dgvSCMenu.CurrentRow.Cells[0].Value.ToString()));
            foreach (var taMenuItemScInfo in qDelList)
            {
                _control.DeleteEntity(taMenuItemScInfo);
            }

            for (int i = 0; i < 17; i++)
            {
                TAMenuItemSCInfo scMenuItem = new TAMenuItemSCInfo();
                if (!string.IsNullOrEmpty(scTxtEngName[i].Text) &&
                    !string.IsNullOrEmpty(scTxtOtherName[i].Text) &&
                    !string.IsNullOrEmpty(scTxtPricce[i].Text))
                {
                    scMenuItem.SystemKey = Guid.NewGuid();
                    scMenuItem.MenuItemID = dgvSCMenu.CurrentRow.Cells[0].Value.ToString();
                    scMenuItem.MenuSetID = btnSCGuid.ToString();
                    scMenuItem.EnglishName = scTxtEngName[i].Text;
                    scMenuItem.OtherName = scTxtOtherName[i].Text;
                    scMenuItem.AddPrice = scTxtPricce[i].Text;
                    scMenuItem.AutoAppend = scChkApd[i].Checked ? "Y" : "N";
                    scMenuItem.IsEnableChoices = chkSCEnableChoices.Checked ? "Y" : "N";
                    _control.AddEntity(scMenuItem);
                }
            }
        }

        private void btnTCSave_Click(object sender, EventArgs e)
        {
            //删除原有的关联
            var qDelList =
                CommonData.TaMenuItemTCList.Where(
                    s =>
                        s.MenuSetID.Equals(btnTCGuid.ToString()) &&
                        s.MenuItemID.Equals(dgvTCMenu.CurrentRow.Cells[0].Value.ToString()));
            foreach (var taMenuItemTcInfo in qDelList)
            {
                _control.DeleteEntity(taMenuItemTcInfo);
            }

            for (int i = 0; i < 17; i++)
            {
                TAMenuItemTCInfo tcMenuItem = new TAMenuItemTCInfo();
                if (!string.IsNullOrEmpty(tcTxtEngName[i].Text) &&
                    !string.IsNullOrEmpty(tcTxtOtherName[i].Text) &&
                    !string.IsNullOrEmpty(tcTxtPricce[i].Text))
                {
                    tcMenuItem.SystemKey = Guid.NewGuid();
                    tcMenuItem.MenuItemID = dgvTCMenu.CurrentRow.Cells[0].Value.ToString();
                    tcMenuItem.MenuSetID = btnTCGuid.ToString();
                    tcMenuItem.EnglishName = tcTxtEngName[i].Text;
                    tcMenuItem.OtherName = tcTxtOtherName[i].Text;
                    tcMenuItem.AddPrice = tcTxtPricce[i].Text;
                    tcMenuItem.AutoAppend = tcChkApd[i].Checked ? "Y" : "N";
                    tcMenuItem.IsEnableChoices = chkTCEnableChoices.Checked ? "Y" : "N";
                    _control.AddEntity(tcMenuItem);
                }
            }
        }

        private void dgvTCMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTCMenu.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvTCMenu.CurrentRow == null) return;

            if (dgvTCMenu.CurrentRow.Index < 0) return;

            new OnLoadSystemCommonData().GetTAMenuItemTCList();
            var tcMenuList = CommonData.TaMenuItemTCList.Where(s =>
                        s.MenuSetID.Equals(btnTCGuid.ToString()) &&
                        s.MenuItemID.Equals(dgvTCMenu.CurrentRow.Cells[0].Value.ToString()));

            if (tcMenuList.Any())
            {
                int i = 0;
                foreach (var tcMenu in tcMenuList)
                {
                    tcTxtEngName[i].Text = tcMenu.EnglishName;
                    tcTxtOtherName[i].Text = tcMenu.OtherName;
                    tcTxtPricce[i].Text = tcMenu.AddPrice;
                    tcChkApd[i].Checked = tcMenu.AutoAppend.Equals("Y");

                    i++;
                }
                chkTCEnableChoices.Checked = tcMenuList.FirstOrDefault().IsEnableChoices.Equals("Y");
            }
            else
            {
                for (int i = 0; i < 17; i++)
                {
                    tcTxtEngName[i].Text = "";
                    tcTxtOtherName[i].Text = "";
                    tcTxtPricce[i].Text = "";
                    tcChkApd[i].Checked = false;
                }
            }
        }

        private void btnTHSave_Click(object sender, EventArgs e)
        {
            var qDelList = CommonData.TaMenuItemTHList.Where(s =>
                        s.MenuSetID.Equals(btnTHGuid.ToString()) &&
                        s.MenuItemID.Equals(dgvTHMenu.CurrentRow.Cells[0].Value.ToString()));
            foreach (var taMenuItemThInfo in qDelList)
            {
                _control.DeleteEntity(taMenuItemThInfo);
            }

            for (int i = 0; i < 17; i++)
            {
                TAMenuItemTHInfo thMenuItem = new TAMenuItemTHInfo();
                if (!string.IsNullOrEmpty(thTxtEngName[i].Text) &&
                    !string.IsNullOrEmpty(thTxtOtherName[i].Text) &&
                    !string.IsNullOrEmpty(thTxtPricce[i].Text))
                {
                    thMenuItem.SystemKey = Guid.NewGuid();
                    thMenuItem.MenuItemID = dgvTHMenu.CurrentRow.Cells[0].Value.ToString();
                    thMenuItem.MenuSetID = btnTHGuid.ToString();
                    thMenuItem.EnglishName = thTxtEngName[i].Text;
                    thMenuItem.OtherName = thTxtOtherName[i].Text;
                    thMenuItem.AddPrice = thTxtPricce[i].Text;
                    thMenuItem.AutoAppend = thChkApd[i].Checked ? "Y" : "N";
                    thMenuItem.IsEnableChoices = chkTHEnableChoices.Checked ? "Y" : "N";
                    _control.AddEntity(thMenuItem);
                }
            }
        }

        private void dgvTHMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTHMenu.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvTHMenu.CurrentRow == null) return;

            if (dgvTHMenu.CurrentRow.Index < 0) return;

            new OnLoadSystemCommonData().GetTAMenuItemTHList();
            var thMenuList = CommonData.TaMenuItemTHList.Where(s =>
                        s.MenuSetID.Equals(btnTHGuid.ToString()) &&
                        s.MenuItemID.Equals(dgvTHMenu.CurrentRow.Cells[0].Value.ToString()));

            if (thMenuList.Any())
            {
                int i = 0;
                foreach (var thMenu in thMenuList)
                {
                    thTxtEngName[i].Text = thMenu.EnglishName;
                    thTxtOtherName[i].Text = thMenu.OtherName;
                    thTxtPricce[i].Text = thMenu.AddPrice;
                    thChkApd[i].Checked = thMenu.AutoAppend.Equals("Y");

                    i++;
                }
                chkTHEnableChoices.Checked = thMenuList.FirstOrDefault().IsEnableChoices.Equals("Y");
            }
            else
            {
                for (int i = 0; i < 17; i++)
                {
                    thTxtEngName[i].Text = "";
                    thTxtOtherName[i].Text = "";
                    thTxtPricce[i].Text = "";
                    thChkApd[i].Checked = false;
                }
            }
        }

        private void btnSubMenuAdd_Click(object sender, EventArgs e)
        {
            iSubMenuStatus = 1;

            //txtSMDishCode.Enabled = true;
            //txtSMDisplayPosition.Enabled = true;
            //txtSMEngName.Enabled = true;
            //txtSMOtherName.Enabled = true;
            //txtSMPrice.Enabled = true;
            //chkSMUnavailable.Enabled = true;
            //chkSMDisountable.Enabled = true;
            //chkSMInventoryCheck.Enabled = true;
            //chkSMNegativePrice.Enabled = true;
            //chkSMWithoutVAT.Enabled = true;

            txtSMDishCode.Text = "";
            txtSMDisplayPosition.Text = "";
            txtSMEngName.Text = "";
            txtSMOtherName.Text = "";
            txtSMPrice.Text = "";
            chkSMUnavailable.Checked = false;
            chkSMDisountable.Checked = false;
            chkSMInventoryCheck.Checked = false;
            chkSMNegativePrice.Checked = false;
            chkSMWithoutVAT.Checked = false;

            //cmbSMSupplyShift.Enabled = true;
            cmbSMSupplyShift.SelectedIndex = 0;
            //chkSMPrtName.Enabled = true;
            chkSMPrtName.Checked = false;
            //chkSMPrtOrder.Enabled = true;
            chkSMPrtOrder.Checked = false;

            for (int i = 0; i < 15; i++)
            {
                txtSubMenuEngName[i].Enabled = true;
                txtSubMenuEngName[i].Text = "";
                txtSubMenuOtherName[i].Enabled = true;
                txtSubMenuOtherName[i].Text = "";
            }

            btnSubMenuDel.Enabled = false;
            //btnSubMenuEdit.Enabled = false;
            btnSubMenuSave.Enabled = true;
            btnSubMenuAdd.Enabled = true;
        }

        private void btnSubMenuEdit_Click(object sender, EventArgs e)
        {
            iSubMenuStatus = 2;

            txtSMDishCode.Enabled = true;
            txtSMDisplayPosition.Enabled = true;
            txtSMEngName.Enabled = true;
            txtSMOtherName.Enabled = true;
            txtSMPrice.Enabled = true;
            chkSMUnavailable.Enabled = true;
            chkSMDisountable.Enabled = true;
            chkSMInventoryCheck.Enabled = true;
            chkSMNegativePrice.Enabled = true;
            chkSMWithoutVAT.Enabled = true;

            cmbSMSupplyShift.Enabled = true;
            chkSMPrtName.Enabled = true;
            chkSMPrtOrder.Enabled = true;            

            for (int i = 0; i < 15; i++)
            {
                txtSubMenuEngName[i].Enabled = true;
                txtSubMenuOtherName[i].Enabled = true;
            }

            btnSubMenuDel.Enabled = false;
            //btnSubMenuEdit.Enabled = false;
            btnSubMenuSave.Enabled = true;
            btnSubMenuAdd.Enabled = false;
        }

        private void btnSubMenuDel_Click(object sender, EventArgs e)
        {
            if (dgvSubMenu.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetTAMenuItemSubMenuList();
            new OnLoadSystemCommonData().GetTAMenuItemSubMenuDetailList();

            var taMenuItemSubMenuDetail = CommonData.TaMenuItemSubMenuDetailList.Where(s => s.SubMenuID.Equals(dgvSubMenu.CurrentRow.Cells[0].Value.ToString()));
            foreach (var subMenuDetail in taMenuItemSubMenuDetail) { _control.DeleteEntity(subMenuDetail); }

            var taMenuItemSubMenu = CommonData.TaMenuItemSubMenuList.FirstOrDefault(s => s.SystemKey.Equals(new Guid(dgvSubMenu.CurrentRow.Cells[0].Value.ToString())));
            if (taMenuItemSubMenu != null) _control.DeleteEntity(taMenuItemSubMenu);
            
            //刷新数据
            new OnLoadSystemCommonData().GetTAMenuItemSubMenuList();
            new OnLoadSystemCommonData().GetTAMenuItemSubMenuDetailList();
            dgvSubMenu.DataSource = CommonData.TaMenuItemSubMenuList;
        }

        private void btnSubMenuSave_Click(object sender, EventArgs e)
        {
            TAMenuItemSubMenuInfo taMenuItemSubMenuInfo = new TAMenuItemSubMenuInfo();

            taMenuItemSubMenuInfo.DishCode = txtSMDishCode.Text;
            taMenuItemSubMenuInfo.DisplayPosition = txtSMDisplayPosition.Text;
            taMenuItemSubMenuInfo.EnglishName = txtSMEngName.Text;
            taMenuItemSubMenuInfo.OtherName = txtSMOtherName.Text;
            taMenuItemSubMenuInfo.Price = txtSMPrice.Text;
            taMenuItemSubMenuInfo.IsUnavailable = chkSMUnavailable.Checked ? "Y" : "N";
            taMenuItemSubMenuInfo.IsDiscountable = chkSMDisountable.Checked ? "Y" : "N";
            taMenuItemSubMenuInfo.IsInventoryChk = chkSMInventoryCheck.Checked ? "Y" : "N";
            taMenuItemSubMenuInfo.IsNegativePrice = chkSMNegativePrice.Checked ? "Y" : "N";
            taMenuItemSubMenuInfo.IsWithoutVAT = chkSMWithoutVAT.Checked ? "Y" : "N";
            taMenuItemSubMenuInfo.SplyShift = cmbSMSupplyShift.Text;
            taMenuItemSubMenuInfo.IsPrtName = chkSMPrtName.Checked ? "Y" : "N";
            taMenuItemSubMenuInfo.IsPrtOrder = chkSMPrtOrder.Checked ? "Y" : "N";
    
            if (iSubMenuStatus == 1) //Add
            {
                taMenuItemSubMenuInfo.SystemKey = Guid.NewGuid();
                _control.AddEntity(taMenuItemSubMenuInfo);
            }
            else //if (iSubMenuStatus == 2) //Edit
            {
                taMenuItemSubMenuInfo.SystemKey = new Guid(dgvSubMenu.CurrentRow.Cells[0].Value.ToString());
                _control.UpdateEntity(taMenuItemSubMenuInfo);
            }

            var qDelList = new List<TAMenuItemSubMenuDetailInfo>();
            if (iSubMenuStatus == 1)
                qDelList = CommonData.TaMenuItemSubMenuDetailList.Where(s =>
                        s.SubMenuID.Equals(taMenuItemSubMenuInfo.SystemKey.ToString())).ToList();            
            else //if (iSubMenuStatus == 2)
                qDelList = CommonData.TaMenuItemSubMenuDetailList.Where(s =>
                        s.SubMenuID.Equals(dgvSubMenu.CurrentRow.Cells[0].Value.ToString())).ToList();
            foreach (var taMenuItemThInfo in qDelList)
            {
                _control.DeleteEntity(taMenuItemThInfo);
            }

            for (int i = 0; i < 15; i++)
            {
                TAMenuItemSubMenuDetailInfo taMenuItemSubMenuDetailInfo = new TAMenuItemSubMenuDetailInfo();
                if (!string.IsNullOrEmpty(txtSubMenuEngName[i].Text) &&
                    !string.IsNullOrEmpty(txtSubMenuOtherName[i].Text))
                {
                    taMenuItemSubMenuDetailInfo.SystemKey = Guid.NewGuid();
                    taMenuItemSubMenuDetailInfo.EnglishName = txtSubMenuEngName[i].Text;
                    taMenuItemSubMenuDetailInfo.OtherName = txtSubMenuOtherName[i].Text;
                    if (iSubMenuStatus == 1)
                        taMenuItemSubMenuDetailInfo.SubMenuID = taMenuItemSubMenuInfo.SystemKey.ToString();
                    else if (iSubMenuStatus == 2)
                        taMenuItemSubMenuDetailInfo.SubMenuID = dgvSubMenu.CurrentRow.Cells[0].Value.ToString();
                    _control.AddEntity(taMenuItemSubMenuDetailInfo);
                }
            }

            //txtSMDishCode.Enabled = false;
            //txtSMDisplayPosition.Enabled = false;
            //txtSMEngName.Enabled = false;
            //txtSMOtherName.Enabled = false;
            //txtSMPrice.Enabled = false;
            //chkSMUnavailable.Enabled = false;
            //chkSMDisountable.Enabled = false;
            //chkSMInventoryCheck.Enabled = false;
            //chkSMNegativePrice.Enabled = false;
            //chkSMWithoutVAT.Enabled = false;

            //cmbSMSupplyShift.Enabled = false;
            //chkSMPrtName.Enabled = false;
            //chkSMPrtOrder.Enabled = false;

            for (int i = 0; i < 15; i++)
            {
                txtSubMenuEngName[i].Enabled = false;
                txtSubMenuOtherName[i].Enabled = false;
            }

            btnSubMenuDel.Enabled = true;
            //btnSubMenuEdit.Enabled = true;
            btnSubMenuSave.Enabled = false;
            btnSubMenuAdd.Enabled = true;

            new OnLoadSystemCommonData().GetTAMenuItemSubMenuList();
            dgvSubMenu.DataSource = CommonData.TaMenuItemSubMenuList;
        }

        private void btnSubMenuExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dgvSubMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSubMenu.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvSubMenu.CurrentRow == null) return;

            if (dgvSubMenu.CurrentRow.Index < 0) return;

            txtSMDishCode.Text = dgvSubMenu.CurrentRow.Cells[1].Value.ToString();
            txtSMDisplayPosition.Text = dgvSubMenu.CurrentRow.Cells[2].Value.ToString();
            txtSMEngName.Text = dgvSubMenu.CurrentRow.Cells[3].Value.ToString();
            txtSMOtherName.Text = dgvSubMenu.CurrentRow.Cells[4].Value.ToString();
            txtSMPrice.Text = dgvSubMenu.CurrentRow.Cells[5].Value.ToString();

            chkSMUnavailable.Checked = dgvSubMenu.CurrentRow.Cells[6].Value.ToString().Equals("Y");
            chkSMDisountable.Checked = dgvSubMenu.CurrentRow.Cells[7].Value.ToString().Equals("Y");
            chkSMInventoryCheck.Checked = dgvSubMenu.CurrentRow.Cells[8].Value.ToString().Equals("Y");
            chkSMNegativePrice.Checked = dgvSubMenu.CurrentRow.Cells[9].Value.ToString().Equals("Y");
            chkSMWithoutVAT.Checked = dgvSubMenu.CurrentRow.Cells[10].Value.ToString().Equals("Y");

            cmbSMSupplyShift.Text = dgvSubMenu.CurrentRow.Cells[11].Value.ToString();
            chkSMPrtName.Checked = dgvSubMenu.CurrentRow.Cells[12].Value.ToString().Equals("Y");
            chkSMPrtOrder.Checked = dgvSubMenu.CurrentRow.Cells[13].Value.ToString().Equals("Y");

            for (int j = 0; j < 15; j++)
            {
                txtSubMenuEngName[j].Text = "";
                txtSubMenuOtherName[j].Text = "";
            }

            new OnLoadSystemCommonData().GetTAMenuItemSubMenuDetailList();
            var taMenuItemSubMenuDetail =
                CommonData.TaMenuItemSubMenuDetailList.Where(
                    s => s.SubMenuID.Equals(dgvSubMenu.CurrentRow.Cells[0].Value.ToString()));

            int i = 0;
            foreach (var taMenuItemSubMenuDetailInfo in taMenuItemSubMenuDetail)
            {
                txtSubMenuEngName[i].Text = taMenuItemSubMenuDetailInfo.EnglishName;
                txtSubMenuOtherName[i].Text = taMenuItemSubMenuDetailInfo.OtherName;
                i++;
            }

        }

        private void btnImportMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Please select file";
            fileDialog.Filter = "Images|*.xls;*.bmp;*.xlsx";

            string strExcelFilePath = "";
            if (fileDialog.ShowDialog() == DialogResult.OK) { strExcelFilePath = fileDialog.FileName; }

            if (!string.IsNullOrEmpty(strExcelFilePath))
            {
                MessageBox.Show(DALCommon.ImportMenuItem(strExcelFilePath, "TA")
                    ? "Data import is successful!"
                    : "Data import failed!");
            }
        }

        private void btnImportMenuCate_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Please select file";
            fileDialog.Filter = "Images|*.xls;*.bmp;*.xlsx";

            string strExcelFilePath = "";
            if (fileDialog.ShowDialog() == DialogResult.OK) { strExcelFilePath = fileDialog.FileName; }

            if (!string.IsNullOrEmpty(strExcelFilePath))
            {
                MessageBox.Show(DALCommon.ImportMenuCate(strExcelFilePath, "TA CATE")
                    ? "Data import is successful!"
                    : "Data import failed!");
            }
        }

    }
}

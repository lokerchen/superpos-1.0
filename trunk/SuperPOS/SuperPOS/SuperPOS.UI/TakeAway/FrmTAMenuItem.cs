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
using SuperPOS.UI.Admin;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAMenuItem : Form
    {
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
        public FrmTAMenuItem()
        {
            InitializeComponent();
        }

        public FrmTAMenuItem(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
        }

        private void FrmTAMenuItem_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAMenuCategory();
            onLoadSystemCommonData.GetTAMenuItemList();

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
                //默认值
                btnDAGuid = tsl.SystemKey;
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
                //默认值
                btnSCGuid = tsl.SystemKey;
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
                //默认值
                btnTCGuid = tsl.SystemKey;
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
                //默认值
                btnTHGuid = tsl.SystemKey;
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
            #region DataGrid控制
            dgvDAMenu.Columns[0].Visible = false;
            dgvDAMenu.Columns[2].Visible = false;
            dgvDAMenu.Columns[4].Visible = false;
            dgvDAMenu.Columns[5].Visible = false;
            dgvDAMenu.Columns[6].Visible = false;
            dgvDAMenu.Columns[7].Visible = false;
            dgvDAMenu.Columns[8].Visible = false;
            dgvDAMenu.Columns[9].Visible = false;
            dgvDAMenu.Columns[10].Visible = false;
            dgvDAMenu.Columns[11].Visible = false;
            dgvDAMenu.Columns[12].Visible = false;
            dgvDAMenu.Columns[13].Visible = false;
            dgvDAMenu.Columns[14].Visible = false;
            dgvDAMenu.Columns[15].Visible = false;
            dgvDAMenu.Columns[16].Visible = false;
            dgvDAMenu.Columns[17].Visible = false;
            dgvDAMenu.Columns[18].Visible = false;
            dgvDAMenu.Columns[19].Visible = false;
            dgvDAMenu.Columns[20].Visible = false;
            dgvDAMenu.Columns[21].Visible = false;
            dgvDAMenu.Columns[0].HeaderText = @"Code";
            dgvDAMenu.Columns[0].Width = 40;
            dgvDAMenu.Columns[1].HeaderText = @"ItemName";
            #endregion

            #endregion
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
            }
            //if (btn1.BackColor = Color.Gray)
            //Console.Out.WriteLine(btnDAGuid.ToString());
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
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
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
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
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
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
        }

        private void btnDAExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDADishCodeSearch_Click(object sender, EventArgs e)
        {
            dgvDAMenu.DataSource = CommonData.TaMenuItemList.Where(s => s.DishCode.Equals(txtDADishCode.Text.Trim()));
        }

        private void btnSCDishCodeSearch_Click(object sender, EventArgs e)
        {
            dgvSCMenu.DataSource = CommonData.TaMenuItemList.Where(s => s.DishCode.Equals(txtSCDishCode.Text.Trim()));
        }

        private void btnTCDishCodeSearch_Click(object sender, EventArgs e)
        {
            dgvTCMenu.DataSource = CommonData.TaMenuItemList.Where(s => s.DishCode.Equals(txtTCDishCode.Text.Trim()));
        }

        private void btnTHDishCodeSearch_Click(object sender, EventArgs e)
        {
            dgvTHMenu.DataSource = CommonData.TaMenuItemList.Where(s => s.DishCode.Equals(txtTHDishCode.Text.Trim()));
        }

        private void btnDAAdd_Click(object sender, EventArgs e)
        {
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

            chkUnavailable.Checked = false;
            chkNegativePrice.Checked = false;
            chkDisountable.Checked = false;
            chkWithoutVAT.Checked = false;
            chkInventoryCheck.Checked = false;
            chkUnavailable.Enabled = true;
            chkNegativePrice.Enabled = true;
            chkDisountable.Enabled = true;
            chkWithoutVAT.Enabled = true;
            chkInventoryCheck.Enabled = true;

            btnDAEdit.Enabled = false;
            btnDADel.Enabled = false;
            btnDASave.Enabled = true;
        }
    }
}

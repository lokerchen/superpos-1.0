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

        private readonly EntityControl _control = new EntityControl();
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
            for (int i = 2; i < 23; i++) { dgvDAMenu.Columns[i].Visible = false; }
            //dgvDAMenu.Columns[2].Visible = false;
            //dgvDAMenu.Columns[4].Visible = false;
            //dgvDAMenu.Columns[5].Visible = false;
            //dgvDAMenu.Columns[6].Visible = false;
            //dgvDAMenu.Columns[7].Visible = false;
            //dgvDAMenu.Columns[8].Visible = false;
            //dgvDAMenu.Columns[9].Visible = false;
            //dgvDAMenu.Columns[10].Visible = false;
            //dgvDAMenu.Columns[11].Visible = false;
            //dgvDAMenu.Columns[12].Visible = false;
            //dgvDAMenu.Columns[13].Visible = false;
            //dgvDAMenu.Columns[14].Visible = false;
            //dgvDAMenu.Columns[15].Visible = false;
            //dgvDAMenu.Columns[16].Visible = false;
            //dgvDAMenu.Columns[17].Visible = false;
            //dgvDAMenu.Columns[18].Visible = false;
            //dgvDAMenu.Columns[19].Visible = false;
            //dgvDAMenu.Columns[20].Visible = false;
            //dgvDAMenu.Columns[21].Visible = false;
            //dgvDAMenu.Columns[22].Visible = false;
            //dgvDAMenu.Columns[23].Visible = false;
            //dgvDAMenu.Columns[24].Visible = false;
            //dgvDAMenu.Columns[25].Visible = false;
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
            iStatus = 1;

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

            cmbBoxSplySft.Enabled = true;
            chkBoxPrtOrderByDept.Enabled = true;
            chkBoxPrtOrderX.Enabled = true;

            cmbBoxMenuCate1.Enabled = true;
            cmbBoxMenuCate2.Enabled = true;
            cmbBoxMenuCate3.Enabled = true;

            btnDAEdit.Enabled = false;
            btnDADel.Enabled = false;
            btnDACopy.Enabled = false;
            btnDASave.Enabled = true;
        }

        private void BindCmbData()
        {
            var lstDeptCate = CommonData.TaMenuCategoryList.OrderBy(s => s.DisplayPosition).Select(lstDC => new { DeptCode = lstDC.EnglishName, SysKey = lstDC.SystemKey });
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
            txtDisPosition.Text = dgvDAMenu.CurrentRow.Cells[2].Value.ToString();
            txtEngName.Text = dgvDAMenu.CurrentRow.Cells[3].Value.ToString();
            txtOtherName.Text = dgvDAMenu.CurrentRow.Cells[4].Value.ToString();
            txtWLarge.Text = dgvDAMenu.CurrentRow.Cells[5].Value.ToString();
            txtWRegular.Text = dgvDAMenu.CurrentRow.Cells[6].Value.ToString();
            txtWSmall.Text = dgvDAMenu.CurrentRow.Cells[7].Value.ToString();
            txtSLarge.Text = dgvDAMenu.CurrentRow.Cells[8].Value.ToString();
            txtSRegular.Text = dgvDAMenu.CurrentRow.Cells[9].Value.ToString();
            txtSSmall.Text = dgvDAMenu.CurrentRow.Cells[10].Value.ToString();

            string[] strMenuCate = dgvDAMenu.CurrentRow.Cells[22].Value.ToString().Split(',');
            cmbBoxMenuCate1.Text = strMenuCate[0];
            cmbBoxMenuCate2.Text = strMenuCate[1];
            cmbBoxMenuCate3.Text = strMenuCate[2];

            cmbBoxSplySft.Text = dgvDAMenu.CurrentRow.Cells[12].Value.ToString();
            chkBoxPrtOrderByDept.Checked = dgvDAMenu.CurrentRow.Cells[13].Value.ToString().Equals("Y");
            chkBoxPrtOrderX.Checked = dgvDAMenu.CurrentRow.Cells[14].Value.ToString().Equals("Y");

            chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[16].Value.ToString().Equals("Y");
            chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[17].Value.ToString().Equals("Y");
            chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[18].Value.ToString().Equals("Y");
            chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[19].Value.ToString().Equals("Y");
            chkUnavailable.Checked = dgvDAMenu.CurrentRow.Cells[20].Value.ToString().Equals("Y");
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
            strMenuCate = cmbBoxMenuCate1.Text + "," + cmbBoxMenuCate2.Text + "," + cmbBoxMenuCate3.Text + ",";
            taMenuItem.MenuCateID = strMenuCate;

            taMenuItem.SupplyShift = cmbBoxSplySft.Text;
            taMenuItem.PrinterName = chkBoxPrtOrderByDept.Checked ? "Y" : "N";
            taMenuItem.PrinterOrder = chkBoxPrtOrderX.Checked ? "Y" : "N";

            taMenuItem.Qty = "0";

            taMenuItem.MenuSetID = "";

            if (iStatus == 1)
            {
                taMenuItem.SystemKey = Guid.NewGuid();
                _control.AddEntity(taMenuItem);
            }
            else if (iStatus == 2)
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
            btnDASave.Enabled = false;
        }
    }
}

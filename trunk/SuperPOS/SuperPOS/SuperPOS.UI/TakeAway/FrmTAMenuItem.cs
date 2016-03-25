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
        private Guid btnGuid = Guid.Empty;
        private Guid btnGuid1 = Guid.Empty;
        private Guid btnGuid2 = Guid.Empty;
        private Guid btnGuid3 = Guid.Empty;
        private Guid btnGuid4 = Guid.Empty;
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

            //cmBoxDish.DataSource = CommonData.TaMenuCategoryList.Select(s => new {});

            #region  Dish Attributes Menu Set 按钮
            btnDA1.Click += btn_Click;
            btnDA2.Click += btn_Click;
            btnDA3.Click += btn_Click;
            btnDA4.Click += btn_Click;

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
                        btnGuid1 = tsl.SystemKey;
                        break;
                    case "2":
                        btnDA2.Text = tsl.EnglishName;
                        btnGuid2 = tsl.SystemKey;
                        break;
                    case "3":
                        btnDA3.Text = tsl.EnglishName;
                        btnGuid3 = tsl.SystemKey;
                        break;
                    case "4":
                        btnDA4.Text = tsl.EnglishName;
                        btnGuid4 = tsl.SystemKey;
                        break;
                }
                //默认值
                btnGuid = tsl.SystemKey;
            }
            #endregion

            #region Dish Attributes category Search下拉菜单
            onLoadSystemCommonData.GetTAMenuCategory();
            cmDABoxDish.DataSource = CommonData.TaMenuCategoryList.Select(s => s.EnglishName).ToList();
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

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            switch (btn.Name)
            {
                case "btn1":
                    btnID = "1";
                    btn.BackColor = Color.CornflowerBlue;
                    btnDA2.BackColor = Color.Gray;
                    btnDA3.BackColor = Color.Gray;
                    btnDA4.BackColor = Color.Gray;
                    btnGuid = btnGuid1;
                    break;
                case "btn2":
                    btnID = "2";
                    btnDA1.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnDA3.BackColor = Color.Gray;
                    btnDA4.BackColor = Color.Gray;
                    btnGuid = btnGuid2;
                    break;
                case "btn3":
                    btnID = "3";
                    btnDA1.BackColor = Color.Gray;
                    btnDA2.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnDA4.BackColor = Color.Gray;
                    btnGuid = btnGuid3;
                    break;
                case "btn4":
                    btnID = "4";
                    btnDA1.BackColor = Color.Gray;
                    btnDA2.BackColor = Color.Gray;
                    btnDA3.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnGuid = btnGuid4;
                    break;
            }
            //if (btn1.BackColor = Color.Gray)
            Console.Out.WriteLine(btnGuid.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            //FrmAdminControlPanel frmAdminControl = new FrmAdminControlPanel();
            //frmAdminControl.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
        }
    }
}

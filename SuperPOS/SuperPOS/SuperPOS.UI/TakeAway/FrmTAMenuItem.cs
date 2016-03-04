using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.DAL;
using SuperPOS.UI.Admin;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAMenuItem : Form
    {
        private string btnID = "1";
        public FrmTAMenuItem()
        {
            InitializeComponent();
        }

        private void FrmTAMenuItem_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();

            #region Menu Set 按钮
            btn1.Click += btn_Click;
            btn2.Click += btn_Click;
            btn3.Click += btn_Click;
            btn4.Click += btn_Click;

            btn1.BackColor = Color.CornflowerBlue;
            btn2.BackColor = Color.Gray;
            btn3.BackColor = Color.Gray;
            btn4.BackColor = Color.Gray;

            onLoadSystemCommonData.GetTAMenuSet();

            foreach (var tsl in CommonData.TaMenuSetList.OrderBy(s => s.ID))
            {
                switch (tsl.ID)
                {
                    case "1":
                        btn1.Text = tsl.EnglishName;
                        break;
                    case "2":
                        btn2.Text = tsl.EnglishName;
                        break;
                    case "3":
                        btn3.Text = tsl.EnglishName;
                        break;
                    case "4":
                        btn4.Text = tsl.EnglishName;
                        break;
                }
            }
            #endregion

            #region Dish category Search下拉菜单
            onLoadSystemCommonData.GetTAMenuCategory();
            cmBoxDish.DataSource = CommonData.TaMenuCategoryList.Select(s => s.EnglishName).ToList();
            #endregion

            #region dgvMenu
            onLoadSystemCommonData.GetTAMenuItemList();
            dgvMenu.DataSource = CommonData.TaMenuItemList;
            #region DataGrid控制
            dgvMenu.Columns[0].Visible = false;
            dgvMenu.Columns[2].Visible = false;
            dgvMenu.Columns[4].Visible = false;
            dgvMenu.Columns[5].Visible = false;
            dgvMenu.Columns[6].Visible = false;
            dgvMenu.Columns[7].Visible = false;
            dgvMenu.Columns[8].Visible = false;
            dgvMenu.Columns[9].Visible = false;
            dgvMenu.Columns[10].Visible = false;
            dgvMenu.Columns[11].Visible = false;
            dgvMenu.Columns[12].Visible = false;
            dgvMenu.Columns[13].Visible = false;
            dgvMenu.Columns[14].Visible = false;
            dgvMenu.Columns[15].Visible = false;
            dgvMenu.Columns[16].Visible = false;
            dgvMenu.Columns[17].Visible = false;
            dgvMenu.Columns[18].Visible = false;
            dgvMenu.Columns[19].Visible = false;
            dgvMenu.Columns[20].Visible = false;
            dgvMenu.Columns[21].Visible = false;
            dgvMenu.Columns[0].HeaderText = @"Code";
            dgvMenu.Columns[0].Width = 40;
            dgvMenu.Columns[1].HeaderText = @"ItemName";
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
                    btn2.BackColor = Color.Gray;
                    btn3.BackColor = Color.Gray;
                    btn4.BackColor = Color.Gray;
                    break;
                case "btn2":
                    btnID = "2";
                    btn1.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btn3.BackColor = Color.Gray;
                    btn4.BackColor = Color.Gray;
                    break;
                case "btn3":
                    btnID = "3";
                    btn1.BackColor = Color.Gray;
                    btn2.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btn4.BackColor = Color.Gray;
                    break;
                case "btn4":
                    btnID = "4";
                    btn1.BackColor = Color.Gray;
                    btn2.BackColor = Color.Gray;
                    btn3.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    break;
            }
            //if (btn1.BackColor = Color.Gray)
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdminControlPanel frmAdminControl = new FrmAdminControlPanel();
            frmAdminControl.ShowDialog();
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

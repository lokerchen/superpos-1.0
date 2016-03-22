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
    public partial class FrmTAMenuCategory : Form
    {
        private int iStatus;
        private readonly EntityControl _control = new EntityControl();
        private UserInfo userInfo = new UserInfo();

        public FrmTAMenuCategory()
        {
            InitializeComponent();
        }

        public FrmTAMenuCategory(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            iStatus = 1;

            txtEnglishName.Enabled = true;
            txtOtherName.Enabled = true;
            txtDisplayPosition.Enabled = true;

            OnLoadSystemCommonData onLoad = new OnLoadSystemCommonData();
            onLoad.GetTADeptCode();
            List<string> lst = new List<string>();
            cmbBoxDeptCode.DataSource = CommonData.TaDeptCodeList.Select(s => s.DeptCode + "-" + s.DeptName).ToList();

            chkHotKey.Checked = false;
            txtDishCode.Enabled = false;

            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            iStatus = 2;

            txtEnglishName.Enabled = true;
            txtOtherName.Enabled = true;
            txtDisplayPosition.Enabled = true;

            OnLoadSystemCommonData onLoad = new OnLoadSystemCommonData();
            onLoad.GetTADeptCode();
            List<string> lst = new List<string>();
            cmbBoxDeptCode.DataSource = CommonData.TaDeptCodeList.Select(s => s.DeptCode + "-" + s.DeptName).ToList();

            chkHotKey.Checked = false;
            txtDishCode.Enabled = false;

            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            btnAdd.Enabled = false;
            btnDel.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEnglishName.Text))
            {
                MessageBox.Show("English Name can not empty,please entry!");
                return;
            }

            if (string.IsNullOrEmpty(txtOtherName.Text))
            {
                MessageBox.Show("Other Name can not empty,please entry!");
                return;
            }

            if (string.IsNullOrEmpty(txtDisplayPosition.Text))
            {
                MessageBox.Show("Other Name can not empty,please entry!");
                return;
            }

            TAMenuCategoryInfo taMenuCategoryInfo = new TAMenuCategoryInfo();
            taMenuCategoryInfo.EnglishName = txtEnglishName.Text.Trim();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvCategory.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetTAMenuCategory();
            var menuCategoryInfo = CommonData.TaMenuCategoryList.FirstOrDefault(s => s.SystemKey.Equals(dgvCategory.CurrentRow.Cells[0].Value));
            if (menuCategoryInfo != null) _control.DeleteEntity(menuCategoryInfo);

            //刷新数据
            new OnLoadSystemCommonData().GetTAMenuCategory();
            dgvCategory.DataSource = CommonData.TaMenuCategoryList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            //FrmAdminControlPanel frmAdmin = new FrmAdminControlPanel();
            //frmAdmin.ShowDialog();
        }

        private void FrmTAMenuCategory_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoad = new OnLoadSystemCommonData();
            onLoad.GetTAMenuCategory();

            dgvCategory.DataSource = CommonData.TaMenuCategoryList;

            dgvCategory.Columns[0].Visible = false;
            dgvCategory.Columns[4].Visible = false;
            dgvCategory.Columns[5].Visible = false;
            dgvCategory.Columns[6].Visible = false;
            dgvCategory.Columns[7].Visible = false;

        }

        private void chkHotKey_CheckedChanged(object sender, EventArgs e)
        {
            txtDishCode.Enabled = chkHotKey.Checked;
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategory.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvCategory.CurrentRow == null) return;

            if (dgvCategory.CurrentRow.Index < 0) return;
            //ShiftCode
            txtEnglishName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
            //ShiftName
            txtOtherName.Text = dgvCategory.CurrentRow.Cells[2].Value.ToString();
            //OtherName
            txtDisplayPosition.Text = dgvCategory.CurrentRow.Cells[3].Value.ToString();

            chkHotKey.Checked = dgvCategory.CurrentRow.Cells[4].Value.ToString().Equals("Y");
            
            txtDishCode.Text = dgvCategory.CurrentRow.Cells[5].Value.ToString();
        }
    }
}

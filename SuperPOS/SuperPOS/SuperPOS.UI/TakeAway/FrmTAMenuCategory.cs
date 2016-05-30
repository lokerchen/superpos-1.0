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
        private Guid TADeptCodeSysKey = Guid.NewGuid();

        private string strMenuSetKey = "";

        private string[] MenuSetKey = new string[4];

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
            cmbBoxDeptCode.Enabled = true;
            chkHotKey.Enabled = true;
            txtDishCode.Enabled = false;

            txtEnglishName.Text = "";
            txtOtherName.Text = "";
            txtDisplayPosition.Text = "";
            BindCmbData();
            chkHotKey.Checked = false;
            txtDishCode.Enabled = false;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            iStatus = 2;

            txtEnglishName.Enabled = true;
            txtOtherName.Enabled = true;
            txtDisplayPosition.Enabled = true;

            //OnLoadSystemCommonData onLoad = new OnLoadSystemCommonData();
            //onLoad.GetTADeptCode();
            //List<string> lst = new List<string>();
            //cmbBoxDeptCode.DataSource = CommonData.TaDeptCodeList.Select(s => s.DeptCode + "-" + s.DeptName).ToList();
            cmbBoxDeptCode.Enabled = true;

            chkHotKey.Enabled = true;
            txtDishCode.Enabled = true;
            txtDishCode.Enabled = chkHotKey.Checked;

            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
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
            taMenuCategoryInfo.OtherName = txtOtherName.Text.Trim();
            taMenuCategoryInfo.DisplayPosition = txtDisplayPosition.Text.Trim();
            taMenuCategoryInfo.DeptSysKey = cmbBoxDeptCode.SelectedValue.ToString();
            taMenuCategoryInfo.DeptCode = cmbBoxDeptCode.Text;
            taMenuCategoryInfo.IsHotKey = chkHotKey.Checked ? "Y" : "N";
            taMenuCategoryInfo.DishCode = txtDishCode.Text.Trim();
            taMenuCategoryInfo.MenuSetID = strMenuSetKey;

            if (iStatus == 1)
            {
                taMenuCategoryInfo.SystemKey = new Guid(Guid.NewGuid().ToString().ToUpper());
                _control.AddEntity(taMenuCategoryInfo);
            }
            else //iStatus == 2
            {
                if (dgvCategory.CurrentRow != null)
                {
                    taMenuCategoryInfo.SystemKey = new Guid(dgvCategory.CurrentRow.Cells[0].Value.ToString().ToUpper());
                }

                _control.UpdateEntity(taMenuCategoryInfo);
            }

            new OnLoadSystemCommonData().GetTAMenuCategory();
            dgvCategory.DataSource = CommonData.TaMenuCategoryList;

            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;

            txtEnglishName.Enabled = false;
            txtOtherName.Enabled = false;
            txtDisplayPosition.Enabled = false;
            cmbBoxDeptCode.Enabled = false;
            chkHotKey.Enabled = false;
            txtDishCode.Enabled = false;
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
            onLoad.GetTADeptCode();

            dgvCategory.DataSource = CommonData.TaMenuCategoryList;
            

            dgvCategory.Columns[0].Visible = false;
            dgvCategory.Columns[4].Visible = false;
            dgvCategory.Columns[5].Visible = false;
            dgvCategory.Columns[6].Visible = false;
            dgvCategory.Columns[7].Visible = false;
            dgvCategory.Columns[8].Visible = false;
            dgvCategory.Columns[9].Visible = false;

            dgvCategory.Columns[1].HeaderText = @"Category Name";
            dgvCategory.Columns[2].HeaderText = @"Category 2nd Name";
            dgvCategory.Columns[3].HeaderText = @"Position";

            #region btnMenuSet赋值
            Button[] btnMenuSet = new Button[4];
            btnMenuSet[0] = btnMenuSet1;
            btnMenuSet[1] = btnMenuSet2;
            btnMenuSet[2] = btnMenuSet3;
            btnMenuSet[3] = btnMenuSet4;

            btnMenuSet1.Click += BtnMenuSet_Click;
            btnMenuSet2.Click += BtnMenuSet_Click;
            btnMenuSet3.Click += BtnMenuSet_Click;
            btnMenuSet4.Click += BtnMenuSet_Click;

            new OnLoadSystemCommonData().GetTAMenuSet();
            int i = 0;
            foreach (var taMenuSet in CommonData.TaMenuSetList)
            {
                if (i >= 4) break;

                btnMenuSet[i].Text = taMenuSet.EnglishName;
                MenuSetKey[i] = taMenuSet.SystemKey.ToString();

                i++;
            }
            #endregion

            BindCmbData();

            txtDishCode.Enabled = false;

            //comboBox1.SelectedValue;
        }

        private void chkHotKey_CheckedChanged(object sender, EventArgs e)
        {
            txtDishCode.Enabled = chkHotKey.Checked;

            if (!chkHotKey.Checked) txtDishCode.Text = "";
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategory.RowCount == 0) { return; }

            if (dgvCategory.CurrentRow == null) return;

            if (dgvCategory.CurrentRow.Index < 0) return;
            //ShiftCode
            txtEnglishName.Text = dgvCategory.CurrentRow.Cells[1].Value?.ToString() ?? "";
            //ShiftName
            txtOtherName.Text = dgvCategory.CurrentRow.Cells[2].Value?.ToString() ?? "";
            //OtherName
            txtDisplayPosition.Text = dgvCategory.CurrentRow.Cells[3].Value?.ToString() ?? "";

            //cmbBoxDeptCode.SelectedItem = dgvCategory.CurrentRow.Cells[5].Value.ToString();
            var tc = CommonData.TaDeptCodeList.Select(lstDC => new {DeptCode = lstDC.DeptCode, SysKey = lstDC.SystemKey})
                    .Where(s => s.DeptCode.Equals(dgvCategory.CurrentRow.Cells[5].Value?.ToString() ?? ""));
            if (tc.Any())
            {
                cmbBoxDeptCode.Text = tc.FirstOrDefault().DeptCode;
            }

            chkHotKey.Checked = dgvCategory.CurrentRow.Cells[6].Value?.ToString().Equals("Y") ?? false;
            
            txtDishCode.Text = dgvCategory.CurrentRow.Cells[7].Value?.ToString() ?? "";
        }

        private void cmbBoxDeptCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //new OnLoadSystemCommonData().GetTADeptCode();
            //var qList = CommonData.TaDeptCodeList.Where(s => s.DeptCode.Equals(cmbBoxDeptCode.Text));

            //if (qList.Any()) { TADeptCodeSysKey = qList.FirstOrDefault().SystemKey; }
            //Console.Out.WriteLine(cmbBoxDeptCode.Text);
            //Console.Out.WriteLine(cmbBoxDeptCode.SelectedValue);
        }

        private void BindCmbData()
        {
            var lstDeptCode = CommonData.TaDeptCodeList.Select(lstDC => new {DeptCode = lstDC.DeptCode, SysKey = lstDC.SystemKey});
            //cmbBoxDeptCode.DataSource = lstDeptCode.ToList();
            cmbBoxDeptCode.DataSource = lstDeptCode.ToList();
            cmbBoxDeptCode.ValueMember = "SysKey";
            cmbBoxDeptCode.DisplayMember = "DeptCode";
        }

        private void BtnMenuSet_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnMenuSet1":
                    strMenuSetKey = MenuSetKey[0];
                    btn.BackColor = Color.CornflowerBlue;
                    btnMenuSet2.BackColor = Color.Gray;
                    btnMenuSet3.BackColor = Color.Gray;
                    btnMenuSet4.BackColor = Color.Gray;
                    break;
                case "btnMenuSet2":
                    strMenuSetKey = MenuSetKey[1];
                    btnMenuSet1.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnMenuSet3.BackColor = Color.Gray;
                    btnMenuSet4.BackColor = Color.Gray;
                    break;
                case "btnMenuSet3":
                    strMenuSetKey = MenuSetKey[2];
                    btnMenuSet1.BackColor = Color.Gray;
                    btnMenuSet2.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    btnMenuSet4.BackColor = Color.Gray;
                    break;
                case "btnMenuSet4":
                    strMenuSetKey = MenuSetKey[3];
                    btnMenuSet1.BackColor = Color.Gray;
                    btnMenuSet2.BackColor = Color.Gray;
                    btnMenuSet3.BackColor = Color.Gray;
                    btn.BackColor = Color.CornflowerBlue;
                    break;
                default:
                    strMenuSetKey = MenuSetKey[0];
                    btn.BackColor = Color.CornflowerBlue;
                    btnMenuSet2.BackColor = Color.Gray;
                    btnMenuSet3.BackColor = Color.Gray;
                    btnMenuSet4.BackColor = Color.Gray;
                    break;
            }
        }

    }
}

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
    public partial class FrmTAExtraMenuEdit : Form
    {
        public UserInfo userInfo = new UserInfo();
        public int iStatus = 0;
        private readonly EntityControl _control = new EntityControl();

        public FrmTAExtraMenuEdit()
        {
            InitializeComponent();
        }

        public FrmTAExtraMenuEdit(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FrmTAExtraMenuEdit_Load(object sender, EventArgs e)
        {
            btnVegetable.Click += Btn_Click;
            btnVegetable2.Click += Btn_Click;
            btnBean.Click += Btn_Click;
            btnMeat.Click += Btn_Click;
            btnSeafood.Click += Btn_Click;
            btnSauce.Click += Btn_Click;
            btnTaste.Click += Btn_Click;
            btnFruit.Click += Btn_Click;
            btnCooking.Click += Btn_Click;
            btnOthers.Click += Btn_Click;

            new OnLoadSystemCommonData().GetExtraMenuEdit();
            dgvExtraMenu.DataSource = CommonData.TaExtraMenuEditList;

            dgvExtraMenu.Columns[0].Visible = false;
            dgvExtraMenu.Columns[1].Visible = false;
            dgvExtraMenu.Columns[2].Visible = false;
            dgvExtraMenu.Columns[3].HeaderText = @"Item Name";
            dgvExtraMenu.Columns[4].Visible = false;
            dgvExtraMenu.Columns[6].Visible = false;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtBtnName.Text = btn.Text;
        }

        private void chkTasteItem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTasteItem.Checked) chkDrinkItem.Checked = false;
        }

        private void chkDrinkItem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDrinkItem.Checked) chkTasteItem.Checked = false;
        }

        private void dgvExtraMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExtraMenu.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvExtraMenu.CurrentRow == null) return;

            if (dgvExtraMenu.CurrentRow.Index < 0) return;

            if (dgvExtraMenu.CurrentRow.Cells[1].Value.Equals("1")) chkTasteItem.Checked = true;
            else chkDrinkItem.Checked = true;

            txtBtnName.Text = dgvExtraMenu.CurrentRow.Cells[2].Value.ToString();
            txtEngName.Text = dgvExtraMenu.CurrentRow.Cells[3].Value.ToString();
            txtOtherName.Text = dgvExtraMenu.CurrentRow.Cells[4].Value.ToString();
            txtPrice.Text = dgvExtraMenu.CurrentRow.Cells[5].Value.ToString();
            txtDisplayPosition.Text = dgvExtraMenu.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            iStatus = 1;

            chkTasteItem.Checked = false;
            chkDrinkItem.Checked = false;
            txtBtnName.Text = "";
            txtEngName.Text = "";
            txtOtherName.Text = "";
            txtPrice.Text = "";
            txtDisplayPosition.Text = "";

            chkTasteItem.Enabled = true;
            chkDrinkItem.Enabled = true;
            //txtBtnName.Enabled = true;
            txtEngName.Enabled = true;
            txtOtherName.Enabled = true;
            txtPrice.Enabled = true;
            txtDisplayPosition.Enabled = true;

            btnVegetable.Enabled = true;
            btnVegetable2.Enabled = true;
            btnBean.Enabled = true;
            btnMeat.Enabled = true;
            btnSeafood.Enabled = true;
            btnSauce.Enabled = true;
            btnTaste.Enabled = true;
            btnFruit.Enabled = true;
            btnCooking.Enabled = true;
            btnOthers.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            iStatus = 2;

            chkTasteItem.Enabled = true;
            chkDrinkItem.Enabled = true;
            //txtBtnName.Enabled = true;
            txtEngName.Enabled = true;
            txtOtherName.Enabled = true;
            txtPrice.Enabled = true;
            txtDisplayPosition.Enabled = true;

            btnVegetable.Enabled = true;
            btnVegetable2.Enabled = true;
            btnBean.Enabled = true;
            btnMeat.Enabled = true;
            btnSeafood.Enabled = true;
            btnSauce.Enabled = true;
            btnTaste.Enabled = true;
            btnFruit.Enabled = true;
            btnCooking.Enabled = true;
            btnOthers.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvExtraMenu.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetExtraMenuEdit();
            var taExtraMenuEdit = CommonData.TaExtraMenuEditList.FirstOrDefault(s => s.SystemKey.Equals(dgvExtraMenu.CurrentRow.Cells[0].Value));
            if (taExtraMenuEdit != null) _control.DeleteEntity(taExtraMenuEdit);

            //刷新数据
            new OnLoadSystemCommonData().GetExtraMenuEdit();
            dgvExtraMenu.DataSource = CommonData.TaExtraMenuEditList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBtnName.Text))
            {
                MessageBox.Show("Please select a button name!");
                return;
            }

            if (chkTasteItem.Checked == false && chkDrinkItem.Checked == false)
            {
                MessageBox.Show("Please select Tasete Item OR Drink Item!");
                return;
            }

            TAExtraMenuEditInfo taExtraMenuEditInfo = new TAExtraMenuEditInfo();

            taExtraMenuEditInfo.TasteOrDrink = chkTasteItem.Checked ? "1" : "2";
            taExtraMenuEditInfo.BtnName = txtBtnName.Text;
            taExtraMenuEditInfo.EnglishName = txtEngName.Text;
            taExtraMenuEditInfo.OtherName = txtOtherName.Text;
            taExtraMenuEditInfo.Price = txtPrice.Text;
            taExtraMenuEditInfo.DisplayPosition = txtDisplayPosition.Text;

            if (iStatus == 1)
            {
                taExtraMenuEditInfo.SystemKey = Guid.NewGuid();
                _control.AddEntity(taExtraMenuEditInfo);
            }
            else if (iStatus == 2)
            {
                taExtraMenuEditInfo.SystemKey = new Guid(dgvExtraMenu.CurrentRow.Cells[0].Value.ToString());
                _control.UpdateEntity(taExtraMenuEditInfo);
            }

            chkTasteItem.Enabled = false;
            chkDrinkItem.Enabled = false;
            txtBtnName.Enabled = false;
            txtEngName.Enabled = false;
            txtOtherName.Enabled = false;
            txtPrice.Enabled = false;
            txtDisplayPosition.Enabled = false;

            btnVegetable.Enabled = false;
            btnVegetable2.Enabled = false;
            btnBean.Enabled = false;
            btnMeat.Enabled = false;
            btnSeafood.Enabled = false;
            btnSauce.Enabled = false;
            btnTaste.Enabled = false;
            btnFruit.Enabled = false;
            btnCooking.Enabled = false;
            btnOthers.Enabled = false;

            new OnLoadSystemCommonData().GetExtraMenuEdit();
            dgvExtraMenu.DataSource = CommonData.TaExtraMenuEditList;
            iStatus = 0;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
        }
    }
}

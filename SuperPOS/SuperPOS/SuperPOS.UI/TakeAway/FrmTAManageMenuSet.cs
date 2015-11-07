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
    public partial class FrmTAManageMenuSet : Form
    {
        private int iStatus;

        private readonly EntityControl _control = new EntityControl();
        public FrmTAManageMenuSet()
        {
            InitializeComponent();
        }

        private void FrmTAManageMenuSet_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoad = new OnLoadSystemCommonData();
            onLoad.GetTAMenuSet();

            dgvMenuSet.DataSource = CommonData.TaMenuSetList;
            dgvMenuSet.Columns[0].Visible = false;
            dgvMenuSet.Columns[3].Visible = false;
            dgvMenuSet.Columns[1].HeaderCell.Value = "English Name";
            dgvMenuSet.Columns[2].HeaderCell.Value = "Other Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            iStatus = 1;
            if (dgvMenuSet.Rows.Count >= 4)
            {
                MessageBox.Show("Up to four records are allowed.");
                return;
            }

            txtEnglishName.Text = "";
            txtOtherName.Text = "";

            btnSave.Enabled = true;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;

            txtEnglishName.Enabled = true;
            txtOtherName.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            iStatus = 2;

            btnSave.Enabled = true;
            btnDel.Enabled = false;
            btnAdd.Enabled = false;

            txtEnglishName.Enabled = true;
            txtOtherName.Enabled = true;
        }

        private void dgvMenuSet_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenuSet.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvMenuSet.CurrentRow == null)
                return;

            if (dgvMenuSet.CurrentRow.Index < 0) return;
            //English Name
            txtEnglishName.Text = dgvMenuSet.CurrentRow.Cells[1].Value.ToString();
            //Other Name
            txtOtherName.Text = dgvMenuSet.CurrentRow.Cells[2].Value.ToString();

            //btnAdd.Enabled = false;
            //btnDel.Enabled = false;
            //btnSave.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvMenuSet.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetTAMenuSet();
            var shiftCodeInfo = CommonData.TaMenuSetList.FirstOrDefault(s => s.SystemKey.Equals(dgvMenuSet.CurrentRow.Cells[0].Value));
            if (shiftCodeInfo != null)
                _control.DeleteEntity(shiftCodeInfo);

            //刷新数据
            new OnLoadSystemCommonData().GetShiftCodeList();
            dgvMenuSet.DataSource = CommonData.ShiftCodeList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEnglishName.Text.Trim()))
            {
                MessageBox.Show("Englis Name is empty,please enter!");
                return;
            }

            if (string.IsNullOrEmpty(txtOtherName.Text.Trim()))
            {
                MessageBox.Show("Other Name is empty,please enter!");
                return;
            }

            var menuSetInfo = new TAMenuSetInfo();
            menuSetInfo.EnglishName = txtEnglishName.Text.Trim();
            menuSetInfo.OtherName = txtOtherName.Text.Trim();

            if (iStatus == 1)
            {
                menuSetInfo.SystemKey = new Guid(Guid.NewGuid().ToString().ToUpper());
                _control.AddEntity(menuSetInfo);
            }
            else //iStatus == 2
            {
                if (dgvMenuSet.CurrentRow != null)
                    menuSetInfo.SystemKey = new Guid(dgvMenuSet.CurrentRow.Cells[0].Value.ToString().ToUpper());
                else 
                    return;

                _control.UpdateEntity(menuSetInfo);
            }

            new OnLoadSystemCommonData().GetTAMenuSet();
            dgvMenuSet.DataSource = CommonData.TaMenuSetList;
            
            iStatus = 0;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;

            txtEnglishName.Enabled = false;
            txtOtherName.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdminControlPanel frmAdminControl = new FrmAdminControlPanel();
            frmAdminControl.ShowDialog();
        }
    }
}

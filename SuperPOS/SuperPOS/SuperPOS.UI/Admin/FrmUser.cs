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

namespace SuperPOS.UI.Admin
{
    public partial class FrmUser : Form
    {
        private readonly EntityControl _control = new EntityControl();
        private int iStatus;

        public FrmUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsrMaintenance frmUsrMaintenance = new FrmUsrMaintenance();
            frmUsrMaintenance.ShowDialog();
            //FrmUsrMaintenance frmUsrMaintenance = new FrmUsrMaintenance();
            //frmUsrMaintenance.SetDataSource();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetShiftCodeList();
            dgvUserList.DataSource = CommonData.UsrList;

            dgvUserList.Columns[0].Width = 20;
            dgvUserList.Columns[1].Width = 100;
            dgvUserList.Columns[2].Width = 120;

            dgvUserList.Columns[0].Visible = false;
            dgvUserList.Columns[4].Visible = false;

            dgvUserList.Columns[0].HeaderText = @"User Code";
            dgvUserList.Columns[1].HeaderText = @"User Name";
            dgvUserList.Columns[2].HeaderText = @"User Password";

            dgvUserList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUserList.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUserList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtUsrName.Text = "";
            txtUsrPwd.Text = "";
            txtUsrCode.Text = "";

            txtUsrName.Enabled = true;
            txtUsrPwd.Enabled = true;
            txtUsrCode.Enabled = false;

            string sUsrCode = CommonData.UsrList.OrderByDescending(s => s.UsrCode).Select(a => a.UsrCode).FirstOrDefault();
            int code = Convert.ToInt32(sUsrCode) + 1;
            txtUsrCode.Text = code.ToString().Length > 1 ? "0" + code : "00" + code;


            iStatus = 1;
        }

        private void dgvUserList_SelectionChanged(object sender, EventArgs e)
        {
            txtUsrName.Enabled = false;
            txtUsrPwd.Enabled = false;
            txtUsrCode.Enabled = false;

            //if (dgvUserList.RowCount == 0)
            //{
            //    MessageBox.Show("This table is empty, please add data first!");
            //    return;
            //}

            if (dgvUserList.CurrentRow == null) return;

            if (dgvUserList.CurrentRow.Index < 0) return;

            txtUsrCode.Text = dgvUserList.CurrentRow.Cells[1].Value.ToString();
            txtUsrName.Text = dgvUserList.CurrentRow.Cells[2].Value.ToString();
            txtUsrPwd.Text = dgvUserList.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDel.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;

            txtUsrName.Enabled = true;
            txtUsrPwd.Enabled = true;

            iStatus = 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsrCode.Text.Trim()))
            {
                MessageBox.Show("User code is empty,please enter!");
                return;
            }

            if (string.IsNullOrEmpty(txtUsrName.Text.Trim()))
            {
                MessageBox.Show("User name is empty,please enter!");
                return;
            }

            if (string.IsNullOrEmpty(txtUsrPwd.Text.Trim()))
            {
                MessageBox.Show("User password is empty,please enter!");
                return;
            }

            var usr = new UserInfo();
            usr.UsrCode = txtUsrCode.Text.Trim();
            usr.UsrName = txtUsrName.Text.Trim();
            usr.UsrPwd = txtUsrPwd.Text.Trim();

            if (iStatus == 1)
            {
                usr.SystemKey = new Guid(Guid.NewGuid().ToString().ToUpper());
                _control.AddEntity(usr);
            }
            else
            {
                if (dgvUserList.CurrentRow != null)
                    usr.SystemKey = new Guid(dgvUserList.CurrentRow.Cells[0].Value.ToString().ToUpper());

                _control.UpdateEntity(usr);
            }

            new OnLoadSystemCommonData().GetUserList();
            dgvUserList.DataSource = CommonData.UsrList;

            btnAdd.Enabled = true;
            btnDel.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentRow == null) return;
            
            new OnLoadSystemCommonData().GetUserList();

            var usrInfo = CommonData.UsrList.FirstOrDefault(s => s.SystemKey.Equals(dgvUserList.CurrentRow.Cells[0].Value));

            if (usrInfo != null) _control.DeleteEntity(usrInfo);

            new OnLoadSystemCommonData().GetUserList();
            dgvUserList.DataSource = CommonData.UsrList;
        }
    }
}

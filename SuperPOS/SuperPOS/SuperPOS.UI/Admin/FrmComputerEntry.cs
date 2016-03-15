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
    public partial class FrmComputerEntry : Form
    {
        private readonly EntityControl _control = new EntityControl();
        private int iStatus;
        private UserInfo userInfo = new UserInfo();

        public FrmComputerEntry()
        {
            InitializeComponent();
        }

        public FrmComputerEntry(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            iStatus = 1;

            txtCode.Text = "";
            txtCompName.Text = "";
            txtCode.Enabled = true;
            txtCompName.Enabled = true;

            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            iStatus = 2;

            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;

            txtCode.Enabled = true;
            txtCompName.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Code can not empty,Please enter!");
                return;
            }

            if (string.IsNullOrEmpty(txtCompName.Text))
            {
                MessageBox.Show("Computer Name can not empty, Please enter!");
                return;
            }

            var compAddrInfo = new CompAddrInfo();
            compAddrInfo.AddrCode = txtCode.Text.Trim();
            compAddrInfo.CompName = txtCompName.Text.Trim();
            compAddrInfo.CompDateTime = DateTime.Now.ToString();
            compAddrInfo.Remark = "";

            if (iStatus == 1)
            {
                compAddrInfo.SystemKey = new Guid(Guid.NewGuid().ToString().ToUpper());
                _control.AddEntity(compAddrInfo);
            }
            else //iStatus == 2
            {
                if (dgvAddr.CurrentRow != null)
                    compAddrInfo.SystemKey = new Guid(dgvAddr.CurrentRow.Cells[0].Value.ToString().ToUpper());

                _control.UpdateEntity(compAddrInfo);
            }
            //_control.AddEntity(shiftCodeInfo);
            //_control.SaveOrUpdateEntity(shiftCodeInfo);

            new OnLoadSystemCommonData().GetCompAddr();
            dgvAddr.DataSource = CommonData.CompAddrList;

            txtCode.Enabled = false;
            txtCompName.Enabled = false;

        }

        private void FrmComputerEntry_Load(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetCompAddr();

            dgvAddr.DataSource = CommonData.CompAddrList;

            dgvAddr.Columns[0].Visible = false;
            dgvAddr.Columns[3].Visible = false;
            dgvAddr.Columns[4].Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvAddr.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetCompAddr();
            var compAddrInfo = CommonData.CompAddrList.FirstOrDefault(s => s.SystemKey.Equals(dgvAddr.CurrentRow.Cells[0].Value));
            if (compAddrInfo != null) _control.DeleteEntity(compAddrInfo);

            //刷新数据
            new OnLoadSystemCommonData().GetCompAddr();
            dgvAddr.DataSource = CommonData.CompAddrList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            //FrmAdminControlPanel frmAdminControl = new FrmAdminControlPanel();
            //frmAdminControl.ShowDialog();
        }

        private void dgvAddr_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAddr.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvAddr.CurrentRow == null)
                return;

            if (dgvAddr.CurrentRow.Index < 0) return;
            //Code
            txtCode.Text = dgvAddr.CurrentRow.Cells[1].Value.ToString();
            //Computer Name
            txtCompName.Text = dgvAddr.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

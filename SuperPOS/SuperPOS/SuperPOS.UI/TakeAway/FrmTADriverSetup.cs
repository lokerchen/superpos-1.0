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

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTADriverSetup : Form
    {
        private readonly EntityControl _control = new EntityControl();
        private int iStatus;
        private UserInfo userInfo = new UserInfo();

        public FrmTADriverSetup()
        {
            InitializeComponent();
        }

        public FrmTADriverSetup(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var driverSetup = new TADriverSetUpInfo();

            driverSetup.DriverName = txtDriverName.Text.Trim();
            driverSetup.DriverPhone = txtPhoneNum.Text.Trim();

            var sb = new StringBuilder();
            sb.Append(",");
            if (chkMonday.Checked) sb.Append("1,");
            if (chkTuesday.Checked) sb.Append("2,");
            if (chkWednesday.Checked) sb.Append("3,");
            if (chkThursday.Checked) sb.Append("4,");
            if (chkFriday.Checked) sb.Append("5,");
            if (chkSaturday.Checked) sb.Append("6,");
            if (chkSunday.Checked) sb.Append("7,");

            driverSetup.DriverWorkDay = sb.ToString();

            if (iStatus == 1)
            {
                driverSetup.SystemKey = Guid.NewGuid();
                _control.AddEntity(driverSetup);
            }
            else
            {
                if (dgvDriver.CurrentRow != null) driverSetup.SystemKey = new Guid(dgvDriver.CurrentRow.Cells[0].Value.ToString());

                _control.UpdateEntity(driverSetup);
            }

            new OnLoadSystemCommonData().GetTADriverSetUp();
            dgvDriver.DataSource = CommonData.TaDriverSetUpList;

            iStatus = 0;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Enabled = false;

            chkSunday.Enabled = false;
            chkMonday.Enabled = false;
            chkTuesday.Enabled = false;
            chkWednesday.Enabled = false;
            chkThursday.Enabled = false;
            chkFriday.Enabled = false;
            chkSaturday.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            iStatus = 2;

            txtDriverName.Enabled = true;
            txtPhoneNum.Enabled = true;

            chkSunday.Enabled = true;
            chkMonday.Enabled = true;
            chkTuesday.Enabled = true;
            chkWednesday.Enabled = true;
            chkThursday.Enabled = true;
            chkFriday.Enabled = true;
            chkSaturday.Enabled = true;

            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            iStatus = 1;

            txtDriverName.Enabled = true;
            txtPhoneNum.Enabled = true;

            chkSunday.Enabled = true;
            chkMonday.Enabled = true;
            chkTuesday.Enabled = true;
            chkWednesday.Enabled = true;
            chkThursday.Enabled = true;
            chkFriday.Enabled = true;
            chkSaturday.Enabled = true;

            txtDriverName.Text = "";
            txtPhoneNum.Text = "";

            chkSunday.Checked = false;
            chkMonday.Checked = false;
            chkTuesday.Checked = false;
            chkWednesday.Checked = false;
            chkThursday.Checked = false;
            chkFriday.Checked = false;
            chkSaturday.Checked = false;

            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvDriver.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetTADriverSetUp();
            var driverSetup =
                CommonData.TaDriverSetUpList.FirstOrDefault(s => s.SystemKey.Equals(dgvDriver.CurrentRow.Cells[0].Value));
            if (driverSetup != null) _control.DeleteEntity(driverSetup);

            //刷新数据
            new OnLoadSystemCommonData().GetTADriverSetUp();
            dgvDriver.DataSource = CommonData.TaDriverSetUpList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dgvDriver_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDriver.RowCount == 0) return;

            if (dgvDriver.CurrentRow?.Index < 0) return;

            txtDriverName.Text = dgvDriver.CurrentRow.Cells[1].Value.ToString();
            txtPhoneNum.Text = dgvDriver.CurrentRow.Cells[2].Value.ToString();

            chkSunday.Checked = false;
            chkMonday.Checked = false;
            chkTuesday.Checked = false;
            chkWednesday.Checked = false;
            chkThursday.Checked = false;
            chkFriday.Checked = false;
            chkSaturday.Checked = false;

            var sTemp = dgvDriver.CurrentRow.Cells[3].Value.ToString().Split(',');
            foreach (var s in sTemp)
            {
                //ChkEnableTrue(Convert.ToInt32(s));
                if (!string.IsNullOrEmpty(s)) ChkStatusTrue(Convert.ToInt32(s));
            }
        }

        private void FrmTADriverSetup_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData _onLoadSysData = new OnLoadSystemCommonData();
            _onLoadSysData.GetTADriverSetUp();

            dgvDriver.DataSource = CommonData.TaDriverSetUpList;

            dgvDriver.Columns[0].Visible = false;
            dgvDriver.Columns[3].Visible = false;
            dgvDriver.Columns[4].Visible = false;
        }

        #region 各CheckBox状态

        /// <summary>
        ///     各CheckBox状态
        /// </summary>
        /// <param name="i">checkbox名</param>
        private void ChkStatusTrue(int i)
        {
            switch (i)
            {
                case 1:
                    chkMonday.Checked = true;
                    break;
                case 2:
                    chkTuesday.Checked = true;
                    break;
                case 3:
                    chkWednesday.Checked = true;
                    break;
                case 4:
                    chkThursday.Checked = true;
                    break;
                case 5:
                    chkFriday.Checked = true;
                    break;
                case 6:
                    chkSaturday.Checked = true;
                    break;
                case 7:
                    chkSunday.Checked = true;
                    break;
                default:
                    ChkStatusTrue();
                    break;
            }
        }
        #endregion

        private void ChkStatusTrue()
        {
            chkSunday.Checked = true;
            chkMonday.Checked = true;
            chkTuesday.Checked = true;
            chkWednesday.Checked = true;
            chkThursday.Checked = true;
            chkFriday.Checked = true;
            chkSaturday.Checked = true;
        }
    }
}

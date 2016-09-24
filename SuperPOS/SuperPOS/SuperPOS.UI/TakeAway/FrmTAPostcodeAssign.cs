using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperPOS.DAL;
using SuperPOS.Common;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAPostcodeAssign : Form
    {
        private readonly EntityControl _control = new EntityControl();
        private UserInfo userInfo = new UserInfo();
        private int iStatus = 0;

        public FrmTAPostcodeAssign()
        {
            InitializeComponent();
        }

        public FrmTAPostcodeAssign(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
        }

        private void FrmTAPostcodeAssign_Load(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetPostcodeZoneList();
            new OnLoadSystemCommonData().GetPostcodeChargeList();

            dgvCharge.DataSource = CommonData.TaPostcodeChargeList;
            dgvZone.DataSource = CommonData.TaPostcodeZoneList;

            dgvCharge.Columns[0].Visible = false;
            dgvCharge.Columns[1].Visible = true;
            dgvCharge.Columns[1].HeaderText = @"Postcode";
            dgvCharge.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCharge.Columns[2].Visible = true;
            dgvCharge.Columns[2].HeaderText = @"Charge";
            dgvCharge.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvZone.Columns[0].Visible = false;
            dgvZone.Columns[1].Visible = true;
            dgvZone.Columns[1].HeaderText = @"Postcode";
            dgvZone.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvZone.Columns[2].Visible = true;
            dgvZone.Columns[2].HeaderText = @"Zone";
            dgvZone.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvCharge_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCharge.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvCharge.CurrentRow == null) return;

            if (dgvCharge.CurrentRow.Index < 0) return;

            txtChargePostCode.Text = dgvCharge.CurrentRow.Cells[1].Value.ToString();
            txtCharge.Text = dgvCharge.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvZone_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZone.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvZone.CurrentRow == null) return;

            if (dgvZone.CurrentRow.Index < 0) return;

            txtZonePostcode.Text = dgvZone.CurrentRow.Cells[1].Value.ToString();
            txtZone.Text = dgvZone.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnChrgNew_Click(object sender, EventArgs e)
        {
            iStatus = 1;

            txtChargePostCode.Text = "";
            txtCharge.Text = "";
        }

        private void btnChrgDel_Click(object sender, EventArgs e)
        {
            if (dgvCharge.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetPostcodeChargeList();
            var pcCharge = CommonData.TaPostcodeChargeList.FirstOrDefault(s => s.SystemKey.Equals(dgvCharge.CurrentRow.Cells[0].Value));
            if (pcCharge != null) _control.DeleteEntity(pcCharge);

            //刷新数据
            new OnLoadSystemCommonData().GetPostcodeChargeList();
            dgvCharge.DataSource = CommonData.TaPostcodeChargeList;
        }

        private void btnChrgExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnChrgSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChargePostCode.Text))
            {
                MessageBox.Show("Postcode can not empty,Please enter!");
                return;
            }

            if (string.IsNullOrEmpty(txtCharge.Text))
            {
                MessageBox.Show("Charge Name can not empty, Please enter!");
                return;
            }

            TAPostcodeChargeInfo taPcChargeInfo = new TAPostcodeChargeInfo();
            taPcChargeInfo.Postcode = txtChargePostCode.Text;
            taPcChargeInfo.Charge = txtCharge.Text;

            if (iStatus == 1)
            {
                taPcChargeInfo.SystemKey = Guid.NewGuid();
                _control.AddEntity(taPcChargeInfo);
            }
            else
            {
                if (dgvCharge.Rows.Count <= 0) return;

                if (dgvCharge.CurrentRow != null)
                    taPcChargeInfo.SystemKey = new Guid(dgvCharge.CurrentRow.Cells[0].Value.ToString().ToUpper());

                _control.UpdateEntity(taPcChargeInfo);
            }

            new OnLoadSystemCommonData().GetPostcodeChargeList();
            dgvCharge.DataSource = CommonData.TaPostcodeChargeList;
        }

        private void btnZoneNew_Click(object sender, EventArgs e)
        {
            iStatus = 3;

            txtZonePostcode.Text = "";
            txtZone.Text = "";
        }

        private void btnZoneDel_Click(object sender, EventArgs e)
        {
            if (dgvZone.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetPostcodeZoneList();
            var pcZone = CommonData.TaPostcodeZoneList.FirstOrDefault(s => s.SystemKey.Equals(dgvZone.CurrentRow.Cells[0].Value));
            if (pcZone != null) _control.DeleteEntity(pcZone);

            //刷新数据
            new OnLoadSystemCommonData().GetPostcodeZoneList();
            dgvZone.DataSource = CommonData.TaPostcodeZoneList;
        }

        private void btnZoneSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtZonePostcode.Text))
            {
                MessageBox.Show("Postcode can not empty,Please enter!");
                return;
            }

            if (string.IsNullOrEmpty(txtZone.Text))
            {
                MessageBox.Show("Charge Name can not empty, Please enter!");
                return;
            }

            TAPostcodeZoneInfo taPcZoneInfo = new TAPostcodeZoneInfo();
            taPcZoneInfo.Postcode = txtZonePostcode.Text;
            taPcZoneInfo.Zone = txtZone.Text;

            if (iStatus == 3)
            {
                taPcZoneInfo.SystemKey = Guid.NewGuid();
                _control.AddEntity(taPcZoneInfo);
            }
            else
            {
                if (dgvZone.Rows.Count <= 0) return;

                if (dgvZone.CurrentRow != null) taPcZoneInfo.SystemKey = new Guid(dgvZone.CurrentRow.Cells[0].Value.ToString().ToUpper());

                _control.UpdateEntity(taPcZoneInfo);
            }

            new OnLoadSystemCommonData().GetPostcodeZoneList();
            dgvZone.DataSource = CommonData.TaPostcodeZoneList;
        }

        private void btnZoneExit_Click(object sender, EventArgs e)
        {

        }
    }
}

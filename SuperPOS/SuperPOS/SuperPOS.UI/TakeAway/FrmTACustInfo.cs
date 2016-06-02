using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Remotion.Linq.Parsing.Structure.ExpressionTreeProcessors;
using SuperPOS.Common;
using SuperPOS.DAL;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTACustInfo : Form
    {
        private readonly EntityControl _control = new EntityControl();

        private string sCallID = "";
        public FrmTACustInfo()
        {
            InitializeComponent();
        }

        public FrmTACustInfo(string strCallID)
        {
            InitializeComponent();
            sCallID = strCallID;
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCID_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var taCustInfo in CommonData.TaCustList) { _control.DeleteEntity(taCustInfo); }
        }

        private void FrmTACustInfo_Load(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(sCallID))
            //{
            //    new OnLoadSystemCommonData().GetTACust();
            //    dgvCust.DataSource = CommonData.TaCustList.ToList();
            //}

            new OnLoadSystemCommonData().GetTACust();
            dgvCust.DataSource = CommonData.TaCustList.ToList();

            dgvCust.Columns[0].Visible = false;
            dgvCust.Columns[1].HeaderText = @"Phone NO.";
            dgvCust.Columns[2].HeaderText = @"Name";
            dgvCust.Columns[3].Visible = false;
            dgvCust.Columns[4].HeaderText = @"Address";
            dgvCust.Columns[5].HeaderText = @"Post Code";
            dgvCust.Columns[6].HeaderText = @"Distance";
            dgvCust.Columns[7].HeaderText = @"PC Zone";
            dgvCust.Columns[8].Visible = false;
            dgvCust.Columns[9].Visible = false;
            dgvCust.Columns[10].Visible = false;
            dgvCust.Columns[11].Visible = false;
            dgvCust.Columns[12].HeaderText = @"Black Listed";
            dgvCust.Columns[13].Visible = false;

            if (!string.IsNullOrEmpty(sCallID))
            {
                new OnLoadSystemCommonData().GetTACust();

                if (CommonData.TaCustList.Any(s => s.Phone1.Equals(sCallID)))
                {
                    var taCustInfo = CommonData.TaCustList.FirstOrDefault(s => s.Phone1.Equals(sCallID));
                    if (taCustInfo != null)
                    {
                        txtPhone.Text = taCustInfo.Phone1;
                        txtName.Text = taCustInfo.Name;
                        txtHouseNo.Text = taCustInfo.HouseNo;
                        txtAddress.Text = taCustInfo.Address1;
                        txtPostcode.Text = taCustInfo.Postcode1;
                        txtDistance.Text = taCustInfo.Distance;
                        txtPCZone.Text = taCustInfo.PcZone;
                        txtDelCharge.Text = taCustInfo.DelCharge;
                        txtReadyTime.Text = taCustInfo.ReadyTime;
                        txtIntNotes.Text = taCustInfo.IntNotes;
                        txtNotesOnBill.Text = taCustInfo.NotesOnBill;
                        chkBlackListed.Checked = taCustInfo.IsBlackListed.Equals("Y");
                    }
                }
            }
        }

        private void dgvCust_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCust.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvCust.CurrentRow?.Index < 0) return;

            txtPhone.Text = dgvCust.CurrentRow.Cells[1].Value?.ToString() ?? "";
            txtName.Text = dgvCust.CurrentRow.Cells[2].Value?.ToString() ?? "";
            txtHouseNo.Text = dgvCust.CurrentRow.Cells[3].Value?.ToString() ?? "";
            txtAddress.Text = dgvCust.CurrentRow.Cells[4].Value?.ToString() ?? "";
            txtPostcode.Text = dgvCust.CurrentRow.Cells[5].Value?.ToString() ?? "";
            txtDistance.Text = dgvCust.CurrentRow.Cells[6].Value?.ToString() ?? "";
            txtPCZone.Text = dgvCust.CurrentRow.Cells[7].Value?.ToString() ?? "";
            txtDelCharge.Text = dgvCust.CurrentRow.Cells[8].Value?.ToString() ?? "";
            txtReadyTime.Text = dgvCust.CurrentRow.Cells[9].Value?.ToString() ?? "";
            txtIntNotes.Text = dgvCust.CurrentRow.Cells[10].Value?.ToString() ?? "";
            txtNotesOnBill.Text = dgvCust.CurrentRow.Cells[11].Value?.ToString() ?? "";
            chkBlackListed.Checked = dgvCust.CurrentRow.Cells[12].Value?.ToString().Equals("Y") ?? false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvCust.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetTACust();

            var taCustInfo = CommonData.TaCustList.FirstOrDefault(s => s.SystemKey.Equals(dgvCust.CurrentRow.Cells[0].Value));
            if (taCustInfo != null) _control.DeleteEntity(taCustInfo);

            //刷新数据
            new OnLoadSystemCommonData().GetTACust();
            dgvCust.DataSource = CommonData.TaCustList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvCust.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetTACust();

            var taCustInfo = CommonData.TaCustList.FirstOrDefault(s => s.SystemKey.Equals(dgvCust.CurrentRow.Cells[0].Value));
            if (taCustInfo != null)
            {
                taCustInfo.Phone1 = txtPhone.Text.Trim();
                taCustInfo.Name = txtName.Text.Trim();
                taCustInfo.HouseNo = txtHouseNo.Text.Trim();
                taCustInfo.Address1 = txtAddress.Text.Trim();
                taCustInfo.Postcode1 = txtPostcode.Text.Trim();
                taCustInfo.Distance = txtDistance.Text.Trim();
                taCustInfo.PcZone = txtPCZone.Text.Trim();
                taCustInfo.DelCharge = txtDelCharge.Text.Trim();
                taCustInfo.ReadyTime = txtReadyTime.Text.Trim();
                taCustInfo.IntNotes = txtIntNotes.Text.Trim();
                taCustInfo.NotesOnBill = txtNotesOnBill.Text.Trim();
                taCustInfo.IsBlackListed = chkBlackListed.Checked ? "Y" : "N";

                _control.UpdateEntity(taCustInfo);
            }

            new OnLoadSystemCommonData().GetTACust();
            dgvCust.DataSource = CommonData.TaCustList;
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Please select file";
            fileDialog.Filter = "Images|*.xls;*.xlsx";

            string strExcelFilePath = "";
            if (fileDialog.ShowDialog() == DialogResult.OK) { strExcelFilePath = fileDialog.FileName; }

            if (!string.IsNullOrEmpty(strExcelFilePath))
            {
                MessageBox.Show(DALCommon.ImportCust(strExcelFilePath, "Sheet1")
                    ? "Data import is successful!"
                    : "Data import failed!");
            }

            new OnLoadSystemCommonData().GetTACust();
            dgvCust.DataSource = CommonData.TaCustList;
        }
    }
}

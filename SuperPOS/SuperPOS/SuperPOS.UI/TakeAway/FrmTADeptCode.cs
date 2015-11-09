using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.DAL;
using SuperPOS.UI.Admin;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTADeptCode : Form
    {
        private int iStatus;
        public FrmTADeptCode()
        {
            InitializeComponent();
        }

        private void FrmDeptCode_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoad = new OnLoadSystemCommonData();
            onLoad.GetTADeptCode();
            onLoad.GetTADeptCodeDetail();

            dgvDeptCode.DataSource = CommonData.TaDeptCodeList;

            dgvDeptCode.Columns[0].Visible = false;
            dgvDeptCode.Columns[1].HeaderCell.Value = "Code";
            dgvDeptCode.Columns[2].HeaderCell.Value = "Dept Name";
            dgvDeptCode.Columns[3].HeaderCell.Value = "Other Name";

            if (CommonData.TaDeptCodeDetailList != null && dgvDeptCode.CurrentRow != null)
            {
                if (dgvDeptCode.CurrentRow.Index > 0)
                {
                    txtDeptCode.Text = dgvDeptCode.CurrentRow.Cells[1].Value.ToString();
                    txtDeptName.Text = dgvDeptCode.CurrentRow.Cells[2].Value.ToString();
                    txtOtherName.Text = dgvDeptCode.CurrentRow.Cells[3].Value.ToString();

                    var deptCode = CommonData.TaDeptCodeDetailList.FirstOrDefault(s => s.DeptCodeSysKey.Equals(dgvDeptCode.CurrentRow.Cells[0].Value.ToString()));
                    if (deptCode != null)
                    {
                        GetPrinter1();
                        cmbBoxNumberOfCopy1.Items.Add("1");
                        cmbBoxNumberOfCopy1.Items.Add("2");
                        cmbBoxNumberOfCopy1.SelectedIndex = cmbBoxNumberOfCopy1.Items.IndexOf(deptCode.NumCopy1.Equals("1") ? "1" : "2");
                        chkPrtDishSeper1.Checked = deptCode.PrtDishSeper1.Equals("Y");

                        GetPrinter2();
                        cmbBoxNumberOfCopy2.Items.Add("1");
                        cmbBoxNumberOfCopy2.Items.Add("2");
                        cmbBoxNumberOfCopy2.SelectedIndex = cmbBoxNumberOfCopy2.Items.IndexOf(deptCode.NumCopy2.Equals("1") ? "1" : "2");
                        chkPrtDishSeper2.Checked = deptCode.PrtDishSeper2.Equals("Y");
                    }
                }
            }
        }

        #region 获得所有打印列表
        private void GetPrinter1()
        {
            foreach (string sPrint in PrinterSettings.InstalledPrinters)//获取所有打印机名称
            {
                PrintDocument print = new PrintDocument();
                string sDefault = print.PrinterSettings.PrinterName;//默认打印机名

                cmbBoxPrinterName1.Items.Add(sPrint);
                if (sPrint == sDefault)
                    cmbBoxPrinterName1.SelectedIndex = cmbBoxPrinterName1.Items.IndexOf(sPrint);
            }
        }
        #endregion

        #region 获得所有打印列表

        private void GetPrinter2()
        {
            foreach (string sPrint in PrinterSettings.InstalledPrinters)//获取所有打印机名称
            {
                PrintDocument print = new PrintDocument();
                string sDefault = print.PrinterSettings.PrinterName;//默认打印机名

                cmbBoxPrinterName2.Items.Add(sPrint);
                if (sPrint == sDefault)
                    cmbBoxPrinterName2.SelectedIndex = cmbBoxPrinterName2.Items.IndexOf(sPrint);
            }
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdminControlPanel frmAdmin = new FrmAdminControlPanel();
            frmAdmin.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            iStatus = 1;

            txtDeptCode.Enabled = true;
            txtDeptName.Enabled = true;
            txtOtherName.Enabled = true;

            cmbBoxPrinterName1.Enabled = true;
            cmbBoxNumberOfCopy1.Enabled = true;
            chkPrtDishSeper1.Enabled = true;

            cmbBoxPrinterName2.Enabled = true;
            cmbBoxNumberOfCopy2.Enabled = true;
            chkPrtDishSeper2.Enabled = true;
        }

        private void dgvDeptCode_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeptCode.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvDeptCode.CurrentRow == null) return;
            if (dgvDeptCode.CurrentRow.Index < 0) return;

            txtDeptCode.Text = dgvDeptCode.CurrentRow.Cells[1].Value.ToString();
            txtDeptName.Text = dgvDeptCode.CurrentRow.Cells[2].Value.ToString();
            txtOtherName.Text = dgvDeptCode.CurrentRow.Cells[3].Value.ToString();

            OnLoadSystemCommonData onLoad = new OnLoadSystemCommonData();
            onLoad.GetTADeptCodeDetail();

            var deptCode = CommonData.TaDeptCodeDetailList.FirstOrDefault(s => s.DeptCodeSysKey.Equals(dgvDeptCode.CurrentRow.Cells[0].Value.ToString()));
            if (deptCode != null)
            {
                GetPrinter1();
                cmbBoxNumberOfCopy1.Items.Add("1");
                cmbBoxNumberOfCopy1.Items.Add("2");
                cmbBoxNumberOfCopy1.SelectedIndex = cmbBoxNumberOfCopy1.Items.IndexOf(deptCode.NumCopy1.Equals("1") ? "1" : "2");
                chkPrtDishSeper1.Checked = deptCode.PrtDishSeper1.Equals("Y");

                GetPrinter2();
                cmbBoxNumberOfCopy2.Items.Add("1");
                cmbBoxNumberOfCopy2.Items.Add("2");
                cmbBoxNumberOfCopy2.SelectedIndex = cmbBoxNumberOfCopy2.Items.IndexOf(deptCode.NumCopy2.Equals("1") ? "1" : "2");
                chkPrtDishSeper2.Checked = deptCode.PrtDishSeper2.Equals("Y");
            }
        }
    }
}

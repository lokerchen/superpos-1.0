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
    public partial class FrmUsrMaintenance : Form
    {
        private UserMaintenanceInfo usrMaintenanceInfo = null;
        private readonly EntityControl _control = new EntityControl();

        public FrmUsrMaintenance()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdminControlPanel frmAdminControl = new FrmAdminControlPanel();
            frmAdminControl.ShowDialog();
        }

        private void btnEditUsr_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUser frmUser = new FrmUser();
            frmUser.ShowDialog();
        }

        private void FrmUsrMaintenance_Load(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetUserList();

            IList<string> lstUsr = CommonData.UsrList.Select(usr => usr.UsrCode + "-" + usr.UsrName).ToList();

            comBoxUsrList.DataSource = lstUsr;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetValue();

            usrMaintenanceInfo.UsrCode = comBoxUsrList.Text.Substring(0, 3);
            
            new OnLoadSystemCommonData().GetUsrMaintenance();
            if (CommonData.UsrMaintenanceList.Any(s => s.UsrCode.Equals(comBoxUsrList.Text.Substring(0, 3))))
                _control.UpdateEntity(usrMaintenanceInfo);
            else
            {
                usrMaintenanceInfo.SystemKey = Guid.NewGuid();
                _control.AddEntity(usrMaintenanceInfo);
            }   
        }

        private void SetValue()
        {
            usrMaintenanceInfo = new UserMaintenanceInfo();

            usrMaintenanceInfo.TACtlPanel = chkTACtrlPanel.Checked ? "Y" : "N";
            usrMaintenanceInfo.TAChangePrice = chkTAChangePrice.Checked ? "Y" : "N";
            usrMaintenanceInfo.TASOPrtAcctSum = chkTASOPrtAcctSummary.Checked ? "Y" : "N";
            usrMaintenanceInfo.TASOChangePayment = chkTASOChangePayment.Checked ? "Y" : "N";
            usrMaintenanceInfo.TASOEditOrder = chkTASOEditOrder.Checked ? "Y" : "N";
            usrMaintenanceInfo.TASOPrtReceipt = chkTASOPrintReceipt.Checked ? "Y" : "N";
            usrMaintenanceInfo.TACLExportData = chkTACusLstExprotData.Checked ? "Y" : "N";

            usrMaintenanceInfo.QDCtlPanel = chkQDCtrlPanel.Checked ? "Y" : "N";
            usrMaintenanceInfo.QDChangePrice = chkQDChangePrice.Checked ? "Y" : "N";
            usrMaintenanceInfo.QDSOPrtAcctSum = chkQDSOPrtAcctSummary.Checked ? "Y" : "N";
            usrMaintenanceInfo.QDSOPrtAcctSum = chkQDSOPrtAcctSummary.Checked ? "Y" : "N";
            usrMaintenanceInfo.QDSOChangePayment = chkQDSOChangePayment.Checked ? "Y" : "N";
            usrMaintenanceInfo.QDSOEditOrder = chkQDSOEditOrder.Checked ? "Y" : "N";
            usrMaintenanceInfo.QDSOPrtReceipt = chkQDSOPrtReceipt.Checked ? "Y" : "N";

            usrMaintenanceInfo.GSSSystemConfig = chkGSSSysConf.Checked ? "Y" : "N";
            usrMaintenanceInfo.GSSUsrMaint = chkGSSUsrMaintenance.Checked ? "Y" : "N";
            usrMaintenanceInfo.GSSDataManager = chkGSSDataManager.Checked ? "Y" : "N";
            usrMaintenanceInfo.GSSCompactDb = chkGSSCompactDB.Checked ? "Y" : "N";
            usrMaintenanceInfo.GRpt = chkRptRpt.Checked ? "Y" : "N";
            usrMaintenanceInfo.GRAccountSum = chkRptAccountSummary.Checked ? "Y" : "N";
            usrMaintenanceInfo.GExitPos = chkGLogon.Checked ? "Y" : "N";
            usrMaintenanceInfo.GSSCoputAdd = chkGSSComputerAdd.Checked ? "Y" : "N";
            usrMaintenanceInfo.GSSShiftCode = chkGSSShiftCode.Checked ? "Y" : "N";
            usrMaintenanceInfo.GTakeawayConfig = chkGTakeawayConfig.Checked ? "Y" : "N";
            usrMaintenanceInfo.GEatInConfig = chkGEatInConfig.Checked ? "Y" : "N";
            usrMaintenanceInfo.GTakewayPrtSetUp = chkGTakeawayPrtSetup.Checked ? "Y" : "N";
            usrMaintenanceInfo.GEatInPrtSetUp = chkGEIPrtSetup.Checked ? "Y" : "N";

            usrMaintenanceInfo.EICtlPanel = chkEICtrlPanel.Checked ? "Y" : "N";
            usrMaintenanceInfo.EIPay = chkEIPay.Checked ? "Y" : "N";
            usrMaintenanceInfo.EIPrtBill = chkEIPrintBill.Checked ? "Y" : "N";
            usrMaintenanceInfo.EIRemoveItemAfterPrt = chkEIRemoveItemAfterPrt.Checked ? "Y" : "N";
            usrMaintenanceInfo.EITblBooking = chkEITblBooking.Checked ? "Y" : "N";
            usrMaintenanceInfo.EISOPrtAcctSum = chkEISOPrtAcctSummary.Checked ? "Y" : "N";
            usrMaintenanceInfo.EISOChangePayment = chkEISOChangePayment.Checked ? "Y" : "N";
            usrMaintenanceInfo.EISOEditOrder = chkEISOEditOrder.Checked ? "Y" : "N";
            usrMaintenanceInfo.EISOPrtReceipt = chkEISOPrtReceipt.Checked ? "Y" : "N";
            usrMaintenanceInfo.EIPBDicount = chkEIPrtBillDisc.Checked ? "Y" : "N";
        }

        private void GetValue(UserMaintenanceInfo uMaintenanceInfo)
        {
            chkTACtrlPanel.Checked = uMaintenanceInfo.TACtlPanel.Equals("Y");

            chkTAChangePrice.Checked = uMaintenanceInfo.TAChangePrice.Equals("Y");
            chkTASOPrtAcctSummary.Checked = uMaintenanceInfo.TASOPrtAcctSum.Equals("Y");
            chkTASOChangePayment.Checked = uMaintenanceInfo.TASOChangePayment.Equals("Y");
            chkTASOEditOrder.Checked = uMaintenanceInfo.TASOEditOrder.Equals("Y");
            chkTASOPrintReceipt.Checked = uMaintenanceInfo.TASOPrtReceipt.Equals("Y");
            chkTACusLstExprotData.Checked = uMaintenanceInfo.TACLExportData.Equals("Y");

            chkQDCtrlPanel.Checked = uMaintenanceInfo.QDCtlPanel.Equals("Y");
            chkQDChangePrice.Checked = uMaintenanceInfo.QDChangePrice.Equals("Y");
            chkQDSOPrtAcctSummary.Checked = uMaintenanceInfo.QDSOPrtAcctSum.Equals("Y");
            chkQDSOPrtAcctSummary.Checked = uMaintenanceInfo.QDSOPrtAcctSum.Equals("Y");
            chkQDSOChangePayment.Checked = uMaintenanceInfo.QDSOChangePayment.Equals("Y");
            chkQDSOEditOrder.Checked = uMaintenanceInfo.QDSOEditOrder.Equals("Y");
            chkQDSOPrtReceipt.Checked = uMaintenanceInfo.QDSOPrtReceipt.Equals("Y");

            chkGSSSysConf.Checked = uMaintenanceInfo.GSSSystemConfig.Equals("Y");
            chkGSSUsrMaintenance.Checked = uMaintenanceInfo.GSSUsrMaint.Equals("Y");
            chkGSSDataManager.Checked = uMaintenanceInfo.GSSDataManager.Equals("Y");
            chkGSSCompactDB.Checked = uMaintenanceInfo.GSSCompactDb.Equals("Y");
            chkRptRpt.Checked  = uMaintenanceInfo.GRpt.Equals("Y");
            chkRptAccountSummary.Checked = uMaintenanceInfo.GRAccountSum.Equals("Y");
            chkGLogon.Checked = uMaintenanceInfo.GExitPos.Equals("Y");
            chkGSSComputerAdd.Checked = uMaintenanceInfo.GSSCoputAdd.Equals("Y");
            chkGSSShiftCode.Checked = uMaintenanceInfo.GSSShiftCode.Equals("Y");
            chkGTakeawayConfig.Checked = uMaintenanceInfo.GTakeawayConfig.Equals("Y");
            chkGEatInConfig.Checked = uMaintenanceInfo.GEatInConfig.Equals("Y");
            chkGTakeawayPrtSetup.Checked = uMaintenanceInfo.GTakewayPrtSetUp.Equals("Y");
            chkGEIPrtSetup.Checked = uMaintenanceInfo.GEatInPrtSetUp.Equals("Y");

            chkEICtrlPanel.Checked = uMaintenanceInfo.EICtlPanel.Equals("Y");
            chkEIPay.Checked = uMaintenanceInfo.EIPay.Equals("Y");
            chkEIPrintBill.Checked = uMaintenanceInfo.EIPrtBill.Equals("Y");
            chkEIRemoveItemAfterPrt.Checked = uMaintenanceInfo.EIRemoveItemAfterPrt.Equals("Y");
            chkEITblBooking.Checked = uMaintenanceInfo.EITblBooking.Equals("Y");
            chkEISOPrtAcctSummary.Checked = uMaintenanceInfo.EISOPrtAcctSum.Equals("Y");
            chkEISOChangePayment.Checked = uMaintenanceInfo.EISOChangePayment.Equals("Y");
            chkEISOEditOrder.Checked = uMaintenanceInfo.EISOEditOrder.Equals("Y");
            chkEISOPrtReceipt.Checked = uMaintenanceInfo.EISOPrtReceipt.Equals("Y");
            chkEIPrtBillDisc.Checked = uMaintenanceInfo.EIPBDicount.Equals("Y");
        }

        private void comBoxUsrList_SelectedIndexChanged(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetUsrMaintenance();
            if (CommonData.UsrMaintenanceList.Any(s => s.UsrCode.Equals(comBoxUsrList.Text.Substring(0, 3))))
            {
                GetValue(CommonData.UsrMaintenanceList.FirstOrDefault(s => s.UsrCode.Equals(comBoxUsrList.Text.Substring(0, 3))));
            }
            else
            {
                foreach (CheckBox c in grpBoxUsrMaintenance.Controls.OfType<GroupBox>().SelectMany(ctl => ctl.Controls.OfType<CheckBox>()))
                {
                    (c).Checked = false;
                }
            }
        }

        //public void SetDataSource()
        //{
        //    comBoxUsrList.DataSource = null;

        //    new OnLoadSystemCommonData().GetUserList();

        //    IList<string> lstUsr = CommonData.UsrList.Select(usr => usr.UsrCode + "-" + usr.UsrName).ToList();

        //    comBoxUsrList.DataSource = lstUsr;
        //}
    }
}


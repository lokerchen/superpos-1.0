namespace SuperPOS.UI.Admin
{
    partial class FrmUsrMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxUsrMaintenance = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditUsr = new System.Windows.Forms.Button();
            this.comBoxUsrList = new System.Windows.Forms.ComboBox();
            this.grpBoxEatIn = new System.Windows.Forms.GroupBox();
            this.chkEIPrtBillDisc = new System.Windows.Forms.CheckBox();
            this.chkEISOPrtReceipt = new System.Windows.Forms.CheckBox();
            this.chkEISOEditOrder = new System.Windows.Forms.CheckBox();
            this.chkEISOChangePayment = new System.Windows.Forms.CheckBox();
            this.chkEISOPrtAcctSummary = new System.Windows.Forms.CheckBox();
            this.chkEITblBooking = new System.Windows.Forms.CheckBox();
            this.chkEIRemoveItemAfterPrt = new System.Windows.Forms.CheckBox();
            this.chkEIPrintBill = new System.Windows.Forms.CheckBox();
            this.chkEIPay = new System.Windows.Forms.CheckBox();
            this.chkEICtrlPanel = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxGeneral = new System.Windows.Forms.GroupBox();
            this.chkGOpenCashDrawer = new System.Windows.Forms.CheckBox();
            this.chkGASPrtSalesRpt = new System.Windows.Forms.CheckBox();
            this.chkGEIPrtSetup = new System.Windows.Forms.CheckBox();
            this.chkGTakeawayPrtSetup = new System.Windows.Forms.CheckBox();
            this.chkGEatInConfig = new System.Windows.Forms.CheckBox();
            this.chkGTakeawayConfig = new System.Windows.Forms.CheckBox();
            this.chkGSSShiftCode = new System.Windows.Forms.CheckBox();
            this.chkGSSComputerAdd = new System.Windows.Forms.CheckBox();
            this.chkGLogon = new System.Windows.Forms.CheckBox();
            this.chkGASSummaryView = new System.Windows.Forms.CheckBox();
            this.chkRptAccountSummary = new System.Windows.Forms.CheckBox();
            this.chkRptRpt = new System.Windows.Forms.CheckBox();
            this.chkGSSCompactDB = new System.Windows.Forms.CheckBox();
            this.chkGSSDataManager = new System.Windows.Forms.CheckBox();
            this.chkGSSUsrMaintenance = new System.Windows.Forms.CheckBox();
            this.chkGSSSysConf = new System.Windows.Forms.CheckBox();
            this.grpBoxQuickDining = new System.Windows.Forms.GroupBox();
            this.chkQDSOPrtReceipt = new System.Windows.Forms.CheckBox();
            this.chkQDSOEditOrder = new System.Windows.Forms.CheckBox();
            this.chkQDSOChangePayment = new System.Windows.Forms.CheckBox();
            this.chkQDSOPrtAcctSummary = new System.Windows.Forms.CheckBox();
            this.chkQDChangePrice = new System.Windows.Forms.CheckBox();
            this.chkQDCtrlPanel = new System.Windows.Forms.CheckBox();
            this.grpBoxTakeaway = new System.Windows.Forms.GroupBox();
            this.chkTACusLstExprotData = new System.Windows.Forms.CheckBox();
            this.chkTASOPrintReceipt = new System.Windows.Forms.CheckBox();
            this.chkTASOEditOrder = new System.Windows.Forms.CheckBox();
            this.chkTASOChangePayment = new System.Windows.Forms.CheckBox();
            this.chkTASOPrtAcctSummary = new System.Windows.Forms.CheckBox();
            this.chkTAChangePrice = new System.Windows.Forms.CheckBox();
            this.chkTACtrlPanel = new System.Windows.Forms.CheckBox();
            this.grpBoxUsrMaintenance.SuspendLayout();
            this.grpBoxEatIn.SuspendLayout();
            this.grpBoxGeneral.SuspendLayout();
            this.grpBoxQuickDining.SuspendLayout();
            this.grpBoxTakeaway.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxUsrMaintenance
            // 
            this.grpBoxUsrMaintenance.Controls.Add(this.btnExit);
            this.grpBoxUsrMaintenance.Controls.Add(this.btnSave);
            this.grpBoxUsrMaintenance.Controls.Add(this.btnEditUsr);
            this.grpBoxUsrMaintenance.Controls.Add(this.comBoxUsrList);
            this.grpBoxUsrMaintenance.Controls.Add(this.grpBoxEatIn);
            this.grpBoxUsrMaintenance.Controls.Add(this.label1);
            this.grpBoxUsrMaintenance.Controls.Add(this.grpBoxGeneral);
            this.grpBoxUsrMaintenance.Controls.Add(this.grpBoxQuickDining);
            this.grpBoxUsrMaintenance.Controls.Add(this.grpBoxTakeaway);
            this.grpBoxUsrMaintenance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBoxUsrMaintenance.Location = new System.Drawing.Point(13, 13);
            this.grpBoxUsrMaintenance.Name = "grpBoxUsrMaintenance";
            this.grpBoxUsrMaintenance.Size = new System.Drawing.Size(1082, 544);
            this.grpBoxUsrMaintenance.TabIndex = 0;
            this.grpBoxUsrMaintenance.TabStop = false;
            this.grpBoxUsrMaintenance.Text = "User Maintenance";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Olive;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(919, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 48);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(807, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 48);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditUsr
            // 
            this.btnEditUsr.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditUsr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditUsr.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditUsr.ForeColor = System.Drawing.Color.White;
            this.btnEditUsr.Location = new System.Drawing.Point(306, 39);
            this.btnEditUsr.Name = "btnEditUsr";
            this.btnEditUsr.Size = new System.Drawing.Size(100, 30);
            this.btnEditUsr.TabIndex = 6;
            this.btnEditUsr.Text = "Edit User";
            this.btnEditUsr.UseVisualStyleBackColor = false;
            this.btnEditUsr.Click += new System.EventHandler(this.btnEditUsr_Click);
            // 
            // comBoxUsrList
            // 
            this.comBoxUsrList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxUsrList.FormattingEnabled = true;
            this.comBoxUsrList.Location = new System.Drawing.Point(122, 39);
            this.comBoxUsrList.Name = "comBoxUsrList";
            this.comBoxUsrList.Size = new System.Drawing.Size(121, 24);
            this.comBoxUsrList.TabIndex = 5;
            this.comBoxUsrList.SelectedIndexChanged += new System.EventHandler(this.comBoxUsrList_SelectedIndexChanged);
            // 
            // grpBoxEatIn
            // 
            this.grpBoxEatIn.Controls.Add(this.chkEIPrtBillDisc);
            this.grpBoxEatIn.Controls.Add(this.chkEISOPrtReceipt);
            this.grpBoxEatIn.Controls.Add(this.chkEISOEditOrder);
            this.grpBoxEatIn.Controls.Add(this.chkEISOChangePayment);
            this.grpBoxEatIn.Controls.Add(this.chkEISOPrtAcctSummary);
            this.grpBoxEatIn.Controls.Add(this.chkEITblBooking);
            this.grpBoxEatIn.Controls.Add(this.chkEIRemoveItemAfterPrt);
            this.grpBoxEatIn.Controls.Add(this.chkEIPrintBill);
            this.grpBoxEatIn.Controls.Add(this.chkEIPay);
            this.grpBoxEatIn.Controls.Add(this.chkEICtrlPanel);
            this.grpBoxEatIn.Location = new System.Drawing.Point(752, 109);
            this.grpBoxEatIn.Name = "grpBoxEatIn";
            this.grpBoxEatIn.Size = new System.Drawing.Size(312, 426);
            this.grpBoxEatIn.TabIndex = 3;
            this.grpBoxEatIn.TabStop = false;
            this.grpBoxEatIn.Text = "Eat-In Access";
            // 
            // chkEIPrtBillDisc
            // 
            this.chkEIPrtBillDisc.AutoSize = true;
            this.chkEIPrtBillDisc.Location = new System.Drawing.Point(24, 272);
            this.chkEIPrtBillDisc.Name = "chkEIPrtBillDisc";
            this.chkEIPrtBillDisc.Size = new System.Drawing.Size(195, 20);
            this.chkEIPrtBillDisc.TabIndex = 9;
            this.chkEIPrtBillDisc.Text = "Print Bill / Discount";
            this.chkEIPrtBillDisc.UseVisualStyleBackColor = true;
            // 
            // chkEISOPrtReceipt
            // 
            this.chkEISOPrtReceipt.AutoSize = true;
            this.chkEISOPrtReceipt.Location = new System.Drawing.Point(24, 211);
            this.chkEISOPrtReceipt.Name = "chkEISOPrtReceipt";
            this.chkEISOPrtReceipt.Size = new System.Drawing.Size(235, 20);
            this.chkEISOPrtReceipt.TabIndex = 8;
            this.chkEISOPrtReceipt.Text = "Show Order / Print Receipt";
            this.chkEISOPrtReceipt.UseVisualStyleBackColor = true;
            // 
            // chkEISOEditOrder
            // 
            this.chkEISOEditOrder.AutoSize = true;
            this.chkEISOEditOrder.Location = new System.Drawing.Point(24, 189);
            this.chkEISOEditOrder.Name = "chkEISOEditOrder";
            this.chkEISOEditOrder.Size = new System.Drawing.Size(211, 20);
            this.chkEISOEditOrder.TabIndex = 7;
            this.chkEISOEditOrder.Text = "Show Order / Edit Order";
            this.chkEISOEditOrder.UseVisualStyleBackColor = true;
            // 
            // chkEISOChangePayment
            // 
            this.chkEISOChangePayment.AutoSize = true;
            this.chkEISOChangePayment.Location = new System.Drawing.Point(24, 166);
            this.chkEISOChangePayment.Name = "chkEISOChangePayment";
            this.chkEISOChangePayment.Size = new System.Drawing.Size(243, 20);
            this.chkEISOChangePayment.TabIndex = 6;
            this.chkEISOChangePayment.Text = "Show Order / Change Payment";
            this.chkEISOChangePayment.UseVisualStyleBackColor = true;
            // 
            // chkEISOPrtAcctSummary
            // 
            this.chkEISOPrtAcctSummary.AutoSize = true;
            this.chkEISOPrtAcctSummary.Location = new System.Drawing.Point(24, 143);
            this.chkEISOPrtAcctSummary.Name = "chkEISOPrtAcctSummary";
            this.chkEISOPrtAcctSummary.Size = new System.Drawing.Size(275, 20);
            this.chkEISOPrtAcctSummary.TabIndex = 5;
            this.chkEISOPrtAcctSummary.Text = "Show Order / Print Acct Summary";
            this.chkEISOPrtAcctSummary.UseVisualStyleBackColor = true;
            // 
            // chkEITblBooking
            // 
            this.chkEITblBooking.AutoSize = true;
            this.chkEITblBooking.Location = new System.Drawing.Point(24, 121);
            this.chkEITblBooking.Name = "chkEITblBooking";
            this.chkEITblBooking.Size = new System.Drawing.Size(131, 20);
            this.chkEITblBooking.TabIndex = 4;
            this.chkEITblBooking.Text = "Table Booking";
            this.chkEITblBooking.UseVisualStyleBackColor = true;
            // 
            // chkEIRemoveItemAfterPrt
            // 
            this.chkEIRemoveItemAfterPrt.AutoSize = true;
            this.chkEIRemoveItemAfterPrt.Location = new System.Drawing.Point(24, 97);
            this.chkEIRemoveItemAfterPrt.Name = "chkEIRemoveItemAfterPrt";
            this.chkEIRemoveItemAfterPrt.Size = new System.Drawing.Size(227, 20);
            this.chkEIRemoveItemAfterPrt.TabIndex = 3;
            this.chkEIRemoveItemAfterPrt.Text = "Remove Item After Printed";
            this.chkEIRemoveItemAfterPrt.UseVisualStyleBackColor = true;
            // 
            // chkEIPrintBill
            // 
            this.chkEIPrintBill.AutoSize = true;
            this.chkEIPrintBill.Location = new System.Drawing.Point(24, 75);
            this.chkEIPrintBill.Name = "chkEIPrintBill";
            this.chkEIPrintBill.Size = new System.Drawing.Size(107, 20);
            this.chkEIPrintBill.TabIndex = 2;
            this.chkEIPrintBill.Text = "Print Bill";
            this.chkEIPrintBill.UseVisualStyleBackColor = true;
            // 
            // chkEIPay
            // 
            this.chkEIPay.AutoSize = true;
            this.chkEIPay.Location = new System.Drawing.Point(24, 52);
            this.chkEIPay.Name = "chkEIPay";
            this.chkEIPay.Size = new System.Drawing.Size(51, 20);
            this.chkEIPay.TabIndex = 1;
            this.chkEIPay.Text = "Pay";
            this.chkEIPay.UseVisualStyleBackColor = true;
            // 
            // chkEICtrlPanel
            // 
            this.chkEICtrlPanel.AutoSize = true;
            this.chkEICtrlPanel.Location = new System.Drawing.Point(24, 29);
            this.chkEICtrlPanel.Name = "chkEICtrlPanel";
            this.chkEICtrlPanel.Size = new System.Drawing.Size(131, 20);
            this.chkEICtrlPanel.TabIndex = 0;
            this.chkEICtrlPanel.Text = "Control Panel";
            this.chkEICtrlPanel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name:";
            // 
            // grpBoxGeneral
            // 
            this.grpBoxGeneral.Controls.Add(this.chkGOpenCashDrawer);
            this.grpBoxGeneral.Controls.Add(this.chkGASPrtSalesRpt);
            this.grpBoxGeneral.Controls.Add(this.chkGEIPrtSetup);
            this.grpBoxGeneral.Controls.Add(this.chkGTakeawayPrtSetup);
            this.grpBoxGeneral.Controls.Add(this.chkGEatInConfig);
            this.grpBoxGeneral.Controls.Add(this.chkGTakeawayConfig);
            this.grpBoxGeneral.Controls.Add(this.chkGSSShiftCode);
            this.grpBoxGeneral.Controls.Add(this.chkGSSComputerAdd);
            this.grpBoxGeneral.Controls.Add(this.chkGLogon);
            this.grpBoxGeneral.Controls.Add(this.chkGASSummaryView);
            this.grpBoxGeneral.Controls.Add(this.chkRptAccountSummary);
            this.grpBoxGeneral.Controls.Add(this.chkRptRpt);
            this.grpBoxGeneral.Controls.Add(this.chkGSSCompactDB);
            this.grpBoxGeneral.Controls.Add(this.chkGSSDataManager);
            this.grpBoxGeneral.Controls.Add(this.chkGSSUsrMaintenance);
            this.grpBoxGeneral.Controls.Add(this.chkGSSSysConf);
            this.grpBoxGeneral.Location = new System.Drawing.Point(22, 309);
            this.grpBoxGeneral.Name = "grpBoxGeneral";
            this.grpBoxGeneral.Size = new System.Drawing.Size(721, 226);
            this.grpBoxGeneral.TabIndex = 2;
            this.grpBoxGeneral.TabStop = false;
            this.grpBoxGeneral.Text = "General Access";
            // 
            // chkGOpenCashDrawer
            // 
            this.chkGOpenCashDrawer.AutoSize = true;
            this.chkGOpenCashDrawer.Location = new System.Drawing.Point(433, 186);
            this.chkGOpenCashDrawer.Name = "chkGOpenCashDrawer";
            this.chkGOpenCashDrawer.Size = new System.Drawing.Size(155, 20);
            this.chkGOpenCashDrawer.TabIndex = 15;
            this.chkGOpenCashDrawer.Text = "Open Cash Drawer";
            this.chkGOpenCashDrawer.UseVisualStyleBackColor = true;
            // 
            // chkGASPrtSalesRpt
            // 
            this.chkGASPrtSalesRpt.AutoSize = true;
            this.chkGASPrtSalesRpt.Location = new System.Drawing.Point(433, 163);
            this.chkGASPrtSalesRpt.Name = "chkGASPrtSalesRpt";
            this.chkGASPrtSalesRpt.Size = new System.Drawing.Size(291, 20);
            this.chkGASPrtSalesRpt.TabIndex = 14;
            this.chkGASPrtSalesRpt.Text = "Account Summary / Print Sales Rpt";
            this.chkGASPrtSalesRpt.UseVisualStyleBackColor = true;
            // 
            // chkGEIPrtSetup
            // 
            this.chkGEIPrtSetup.AutoSize = true;
            this.chkGEIPrtSetup.Location = new System.Drawing.Point(433, 140);
            this.chkGEIPrtSetup.Name = "chkGEIPrtSetup";
            this.chkGEIPrtSetup.Size = new System.Drawing.Size(187, 20);
            this.chkGEIPrtSetup.TabIndex = 13;
            this.chkGEIPrtSetup.Text = "Eat-In / Print Setup";
            this.chkGEIPrtSetup.UseVisualStyleBackColor = true;
            // 
            // chkGTakeawayPrtSetup
            // 
            this.chkGTakeawayPrtSetup.AutoSize = true;
            this.chkGTakeawayPrtSetup.Location = new System.Drawing.Point(433, 117);
            this.chkGTakeawayPrtSetup.Name = "chkGTakeawayPrtSetup";
            this.chkGTakeawayPrtSetup.Size = new System.Drawing.Size(203, 20);
            this.chkGTakeawayPrtSetup.TabIndex = 12;
            this.chkGTakeawayPrtSetup.Text = "Takeaway / Print Setup";
            this.chkGTakeawayPrtSetup.UseVisualStyleBackColor = true;
            // 
            // chkGEatInConfig
            // 
            this.chkGEatInConfig.AutoSize = true;
            this.chkGEatInConfig.Location = new System.Drawing.Point(433, 95);
            this.chkGEatInConfig.Name = "chkGEatInConfig";
            this.chkGEatInConfig.Size = new System.Drawing.Size(187, 20);
            this.chkGEatInConfig.TabIndex = 11;
            this.chkGEatInConfig.Text = "Eat-In Configuration";
            this.chkGEatInConfig.UseVisualStyleBackColor = true;
            // 
            // chkGTakeawayConfig
            // 
            this.chkGTakeawayConfig.AutoSize = true;
            this.chkGTakeawayConfig.Location = new System.Drawing.Point(433, 72);
            this.chkGTakeawayConfig.Name = "chkGTakeawayConfig";
            this.chkGTakeawayConfig.Size = new System.Drawing.Size(203, 20);
            this.chkGTakeawayConfig.TabIndex = 10;
            this.chkGTakeawayConfig.Text = "Takeaway Configuration";
            this.chkGTakeawayConfig.UseVisualStyleBackColor = true;
            // 
            // chkGSSShiftCode
            // 
            this.chkGSSShiftCode.AutoSize = true;
            this.chkGSSShiftCode.Location = new System.Drawing.Point(433, 49);
            this.chkGSSShiftCode.Name = "chkGSSShiftCode";
            this.chkGSSShiftCode.Size = new System.Drawing.Size(243, 20);
            this.chkGSSShiftCode.TabIndex = 9;
            this.chkGSSShiftCode.Text = "System Setting / Shift Code";
            this.chkGSSShiftCode.UseVisualStyleBackColor = true;
            // 
            // chkGSSComputerAdd
            // 
            this.chkGSSComputerAdd.AutoSize = true;
            this.chkGSSComputerAdd.Location = new System.Drawing.Point(433, 26);
            this.chkGSSComputerAdd.Name = "chkGSSComputerAdd";
            this.chkGSSComputerAdd.Size = new System.Drawing.Size(267, 20);
            this.chkGSSComputerAdd.TabIndex = 8;
            this.chkGSSComputerAdd.Text = "System Setting / Computer Add.";
            this.chkGSSComputerAdd.UseVisualStyleBackColor = true;
            // 
            // chkGLogon
            // 
            this.chkGLogon.AutoSize = true;
            this.chkGLogon.Location = new System.Drawing.Point(27, 186);
            this.chkGLogon.Name = "chkGLogon";
            this.chkGLogon.Size = new System.Drawing.Size(267, 20);
            this.chkGLogon.TabIndex = 7;
            this.chkGLogon.Text = "Logon screen EXIT POS software";
            this.chkGLogon.UseVisualStyleBackColor = true;
            // 
            // chkGASSummaryView
            // 
            this.chkGASSummaryView.AutoSize = true;
            this.chkGASSummaryView.Location = new System.Drawing.Point(27, 163);
            this.chkGASSummaryView.Name = "chkGASSummaryView";
            this.chkGASSummaryView.Size = new System.Drawing.Size(267, 20);
            this.chkGASSummaryView.TabIndex = 6;
            this.chkGASSummaryView.Text = "Account Summary / Summary View";
            this.chkGASSummaryView.UseVisualStyleBackColor = true;
            // 
            // chkRptAccountSummary
            // 
            this.chkRptAccountSummary.AutoSize = true;
            this.chkRptAccountSummary.Location = new System.Drawing.Point(27, 140);
            this.chkRptAccountSummary.Name = "chkRptAccountSummary";
            this.chkRptAccountSummary.Size = new System.Drawing.Size(243, 20);
            this.chkRptAccountSummary.TabIndex = 5;
            this.chkRptAccountSummary.Text = "Reporting / Account Summary";
            this.chkRptAccountSummary.UseVisualStyleBackColor = true;
            // 
            // chkRptRpt
            // 
            this.chkRptRpt.AutoSize = true;
            this.chkRptRpt.Location = new System.Drawing.Point(27, 117);
            this.chkRptRpt.Name = "chkRptRpt";
            this.chkRptRpt.Size = new System.Drawing.Size(179, 20);
            this.chkRptRpt.TabIndex = 4;
            this.chkRptRpt.Text = "Reporting / Reports";
            this.chkRptRpt.UseVisualStyleBackColor = true;
            // 
            // chkGSSCompactDB
            // 
            this.chkGSSCompactDB.AutoSize = true;
            this.chkGSSCompactDB.Location = new System.Drawing.Point(27, 95);
            this.chkGSSCompactDB.Name = "chkGSSCompactDB";
            this.chkGSSCompactDB.Size = new System.Drawing.Size(291, 20);
            this.chkGSSCompactDB.TabIndex = 3;
            this.chkGSSCompactDB.Text = "System Setting / Compact Database";
            this.chkGSSCompactDB.UseVisualStyleBackColor = true;
            // 
            // chkGSSDataManager
            // 
            this.chkGSSDataManager.AutoSize = true;
            this.chkGSSDataManager.Location = new System.Drawing.Point(27, 72);
            this.chkGSSDataManager.Name = "chkGSSDataManager";
            this.chkGSSDataManager.Size = new System.Drawing.Size(259, 20);
            this.chkGSSDataManager.TabIndex = 2;
            this.chkGSSDataManager.Text = "System Setting / Data Manager";
            this.chkGSSDataManager.UseVisualStyleBackColor = true;
            // 
            // chkGSSUsrMaintenance
            // 
            this.chkGSSUsrMaintenance.AutoSize = true;
            this.chkGSSUsrMaintenance.Location = new System.Drawing.Point(27, 49);
            this.chkGSSUsrMaintenance.Name = "chkGSSUsrMaintenance";
            this.chkGSSUsrMaintenance.Size = new System.Drawing.Size(291, 20);
            this.chkGSSUsrMaintenance.TabIndex = 1;
            this.chkGSSUsrMaintenance.Text = "System Setting / User Maintenance";
            this.chkGSSUsrMaintenance.UseVisualStyleBackColor = true;
            // 
            // chkGSSSysConf
            // 
            this.chkGSSSysConf.AutoSize = true;
            this.chkGSSSysConf.Location = new System.Drawing.Point(27, 26);
            this.chkGSSSysConf.Name = "chkGSSSysConf";
            this.chkGSSSysConf.Size = new System.Drawing.Size(267, 20);
            this.chkGSSSysConf.TabIndex = 0;
            this.chkGSSSysConf.Text = "System Setting / System Config";
            this.chkGSSSysConf.UseVisualStyleBackColor = true;
            // 
            // grpBoxQuickDining
            // 
            this.grpBoxQuickDining.Controls.Add(this.chkQDSOPrtReceipt);
            this.grpBoxQuickDining.Controls.Add(this.chkQDSOEditOrder);
            this.grpBoxQuickDining.Controls.Add(this.chkQDSOChangePayment);
            this.grpBoxQuickDining.Controls.Add(this.chkQDSOPrtAcctSummary);
            this.grpBoxQuickDining.Controls.Add(this.chkQDChangePrice);
            this.grpBoxQuickDining.Controls.Add(this.chkQDCtrlPanel);
            this.grpBoxQuickDining.Location = new System.Drawing.Point(408, 109);
            this.grpBoxQuickDining.Name = "grpBoxQuickDining";
            this.grpBoxQuickDining.Size = new System.Drawing.Size(338, 190);
            this.grpBoxQuickDining.TabIndex = 1;
            this.grpBoxQuickDining.TabStop = false;
            this.grpBoxQuickDining.Text = "Quick Dining Access";
            // 
            // chkQDSOPrtReceipt
            // 
            this.chkQDSOPrtReceipt.AutoSize = true;
            this.chkQDSOPrtReceipt.Location = new System.Drawing.Point(47, 154);
            this.chkQDSOPrtReceipt.Name = "chkQDSOPrtReceipt";
            this.chkQDSOPrtReceipt.Size = new System.Drawing.Size(235, 20);
            this.chkQDSOPrtReceipt.TabIndex = 5;
            this.chkQDSOPrtReceipt.Text = "Show Order / Print Receipt";
            this.chkQDSOPrtReceipt.UseVisualStyleBackColor = true;
            // 
            // chkQDSOEditOrder
            // 
            this.chkQDSOEditOrder.AutoSize = true;
            this.chkQDSOEditOrder.Location = new System.Drawing.Point(47, 131);
            this.chkQDSOEditOrder.Name = "chkQDSOEditOrder";
            this.chkQDSOEditOrder.Size = new System.Drawing.Size(211, 20);
            this.chkQDSOEditOrder.TabIndex = 4;
            this.chkQDSOEditOrder.Text = "Show Order / Edit Order";
            this.chkQDSOEditOrder.UseVisualStyleBackColor = true;
            // 
            // chkQDSOChangePayment
            // 
            this.chkQDSOChangePayment.AutoSize = true;
            this.chkQDSOChangePayment.Location = new System.Drawing.Point(47, 109);
            this.chkQDSOChangePayment.Name = "chkQDSOChangePayment";
            this.chkQDSOChangePayment.Size = new System.Drawing.Size(243, 20);
            this.chkQDSOChangePayment.TabIndex = 3;
            this.chkQDSOChangePayment.Text = "Show Order / Change Payment";
            this.chkQDSOChangePayment.UseVisualStyleBackColor = true;
            // 
            // chkQDSOPrtAcctSummary
            // 
            this.chkQDSOPrtAcctSummary.AutoSize = true;
            this.chkQDSOPrtAcctSummary.Location = new System.Drawing.Point(47, 86);
            this.chkQDSOPrtAcctSummary.Name = "chkQDSOPrtAcctSummary";
            this.chkQDSOPrtAcctSummary.Size = new System.Drawing.Size(275, 20);
            this.chkQDSOPrtAcctSummary.TabIndex = 2;
            this.chkQDSOPrtAcctSummary.Text = "Show Order / Print Acct Summary";
            this.chkQDSOPrtAcctSummary.UseVisualStyleBackColor = true;
            // 
            // chkQDChangePrice
            // 
            this.chkQDChangePrice.AutoSize = true;
            this.chkQDChangePrice.Location = new System.Drawing.Point(47, 63);
            this.chkQDChangePrice.Name = "chkQDChangePrice";
            this.chkQDChangePrice.Size = new System.Drawing.Size(123, 20);
            this.chkQDChangePrice.TabIndex = 1;
            this.chkQDChangePrice.Text = "Change Price";
            this.chkQDChangePrice.UseVisualStyleBackColor = true;
            // 
            // chkQDCtrlPanel
            // 
            this.chkQDCtrlPanel.AutoSize = true;
            this.chkQDCtrlPanel.Location = new System.Drawing.Point(47, 40);
            this.chkQDCtrlPanel.Name = "chkQDCtrlPanel";
            this.chkQDCtrlPanel.Size = new System.Drawing.Size(131, 20);
            this.chkQDCtrlPanel.TabIndex = 0;
            this.chkQDCtrlPanel.Text = "Control Panel";
            this.chkQDCtrlPanel.UseVisualStyleBackColor = true;
            // 
            // grpBoxTakeaway
            // 
            this.grpBoxTakeaway.Controls.Add(this.chkTACusLstExprotData);
            this.grpBoxTakeaway.Controls.Add(this.chkTASOPrintReceipt);
            this.grpBoxTakeaway.Controls.Add(this.chkTASOEditOrder);
            this.grpBoxTakeaway.Controls.Add(this.chkTASOChangePayment);
            this.grpBoxTakeaway.Controls.Add(this.chkTASOPrtAcctSummary);
            this.grpBoxTakeaway.Controls.Add(this.chkTAChangePrice);
            this.grpBoxTakeaway.Controls.Add(this.chkTACtrlPanel);
            this.grpBoxTakeaway.Location = new System.Drawing.Point(22, 107);
            this.grpBoxTakeaway.Name = "grpBoxTakeaway";
            this.grpBoxTakeaway.Size = new System.Drawing.Size(345, 192);
            this.grpBoxTakeaway.TabIndex = 0;
            this.grpBoxTakeaway.TabStop = false;
            this.grpBoxTakeaway.Text = "Takeaway Access";
            // 
            // chkTACusLstExprotData
            // 
            this.chkTACusLstExprotData.AutoSize = true;
            this.chkTACusLstExprotData.Location = new System.Drawing.Point(27, 164);
            this.chkTACusLstExprotData.Name = "chkTACusLstExprotData";
            this.chkTACusLstExprotData.Size = new System.Drawing.Size(243, 20);
            this.chkTACusLstExprotData.TabIndex = 6;
            this.chkTACusLstExprotData.Text = "Customer List / Export Data";
            this.chkTACusLstExprotData.UseVisualStyleBackColor = true;
            // 
            // chkTASOPrintReceipt
            // 
            this.chkTASOPrintReceipt.AutoSize = true;
            this.chkTASOPrintReceipt.Location = new System.Drawing.Point(27, 145);
            this.chkTASOPrintReceipt.Name = "chkTASOPrintReceipt";
            this.chkTASOPrintReceipt.Size = new System.Drawing.Size(235, 20);
            this.chkTASOPrintReceipt.TabIndex = 5;
            this.chkTASOPrintReceipt.Text = "Show Order / Print Receipt";
            this.chkTASOPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // chkTASOEditOrder
            // 
            this.chkTASOEditOrder.AutoSize = true;
            this.chkTASOEditOrder.Location = new System.Drawing.Point(27, 122);
            this.chkTASOEditOrder.Name = "chkTASOEditOrder";
            this.chkTASOEditOrder.Size = new System.Drawing.Size(211, 20);
            this.chkTASOEditOrder.TabIndex = 4;
            this.chkTASOEditOrder.Text = "Show Order / Edit Order";
            this.chkTASOEditOrder.UseVisualStyleBackColor = true;
            // 
            // chkTASOChangePayment
            // 
            this.chkTASOChangePayment.AutoSize = true;
            this.chkTASOChangePayment.Location = new System.Drawing.Point(27, 99);
            this.chkTASOChangePayment.Name = "chkTASOChangePayment";
            this.chkTASOChangePayment.Size = new System.Drawing.Size(243, 20);
            this.chkTASOChangePayment.TabIndex = 3;
            this.chkTASOChangePayment.Text = "Show Order / Change Payment";
            this.chkTASOChangePayment.UseVisualStyleBackColor = true;
            // 
            // chkTASOPrtAcctSummary
            // 
            this.chkTASOPrtAcctSummary.AutoSize = true;
            this.chkTASOPrtAcctSummary.Location = new System.Drawing.Point(27, 76);
            this.chkTASOPrtAcctSummary.Name = "chkTASOPrtAcctSummary";
            this.chkTASOPrtAcctSummary.Size = new System.Drawing.Size(275, 20);
            this.chkTASOPrtAcctSummary.TabIndex = 2;
            this.chkTASOPrtAcctSummary.Text = "Show Order / Print Acct Summary";
            this.chkTASOPrtAcctSummary.UseVisualStyleBackColor = true;
            // 
            // chkTAChangePrice
            // 
            this.chkTAChangePrice.AutoSize = true;
            this.chkTAChangePrice.Location = new System.Drawing.Point(27, 53);
            this.chkTAChangePrice.Name = "chkTAChangePrice";
            this.chkTAChangePrice.Size = new System.Drawing.Size(123, 20);
            this.chkTAChangePrice.TabIndex = 1;
            this.chkTAChangePrice.Text = "Change Price";
            this.chkTAChangePrice.UseVisualStyleBackColor = true;
            // 
            // chkTACtrlPanel
            // 
            this.chkTACtrlPanel.AutoSize = true;
            this.chkTACtrlPanel.Location = new System.Drawing.Point(27, 30);
            this.chkTACtrlPanel.Name = "chkTACtrlPanel";
            this.chkTACtrlPanel.Size = new System.Drawing.Size(131, 20);
            this.chkTACtrlPanel.TabIndex = 0;
            this.chkTACtrlPanel.Text = "Control Panel";
            this.chkTACtrlPanel.UseVisualStyleBackColor = true;
            // 
            // FrmUsrMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 563);
            this.Controls.Add(this.grpBoxUsrMaintenance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsrMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsrMaintenance";
            this.Load += new System.EventHandler(this.FrmUsrMaintenance_Load);
            this.grpBoxUsrMaintenance.ResumeLayout(false);
            this.grpBoxUsrMaintenance.PerformLayout();
            this.grpBoxEatIn.ResumeLayout(false);
            this.grpBoxEatIn.PerformLayout();
            this.grpBoxGeneral.ResumeLayout(false);
            this.grpBoxGeneral.PerformLayout();
            this.grpBoxQuickDining.ResumeLayout(false);
            this.grpBoxQuickDining.PerformLayout();
            this.grpBoxTakeaway.ResumeLayout(false);
            this.grpBoxTakeaway.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxUsrMaintenance;
        private System.Windows.Forms.GroupBox grpBoxEatIn;
        private System.Windows.Forms.GroupBox grpBoxGeneral;
        private System.Windows.Forms.GroupBox grpBoxQuickDining;
        private System.Windows.Forms.CheckBox chkQDSOPrtReceipt;
        private System.Windows.Forms.CheckBox chkQDSOEditOrder;
        private System.Windows.Forms.CheckBox chkQDSOChangePayment;
        private System.Windows.Forms.CheckBox chkQDSOPrtAcctSummary;
        private System.Windows.Forms.CheckBox chkQDChangePrice;
        private System.Windows.Forms.CheckBox chkQDCtrlPanel;
        private System.Windows.Forms.GroupBox grpBoxTakeaway;
        private System.Windows.Forms.CheckBox chkTACusLstExprotData;
        private System.Windows.Forms.CheckBox chkTASOPrintReceipt;
        private System.Windows.Forms.CheckBox chkTASOEditOrder;
        private System.Windows.Forms.CheckBox chkTASOChangePayment;
        private System.Windows.Forms.CheckBox chkTASOPrtAcctSummary;
        private System.Windows.Forms.CheckBox chkTAChangePrice;
        private System.Windows.Forms.CheckBox chkTACtrlPanel;
        private System.Windows.Forms.CheckBox chkEIPrtBillDisc;
        private System.Windows.Forms.CheckBox chkEISOPrtReceipt;
        private System.Windows.Forms.CheckBox chkEISOEditOrder;
        private System.Windows.Forms.CheckBox chkEISOChangePayment;
        private System.Windows.Forms.CheckBox chkEISOPrtAcctSummary;
        private System.Windows.Forms.CheckBox chkEITblBooking;
        private System.Windows.Forms.CheckBox chkEIRemoveItemAfterPrt;
        private System.Windows.Forms.CheckBox chkEIPrintBill;
        private System.Windows.Forms.CheckBox chkEIPay;
        private System.Windows.Forms.CheckBox chkEICtrlPanel;
        private System.Windows.Forms.CheckBox chkGOpenCashDrawer;
        private System.Windows.Forms.CheckBox chkGASPrtSalesRpt;
        private System.Windows.Forms.CheckBox chkGEIPrtSetup;
        private System.Windows.Forms.CheckBox chkGTakeawayPrtSetup;
        private System.Windows.Forms.CheckBox chkGEatInConfig;
        private System.Windows.Forms.CheckBox chkGTakeawayConfig;
        private System.Windows.Forms.CheckBox chkGSSShiftCode;
        private System.Windows.Forms.CheckBox chkGSSComputerAdd;
        private System.Windows.Forms.CheckBox chkGLogon;
        private System.Windows.Forms.CheckBox chkGASSummaryView;
        private System.Windows.Forms.CheckBox chkRptAccountSummary;
        private System.Windows.Forms.CheckBox chkRptRpt;
        private System.Windows.Forms.CheckBox chkGSSCompactDB;
        private System.Windows.Forms.CheckBox chkGSSDataManager;
        private System.Windows.Forms.CheckBox chkGSSUsrMaintenance;
        private System.Windows.Forms.CheckBox chkGSSSysConf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditUsr;
        private System.Windows.Forms.ComboBox comBoxUsrList;
    }
}
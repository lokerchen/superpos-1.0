namespace SuperPOS.UI
{
    partial class FrmTAShowOrder
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowDriver = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnChangePayment = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSurcharge = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDeliveryCharge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustInfo = new System.Windows.Forms.Button();
            this.btnEatIn = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnCollect = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnPrtAccountSummary = new System.Windows.Forms.Button();
            this.btnPrtKitchenPaper = new System.Windows.Forms.Button();
            this.btnPrtBill = new System.Windows.Forms.Button();
            this.btnPrtReceipt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.dgvTotalOrder = new System.Windows.Forms.DataGridView();
            this.timerCurrent = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnShowDriver);
            this.groupBox1.Controls.Add(this.btnEditOrder);
            this.groupBox1.Controls.Add(this.btnChangePayment);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.lblSurcharge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDeliveryCharge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCustInfo);
            this.groupBox1.Controls.Add(this.btnEatIn);
            this.groupBox1.Controls.Add(this.btnShop);
            this.groupBox1.Controls.Add(this.btnDelivery);
            this.groupBox1.Controls.Add(this.btnCollect);
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.btnPrtAccountSummary);
            this.groupBox1.Controls.Add(this.btnPrtKitchenPaper);
            this.groupBox1.Controls.Add(this.btnPrtBill);
            this.groupBox1.Controls.Add(this.btnPrtReceipt);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvOrderList);
            this.groupBox1.Controls.Add(this.dgvTotalOrder);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(896, 624);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Olive;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(801, 529);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 60);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowDriver
            // 
            this.btnShowDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnShowDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDriver.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowDriver.ForeColor = System.Drawing.Color.White;
            this.btnShowDriver.Location = new System.Drawing.Point(658, 529);
            this.btnShowDriver.Name = "btnShowDriver";
            this.btnShowDriver.Size = new System.Drawing.Size(80, 60);
            this.btnShowDriver.TabIndex = 23;
            this.btnShowDriver.Text = "Show Driver D/C";
            this.btnShowDriver.UseVisualStyleBackColor = false;
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditOrder.ForeColor = System.Drawing.Color.White;
            this.btnEditOrder.Location = new System.Drawing.Point(535, 529);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(80, 60);
            this.btnEditOrder.TabIndex = 22;
            this.btnEditOrder.Text = "Edit Order";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            // 
            // btnChangePayment
            // 
            this.btnChangePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChangePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePayment.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChangePayment.ForeColor = System.Drawing.Color.White;
            this.btnChangePayment.Location = new System.Drawing.Point(415, 529);
            this.btnChangePayment.Name = "btnChangePayment";
            this.btnChangePayment.Size = new System.Drawing.Size(80, 60);
            this.btnChangePayment.TabIndex = 21;
            this.btnChangePayment.Text = "Change Payment";
            this.btnChangePayment.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTotalAmount);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtItems);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(6, 558);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 59);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTotalAmount.Location = new System.Drawing.Point(262, 16);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(81, 29);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.Text = "129.70";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(141, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total Amount";
            // 
            // txtItems
            // 
            this.txtItems.Enabled = false;
            this.txtItems.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtItems.Location = new System.Drawing.Point(65, 16);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(55, 29);
            this.txtItems.TabIndex = 1;
            this.txtItems.Text = "11";
            this.txtItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Items";
            // 
            // lblSurcharge
            // 
            this.lblSurcharge.AutoSize = true;
            this.lblSurcharge.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSurcharge.Location = new System.Drawing.Point(268, 520);
            this.lblSurcharge.Name = "lblSurcharge";
            this.lblSurcharge.Size = new System.Drawing.Size(41, 21);
            this.lblSurcharge.TabIndex = 19;
            this.lblSurcharge.Text = "1.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(171, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Surcharge:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDiscount.Location = new System.Drawing.Point(268, 493);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(41, 21);
            this.lblDiscount.TabIndex = 17;
            this.lblDiscount.Text = "3.80";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(181, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Discount:";
            // 
            // lblDeliveryCharge
            // 
            this.lblDeliveryCharge.AutoSize = true;
            this.lblDeliveryCharge.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeliveryCharge.Location = new System.Drawing.Point(268, 461);
            this.lblDeliveryCharge.Name = "lblDeliveryCharge";
            this.lblDeliveryCharge.Size = new System.Drawing.Size(41, 21);
            this.lblDeliveryCharge.TabIndex = 15;
            this.lblDeliveryCharge.Text = "2.50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(128, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Delivery Charge:";
            // 
            // btnCustInfo
            // 
            this.btnCustInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCustInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCustInfo.ForeColor = System.Drawing.Color.White;
            this.btnCustInfo.Location = new System.Drawing.Point(22, 474);
            this.btnCustInfo.Name = "btnCustInfo";
            this.btnCustInfo.Size = new System.Drawing.Size(80, 60);
            this.btnCustInfo.TabIndex = 13;
            this.btnCustInfo.Text = "Cust Info";
            this.btnCustInfo.UseVisualStyleBackColor = false;
            this.btnCustInfo.Click += new System.EventHandler(this.btnCustInfo_Click);
            // 
            // btnEatIn
            // 
            this.btnEatIn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEatIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEatIn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEatIn.ForeColor = System.Drawing.Color.White;
            this.btnEatIn.Location = new System.Drawing.Point(705, 450);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(80, 60);
            this.btnEatIn.TabIndex = 12;
            this.btnEatIn.Text = "Eat In";
            this.btnEatIn.UseVisualStyleBackColor = false;
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Location = new System.Drawing.Point(620, 450);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(80, 60);
            this.btnShop.TabIndex = 11;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Location = new System.Drawing.Point(535, 450);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(80, 60);
            this.btnDelivery.TabIndex = 10;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = false;
            // 
            // btnCollect
            // 
            this.btnCollect.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCollect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCollect.ForeColor = System.Drawing.Color.White;
            this.btnCollect.Location = new System.Drawing.Point(450, 450);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(80, 60);
            this.btnCollect.TabIndex = 9;
            this.btnCollect.Text = "Collect";
            this.btnCollect.UseVisualStyleBackColor = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(365, 450);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(80, 60);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            // 
            // btnPrtAccountSummary
            // 
            this.btnPrtAccountSummary.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrtAccountSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrtAccountSummary.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrtAccountSummary.ForeColor = System.Drawing.Color.White;
            this.btnPrtAccountSummary.Location = new System.Drawing.Point(777, 354);
            this.btnPrtAccountSummary.Name = "btnPrtAccountSummary";
            this.btnPrtAccountSummary.Size = new System.Drawing.Size(100, 70);
            this.btnPrtAccountSummary.TabIndex = 7;
            this.btnPrtAccountSummary.Text = "Print Account Summary";
            this.btnPrtAccountSummary.UseVisualStyleBackColor = false;
            // 
            // btnPrtKitchenPaper
            // 
            this.btnPrtKitchenPaper.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrtKitchenPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrtKitchenPaper.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrtKitchenPaper.ForeColor = System.Drawing.Color.White;
            this.btnPrtKitchenPaper.Location = new System.Drawing.Point(777, 264);
            this.btnPrtKitchenPaper.Name = "btnPrtKitchenPaper";
            this.btnPrtKitchenPaper.Size = new System.Drawing.Size(100, 70);
            this.btnPrtKitchenPaper.TabIndex = 6;
            this.btnPrtKitchenPaper.Text = "Print Kitchen Paper";
            this.btnPrtKitchenPaper.UseVisualStyleBackColor = false;
            // 
            // btnPrtBill
            // 
            this.btnPrtBill.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrtBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrtBill.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrtBill.ForeColor = System.Drawing.Color.White;
            this.btnPrtBill.Location = new System.Drawing.Point(777, 184);
            this.btnPrtBill.Name = "btnPrtBill";
            this.btnPrtBill.Size = new System.Drawing.Size(100, 60);
            this.btnPrtBill.TabIndex = 5;
            this.btnPrtBill.Text = "Print Bill";
            this.btnPrtBill.UseVisualStyleBackColor = false;
            // 
            // btnPrtReceipt
            // 
            this.btnPrtReceipt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrtReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrtReceipt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrtReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrtReceipt.Location = new System.Drawing.Point(777, 104);
            this.btnPrtReceipt.Name = "btnPrtReceipt";
            this.btnPrtReceipt.Size = new System.Drawing.Size(100, 60);
            this.btnPrtReceipt.TabIndex = 4;
            this.btnPrtReceipt.Text = "Print Receipt";
            this.btnPrtReceipt.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCurrentDate);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(597, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 74);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Date";
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Enabled = false;
            this.txtCurrentDate.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCurrentDate.Location = new System.Drawing.Point(8, 27);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.Size = new System.Drawing.Size(133, 34);
            this.txtCurrentDate.TabIndex = 0;
            this.txtCurrentDate.Text = "2015-11-26";
            this.txtCurrentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCurrentTime);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(365, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Time";
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.Enabled = false;
            this.txtCurrentTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCurrentTime.Location = new System.Drawing.Point(9, 28);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.Size = new System.Drawing.Size(140, 34);
            this.txtCurrentTime.TabIndex = 0;
            this.txtCurrentTime.Text = "23:37:56";
            this.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(365, 104);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowTemplate.Height = 23;
            this.dgvOrderList.Size = new System.Drawing.Size(387, 327);
            this.dgvOrderList.TabIndex = 1;
            // 
            // dgvTotalOrder
            // 
            this.dgvTotalOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalOrder.Location = new System.Drawing.Point(22, 24);
            this.dgvTotalOrder.Name = "dgvTotalOrder";
            this.dgvTotalOrder.RowTemplate.Height = 23;
            this.dgvTotalOrder.Size = new System.Drawing.Size(300, 421);
            this.dgvTotalOrder.TabIndex = 0;
            // 
            // timerCurrent
            // 
            this.timerCurrent.Interval = 1000;
            this.timerCurrent.Tick += new System.EventHandler(this.timerCurrent_Tick);
            // 
            // FrmTAShowOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 652);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTAShowOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowOrder";
            this.Load += new System.EventHandler(this.FrmShowOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowDriver;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnChangePayment;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSurcharge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDeliveryCharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustInfo;
        private System.Windows.Forms.Button btnEatIn;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnPrtAccountSummary;
        private System.Windows.Forms.Button btnPrtKitchenPaper;
        private System.Windows.Forms.Button btnPrtBill;
        private System.Windows.Forms.Button btnPrtReceipt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.DataGridView dgvTotalOrder;
        private System.Windows.Forms.Timer timerCurrent;
    }
}
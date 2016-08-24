namespace SuperPOS.UI.TakeAway
{
    partial class FrmTAPendOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPendOrder = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnCollection = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.txtDeliveryCharge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPrtKit = new System.Windows.Forms.Button();
            this.btnPrtBill = new System.Windows.Forms.Button();
            this.btnPrtReceipt = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowAssign = new System.Windows.Forms.Button();
            this.btnShowUnAssign = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPendOrder);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pending TA Orders List View\r\n";
            // 
            // dgvPendOrder
            // 
            this.dgvPendOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPendOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPendOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendOrder.Location = new System.Drawing.Point(10, 29);
            this.dgvPendOrder.MultiSelect = false;
            this.dgvPendOrder.Name = "dgvPendOrder";
            this.dgvPendOrder.ReadOnly = true;
            this.dgvPendOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPendOrder.RowTemplate.Height = 23;
            this.dgvPendOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendOrder.Size = new System.Drawing.Size(864, 355);
            this.dgvPendOrder.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAll);
            this.groupBox2.Controls.Add(this.btnShop);
            this.groupBox2.Controls.Add(this.btnCollection);
            this.groupBox2.Controls.Add(this.btnDelivery);
            this.groupBox2.Controls.Add(this.txtDeliveryCharge);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(883, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(733, 19);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(100, 30);
            this.btnAll.TabIndex = 93;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnShop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Location = new System.Drawing.Point(608, 19);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(100, 30);
            this.btnShop.TabIndex = 92;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnCollection
            // 
            this.btnCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCollection.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCollection.FlatAppearance.BorderSize = 0;
            this.btnCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollection.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCollection.ForeColor = System.Drawing.Color.White;
            this.btnCollection.Location = new System.Drawing.Point(482, 19);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(100, 30);
            this.btnCollection.TabIndex = 91;
            this.btnCollection.Text = "Collection";
            this.btnCollection.UseVisualStyleBackColor = false;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.Red;
            this.btnDelivery.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelivery.FlatAppearance.BorderSize = 0;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Location = new System.Drawing.Point(354, 19);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(100, 30);
            this.btnDelivery.TabIndex = 90;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // txtDeliveryCharge
            // 
            this.txtDeliveryCharge.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeliveryCharge.Location = new System.Drawing.Point(152, 22);
            this.txtDeliveryCharge.Name = "txtDeliveryCharge";
            this.txtDeliveryCharge.ReadOnly = true;
            this.txtDeliveryCharge.Size = new System.Drawing.Size(100, 34);
            this.txtDeliveryCharge.TabIndex = 1;
            this.txtDeliveryCharge.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery Charge:";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(899, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 55);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPrtKit
            // 
            this.btnPrtKit.BackColor = System.Drawing.Color.Navy;
            this.btnPrtKit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrtKit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrtKit.ForeColor = System.Drawing.Color.White;
            this.btnPrtKit.Location = new System.Drawing.Point(899, 240);
            this.btnPrtKit.Name = "btnPrtKit";
            this.btnPrtKit.Size = new System.Drawing.Size(100, 55);
            this.btnPrtKit.TabIndex = 88;
            this.btnPrtKit.Text = "Print Kitchen Paper";
            this.btnPrtKit.UseVisualStyleBackColor = false;
            this.btnPrtKit.Click += new System.EventHandler(this.btnPrtKit_Click);
            // 
            // btnPrtBill
            // 
            this.btnPrtBill.BackColor = System.Drawing.Color.Navy;
            this.btnPrtBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrtBill.ForeColor = System.Drawing.Color.White;
            this.btnPrtBill.Location = new System.Drawing.Point(899, 176);
            this.btnPrtBill.Name = "btnPrtBill";
            this.btnPrtBill.Size = new System.Drawing.Size(100, 55);
            this.btnPrtBill.TabIndex = 87;
            this.btnPrtBill.Text = "Print Bill";
            this.btnPrtBill.UseVisualStyleBackColor = false;
            this.btnPrtBill.Click += new System.EventHandler(this.btnPrtBill_Click);
            // 
            // btnPrtReceipt
            // 
            this.btnPrtReceipt.BackColor = System.Drawing.Color.Navy;
            this.btnPrtReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrtReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrtReceipt.Location = new System.Drawing.Point(899, 112);
            this.btnPrtReceipt.Name = "btnPrtReceipt";
            this.btnPrtReceipt.Size = new System.Drawing.Size(100, 55);
            this.btnPrtReceipt.TabIndex = 86;
            this.btnPrtReceipt.Text = "Print Receipt";
            this.btnPrtReceipt.UseVisualStyleBackColor = false;
            this.btnPrtReceipt.Click += new System.EventHandler(this.btnPrtReceipt_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Blue;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(899, 337);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 55);
            this.btnPay.TabIndex = 89;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(899, 454);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 55);
            this.btnExit.TabIndex = 90;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDriver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDriver.FlatAppearance.BorderSize = 0;
            this.btnDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriver.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDriver.ForeColor = System.Drawing.Color.White;
            this.btnDriver.Location = new System.Drawing.Point(148, 482);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(125, 29);
            this.btnDriver.TabIndex = 94;
            this.btnDriver.Text = "Assign Driver";
            this.btnDriver.UseVisualStyleBackColor = false;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // cmbDriver
            // 
            this.cmbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriver.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(21, 482);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(121, 35);
            this.cmbDriver.TabIndex = 95;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(424, 476);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(130, 35);
            this.btnShowAll.TabIndex = 96;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowAssign
            // 
            this.btnShowAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowAssign.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowAssign.FlatAppearance.BorderSize = 0;
            this.btnShowAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAssign.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowAssign.ForeColor = System.Drawing.Color.White;
            this.btnShowAssign.Location = new System.Drawing.Point(574, 476);
            this.btnShowAssign.Name = "btnShowAssign";
            this.btnShowAssign.Size = new System.Drawing.Size(130, 35);
            this.btnShowAssign.TabIndex = 97;
            this.btnShowAssign.Text = "Show Assigned";
            this.btnShowAssign.UseVisualStyleBackColor = false;
            this.btnShowAssign.Click += new System.EventHandler(this.btnShowAssign_Click);
            // 
            // btnShowUnAssign
            // 
            this.btnShowUnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowUnAssign.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowUnAssign.FlatAppearance.BorderSize = 0;
            this.btnShowUnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUnAssign.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowUnAssign.ForeColor = System.Drawing.Color.White;
            this.btnShowUnAssign.Location = new System.Drawing.Point(724, 476);
            this.btnShowUnAssign.Name = "btnShowUnAssign";
            this.btnShowUnAssign.Size = new System.Drawing.Size(130, 35);
            this.btnShowUnAssign.TabIndex = 98;
            this.btnShowUnAssign.Text = "Show Unassigned";
            this.btnShowUnAssign.UseVisualStyleBackColor = false;
            this.btnShowUnAssign.Click += new System.EventHandler(this.btnShowUnAssign_Click);
            // 
            // FrmTAPendOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 533);
            this.Controls.Add(this.btnShowUnAssign);
            this.Controls.Add(this.btnShowAssign);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.cmbDriver);
            this.Controls.Add(this.btnDriver);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnPrtKit);
            this.Controls.Add(this.btnPrtBill);
            this.Controls.Add(this.btnPrtReceipt);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTAPendOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPendOrder";
            this.Load += new System.EventHandler(this.FrmPendOrder_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPrtKit;
        private System.Windows.Forms.Button btnPrtBill;
        private System.Windows.Forms.Button btnPrtReceipt;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnCollection;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.TextBox txtDeliveryCharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowAssign;
        private System.Windows.Forms.Button btnShowUnAssign;
        private System.Windows.Forms.DataGridView dgvPendOrder;
    }
}
namespace SuperPOS.UI.TakeAway
{
    partial class FrmTAOrderListView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPayExactCash = new System.Windows.Forms.Button();
            this.btnPayCard = new System.Windows.Forms.Button();
            this.btnPrtKitchenPaper = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUnpaidDelivery = new System.Windows.Forms.Button();
            this.btnUnpaidCollection = new System.Windows.Forms.Button();
            this.btnUnpaidShop = new System.Windows.Forms.Button();
            this.btnShowUnassigned = new System.Windows.Forms.Button();
            this.btnShowAssigned = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnAssignDriver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeliveryCharge = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDriver);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAssignDriver);
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.btnShowAssigned);
            this.groupBox1.Controls.Add(this.btnShowUnassigned);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnPrtKitchenPaper);
            this.groupBox1.Controls.Add(this.btnPayCard);
            this.groupBox1.Controls.Add(this.btnPayExactCash);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 599);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pending TA Orders List View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(879, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(920, 60);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 60);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            // 
            // btnPayExactCash
            // 
            this.btnPayExactCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPayExactCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayExactCash.ForeColor = System.Drawing.Color.White;
            this.btnPayExactCash.Location = new System.Drawing.Point(920, 139);
            this.btnPayExactCash.Name = "btnPayExactCash";
            this.btnPayExactCash.Size = new System.Drawing.Size(90, 60);
            this.btnPayExactCash.TabIndex = 2;
            this.btnPayExactCash.Text = "Pay Exact Cash";
            this.btnPayExactCash.UseVisualStyleBackColor = false;
            // 
            // btnPayCard
            // 
            this.btnPayCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPayCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayCard.ForeColor = System.Drawing.Color.White;
            this.btnPayCard.Location = new System.Drawing.Point(920, 227);
            this.btnPayCard.Name = "btnPayCard";
            this.btnPayCard.Size = new System.Drawing.Size(90, 60);
            this.btnPayCard.TabIndex = 3;
            this.btnPayCard.Text = "Pay Card";
            this.btnPayCard.UseVisualStyleBackColor = false;
            // 
            // btnPrtKitchenPaper
            // 
            this.btnPrtKitchenPaper.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrtKitchenPaper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrtKitchenPaper.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrtKitchenPaper.ForeColor = System.Drawing.Color.White;
            this.btnPrtKitchenPaper.Location = new System.Drawing.Point(920, 315);
            this.btnPrtKitchenPaper.Name = "btnPrtKitchenPaper";
            this.btnPrtKitchenPaper.Size = new System.Drawing.Size(90, 70);
            this.btnPrtKitchenPaper.TabIndex = 4;
            this.btnPrtKitchenPaper.Text = "Print Kitchen Paper";
            this.btnPrtKitchenPaper.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Olive;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(891, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDeliveryCharge);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnUnpaidShop);
            this.groupBox2.Controls.Add(this.btnUnpaidCollection);
            this.groupBox2.Controls.Add(this.btnUnpaidDelivery);
            this.groupBox2.Location = new System.Drawing.Point(31, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 63);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnUnpaidDelivery
            // 
            this.btnUnpaidDelivery.BackColor = System.Drawing.Color.Red;
            this.btnUnpaidDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnpaidDelivery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnpaidDelivery.ForeColor = System.Drawing.Color.White;
            this.btnUnpaidDelivery.Location = new System.Drawing.Point(24, 17);
            this.btnUnpaidDelivery.Name = "btnUnpaidDelivery";
            this.btnUnpaidDelivery.Size = new System.Drawing.Size(150, 40);
            this.btnUnpaidDelivery.TabIndex = 2;
            this.btnUnpaidDelivery.Text = "Delivery Unpaid";
            this.btnUnpaidDelivery.UseVisualStyleBackColor = false;
            // 
            // btnUnpaidCollection
            // 
            this.btnUnpaidCollection.BackColor = System.Drawing.Color.Purple;
            this.btnUnpaidCollection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnpaidCollection.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnpaidCollection.ForeColor = System.Drawing.Color.White;
            this.btnUnpaidCollection.Location = new System.Drawing.Point(180, 17);
            this.btnUnpaidCollection.Name = "btnUnpaidCollection";
            this.btnUnpaidCollection.Size = new System.Drawing.Size(150, 40);
            this.btnUnpaidCollection.TabIndex = 3;
            this.btnUnpaidCollection.Text = "Collection Unpaid";
            this.btnUnpaidCollection.UseVisualStyleBackColor = false;
            // 
            // btnUnpaidShop
            // 
            this.btnUnpaidShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUnpaidShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnpaidShop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnpaidShop.ForeColor = System.Drawing.Color.White;
            this.btnUnpaidShop.Location = new System.Drawing.Point(336, 17);
            this.btnUnpaidShop.Name = "btnUnpaidShop";
            this.btnUnpaidShop.Size = new System.Drawing.Size(150, 40);
            this.btnUnpaidShop.TabIndex = 4;
            this.btnUnpaidShop.Text = "Shop Unpaid";
            this.btnUnpaidShop.UseVisualStyleBackColor = false;
            // 
            // btnShowUnassigned
            // 
            this.btnShowUnassigned.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowUnassigned.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowUnassigned.ForeColor = System.Drawing.Color.White;
            this.btnShowUnassigned.Location = new System.Drawing.Point(718, 531);
            this.btnShowUnassigned.Name = "btnShowUnassigned";
            this.btnShowUnassigned.Size = new System.Drawing.Size(110, 50);
            this.btnShowUnassigned.TabIndex = 5;
            this.btnShowUnassigned.Text = "Show Unassigned";
            this.btnShowUnassigned.UseVisualStyleBackColor = false;
            // 
            // btnShowAssigned
            // 
            this.btnShowAssigned.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAssigned.ForeColor = System.Drawing.Color.White;
            this.btnShowAssigned.Location = new System.Drawing.Point(570, 531);
            this.btnShowAssigned.Name = "btnShowAssigned";
            this.btnShowAssigned.Size = new System.Drawing.Size(110, 50);
            this.btnShowAssigned.TabIndex = 7;
            this.btnShowAssigned.Text = "Show Assigned";
            this.btnShowAssigned.UseVisualStyleBackColor = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(424, 531);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(110, 50);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            // 
            // btnAssignDriver
            // 
            this.btnAssignDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAssignDriver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssignDriver.ForeColor = System.Drawing.Color.White;
            this.btnAssignDriver.Location = new System.Drawing.Point(6, 531);
            this.btnAssignDriver.Name = "btnAssignDriver";
            this.btnAssignDriver.Size = new System.Drawing.Size(120, 50);
            this.btnAssignDriver.TabIndex = 9;
            this.btnAssignDriver.Text = "Assign Driver";
            this.btnAssignDriver.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Show Driver";
            // 
            // cmbDriver
            // 
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(264, 538);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(121, 29);
            this.cmbDriver.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Delivery Charge";
            // 
            // txtDeliveryCharge
            // 
            this.txtDeliveryCharge.Location = new System.Drawing.Point(662, 22);
            this.txtDeliveryCharge.Name = "txtDeliveryCharge";
            this.txtDeliveryCharge.Size = new System.Drawing.Size(100, 29);
            this.txtDeliveryCharge.TabIndex = 6;
            // 
            // FrmTAOrderListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 624);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTAOrderListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTAOrderListView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssignDriver;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowAssigned;
        private System.Windows.Forms.Button btnShowUnassigned;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDeliveryCharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnpaidShop;
        private System.Windows.Forms.Button btnUnpaidCollection;
        private System.Windows.Forms.Button btnUnpaidDelivery;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrtKitchenPaper;
        private System.Windows.Forms.Button btnPayCard;
        private System.Windows.Forms.Button btnPayExactCash;
        private System.Windows.Forms.Button btnOpen;
    }
}
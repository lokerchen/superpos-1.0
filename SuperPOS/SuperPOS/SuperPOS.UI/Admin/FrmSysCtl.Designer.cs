namespace SuperPOS.UI.Admin
{
    partial class FrmSysCtl
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTakeaway = new System.Windows.Forms.CheckBox();
            this.chkEatIn = new System.Windows.Forms.CheckBox();
            this.chkQuickFood = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkShopDetailReadOnly = new System.Windows.Forms.CheckBox();
            this.chkNotAccountFor = new System.Windows.Forms.CheckBox();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccessCode = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkQuickFood);
            this.groupBox1.Controls.Add(this.chkEatIn);
            this.groupBox1.Controls.Add(this.chkTakeaway);
            this.groupBox1.Location = new System.Drawing.Point(20, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(288, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function Access Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkShopDetailReadOnly);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtShopName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(336, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(369, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shop Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAccessCode);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtKey2);
            this.groupBox3.Controls.Add(this.txtKey1);
            this.groupBox3.Controls.Add(this.chkNotAccountFor);
            this.groupBox3.Location = new System.Drawing.Point(20, 246);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(314, 194);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Smart Control";
            // 
            // chkTakeaway
            // 
            this.chkTakeaway.AutoSize = true;
            this.chkTakeaway.Location = new System.Drawing.Point(58, 45);
            this.chkTakeaway.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTakeaway.Name = "chkTakeaway";
            this.chkTakeaway.Size = new System.Drawing.Size(104, 25);
            this.chkTakeaway.TabIndex = 0;
            this.chkTakeaway.Text = "Takeaway";
            this.chkTakeaway.UseVisualStyleBackColor = true;
            // 
            // chkEatIn
            // 
            this.chkEatIn.AutoSize = true;
            this.chkEatIn.Location = new System.Drawing.Point(58, 89);
            this.chkEatIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkEatIn.Name = "chkEatIn";
            this.chkEatIn.Size = new System.Drawing.Size(73, 25);
            this.chkEatIn.TabIndex = 1;
            this.chkEatIn.Text = "Eat In";
            this.chkEatIn.UseVisualStyleBackColor = true;
            // 
            // chkQuickFood
            // 
            this.chkQuickFood.AutoSize = true;
            this.chkQuickFood.Location = new System.Drawing.Point(58, 136);
            this.chkQuickFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkQuickFood.Name = "chkQuickFood";
            this.chkQuickFood.Size = new System.Drawing.Size(117, 25);
            this.chkQuickFood.TabIndex = 2;
            this.chkQuickFood.Text = "Quick Food";
            this.chkQuickFood.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop Name";
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(119, 33);
            this.txtShopName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(227, 29);
            this.txtShopName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(119, 89);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 29);
            this.txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // chkShopDetailReadOnly
            // 
            this.chkShopDetailReadOnly.AutoSize = true;
            this.chkShopDetailReadOnly.Location = new System.Drawing.Point(17, 146);
            this.chkShopDetailReadOnly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkShopDetailReadOnly.Name = "chkShopDetailReadOnly";
            this.chkShopDetailReadOnly.Size = new System.Drawing.Size(207, 25);
            this.chkShopDetailReadOnly.TabIndex = 4;
            this.chkShopDetailReadOnly.Text = "Shop Details Read Only";
            this.chkShopDetailReadOnly.UseVisualStyleBackColor = true;
            // 
            // chkNotAccountFor
            // 
            this.chkNotAccountFor.AutoSize = true;
            this.chkNotAccountFor.Location = new System.Drawing.Point(33, 30);
            this.chkNotAccountFor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkNotAccountFor.Name = "chkNotAccountFor";
            this.chkNotAccountFor.Size = new System.Drawing.Size(156, 25);
            this.chkNotAccountFor.TabIndex = 0;
            this.chkNotAccountFor.Text = "Not Account For";
            this.chkNotAccountFor.UseVisualStyleBackColor = true;
            // 
            // txtKey1
            // 
            this.txtKey1.Location = new System.Drawing.Point(33, 78);
            this.txtKey1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(84, 29);
            this.txtKey1.TabIndex = 1;
            this.txtKey1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKey1_KeyDown);
            // 
            // txtKey2
            // 
            this.txtKey2.Location = new System.Drawing.Point(145, 78);
            this.txtKey2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(96, 29);
            this.txtKey2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Access Code";
            // 
            // txtAccessCode
            // 
            this.txtAccessCode.Location = new System.Drawing.Point(140, 127);
            this.txtAccessCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccessCode.Name = "txtAccessCode";
            this.txtAccessCode.Size = new System.Drawing.Size(162, 29);
            this.txtAccessCode.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 17);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(726, 462);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "System Control";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(472, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Olive;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(472, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // FrmSysCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 490);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSysCtl";
            this.Text = "FrmSysCtl";
            this.Load += new System.EventHandler(this.FrmSysCtl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkQuickFood;
        private System.Windows.Forms.CheckBox chkEatIn;
        private System.Windows.Forms.CheckBox chkTakeaway;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkShopDetailReadOnly;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAccessCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.CheckBox chkNotAccountFor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
    }
}
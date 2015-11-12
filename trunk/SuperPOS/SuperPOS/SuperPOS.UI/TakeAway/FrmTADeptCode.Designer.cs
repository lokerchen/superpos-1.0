namespace SuperPOS.UI.TakeAway
{
    partial class FrmTADeptCode
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkPrtDishSeper2 = new System.Windows.Forms.CheckBox();
            this.cmbBoxNumberOfCopy2 = new System.Windows.Forms.ComboBox();
            this.cmbBoxPrinterName2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkPrtDishSeper1 = new System.Windows.Forms.CheckBox();
            this.cmbBoxNumberOfCopy1 = new System.Windows.Forms.ComboBox();
            this.cmbBoxPrinterName1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOtherName = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtDeptCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDeptCode = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptCode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department Code Entry";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(575, 460);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 65);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(335, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 65);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(455, 460);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 65);
            this.btnDel.TabIndex = 28;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(215, 460);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 65);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(95, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 65);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkPrtDishSeper2);
            this.groupBox5.Controls.Add(this.cmbBoxNumberOfCopy2);
            this.groupBox5.Controls.Add(this.cmbBoxPrinterName2);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(398, 317);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 126);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Printer #2 Assignment";
            // 
            // chkPrtDishSeper2
            // 
            this.chkPrtDishSeper2.AutoSize = true;
            this.chkPrtDishSeper2.Enabled = false;
            this.chkPrtDishSeper2.Location = new System.Drawing.Point(17, 100);
            this.chkPrtDishSeper2.Name = "chkPrtDishSeper2";
            this.chkPrtDishSeper2.Size = new System.Drawing.Size(211, 20);
            this.chkPrtDishSeper2.TabIndex = 4;
            this.chkPrtDishSeper2.Text = "Print Dishes Seperately";
            this.chkPrtDishSeper2.UseVisualStyleBackColor = true;
            // 
            // cmbBoxNumberOfCopy2
            // 
            this.cmbBoxNumberOfCopy2.Enabled = false;
            this.cmbBoxNumberOfCopy2.FormattingEnabled = true;
            this.cmbBoxNumberOfCopy2.Location = new System.Drawing.Point(136, 59);
            this.cmbBoxNumberOfCopy2.Name = "cmbBoxNumberOfCopy2";
            this.cmbBoxNumberOfCopy2.Size = new System.Drawing.Size(155, 24);
            this.cmbBoxNumberOfCopy2.TabIndex = 3;
            // 
            // cmbBoxPrinterName2
            // 
            this.cmbBoxPrinterName2.Enabled = false;
            this.cmbBoxPrinterName2.FormattingEnabled = true;
            this.cmbBoxPrinterName2.Location = new System.Drawing.Point(136, 26);
            this.cmbBoxPrinterName2.Name = "cmbBoxPrinterName2";
            this.cmbBoxPrinterName2.Size = new System.Drawing.Size(155, 24);
            this.cmbBoxPrinterName2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Number of Copy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pirnter Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkPrtDishSeper1);
            this.groupBox4.Controls.Add(this.cmbBoxNumberOfCopy1);
            this.groupBox4.Controls.Add(this.cmbBoxPrinterName1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(398, 173);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 138);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Printer #1 Assignment";
            // 
            // chkPrtDishSeper1
            // 
            this.chkPrtDishSeper1.AutoSize = true;
            this.chkPrtDishSeper1.Enabled = false;
            this.chkPrtDishSeper1.Location = new System.Drawing.Point(17, 112);
            this.chkPrtDishSeper1.Name = "chkPrtDishSeper1";
            this.chkPrtDishSeper1.Size = new System.Drawing.Size(211, 20);
            this.chkPrtDishSeper1.TabIndex = 4;
            this.chkPrtDishSeper1.Text = "Print Dishes Seperately";
            this.chkPrtDishSeper1.UseVisualStyleBackColor = true;
            // 
            // cmbBoxNumberOfCopy1
            // 
            this.cmbBoxNumberOfCopy1.Enabled = false;
            this.cmbBoxNumberOfCopy1.FormattingEnabled = true;
            this.cmbBoxNumberOfCopy1.Location = new System.Drawing.Point(141, 71);
            this.cmbBoxNumberOfCopy1.Name = "cmbBoxNumberOfCopy1";
            this.cmbBoxNumberOfCopy1.Size = new System.Drawing.Size(150, 24);
            this.cmbBoxNumberOfCopy1.TabIndex = 3;
            // 
            // cmbBoxPrinterName1
            // 
            this.cmbBoxPrinterName1.Enabled = false;
            this.cmbBoxPrinterName1.FormattingEnabled = true;
            this.cmbBoxPrinterName1.Location = new System.Drawing.Point(141, 31);
            this.cmbBoxPrinterName1.Name = "cmbBoxPrinterName1";
            this.cmbBoxPrinterName1.Size = new System.Drawing.Size(150, 24);
            this.cmbBoxPrinterName1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Number of Copy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Printer Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOtherName);
            this.groupBox3.Controls.Add(this.txtDeptName);
            this.groupBox3.Controls.Add(this.txtDeptCode);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(398, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 128);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Department Code Content Input";
            // 
            // txtOtherName
            // 
            this.txtOtherName.Enabled = false;
            this.txtOtherName.Location = new System.Drawing.Point(141, 92);
            this.txtOtherName.Name = "txtOtherName";
            this.txtOtherName.Size = new System.Drawing.Size(138, 26);
            this.txtOtherName.TabIndex = 5;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Enabled = false;
            this.txtDeptName.Location = new System.Drawing.Point(141, 58);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(138, 26);
            this.txtDeptName.TabIndex = 4;
            // 
            // txtDeptCode
            // 
            this.txtDeptCode.Enabled = false;
            this.txtDeptCode.Location = new System.Drawing.Point(141, 22);
            this.txtDeptCode.Name = "txtDeptCode";
            this.txtDeptCode.Size = new System.Drawing.Size(138, 26);
            this.txtDeptCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Other Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dept Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dept. Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDeptCode);
            this.groupBox2.Location = new System.Drawing.Point(17, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 413);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department Code List";
            // 
            // dgvDeptCode
            // 
            this.dgvDeptCode.Location = new System.Drawing.Point(10, 25);
            this.dgvDeptCode.Name = "dgvDeptCode";
            this.dgvDeptCode.RowTemplate.Height = 23;
            this.dgvDeptCode.Size = new System.Drawing.Size(345, 373);
            this.dgvDeptCode.TabIndex = 0;
            this.dgvDeptCode.SelectionChanged += new System.EventHandler(this.dgvDeptCode_SelectionChanged);
            // 
            // FrmTADeptCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 557);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTADeptCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeptCode";
            this.Load += new System.EventHandler(this.FrmDeptCode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDeptCode;
        private System.Windows.Forms.CheckBox chkPrtDishSeper2;
        private System.Windows.Forms.ComboBox cmbBoxNumberOfCopy2;
        private System.Windows.Forms.ComboBox cmbBoxPrinterName2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkPrtDishSeper1;
        private System.Windows.Forms.ComboBox cmbBoxNumberOfCopy1;
        private System.Windows.Forms.ComboBox cmbBoxPrinterName1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOtherName;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtDeptCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}
namespace SuperPOS.UI.Admin
{
    partial class FrmComputerEntry
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
            this.grpBoxCompAddrEntry = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvAddr = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBoxAddrEntry = new System.Windows.Forms.GroupBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpBoxCompAddrEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddr)).BeginInit();
            this.grpBoxAddrEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxCompAddrEntry
            // 
            this.grpBoxCompAddrEntry.Controls.Add(this.btnExit);
            this.grpBoxCompAddrEntry.Controls.Add(this.dgvAddr);
            this.grpBoxCompAddrEntry.Controls.Add(this.btnSave);
            this.grpBoxCompAddrEntry.Controls.Add(this.grpBoxAddrEntry);
            this.grpBoxCompAddrEntry.Controls.Add(this.btnDel);
            this.grpBoxCompAddrEntry.Controls.Add(this.btnEdit);
            this.grpBoxCompAddrEntry.Controls.Add(this.btnAdd);
            this.grpBoxCompAddrEntry.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBoxCompAddrEntry.Location = new System.Drawing.Point(12, 13);
            this.grpBoxCompAddrEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxCompAddrEntry.Name = "grpBoxCompAddrEntry";
            this.grpBoxCompAddrEntry.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxCompAddrEntry.Size = new System.Drawing.Size(622, 265);
            this.grpBoxCompAddrEntry.TabIndex = 0;
            this.grpBoxCompAddrEntry.TabStop = false;
            this.grpBoxCompAddrEntry.Text = "Computer Address Entry";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(211, 155);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 98);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvAddr
            // 
            this.dgvAddr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddr.Location = new System.Drawing.Point(316, 27);
            this.dgvAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAddr.Name = "dgvAddr";
            this.dgvAddr.ReadOnly = true;
            this.dgvAddr.RowTemplate.Height = 23;
            this.dgvAddr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddr.Size = new System.Drawing.Size(293, 226);
            this.dgvAddr.TabIndex = 1;
            this.dgvAddr.SelectionChanged += new System.EventHandler(this.dgvAddr_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(22, 210);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 42);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpBoxAddrEntry
            // 
            this.grpBoxAddrEntry.Controls.Add(this.txtCompName);
            this.grpBoxAddrEntry.Controls.Add(this.txtCode);
            this.grpBoxAddrEntry.Controls.Add(this.label2);
            this.grpBoxAddrEntry.Controls.Add(this.label1);
            this.grpBoxAddrEntry.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBoxAddrEntry.Location = new System.Drawing.Point(17, 27);
            this.grpBoxAddrEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxAddrEntry.Name = "grpBoxAddrEntry";
            this.grpBoxAddrEntry.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxAddrEntry.Size = new System.Drawing.Size(293, 101);
            this.grpBoxAddrEntry.TabIndex = 0;
            this.grpBoxAddrEntry.TabStop = false;
            this.grpBoxAddrEntry.Text = "Address Entry";
            // 
            // txtCompName
            // 
            this.txtCompName.Enabled = false;
            this.txtCompName.Location = new System.Drawing.Point(134, 61);
            this.txtCompName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(147, 26);
            this.txtCompName.TabIndex = 3;
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(134, 27);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(147, 26);
            this.txtCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(117, 210);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(87, 42);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(117, 155);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 42);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(22, 155);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 42);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmComputerEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 292);
            this.Controls.Add(this.grpBoxCompAddrEntry);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmComputerEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmComputerEntry";
            this.Load += new System.EventHandler(this.FrmComputerEntry_Load);
            this.grpBoxCompAddrEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddr)).EndInit();
            this.grpBoxAddrEntry.ResumeLayout(false);
            this.grpBoxAddrEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCompAddrEntry;
        private System.Windows.Forms.GroupBox grpBoxAddrEntry;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAddr;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}
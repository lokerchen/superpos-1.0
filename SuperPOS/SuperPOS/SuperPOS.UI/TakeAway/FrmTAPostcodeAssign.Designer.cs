namespace SuperPOS.UI.TakeAway
{
    partial class FrmTAPostcodeAssign
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCharge = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChargePostCode = new System.Windows.Forms.TextBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChrgNew = new System.Windows.Forms.Button();
            this.btnChrgSave = new System.Windows.Forms.Button();
            this.btnChrgDel = new System.Windows.Forms.Button();
            this.btnChrgExit = new System.Windows.Forms.Button();
            this.btnZoneExit = new System.Windows.Forms.Button();
            this.btnZoneDel = new System.Windows.Forms.Button();
            this.btnZoneSave = new System.Windows.Forms.Button();
            this.btnZoneNew = new System.Windows.Forms.Button();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZonePostcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvZone = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZone)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Postcode Assignment";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 394);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnChrgExit);
            this.tabPage1.Controls.Add(this.btnChrgDel);
            this.tabPage1.Controls.Add(this.btnChrgSave);
            this.tabPage1.Controls.Add(this.btnChrgNew);
            this.tabPage1.Controls.Add(this.txtCharge);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtChargePostCode);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvCharge);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Charges for Special Postcode Prefixes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnZoneExit);
            this.tabPage2.Controls.Add(this.btnZoneDel);
            this.tabPage2.Controls.Add(this.btnZoneSave);
            this.tabPage2.Controls.Add(this.btnZoneNew);
            this.tabPage2.Controls.Add(this.txtZone);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtZonePostcode);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgvZone);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Postcode Zone Assignment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCharge
            // 
            this.dgvCharge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharge.Location = new System.Drawing.Point(7, 16);
            this.dgvCharge.Name = "dgvCharge";
            this.dgvCharge.ReadOnly = true;
            this.dgvCharge.RowTemplate.Height = 27;
            this.dgvCharge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCharge.Size = new System.Drawing.Size(239, 339);
            this.dgvCharge.TabIndex = 0;
            this.dgvCharge.SelectionChanged += new System.EventHandler(this.dgvCharge_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Postcode";
            // 
            // txtChargePostCode
            // 
            this.txtChargePostCode.Location = new System.Drawing.Point(357, 57);
            this.txtChargePostCode.Name = "txtChargePostCode";
            this.txtChargePostCode.Size = new System.Drawing.Size(116, 27);
            this.txtChargePostCode.TabIndex = 2;
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(357, 119);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(116, 27);
            this.txtCharge.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Charge";
            // 
            // btnChrgNew
            // 
            this.btnChrgNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChrgNew.FlatAppearance.BorderSize = 0;
            this.btnChrgNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChrgNew.ForeColor = System.Drawing.Color.White;
            this.btnChrgNew.Location = new System.Drawing.Point(291, 186);
            this.btnChrgNew.Name = "btnChrgNew";
            this.btnChrgNew.Size = new System.Drawing.Size(74, 69);
            this.btnChrgNew.TabIndex = 5;
            this.btnChrgNew.Text = "New";
            this.btnChrgNew.UseVisualStyleBackColor = false;
            this.btnChrgNew.Click += new System.EventHandler(this.btnChrgNew_Click);
            // 
            // btnChrgSave
            // 
            this.btnChrgSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChrgSave.FlatAppearance.BorderSize = 0;
            this.btnChrgSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChrgSave.ForeColor = System.Drawing.Color.White;
            this.btnChrgSave.Location = new System.Drawing.Point(291, 275);
            this.btnChrgSave.Name = "btnChrgSave";
            this.btnChrgSave.Size = new System.Drawing.Size(74, 69);
            this.btnChrgSave.TabIndex = 6;
            this.btnChrgSave.Text = "Save";
            this.btnChrgSave.UseVisualStyleBackColor = false;
            this.btnChrgSave.Click += new System.EventHandler(this.btnChrgSave_Click);
            // 
            // btnChrgDel
            // 
            this.btnChrgDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChrgDel.FlatAppearance.BorderSize = 0;
            this.btnChrgDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChrgDel.ForeColor = System.Drawing.Color.White;
            this.btnChrgDel.Location = new System.Drawing.Point(384, 186);
            this.btnChrgDel.Name = "btnChrgDel";
            this.btnChrgDel.Size = new System.Drawing.Size(74, 69);
            this.btnChrgDel.TabIndex = 7;
            this.btnChrgDel.Text = "Del";
            this.btnChrgDel.UseVisualStyleBackColor = false;
            this.btnChrgDel.Click += new System.EventHandler(this.btnChrgDel_Click);
            // 
            // btnChrgExit
            // 
            this.btnChrgExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChrgExit.FlatAppearance.BorderSize = 0;
            this.btnChrgExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChrgExit.ForeColor = System.Drawing.Color.White;
            this.btnChrgExit.Location = new System.Drawing.Point(384, 275);
            this.btnChrgExit.Name = "btnChrgExit";
            this.btnChrgExit.Size = new System.Drawing.Size(74, 69);
            this.btnChrgExit.TabIndex = 8;
            this.btnChrgExit.Text = "Exit";
            this.btnChrgExit.UseVisualStyleBackColor = false;
            this.btnChrgExit.Click += new System.EventHandler(this.btnChrgExit_Click);
            // 
            // btnZoneExit
            // 
            this.btnZoneExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZoneExit.FlatAppearance.BorderSize = 0;
            this.btnZoneExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoneExit.ForeColor = System.Drawing.Color.White;
            this.btnZoneExit.Location = new System.Drawing.Point(392, 270);
            this.btnZoneExit.Name = "btnZoneExit";
            this.btnZoneExit.Size = new System.Drawing.Size(74, 69);
            this.btnZoneExit.TabIndex = 17;
            this.btnZoneExit.Text = "Exit";
            this.btnZoneExit.UseVisualStyleBackColor = false;
            this.btnZoneExit.Click += new System.EventHandler(this.btnZoneExit_Click);
            // 
            // btnZoneDel
            // 
            this.btnZoneDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZoneDel.FlatAppearance.BorderSize = 0;
            this.btnZoneDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoneDel.ForeColor = System.Drawing.Color.White;
            this.btnZoneDel.Location = new System.Drawing.Point(392, 181);
            this.btnZoneDel.Name = "btnZoneDel";
            this.btnZoneDel.Size = new System.Drawing.Size(74, 69);
            this.btnZoneDel.TabIndex = 16;
            this.btnZoneDel.Text = "Del";
            this.btnZoneDel.UseVisualStyleBackColor = false;
            this.btnZoneDel.Click += new System.EventHandler(this.btnZoneDel_Click);
            // 
            // btnZoneSave
            // 
            this.btnZoneSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZoneSave.FlatAppearance.BorderSize = 0;
            this.btnZoneSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoneSave.ForeColor = System.Drawing.Color.White;
            this.btnZoneSave.Location = new System.Drawing.Point(299, 270);
            this.btnZoneSave.Name = "btnZoneSave";
            this.btnZoneSave.Size = new System.Drawing.Size(74, 69);
            this.btnZoneSave.TabIndex = 15;
            this.btnZoneSave.Text = "Save";
            this.btnZoneSave.UseVisualStyleBackColor = false;
            this.btnZoneSave.Click += new System.EventHandler(this.btnZoneSave_Click);
            // 
            // btnZoneNew
            // 
            this.btnZoneNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnZoneNew.FlatAppearance.BorderSize = 0;
            this.btnZoneNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoneNew.ForeColor = System.Drawing.Color.White;
            this.btnZoneNew.Location = new System.Drawing.Point(299, 181);
            this.btnZoneNew.Name = "btnZoneNew";
            this.btnZoneNew.Size = new System.Drawing.Size(74, 69);
            this.btnZoneNew.TabIndex = 14;
            this.btnZoneNew.Text = "New";
            this.btnZoneNew.UseVisualStyleBackColor = false;
            this.btnZoneNew.Click += new System.EventHandler(this.btnZoneNew_Click);
            // 
            // txtZone
            // 
            this.txtZone.Location = new System.Drawing.Point(365, 114);
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(116, 27);
            this.txtZone.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Zone";
            // 
            // txtZonePostcode
            // 
            this.txtZonePostcode.Location = new System.Drawing.Point(365, 52);
            this.txtZonePostcode.Name = "txtZonePostcode";
            this.txtZonePostcode.Size = new System.Drawing.Size(116, 27);
            this.txtZonePostcode.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Postcode";
            // 
            // dgvZone
            // 
            this.dgvZone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZone.Location = new System.Drawing.Point(15, 11);
            this.dgvZone.Name = "dgvZone";
            this.dgvZone.RowTemplate.Height = 27;
            this.dgvZone.Size = new System.Drawing.Size(239, 339);
            this.dgvZone.TabIndex = 9;
            this.dgvZone.SelectionChanged += new System.EventHandler(this.dgvZone_SelectionChanged);
            // 
            // FrmTAPostcodeAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 436);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTAPostcodeAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmTAPostcodeAssign";
            this.Load += new System.EventHandler(this.FrmTAPostcodeAssign_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChargePostCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCharge;
        private System.Windows.Forms.Button btnChrgNew;
        private System.Windows.Forms.Button btnChrgExit;
        private System.Windows.Forms.Button btnChrgDel;
        private System.Windows.Forms.Button btnChrgSave;
        private System.Windows.Forms.Button btnZoneExit;
        private System.Windows.Forms.Button btnZoneDel;
        private System.Windows.Forms.Button btnZoneSave;
        private System.Windows.Forms.Button btnZoneNew;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZonePostcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvZone;
    }
}
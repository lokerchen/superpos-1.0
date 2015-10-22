namespace SuperPOS.UI.Admin
{
    partial class FrmCompactDB
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
            this.grpBoxDataManager = new System.Windows.Forms.GroupBox();
            this.btnRestoreData = new System.Windows.Forms.Button();
            this.btnBackupData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpBoxDataManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxDataManager
            // 
            this.grpBoxDataManager.Controls.Add(this.btnRestoreData);
            this.grpBoxDataManager.Controls.Add(this.btnBackupData);
            this.grpBoxDataManager.Location = new System.Drawing.Point(12, 12);
            this.grpBoxDataManager.Name = "grpBoxDataManager";
            this.grpBoxDataManager.Size = new System.Drawing.Size(335, 131);
            this.grpBoxDataManager.TabIndex = 0;
            this.grpBoxDataManager.TabStop = false;
            this.grpBoxDataManager.Text = "Data Manager";
            // 
            // btnRestoreData
            // 
            this.btnRestoreData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRestoreData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestoreData.ForeColor = System.Drawing.Color.White;
            this.btnRestoreData.Location = new System.Drawing.Point(177, 52);
            this.btnRestoreData.Name = "btnRestoreData";
            this.btnRestoreData.Size = new System.Drawing.Size(125, 45);
            this.btnRestoreData.TabIndex = 21;
            this.btnRestoreData.Text = "Restore Data";
            this.btnRestoreData.UseVisualStyleBackColor = false;
            this.btnRestoreData.Click += new System.EventHandler(this.btnRestoreData_Click);
            // 
            // btnBackupData
            // 
            this.btnBackupData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackupData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackupData.ForeColor = System.Drawing.Color.White;
            this.btnBackupData.Location = new System.Drawing.Point(33, 52);
            this.btnBackupData.Name = "btnBackupData";
            this.btnBackupData.Size = new System.Drawing.Size(125, 45);
            this.btnBackupData.TabIndex = 20;
            this.btnBackupData.Text = "Backup Data";
            this.btnBackupData.UseVisualStyleBackColor = false;
            this.btnBackupData.Click += new System.EventHandler(this.btnBackupData_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(111, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 45);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogBackupData";
            // 
            // FrmCompactDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 237);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBoxDataManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompactDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCompactDB";
            this.grpBoxDataManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDataManager;
        private System.Windows.Forms.Button btnRestoreData;
        private System.Windows.Forms.Button btnBackupData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
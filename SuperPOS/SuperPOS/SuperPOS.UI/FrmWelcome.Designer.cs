namespace SuperPOS.UI
{
    partial class FrmWelcome
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.pgBarInit = new System.Windows.Forms.ProgressBar();
            this.lblPgBarMsg = new System.Windows.Forms.Label();
            this.timerPgBarInit = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Location = new System.Drawing.Point(105, 23);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(318, 198);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // pgBarInit
            // 
            this.pgBarInit.Location = new System.Drawing.Point(105, 261);
            this.pgBarInit.Name = "pgBarInit";
            this.pgBarInit.Size = new System.Drawing.Size(318, 23);
            this.pgBarInit.TabIndex = 1;
            // 
            // lblPgBarMsg
            // 
            this.lblPgBarMsg.AutoSize = true;
            this.lblPgBarMsg.Location = new System.Drawing.Point(103, 234);
            this.lblPgBarMsg.Name = "lblPgBarMsg";
            this.lblPgBarMsg.Size = new System.Drawing.Size(269, 12);
            this.lblPgBarMsg.TabIndex = 2;
            this.lblPgBarMsg.Text = "Is initialized data, please wait a moment...";
            // 
            // timerPgBarInit
            // 
            this.timerPgBarInit.Tick += new System.EventHandler(this.timerPgBarInit_Tick);
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 316);
            this.Controls.Add(this.lblPgBarMsg);
            this.Controls.Add(this.pgBarInit);
            this.Controls.Add(this.picBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmWelcome_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.ProgressBar pgBarInit;
        private System.Windows.Forms.Label lblPgBarMsg;
        private System.Windows.Forms.Timer timerPgBarInit;
    }
}


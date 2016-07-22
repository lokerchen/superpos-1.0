namespace SuperPOS.UI
{
    partial class FrmSelectMenu
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCtlPanel = new System.Windows.Forms.Button();
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.btnDrawer = new System.Windows.Forms.Button();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnTakeaway = new System.Windows.Forms.Button();
            this.btnEatIn = new System.Windows.Forms.Button();
            this.btnQuickFood = new System.Windows.Forms.Button();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnCtlPanel);
            this.groupBox1.Controls.Add(this.btnShowOrder);
            this.groupBox1.Controls.Add(this.btnDrawer);
            this.groupBox1.Controls.Add(this.txtStaff);
            this.groupBox1.Controls.Add(this.txtSession);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(22, 460);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 60);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCtlPanel
            // 
            this.btnCtlPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCtlPanel.FlatAppearance.BorderSize = 0;
            this.btnCtlPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCtlPanel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCtlPanel.ForeColor = System.Drawing.Color.White;
            this.btnCtlPanel.Location = new System.Drawing.Point(22, 380);
            this.btnCtlPanel.Name = "btnCtlPanel";
            this.btnCtlPanel.Size = new System.Drawing.Size(133, 60);
            this.btnCtlPanel.TabIndex = 6;
            this.btnCtlPanel.Text = "Control Panel";
            this.btnCtlPanel.UseVisualStyleBackColor = false;
            this.btnCtlPanel.Click += new System.EventHandler(this.btnCtlPanel_Click);
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowOrder.FlatAppearance.BorderSize = 0;
            this.btnShowOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOrder.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowOrder.ForeColor = System.Drawing.Color.White;
            this.btnShowOrder.Location = new System.Drawing.Point(22, 300);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(133, 60);
            this.btnShowOrder.TabIndex = 5;
            this.btnShowOrder.Text = "Show Order";
            this.btnShowOrder.UseVisualStyleBackColor = false;
            this.btnShowOrder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // btnDrawer
            // 
            this.btnDrawer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDrawer.FlatAppearance.BorderSize = 0;
            this.btnDrawer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawer.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDrawer.ForeColor = System.Drawing.Color.White;
            this.btnDrawer.Location = new System.Drawing.Point(22, 220);
            this.btnDrawer.Name = "btnDrawer";
            this.btnDrawer.Size = new System.Drawing.Size(133, 60);
            this.btnDrawer.TabIndex = 4;
            this.btnDrawer.Text = "Cash Drawer";
            this.btnDrawer.UseVisualStyleBackColor = false;
            // 
            // txtStaff
            // 
            this.txtStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaff.Enabled = false;
            this.txtStaff.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStaff.Location = new System.Drawing.Point(22, 144);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(133, 34);
            this.txtStaff.TabIndex = 3;
            this.txtStaff.Text = "STAFF8";
            this.txtStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSession
            // 
            this.txtSession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSession.Enabled = false;
            this.txtSession.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSession.Location = new System.Drawing.Point(22, 105);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(133, 34);
            this.txtSession.TabIndex = 2;
            this.txtSession.Text = "DINNER";
            this.txtSession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTime.Location = new System.Drawing.Point(22, 65);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(133, 34);
            this.txtTime.TabIndex = 1;
            this.txtTime.Text = "23:23:23";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDate.Location = new System.Drawing.Point(22, 22);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(133, 34);
            this.txtDate.TabIndex = 0;
            this.txtDate.Text = "25/11/2015";
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(209, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(518, 98);
            this.button5.TabIndex = 1;
            this.button5.Text = "Desktop Area";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnTakeaway
            // 
            this.btnTakeaway.BackColor = System.Drawing.Color.Silver;
            this.btnTakeaway.FlatAppearance.BorderSize = 0;
            this.btnTakeaway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeaway.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTakeaway.ForeColor = System.Drawing.Color.White;
            this.btnTakeaway.Location = new System.Drawing.Point(307, 169);
            this.btnTakeaway.Name = "btnTakeaway";
            this.btnTakeaway.Size = new System.Drawing.Size(300, 90);
            this.btnTakeaway.TabIndex = 2;
            this.btnTakeaway.Text = "Takeaway";
            this.btnTakeaway.UseVisualStyleBackColor = false;
            this.btnTakeaway.Click += new System.EventHandler(this.btnTakeaway_Click);
            this.btnTakeaway.MouseLeave += new System.EventHandler(this.btnTakeaway_MouseLeave);
            this.btnTakeaway.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTakeaway_MouseMove);
            // 
            // btnEatIn
            // 
            this.btnEatIn.BackColor = System.Drawing.Color.Silver;
            this.btnEatIn.FlatAppearance.BorderSize = 0;
            this.btnEatIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEatIn.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEatIn.ForeColor = System.Drawing.Color.White;
            this.btnEatIn.Location = new System.Drawing.Point(307, 275);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(300, 90);
            this.btnEatIn.TabIndex = 3;
            this.btnEatIn.Text = "Eat In";
            this.btnEatIn.UseVisualStyleBackColor = false;
            this.btnEatIn.Click += new System.EventHandler(this.btnEatIn_Click);
            this.btnEatIn.MouseLeave += new System.EventHandler(this.btnEatIn_MouseLeave);
            this.btnEatIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEatIn_MouseMove);
            // 
            // btnQuickFood
            // 
            this.btnQuickFood.BackColor = System.Drawing.Color.Silver;
            this.btnQuickFood.FlatAppearance.BorderSize = 0;
            this.btnQuickFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickFood.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuickFood.ForeColor = System.Drawing.Color.White;
            this.btnQuickFood.Location = new System.Drawing.Point(307, 381);
            this.btnQuickFood.Name = "btnQuickFood";
            this.btnQuickFood.Size = new System.Drawing.Size(300, 90);
            this.btnQuickFood.TabIndex = 4;
            this.btnQuickFood.Text = "Quick Food";
            this.btnQuickFood.UseVisualStyleBackColor = false;
            this.btnQuickFood.Click += new System.EventHandler(this.btnQuickFood_Click);
            this.btnQuickFood.MouseLeave += new System.EventHandler(this.btnQuickFood_MouseLeave);
            this.btnQuickFood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnQuickFood_MouseMove);
            // 
            // timerShow
            // 
            this.timerShow.Enabled = true;
            this.timerShow.Interval = 1000;
            this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
            // 
            // FrmSelectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 561);
            this.Controls.Add(this.btnQuickFood);
            this.Controls.Add(this.btnEatIn);
            this.Controls.Add(this.btnTakeaway);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSelectMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelectMenu";
            this.Load += new System.EventHandler(this.FrmSelectMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCtlPanel;
        private System.Windows.Forms.Button btnShowOrder;
        private System.Windows.Forms.Button btnDrawer;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTakeaway;
        private System.Windows.Forms.Button btnEatIn;
        private System.Windows.Forms.Button btnQuickFood;
        private System.Windows.Forms.Timer timerShow;
    }
}
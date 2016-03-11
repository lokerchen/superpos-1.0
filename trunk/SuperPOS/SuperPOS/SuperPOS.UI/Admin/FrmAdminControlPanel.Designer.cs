namespace SuperPOS.UI.Admin
{
    partial class FrmAdminControlPanel
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("System Configuration");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("User Maintenance");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Data Manager");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Compact Database");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Computer Address");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Shift Code");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("System Setting", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Takeaway Configuration");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Menu Category");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Menu Item");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Manage Menu Set");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Extra Menu Edit");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Order Control");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Department Code");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Table Setup");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Print Setup");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Driver Setup");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Takeaway & Quick Dining Setting", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Eat In Setting");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Reporting");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("System Control");
            this.grpBoxCtrlPanel = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxWelCome = new System.Windows.Forms.PictureBox();
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.grpBoxCtrlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWelCome)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxCtrlPanel
            // 
            this.grpBoxCtrlPanel.Controls.Add(this.btnExit);
            this.grpBoxCtrlPanel.Controls.Add(this.panel1);
            this.grpBoxCtrlPanel.Controls.Add(this.treeViewMenu);
            this.grpBoxCtrlPanel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBoxCtrlPanel.Location = new System.Drawing.Point(12, 4);
            this.grpBoxCtrlPanel.Name = "grpBoxCtrlPanel";
            this.grpBoxCtrlPanel.Size = new System.Drawing.Size(880, 547);
            this.grpBoxCtrlPanel.TabIndex = 0;
            this.grpBoxCtrlPanel.TabStop = false;
            this.grpBoxCtrlPanel.Text = "Control Panel";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(761, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picBoxWelCome);
            this.panel1.Location = new System.Drawing.Point(312, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 470);
            this.panel1.TabIndex = 1;
            // 
            // picBoxWelCome
            // 
            this.picBoxWelCome.Location = new System.Drawing.Point(50, 67);
            this.picBoxWelCome.Name = "picBoxWelCome";
            this.picBoxWelCome.Size = new System.Drawing.Size(462, 295);
            this.picBoxWelCome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxWelCome.TabIndex = 0;
            this.picBoxWelCome.TabStop = false;
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewMenu.Location = new System.Drawing.Point(15, 64);
            this.treeViewMenu.Name = "treeViewMenu";
            treeNode1.Name = "101";
            treeNode1.Text = "System Configuration";
            treeNode2.Name = "102";
            treeNode2.Text = "User Maintenance";
            treeNode3.Name = "103";
            treeNode3.Text = "Data Manager";
            treeNode4.Name = "104";
            treeNode4.Text = "Compact Database";
            treeNode5.Name = "105";
            treeNode5.Text = "Computer Address";
            treeNode6.Name = "106";
            treeNode6.Text = "Shift Code";
            treeNode7.Name = "1";
            treeNode7.Text = "System Setting";
            treeNode8.Name = "201";
            treeNode8.Text = "Takeaway Configuration";
            treeNode9.Name = "202";
            treeNode9.Text = "Menu Category";
            treeNode10.Name = "203";
            treeNode10.Text = "Menu Item";
            treeNode11.Name = "204";
            treeNode11.Text = "Manage Menu Set";
            treeNode12.Name = "205";
            treeNode12.Text = "Extra Menu Edit";
            treeNode13.Name = "206";
            treeNode13.Text = "Order Control";
            treeNode14.Name = "207";
            treeNode14.Text = "Department Code";
            treeNode15.Name = "208";
            treeNode15.Text = "Table Setup";
            treeNode16.Name = "209";
            treeNode16.Text = "Print Setup";
            treeNode17.Name = "210";
            treeNode17.Text = "Driver Setup";
            treeNode18.Name = "2";
            treeNode18.Text = "Takeaway & Quick Dining Setting";
            treeNode19.Name = "3";
            treeNode19.Text = "Eat In Setting";
            treeNode20.Name = "4";
            treeNode20.Text = "Reporting";
            treeNode21.Name = "5";
            treeNode21.Text = "System Control";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            this.treeViewMenu.Size = new System.Drawing.Size(291, 470);
            this.treeViewMenu.TabIndex = 0;
            this.treeViewMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMenu_AfterSelect);
            this.treeViewMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewMenu_NodeMouseClick);
            // 
            // FrmAdminControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 556);
            this.Controls.Add(this.grpBoxCtrlPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAdminControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminMain";
            this.Load += new System.EventHandler(this.FrmAdminControlPanel_Load);
            this.grpBoxCtrlPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWelCome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCtrlPanel;
        private System.Windows.Forms.TreeView treeViewMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxWelCome;
        private System.Windows.Forms.Button btnExit;
    }
}
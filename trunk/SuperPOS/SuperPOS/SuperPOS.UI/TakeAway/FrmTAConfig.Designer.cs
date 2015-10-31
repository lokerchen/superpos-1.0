namespace SuperPOS.UI.TakeAway
{
    partial class FrmTAConfig
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
            this.grpTAConfig = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeliveryDis = new System.Windows.Forms.TextBox();
            this.txtDeliveryDisThres = new System.Windows.Forms.TextBox();
            this.txtCollDis = new System.Windows.Forms.TextBox();
            this.txtCollDisThres = new System.Windows.Forms.TextBox();
            this.txtShopDis = new System.Windows.Forms.TextBox();
            this.txtShopDisThres = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grpTAConfig.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTAConfig
            // 
            this.grpTAConfig.Controls.Add(this.tabControl1);
            this.grpTAConfig.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpTAConfig.Location = new System.Drawing.Point(12, 12);
            this.grpTAConfig.Name = "grpTAConfig";
            this.grpTAConfig.Size = new System.Drawing.Size(921, 638);
            this.grpTAConfig.TabIndex = 0;
            this.grpTAConfig.TabStop = false;
            this.grpTAConfig.Text = "Takeaway Configuration";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 610);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(883, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtShopDisThres);
            this.groupBox2.Controls.Add(this.txtShopDis);
            this.groupBox2.Controls.Add(this.txtCollDisThres);
            this.groupBox2.Controls.Add(this.txtCollDis);
            this.groupBox2.Controls.Add(this.txtDeliveryDisThres);
            this.groupBox2.Controls.Add(this.txtDeliveryDis);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auto Discount Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(22, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Type and Surcharges";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(403, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(883, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delivery Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(883, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Post Code Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery Discount %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delivery Discount Threshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Collection Discount %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Collection Discount Threshold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shop Discount %";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shop Discount Threshold";
            // 
            // txtDeliveryDis
            // 
            this.txtDeliveryDis.Location = new System.Drawing.Point(239, 25);
            this.txtDeliveryDis.Name = "txtDeliveryDis";
            this.txtDeliveryDis.Size = new System.Drawing.Size(100, 23);
            this.txtDeliveryDis.TabIndex = 6;
            // 
            // txtDeliveryDisThres
            // 
            this.txtDeliveryDisThres.Location = new System.Drawing.Point(239, 61);
            this.txtDeliveryDisThres.Name = "txtDeliveryDisThres";
            this.txtDeliveryDisThres.Size = new System.Drawing.Size(100, 23);
            this.txtDeliveryDisThres.TabIndex = 7;
            // 
            // txtCollDis
            // 
            this.txtCollDis.Location = new System.Drawing.Point(239, 103);
            this.txtCollDis.Name = "txtCollDis";
            this.txtCollDis.Size = new System.Drawing.Size(100, 23);
            this.txtCollDis.TabIndex = 8;
            // 
            // txtCollDisThres
            // 
            this.txtCollDisThres.Location = new System.Drawing.Point(239, 134);
            this.txtCollDisThres.Name = "txtCollDisThres";
            this.txtCollDisThres.Size = new System.Drawing.Size(100, 23);
            this.txtCollDisThres.TabIndex = 9;
            // 
            // txtShopDis
            // 
            this.txtShopDis.Location = new System.Drawing.Point(239, 163);
            this.txtShopDis.Name = "txtShopDis";
            this.txtShopDis.Size = new System.Drawing.Size(100, 23);
            this.txtShopDis.TabIndex = 10;
            // 
            // txtShopDisThres
            // 
            this.txtShopDisThres.Location = new System.Drawing.Point(239, 190);
            this.txtShopDisThres.Name = "txtShopDisThres";
            this.txtShopDisThres.Size = new System.Drawing.Size(100, 23);
            this.txtShopDisThres.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(87, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 125);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delivery Distance Charge";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(87, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delivery Surcharge";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(87, 399);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Charge Options";
            // 
            // FrmTAConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 662);
            this.Controls.Add(this.grpTAConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTAConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTAConfig";
            this.grpTAConfig.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTAConfig;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShopDisThres;
        private System.Windows.Forms.TextBox txtShopDis;
        private System.Windows.Forms.TextBox txtCollDisThres;
        private System.Windows.Forms.TextBox txtCollDis;
        private System.Windows.Forms.TextBox txtDeliveryDisThres;
        private System.Windows.Forms.TextBox txtDeliveryDis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpTAConfig = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGSExit = new System.Windows.Forms.Button();
            this.btnGSSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtShopDisThres = new System.Windows.Forms.TextBox();
            this.txtShopDis = new System.Windows.Forms.TextBox();
            this.txtCollDisThres = new System.Windows.Forms.TextBox();
            this.txtCollDis = new System.Windows.Forms.TextBox();
            this.txtDeliveryDisThres = new System.Windows.Forms.TextBox();
            this.txtDeliveryDis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTAPayType = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDSExit = new System.Windows.Forms.Button();
            this.btnDSSave = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSurchargeAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrderThreshold = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkIgnoreCharge = new System.Windows.Forms.CheckBox();
            this.txtIgnoreMiles = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkDiliveryChargeIncludeInOrder = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPerMileThereafter = new System.Windows.Forms.TextBox();
            this.dgvDSDist = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtMapRef = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPostCode = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtYourY = new System.Windows.Forms.TextBox();
            this.txtYourX = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtYourStd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtYourPostCode = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.grpTAConfig.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAPayType)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDist)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostCode)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTAConfig
            // 
            this.grpTAConfig.Controls.Add(this.tabControl1);
            this.grpTAConfig.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpTAConfig.Location = new System.Drawing.Point(7, 6);
            this.grpTAConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTAConfig.Name = "grpTAConfig";
            this.grpTAConfig.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTAConfig.Size = new System.Drawing.Size(608, 495);
            this.grpTAConfig.TabIndex = 0;
            this.grpTAConfig.TabStop = false;
            this.grpTAConfig.Text = "Takeaway Configuration";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(10, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 467);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGSExit);
            this.tabPage1.Controls.Add(this.btnGSSave);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(585, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGSExit
            // 
            this.btnGSExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGSExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGSExit.ForeColor = System.Drawing.Color.White;
            this.btnGSExit.Location = new System.Drawing.Point(312, 378);
            this.btnGSExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGSExit.Name = "btnGSExit";
            this.btnGSExit.Size = new System.Drawing.Size(90, 50);
            this.btnGSExit.TabIndex = 3;
            this.btnGSExit.Text = "Exit";
            this.btnGSExit.UseVisualStyleBackColor = false;
            this.btnGSExit.Click += new System.EventHandler(this.btnGSExit_Click);
            // 
            // btnGSSave
            // 
            this.btnGSSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGSSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGSSave.ForeColor = System.Drawing.Color.White;
            this.btnGSSave.Location = new System.Drawing.Point(138, 377);
            this.btnGSSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGSSave.Name = "btnGSSave";
            this.btnGSSave.Size = new System.Drawing.Size(90, 50);
            this.btnGSSave.TabIndex = 2;
            this.btnGSSave.Text = "Save";
            this.btnGSSave.UseVisualStyleBackColor = false;
            this.btnGSSave.Click += new System.EventHandler(this.btnGSSave_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(119, 193);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(338, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auto Discount Settings";
            // 
            // txtShopDisThres
            // 
            this.txtShopDisThres.Location = new System.Drawing.Point(204, 142);
            this.txtShopDisThres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShopDisThres.Name = "txtShopDisThres";
            this.txtShopDisThres.Size = new System.Drawing.Size(116, 23);
            this.txtShopDisThres.TabIndex = 11;
            this.txtShopDisThres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShopDisThres_KeyPress);
            // 
            // txtShopDis
            // 
            this.txtShopDis.Location = new System.Drawing.Point(204, 117);
            this.txtShopDis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShopDis.Name = "txtShopDis";
            this.txtShopDis.Size = new System.Drawing.Size(116, 23);
            this.txtShopDis.TabIndex = 10;
            this.txtShopDis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShopDis_KeyPress);
            // 
            // txtCollDisThres
            // 
            this.txtCollDisThres.Location = new System.Drawing.Point(204, 92);
            this.txtCollDisThres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCollDisThres.Name = "txtCollDisThres";
            this.txtCollDisThres.Size = new System.Drawing.Size(116, 23);
            this.txtCollDisThres.TabIndex = 9;
            this.txtCollDisThres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCollDisThres_KeyPress);
            // 
            // txtCollDis
            // 
            this.txtCollDis.Location = new System.Drawing.Point(204, 67);
            this.txtCollDis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCollDis.Name = "txtCollDis";
            this.txtCollDis.Size = new System.Drawing.Size(116, 23);
            this.txtCollDis.TabIndex = 8;
            this.txtCollDis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCollDis_KeyPress);
            // 
            // txtDeliveryDisThres
            // 
            this.txtDeliveryDisThres.Location = new System.Drawing.Point(204, 43);
            this.txtDeliveryDisThres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeliveryDisThres.Name = "txtDeliveryDisThres";
            this.txtDeliveryDisThres.Size = new System.Drawing.Size(116, 23);
            this.txtDeliveryDisThres.TabIndex = 7;
            this.txtDeliveryDisThres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeliveryDisThres_KeyPress);
            // 
            // txtDeliveryDis
            // 
            this.txtDeliveryDis.Location = new System.Drawing.Point(204, 18);
            this.txtDeliveryDis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeliveryDis.Name = "txtDeliveryDis";
            this.txtDeliveryDis.Size = new System.Drawing.Size(116, 23);
            this.txtDeliveryDis.TabIndex = 6;
            this.txtDeliveryDis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeliveryDis_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shop Discount Threshold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shop Discount %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Collection Discount Threshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Collection Discount %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delivery Discount Threshold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery Discount %";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTAPayType);
            this.groupBox1.Location = new System.Drawing.Point(5, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(574, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Type and Surcharges";
            // 
            // dgvTAPayType
            // 
            this.dgvTAPayType.AllowUserToDeleteRows = false;
            this.dgvTAPayType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTAPayType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTAPayType.Location = new System.Drawing.Point(9, 24);
            this.dgvTAPayType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTAPayType.MultiSelect = false;
            this.dgvTAPayType.Name = "dgvTAPayType";
            this.dgvTAPayType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTAPayType.RowTemplate.Height = 23;
            this.dgvTAPayType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTAPayType.Size = new System.Drawing.Size(559, 145);
            this.dgvTAPayType.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDSExit);
            this.tabPage2.Controls.Add(this.btnDSSave);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(585, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delivery Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDSExit
            // 
            this.btnDSExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDSExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSExit.ForeColor = System.Drawing.Color.White;
            this.btnDSExit.Location = new System.Drawing.Point(318, 373);
            this.btnDSExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDSExit.Name = "btnDSExit";
            this.btnDSExit.Size = new System.Drawing.Size(90, 50);
            this.btnDSExit.TabIndex = 5;
            this.btnDSExit.Text = "Exit";
            this.btnDSExit.UseVisualStyleBackColor = false;
            this.btnDSExit.Click += new System.EventHandler(this.btnDSExit_Click);
            // 
            // btnDSSave
            // 
            this.btnDSSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDSSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSSave.ForeColor = System.Drawing.Color.White;
            this.btnDSSave.Location = new System.Drawing.Point(106, 373);
            this.btnDSSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDSSave.Name = "btnDSSave";
            this.btnDSSave.Size = new System.Drawing.Size(90, 50);
            this.btnDSSave.TabIndex = 4;
            this.btnDSSave.Text = "Save";
            this.btnDSSave.UseVisualStyleBackColor = false;
            this.btnDSSave.Click += new System.EventHandler(this.btnDSSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSurchargeAmount);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtOrderThreshold);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(7, 289);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(533, 76);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Charge Options";
            // 
            // txtSurchargeAmount
            // 
            this.txtSurchargeAmount.Location = new System.Drawing.Point(378, 35);
            this.txtSurchargeAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSurchargeAmount.Name = "txtSurchargeAmount";
            this.txtSurchargeAmount.Size = new System.Drawing.Size(116, 23);
            this.txtSurchargeAmount.TabIndex = 3;
            this.txtSurchargeAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurchargeAmount_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Surcharge Amount";
            // 
            // txtOrderThreshold
            // 
            this.txtOrderThreshold.Location = new System.Drawing.Point(118, 35);
            this.txtOrderThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderThreshold.Name = "txtOrderThreshold";
            this.txtOrderThreshold.Size = new System.Drawing.Size(111, 23);
            this.txtOrderThreshold.TabIndex = 1;
            this.txtOrderThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderThreshold_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Order Threshold";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.chkIgnoreCharge);
            this.groupBox4.Controls.Add(this.txtIgnoreMiles);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.chkDiliveryChargeIncludeInOrder);
            this.groupBox4.Location = new System.Drawing.Point(7, 185);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(533, 96);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delivery Surcharge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ignore Delivery Surcharge When Distance Exceeds";
            // 
            // chkIgnoreCharge
            // 
            this.chkIgnoreCharge.AutoSize = true;
            this.chkIgnoreCharge.Location = new System.Drawing.Point(10, 68);
            this.chkIgnoreCharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIgnoreCharge.Name = "chkIgnoreCharge";
            this.chkIgnoreCharge.Size = new System.Drawing.Size(337, 21);
            this.chkIgnoreCharge.TabIndex = 4;
            this.chkIgnoreCharge.Text = "Ignore Delivery Distance Charge If Surcharge Applies";
            this.chkIgnoreCharge.UseVisualStyleBackColor = true;
            // 
            // txtIgnoreMiles
            // 
            this.txtIgnoreMiles.Location = new System.Drawing.Point(311, 41);
            this.txtIgnoreMiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIgnoreMiles.Name = "txtIgnoreMiles";
            this.txtIgnoreMiles.Size = new System.Drawing.Size(66, 23);
            this.txtIgnoreMiles.TabIndex = 3;
            this.txtIgnoreMiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIgnoreMiles_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Miles";
            // 
            // chkDiliveryChargeIncludeInOrder
            // 
            this.chkDiliveryChargeIncludeInOrder.AutoSize = true;
            this.chkDiliveryChargeIncludeInOrder.Location = new System.Drawing.Point(10, 25);
            this.chkDiliveryChargeIncludeInOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDiliveryChargeIncludeInOrder.Name = "chkDiliveryChargeIncludeInOrder";
            this.chkDiliveryChargeIncludeInOrder.Size = new System.Drawing.Size(225, 21);
            this.chkDiliveryChargeIncludeInOrder.TabIndex = 0;
            this.chkDiliveryChargeIncludeInOrder.Text = "Delivery Charge Includes In Order";
            this.chkDiliveryChargeIncludeInOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPerMileThereafter);
            this.groupBox3.Controls.Add(this.dgvDSDist);
            this.groupBox3.Location = new System.Drawing.Point(7, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(533, 185);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delivery Distance Charge";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Per Mile Thereafter";
            // 
            // txtPerMileThereafter
            // 
            this.txtPerMileThereafter.Location = new System.Drawing.Point(10, 154);
            this.txtPerMileThereafter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPerMileThereafter.Name = "txtPerMileThereafter";
            this.txtPerMileThereafter.Size = new System.Drawing.Size(62, 23);
            this.txtPerMileThereafter.TabIndex = 1;
            this.txtPerMileThereafter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerMileThereafter_KeyPress);
            // 
            // dgvDSDist
            // 
            this.dgvDSDist.Location = new System.Drawing.Point(9, 24);
            this.dgvDSDist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDSDist.Name = "dgvDSDist";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSDist.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSDist.RowTemplate.Height = 23;
            this.dgvDSDist.Size = new System.Drawing.Size(516, 127);
            this.dgvDSDist.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.btnExit);
            this.tabPage3.Controls.Add(this.btnSave);
            this.tabPage3.Controls.Add(this.btnDel);
            this.tabPage3.Controls.Add(this.btnEdit);
            this.tabPage3.Controls.Add(this.btnAdd);
            this.tabPage3.Controls.Add(this.txtSearch);
            this.tabPage3.Controls.Add(this.txtAddress);
            this.tabPage3.Controls.Add(this.txtDistance);
            this.tabPage3.Controls.Add(this.txtMapRef);
            this.tabPage3.Controls.Add(this.txtPostCode);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dgvPostCode);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(585, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Post Code Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(476, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 21;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(492, 328);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 98);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(333, 384);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 42);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(413, 384);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 42);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(413, 328);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 42);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(333, 328);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 42);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(324, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(146, 23);
            this.txtSearch.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(433, 270);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(116, 23);
            this.txtAddress.TabIndex = 12;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(433, 245);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(116, 23);
            this.txtDistance.TabIndex = 11;
            // 
            // txtMapRef
            // 
            this.txtMapRef.Location = new System.Drawing.Point(433, 220);
            this.txtMapRef.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMapRef.Name = "txtMapRef";
            this.txtMapRef.Size = new System.Drawing.Size(116, 23);
            this.txtMapRef.TabIndex = 10;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(433, 195);
            this.txtPostCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(116, 23);
            this.txtPostCode.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(352, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(352, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Distance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Map Ref";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Post Code";
            // 
            // dgvPostCode
            // 
            this.dgvPostCode.Location = new System.Drawing.Point(6, 6);
            this.dgvPostCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPostCode.Name = "dgvPostCode";
            this.dgvPostCode.RowTemplate.Height = 23;
            this.dgvPostCode.Size = new System.Drawing.Size(312, 420);
            this.dgvPostCode.TabIndex = 4;
            this.dgvPostCode.SelectionChanged += new System.EventHandler(this.dgvPostCode_SelectionChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtYourY);
            this.groupBox6.Controls.Add(this.txtYourX);
            this.groupBox6.Controls.Add(this.textBox11);
            this.groupBox6.Controls.Add(this.txtYourStd);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtYourPostCode);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(324, 45);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(238, 142);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Your Location";
            // 
            // txtYourY
            // 
            this.txtYourY.Location = new System.Drawing.Point(103, 96);
            this.txtYourY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYourY.Name = "txtYourY";
            this.txtYourY.Size = new System.Drawing.Size(116, 23);
            this.txtYourY.TabIndex = 20;
            // 
            // txtYourX
            // 
            this.txtYourX.Location = new System.Drawing.Point(103, 71);
            this.txtYourX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYourX.Name = "txtYourX";
            this.txtYourX.Size = new System.Drawing.Size(116, 23);
            this.txtYourX.TabIndex = 19;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(103, 46);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(116, 23);
            this.textBox11.TabIndex = 18;
            // 
            // txtYourStd
            // 
            this.txtYourStd.Location = new System.Drawing.Point(103, 21);
            this.txtYourStd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYourStd.Name = "txtYourStd";
            this.txtYourStd.Size = new System.Drawing.Size(116, 23);
            this.txtYourStd.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 17);
            this.label16.TabIndex = 16;
            this.label16.Text = "Your Y";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 17);
            this.label17.TabIndex = 15;
            this.label17.Text = "Your X";
            // 
            // txtYourPostCode
            // 
            this.txtYourPostCode.AutoSize = true;
            this.txtYourPostCode.Location = new System.Drawing.Point(7, 51);
            this.txtYourPostCode.Name = "txtYourPostCode";
            this.txtYourPostCode.Size = new System.Drawing.Size(93, 17);
            this.txtYourPostCode.TabIndex = 14;
            this.txtYourPostCode.Text = "Your Postcode";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 17);
            this.label19.TabIndex = 13;
            this.label19.Text = "Your STD";
            // 
            // FrmTAConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 511);
            this.Controls.Add(this.grpTAConfig);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTAConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTAConfig";
            this.Load += new System.EventHandler(this.FrmTAConfig_Load);
            this.grpTAConfig.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAPayType)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDist)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostCode)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTAConfig;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTAPayType;
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
        private System.Windows.Forms.Button btnGSExit;
        private System.Windows.Forms.Button btnGSSave;
        private System.Windows.Forms.TextBox txtSurchargeAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOrderThreshold;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIgnoreMiles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkDiliveryChargeIncludeInOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPerMileThereafter;
        private System.Windows.Forms.DataGridView dgvDSDist;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtMapRef;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvPostCode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtYourY;
        private System.Windows.Forms.TextBox txtYourX;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txtYourStd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label txtYourPostCode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnDSExit;
        private System.Windows.Forms.Button btnDSSave;
        private System.Windows.Forms.CheckBox chkIgnoreCharge;
    }
}
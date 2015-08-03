namespace SuperPOS.UI
{
    partial class FrmShiftCodeEntry
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
            this.grpBoxSCEntry = new System.Windows.Forms.GroupBox();
            this.grpBoxSCContentInput = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpBoxSpecialPrice = new System.Windows.Forms.GroupBox();
            this.chkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.chkBoxFriday = new System.Windows.Forms.CheckBox();
            this.chkBoxThursday = new System.Windows.Forms.CheckBox();
            this.chkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.chkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.chkBoxMonday = new System.Windows.Forms.CheckBox();
            this.chkBoxSunday = new System.Windows.Forms.CheckBox();
            this.chkBoxEnable = new System.Windows.Forms.CheckBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblOtherName = new System.Windows.Forms.Label();
            this.lblShiftName = new System.Windows.Forms.Label();
            this.lblShiftCode = new System.Windows.Forms.Label();
            this.grpBoxSCList = new System.Windows.Forms.GroupBox();
            this.lvShiftCode = new System.Windows.Forms.ListView();
            this.columnHeaderCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderShiftName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOtherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.bntEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxSCEntry.SuspendLayout();
            this.grpBoxSCContentInput.SuspendLayout();
            this.grpBoxSpecialPrice.SuspendLayout();
            this.grpBoxSCList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxSCEntry
            // 
            this.grpBoxSCEntry.Controls.Add(this.grpBoxSCContentInput);
            this.grpBoxSCEntry.Controls.Add(this.grpBoxSCList);
            this.grpBoxSCEntry.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBoxSCEntry.Location = new System.Drawing.Point(12, 12);
            this.grpBoxSCEntry.Name = "grpBoxSCEntry";
            this.grpBoxSCEntry.Size = new System.Drawing.Size(630, 503);
            this.grpBoxSCEntry.TabIndex = 1;
            this.grpBoxSCEntry.TabStop = false;
            this.grpBoxSCEntry.Text = "Shift Code Entry";
            // 
            // grpBoxSCContentInput
            // 
            this.grpBoxSCContentInput.Controls.Add(this.btnExit);
            this.grpBoxSCContentInput.Controls.Add(this.btnSave);
            this.grpBoxSCContentInput.Controls.Add(this.btnDel);
            this.grpBoxSCContentInput.Controls.Add(this.bntEdit);
            this.grpBoxSCContentInput.Controls.Add(this.btnAdd);
            this.grpBoxSCContentInput.Controls.Add(this.dateTimePicker2);
            this.grpBoxSCContentInput.Controls.Add(this.dateTimePicker1);
            this.grpBoxSCContentInput.Controls.Add(this.textBox3);
            this.grpBoxSCContentInput.Controls.Add(this.textBox2);
            this.grpBoxSCContentInput.Controls.Add(this.textBox1);
            this.grpBoxSCContentInput.Controls.Add(this.grpBoxSpecialPrice);
            this.grpBoxSCContentInput.Controls.Add(this.lblTo);
            this.grpBoxSCContentInput.Controls.Add(this.lblFrom);
            this.grpBoxSCContentInput.Controls.Add(this.lblOtherName);
            this.grpBoxSCContentInput.Controls.Add(this.lblShiftName);
            this.grpBoxSCContentInput.Controls.Add(this.lblShiftCode);
            this.grpBoxSCContentInput.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBoxSCContentInput.Location = new System.Drawing.Point(353, 22);
            this.grpBoxSCContentInput.Name = "grpBoxSCContentInput";
            this.grpBoxSCContentInput.Size = new System.Drawing.Size(271, 469);
            this.grpBoxSCContentInput.TabIndex = 1;
            this.grpBoxSCContentInput.TabStop = false;
            this.grpBoxSCContentInput.Text = "Shift Code Content Input";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(181, 145);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(64, 23);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(64, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 6;
            // 
            // grpBoxSpecialPrice
            // 
            this.grpBoxSpecialPrice.Controls.Add(this.chkBoxSaturday);
            this.grpBoxSpecialPrice.Controls.Add(this.chkBoxFriday);
            this.grpBoxSpecialPrice.Controls.Add(this.chkBoxThursday);
            this.grpBoxSpecialPrice.Controls.Add(this.chkBoxWednesday);
            this.grpBoxSpecialPrice.Controls.Add(this.chkBoxTuesday);
            this.grpBoxSpecialPrice.Controls.Add(this.chkBoxMonday);
            this.grpBoxSpecialPrice.Controls.Add(this.chkBoxSunday);
            this.grpBoxSpecialPrice.Controls.Add(this.chkBoxEnable);
            this.grpBoxSpecialPrice.Location = new System.Drawing.Point(24, 195);
            this.grpBoxSpecialPrice.Name = "grpBoxSpecialPrice";
            this.grpBoxSpecialPrice.Size = new System.Drawing.Size(216, 177);
            this.grpBoxSpecialPrice.TabIndex = 5;
            this.grpBoxSpecialPrice.TabStop = false;
            this.grpBoxSpecialPrice.Text = "Special Price";
            // 
            // chkBoxSaturday
            // 
            this.chkBoxSaturday.AutoSize = true;
            this.chkBoxSaturday.Location = new System.Drawing.Point(129, 81);
            this.chkBoxSaturday.Name = "chkBoxSaturday";
            this.chkBoxSaturday.Size = new System.Drawing.Size(82, 18);
            this.chkBoxSaturday.TabIndex = 7;
            this.chkBoxSaturday.Text = "Saturday";
            this.chkBoxSaturday.UseVisualStyleBackColor = true;
            // 
            // chkBoxFriday
            // 
            this.chkBoxFriday.AutoSize = true;
            this.chkBoxFriday.Location = new System.Drawing.Point(129, 57);
            this.chkBoxFriday.Name = "chkBoxFriday";
            this.chkBoxFriday.Size = new System.Drawing.Size(68, 18);
            this.chkBoxFriday.TabIndex = 6;
            this.chkBoxFriday.Text = "Friday";
            this.chkBoxFriday.UseVisualStyleBackColor = true;
            // 
            // chkBoxThursday
            // 
            this.chkBoxThursday.AutoSize = true;
            this.chkBoxThursday.Location = new System.Drawing.Point(17, 155);
            this.chkBoxThursday.Name = "chkBoxThursday";
            this.chkBoxThursday.Size = new System.Drawing.Size(82, 18);
            this.chkBoxThursday.TabIndex = 5;
            this.chkBoxThursday.Text = "Thursday";
            this.chkBoxThursday.UseVisualStyleBackColor = true;
            // 
            // chkBoxWednesday
            // 
            this.chkBoxWednesday.AutoSize = true;
            this.chkBoxWednesday.Location = new System.Drawing.Point(17, 130);
            this.chkBoxWednesday.Name = "chkBoxWednesday";
            this.chkBoxWednesday.Size = new System.Drawing.Size(89, 18);
            this.chkBoxWednesday.TabIndex = 4;
            this.chkBoxWednesday.Text = "Wednesday";
            this.chkBoxWednesday.UseVisualStyleBackColor = true;
            // 
            // chkBoxTuesday
            // 
            this.chkBoxTuesday.AutoSize = true;
            this.chkBoxTuesday.Location = new System.Drawing.Point(17, 105);
            this.chkBoxTuesday.Name = "chkBoxTuesday";
            this.chkBoxTuesday.Size = new System.Drawing.Size(75, 18);
            this.chkBoxTuesday.TabIndex = 3;
            this.chkBoxTuesday.Text = "Tuesday";
            this.chkBoxTuesday.UseVisualStyleBackColor = true;
            // 
            // chkBoxMonday
            // 
            this.chkBoxMonday.AutoSize = true;
            this.chkBoxMonday.Location = new System.Drawing.Point(17, 80);
            this.chkBoxMonday.Name = "chkBoxMonday";
            this.chkBoxMonday.Size = new System.Drawing.Size(68, 18);
            this.chkBoxMonday.TabIndex = 2;
            this.chkBoxMonday.Text = "Monday";
            this.chkBoxMonday.UseVisualStyleBackColor = true;
            // 
            // chkBoxSunday
            // 
            this.chkBoxSunday.AutoSize = true;
            this.chkBoxSunday.Location = new System.Drawing.Point(17, 56);
            this.chkBoxSunday.Name = "chkBoxSunday";
            this.chkBoxSunday.Size = new System.Drawing.Size(68, 18);
            this.chkBoxSunday.TabIndex = 1;
            this.chkBoxSunday.Text = "Sunday";
            this.chkBoxSunday.UseVisualStyleBackColor = true;
            // 
            // chkBoxEnable
            // 
            this.chkBoxEnable.AutoSize = true;
            this.chkBoxEnable.Location = new System.Drawing.Point(17, 22);
            this.chkBoxEnable.Name = "chkBoxEnable";
            this.chkBoxEnable.Size = new System.Drawing.Size(68, 18);
            this.chkBoxEnable.TabIndex = 0;
            this.chkBoxEnable.Text = "Enable";
            this.chkBoxEnable.UseVisualStyleBackColor = true;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(143, 151);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 14);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To：";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(21, 151);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(49, 14);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From：";
            // 
            // lblOtherName
            // 
            this.lblOtherName.AutoSize = true;
            this.lblOtherName.Location = new System.Drawing.Point(25, 106);
            this.lblOtherName.Name = "lblOtherName";
            this.lblOtherName.Size = new System.Drawing.Size(91, 14);
            this.lblOtherName.TabIndex = 2;
            this.lblOtherName.Text = "Other Name：";
            // 
            // lblShiftName
            // 
            this.lblShiftName.AutoSize = true;
            this.lblShiftName.Location = new System.Drawing.Point(25, 73);
            this.lblShiftName.Name = "lblShiftName";
            this.lblShiftName.Size = new System.Drawing.Size(91, 14);
            this.lblShiftName.TabIndex = 1;
            this.lblShiftName.Text = "Shift Name：";
            // 
            // lblShiftCode
            // 
            this.lblShiftCode.AutoSize = true;
            this.lblShiftCode.Location = new System.Drawing.Point(25, 37);
            this.lblShiftCode.Name = "lblShiftCode";
            this.lblShiftCode.Size = new System.Drawing.Size(91, 14);
            this.lblShiftCode.TabIndex = 0;
            this.lblShiftCode.Text = "Shift Code：";
            // 
            // grpBoxSCList
            // 
            this.grpBoxSCList.Controls.Add(this.lvShiftCode);
            this.grpBoxSCList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBoxSCList.Location = new System.Drawing.Point(6, 22);
            this.grpBoxSCList.Name = "grpBoxSCList";
            this.grpBoxSCList.Size = new System.Drawing.Size(331, 469);
            this.grpBoxSCList.TabIndex = 0;
            this.grpBoxSCList.TabStop = false;
            this.grpBoxSCList.Text = "Shift Code List";
            // 
            // lvShiftCode
            // 
            this.lvShiftCode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCode,
            this.columnHeaderShiftName,
            this.columnHeaderOtherName});
            this.lvShiftCode.Location = new System.Drawing.Point(6, 22);
            this.lvShiftCode.Name = "lvShiftCode";
            this.lvShiftCode.Size = new System.Drawing.Size(320, 441);
            this.lvShiftCode.TabIndex = 0;
            this.lvShiftCode.UseCompatibleStateImageBehavior = false;
            this.lvShiftCode.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCode
            // 
            this.columnHeaderCode.Text = "Code";
            // 
            // columnHeaderShiftName
            // 
            this.columnHeaderShiftName.Text = "Shift Name";
            this.columnHeaderShiftName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderShiftName.Width = 130;
            // 
            // columnHeaderOtherName
            // 
            this.columnHeaderOtherName.Text = "Other Name";
            this.columnHeaderOtherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderOtherName.Width = 130;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(22, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // bntEdit
            // 
            this.bntEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bntEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntEdit.ForeColor = System.Drawing.Color.White;
            this.bntEdit.Location = new System.Drawing.Point(103, 391);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(75, 30);
            this.bntEdit.TabIndex = 12;
            this.bntEdit.Text = "Edit";
            this.bntEdit.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(103, 430);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(22, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(184, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 69);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // FrmShiftCodeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 550);
            this.Controls.Add(this.grpBoxSCEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShiftCodeEntry";
            this.Text = "FrmShiftCodeEntry";
            this.grpBoxSCEntry.ResumeLayout(false);
            this.grpBoxSCContentInput.ResumeLayout(false);
            this.grpBoxSCContentInput.PerformLayout();
            this.grpBoxSpecialPrice.ResumeLayout(false);
            this.grpBoxSpecialPrice.PerformLayout();
            this.grpBoxSCList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSCEntry;
        private System.Windows.Forms.GroupBox grpBoxSCContentInput;
        private System.Windows.Forms.GroupBox grpBoxSCList;
        private System.Windows.Forms.ListView lvShiftCode;
        private System.Windows.Forms.ColumnHeader columnHeaderCode;
        private System.Windows.Forms.ColumnHeader columnHeaderShiftName;
        private System.Windows.Forms.ColumnHeader columnHeaderOtherName;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpBoxSpecialPrice;
        private System.Windows.Forms.CheckBox chkBoxSaturday;
        private System.Windows.Forms.CheckBox chkBoxFriday;
        private System.Windows.Forms.CheckBox chkBoxThursday;
        private System.Windows.Forms.CheckBox chkBoxWednesday;
        private System.Windows.Forms.CheckBox chkBoxTuesday;
        private System.Windows.Forms.CheckBox chkBoxMonday;
        private System.Windows.Forms.CheckBox chkBoxSunday;
        private System.Windows.Forms.CheckBox chkBoxEnable;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblOtherName;
        private System.Windows.Forms.Label lblShiftName;
        private System.Windows.Forms.Label lblShiftCode;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button bntEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}
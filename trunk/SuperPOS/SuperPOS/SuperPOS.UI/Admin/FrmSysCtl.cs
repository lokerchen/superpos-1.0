using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Common;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.Admin
{
    public partial class FrmSysCtl : Form
    {
        private readonly EntityControl _control = new EntityControl();
        private string sysGuid;

        public FrmSysCtl()
        {
            InitializeComponent();
        }

        private void FrmSysCtl_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetSysControlList();

            if (CommonData.SysControlList.Count > 0)
            {
                var qList = CommonData.SysControlList.FirstOrDefault();
                sysGuid = qList.SystemKey.ToString();
                chkTakeaway.Checked = qList.IsTakeaway.Equals("Y");
                chkEatIn.Checked = qList.IsEatIn.Equals("Y");
                chkQuickFood.Checked = qList.IsQuickFood.Equals("Y");

                txtShopName.Text = qList.ShopName;
                txtAddress.Text = qList.Address;
                chkShopDetailReadOnly.Checked = qList.IsShopDetailReadOnly.Equals("Y");
                chkNotAccountFor.Checked = qList.IsNotAccountFor.Equals("Y");
                txtKey1.Text = qList.Key1;
                txtKey2.Text = qList.Key2;
                txtAccessCode.Text = qList.AccessCode;
                txtImg1.Text = qList.ImgPath1;
                txtImg2.Text = qList.ImgPath2;
                txtImg3.Text = qList.ImgPath3;
                txtImg4.Text = qList.ImgPath4;
                txtImg5.Text = qList.ImgPath5;
            }
            else
            {
                //sysGuid = Guid.NewGuid().ToString().ToUpper();
                chkTakeaway.Checked = false;
                chkEatIn.Checked = false;
                chkQuickFood.Checked = false;

                txtShopName.Text = "";
                txtAddress.Text = "";
                chkShopDetailReadOnly.Checked = false;
                chkNotAccountFor.Checked = false;
                txtKey1.Text = "";
                txtKey2.Text = "";
                txtAccessCode.Text = "";
                txtImg1.Text = "";
                txtImg2.Text = "";
                txtImg3.Text = "";
                txtImg4.Text = "";
                txtImg5.Text = "";
            }
        }

        private string GetKey(Keys key)
        {
            switch (key)
            {
                case Keys.ControlKey:
                    return "CONTROL";
                case Keys.ShiftKey:
                    return "SHIFT";
                case Keys.Alt:
                    return "ALT";
                case Keys.F1:
                    return "F1";
                case Keys.F2:
                    return "F2";
                case Keys.F3:
                    return "F3";
                case Keys.F4:
                    return "F4";
                case Keys.F5:
                    return "F5";
                case Keys.F6:
                    return "F6";
                case Keys.F7:
                    return "F7";
                case Keys.F8:
                    return "F8";
                case Keys.F9:
                    return "F9";
                case Keys.F10:
                    return "F10";
                case Keys.F11:
                    return "F11";
                case Keys.F12:
                    return "F12";
                default:
                    return "";
            }
            return "";
        }

        private void txtKey1_KeyDown(object sender, KeyEventArgs e)
        {
            txtKey1.Text = GetKey(e.KeyCode);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SysControlInfo sysControl = new SysControlInfo();
            sysControl.IsTakeaway = chkTakeaway.Checked ? "Y" : "N";
            sysControl.IsEatIn = chkEatIn.Checked ? "Y" : "N";
            sysControl.IsQuickFood = chkQuickFood.Checked ? "Y" : "N";

            sysControl.ShopName = txtShopName.Text.Trim();
            sysControl.Address = txtAddress.Text.Trim();
            sysControl.IsShopDetailReadOnly = chkShopDetailReadOnly.Checked ? "Y" : "N";

            sysControl.IsNotAccountFor = chkNotAccountFor.Checked ? "Y" : "N";
            sysControl.Key1 = txtKey1.Text.Trim();
            sysControl.Key2 = txtKey2.Text.Trim();
            sysControl.AccessCode = txtAccessCode.Text.Trim();

            sysControl.ImgPath1 = txtImg1.Text.Trim();
            sysControl.ImgPath2 = txtImg2.Text.Trim();
            sysControl.ImgPath3 = txtImg3.Text.Trim();
            sysControl.ImgPath4 = txtImg4.Text.Trim();
            sysControl.ImgPath5 = txtImg5.Text.Trim();

            if (string.IsNullOrEmpty(sysGuid))
            {
                sysControl.SystemKey = new Guid(Guid.NewGuid().ToString().ToUpper());
                _control.AddEntity(sysControl);
            }
            else
            {
                sysControl.SystemKey = new Guid(sysGuid);
                _control.UpdateEntity(sysControl);
            }
        }

        private void btnImg1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Please select file";
            fileDialog.Filter = "Images|*.jpg;*.bmp;*.jpeg";

            if (fileDialog.ShowDialog() == DialogResult.OK) { txtImg1.Text = fileDialog.FileName; }
        }

        private void btnImg2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Please select file";
            fileDialog.Filter = "Images|*.jpg;*.bmp;*.jpeg";

            if (fileDialog.ShowDialog() == DialogResult.OK) { txtImg2.Text = fileDialog.FileName; }
        }

        private void btnImg3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Please select file";
            fileDialog.Filter = "Images|*.jpg;*.bmp;*.jpeg";

            if (fileDialog.ShowDialog() == DialogResult.OK) { txtImg3.Text = fileDialog.FileName; }
        }

        private void btnImg4_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Please select file";
            fileDialog.Filter = "Execute file|*.exe";

            if (fileDialog.ShowDialog() == DialogResult.OK) { txtImg4.Text = fileDialog.FileName; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void txtKey2_KeyDown(object sender, KeyEventArgs e)
        {
            txtKey2.Text = GetKey(e.KeyCode);
        }
    }
}

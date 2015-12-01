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

            if (string.IsNullOrEmpty(sysGuid))
            {
                sysControl.SystemKey = new Guid(Guid.NewGuid().ToString().ToUpper());
                _control.AddEntity(sysControl);
            }
            else _control.UpdateEntity(sysControl);
        }
    }
}

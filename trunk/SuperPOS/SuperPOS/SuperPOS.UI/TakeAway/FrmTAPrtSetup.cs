using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperPOS.Common;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAPrtSetup: Form
    {
        private UserInfo userInfo = new UserInfo();

        private readonly EntityControl _control = new EntityControl();

        public FrmTAPrtSetup()
        {
            InitializeComponent();
        }

        public FrmTAPrtSetup(UserInfo user)
        {
            InitializeComponent();
            userInfo = user;
        }

        private void FrmTAPrtSetup_Load(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetTAPrtInfo();

            if (CommonData.TAPrtInfos.Any())
            {
                TAPrtInfo taPrtInfo = CommonData.TAPrtInfos.FirstOrDefault();
                txtTelNo.Text = taPrtInfo.TelNo;
                txtVATNo.Text = taPrtInfo.VATNo;
                txtMsg1.Text = taPrtInfo.Message1;
                txtMsg2.Text = taPrtInfo.Message2;
                txtMsg3.Text = taPrtInfo.Message3;
                txtMsg4.Text = taPrtInfo.Message4;
                txtMsg5.Text = taPrtInfo.Message5;

            }
        }

        private void btnGenSave_Click(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetTAPrtInfo();

            if (CommonData.TAPrtInfos.Any())
            {
                TAPrtInfo taPrtInfo = CommonData.TAPrtInfos.FirstOrDefault();
                taPrtInfo.TelNo = txtTelNo.Text.Trim();
                taPrtInfo.VATNo = txtVATNo.Text.Trim();
                taPrtInfo.Message1 = txtMsg1.Text.Trim();
                taPrtInfo.Message2 = txtMsg2.Text.Trim();
                taPrtInfo.Message3 = txtMsg3.Text.Trim();
                taPrtInfo.Message4 = txtMsg4.Text.Trim();
                taPrtInfo.Message5 = txtMsg5.Text.Trim();

                _control.UpdateEntity(taPrtInfo);
            }
            else
            {
                TAPrtInfo taPrtInfo = new TAPrtInfo();
                taPrtInfo.SystemKey = Guid.NewGuid();
                taPrtInfo.TelNo = txtTelNo.Text.Trim();
                taPrtInfo.VATNo = txtVATNo.Text.Trim();
                taPrtInfo.Message1 = txtMsg1.Text.Trim();
                taPrtInfo.Message2 = txtMsg2.Text.Trim();
                taPrtInfo.Message3 = txtMsg3.Text.Trim();
                taPrtInfo.Message4 = txtMsg4.Text.Trim();
                taPrtInfo.Message5 = txtMsg5.Text.Trim();

                _control.AddEntity(taPrtInfo);
            }
        }

        private void btnGenExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

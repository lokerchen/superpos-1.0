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

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTATblSetup : Form
    {
        private UserInfo userInfo = new UserInfo();
        private readonly EntityControl _control = new EntityControl();
        public FrmTATblSetup()
        {
            InitializeComponent();
        }

        public FrmTATblSetup(UserInfo user)
        {
            InitializeComponent();
            userInfo = user;

            #region 按钮事件加载
            btn1.Click += Btn_Click;
            btn2.Click += Btn_Click;
            btn3.Click += Btn_Click;
            btn4.Click += Btn_Click;
            btn5.Click += Btn_Click;
            btn6.Click += Btn_Click;
            btn7.Click += Btn_Click;
            btn8.Click += Btn_Click;
            btn9.Click += Btn_Click;
            btn10.Click += Btn_Click;
            btn11.Click += Btn_Click;
            btn12.Click += Btn_Click;
            btn13.Click += Btn_Click;
            btn14.Click += Btn_Click;
            btn15.Click += Btn_Click;
            btn16.Click += Btn_Click;
            btn17.Click += Btn_Click;
            btn18.Click += Btn_Click;
            btn19.Click += Btn_Click;
            btn20.Click += Btn_Click;
            btn21.Click += Btn_Click;
            btn22.Click += Btn_Click;
            btn23.Click += Btn_Click;
            btn24.Click += Btn_Click;
            btn25.Click += Btn_Click;
            btn26.Click += Btn_Click;
            btn27.Click += Btn_Click;
            btn28.Click += Btn_Click;
            btn29.Click += Btn_Click;
            btn30.Click += Btn_Click;
            btn31.Click += Btn_Click;
            btn32.Click += Btn_Click;
            btn33.Click += Btn_Click;
            btn34.Click += Btn_Click;
            btn35.Click += Btn_Click;
            btn36.Click += Btn_Click;
            btn37.Click += Btn_Click;
            btn38.Click += Btn_Click;
            btn39.Click += Btn_Click;
            btn40.Click += Btn_Click;

            btn1.Enter += BtnEnter_Click;
            btn2.Enter += BtnEnter_Click;
            btn3.Enter += BtnEnter_Click;
            btn4.Enter += BtnEnter_Click;
            btn5.Enter += BtnEnter_Click;
            btn6.Enter += BtnEnter_Click;
            btn7.Enter += BtnEnter_Click;
            btn8.Enter += BtnEnter_Click;
            btn9.Enter += BtnEnter_Click;
            btn10.Enter += BtnEnter_Click;
            btn11.Enter += BtnEnter_Click;
            btn12.Enter += BtnEnter_Click;
            btn13.Enter += BtnEnter_Click;
            btn14.Enter += BtnEnter_Click;
            btn15.Enter += BtnEnter_Click;
            btn16.Enter += BtnEnter_Click;
            btn17.Enter += BtnEnter_Click;
            btn18.Enter += BtnEnter_Click;
            btn19.Enter += BtnEnter_Click;
            btn20.Enter += BtnEnter_Click;
            btn21.Enter += BtnEnter_Click;
            btn22.Enter += BtnEnter_Click;
            btn23.Enter += BtnEnter_Click;
            btn24.Enter += BtnEnter_Click;
            btn25.Enter += BtnEnter_Click;
            btn26.Enter += BtnEnter_Click;
            btn27.Enter += BtnEnter_Click;
            btn28.Enter += BtnEnter_Click;
            btn29.Enter += BtnEnter_Click;
            btn30.Enter += BtnEnter_Click;
            btn31.Enter += BtnEnter_Click;
            btn32.Enter += BtnEnter_Click;
            btn33.Enter += BtnEnter_Click;
            btn34.Enter += BtnEnter_Click;
            btn35.Enter += BtnEnter_Click;
            btn36.Enter += BtnEnter_Click;
            btn37.Enter += BtnEnter_Click;
            btn38.Enter += BtnEnter_Click;
            btn39.Enter += BtnEnter_Click;
            btn40.Enter += BtnEnter_Click;

            btn1.Leave += BtnLeave_Click;
            btn2.Leave += BtnLeave_Click;
            btn3.Leave += BtnLeave_Click;
            btn4.Leave += BtnLeave_Click;
            btn5.Leave += BtnLeave_Click;
            btn6.Leave += BtnLeave_Click;
            btn7.Leave += BtnLeave_Click;
            btn8.Leave += BtnLeave_Click;
            btn9.Leave += BtnLeave_Click;
            btn10.Leave += BtnLeave_Click;
            btn11.Leave += BtnLeave_Click;
            btn12.Leave += BtnLeave_Click;
            btn13.Leave += BtnLeave_Click;
            btn14.Leave += BtnLeave_Click;
            btn15.Leave += BtnLeave_Click;
            btn16.Leave += BtnLeave_Click;
            btn17.Leave += BtnLeave_Click;
            btn18.Leave += BtnLeave_Click;
            btn19.Leave += BtnLeave_Click;
            btn20.Leave += BtnLeave_Click;
            btn21.Leave += BtnLeave_Click;
            btn22.Leave += BtnLeave_Click;
            btn23.Leave += BtnLeave_Click;
            btn24.Leave += BtnLeave_Click;
            btn25.Leave += BtnLeave_Click;
            btn26.Leave += BtnLeave_Click;
            btn27.Leave += BtnLeave_Click;
            btn28.Leave += BtnLeave_Click;
            btn29.Leave += BtnLeave_Click;
            btn30.Leave += BtnLeave_Click;
            btn31.Leave += BtnLeave_Click;
            btn32.Leave += BtnLeave_Click;
            btn33.Leave += BtnLeave_Click;
            btn34.Leave += BtnLeave_Click;
            btn35.Leave += BtnLeave_Click;
            btn36.Leave += BtnLeave_Click;
            btn37.Leave += BtnLeave_Click;
            btn38.Leave += BtnLeave_Click;
            btn39.Leave += BtnLeave_Click;
            btn40.Leave += BtnLeave_Click;
            #endregion
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtBtnNum.Text = btn.Text;

            new OnLoadSystemCommonData().GetTaTblSetup();
            var qTblSetupList = CommonData.TaTblSetupList.Where(s => s.BtnNum.Equals(txtBtnNum.Text));
            txtRefNum.Text = qTblSetupList.Any() ? qTblSetupList.FirstOrDefault().RefNum : "";
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Crimson;
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            btn.BackColor = Color.FromArgb(0, 192, 0);
        }

        private void FrmTATblSetup_Load(object sender, EventArgs e)
        {
            txtBtnNum.Text = "1";

            new OnLoadSystemCommonData().GetTaTblSetup();
            var qTblSetupList = CommonData.TaTblSetupList.Where(s => s.BtnNum.Equals(txtBtnNum.Text));
            txtRefNum.Text = qTblSetupList.Any() ? qTblSetupList.FirstOrDefault().RefNum : "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetTaTblSetup();
            var qTblSetupList = CommonData.TaTblSetupList.Where(s => s.BtnNum.Equals(txtBtnNum.Text));

            TATblSetupInfo taTblSetupInfo = new TATblSetupInfo();
            if (qTblSetupList.Any())
            {
                taTblSetupInfo = qTblSetupList.FirstOrDefault();
                taTblSetupInfo.RefNum = txtRefNum.Text;
                _control.UpdateEntity(taTblSetupInfo);
            }
            else
            {
                taTblSetupInfo.SystemKey = Guid.NewGuid();
                taTblSetupInfo.BtnNum = txtBtnNum.Text;
                taTblSetupInfo.RefNum = txtRefNum.Text;
                _control.AddEntity(taTblSetupInfo);
            }
        }
    }
}

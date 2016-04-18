using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTATblSetup : Form
    {
        private UserInfo userInfo = new UserInfo();
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
            #endregion
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmTATblSetup_Load(object sender, EventArgs e)
        {

        }
    }
}

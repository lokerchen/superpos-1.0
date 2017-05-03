using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperPOS.UI.TakeAway
{
    public partial class Frm3rdChoice : Form
    {
        //定义按钮
        private Button[] btn = new Button[15];

        public Frm3rdChoice()
        {
            InitializeComponent();
        }

        private void Frm3rdChoice_Load(object sender, EventArgs e)
        {
            #region 按钮赋值
            btn[0] = btn1;
            btn[1] = btn2;
            btn[2] = btn3;
            btn[3] = btn4;
            btn[4] = btn5;
            btn[5] = btn6;
            btn[6] = btn7;
            btn[7] = btn8;
            btn[8] = btn9;
            btn[9] = btn10;
            btn[10] = btn11;
            btn[11] = btn12;
            btn[12] = btn13;
            btn[13] = btn14;
            btn[14] = btn15;
            #endregion
        }
    }
}

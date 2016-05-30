using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperPOS.DAL;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAMenuSelect : Form
    {
        private string strValue = "";
        public string ValueString
        {
            get { return strValue; }
            set { ValueString = value; }
        }

        public FrmTAMenuSelect()
        {
            InitializeComponent();
        }

        private void FrmTAMenuSelect_Load(object sender, EventArgs e)
        {
            Button[] btnMenu = new Button[4];

            btnMenu[0] = btn1;
            btnMenu[1] = btn2;
            btnMenu[2] = btn3;
            btnMenu[3] = btn4;

            btn1.Click += BtnMenu_Click;
            btn2.Click += BtnMenu_Click;
            btn3.Click += BtnMenu_Click;
            btn4.Click += BtnMenu_Click;

            new OnLoadSystemCommonData().GetTAMenuSet();

            int i = 0;
            foreach (var menuSet in CommonData.TaMenuSetList)
            {
                if (i >= 4) break;

                if (string.IsNullOrEmpty(menuSet.EnglishName)) continue;

                btnMenu[i].Text = menuSet.EnglishName;

                i++;
            }

            for (int j = i; j <= 3; j++)
            {
                btnMenu[i].Visible = false;
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //strValue = btn.Text;

            if (CommonData.TaMenuSetList.Any(s => s.EnglishName.Equals(btn.Text)))
            {
                strValue = CommonData.TaMenuSetList.FirstOrDefault(s => s.EnglishName.Equals(btn.Text)).SystemKey.ToString();

                if (!string.IsNullOrEmpty(strValue))
                {
                    this.DialogResult = DialogResult.OK;
                    Hide();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Hide();
        }
    }
}

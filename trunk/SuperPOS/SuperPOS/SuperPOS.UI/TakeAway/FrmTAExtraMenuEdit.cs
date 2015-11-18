using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.UI.Admin;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAExtraMenuEdit : Form
    {
        public FrmTAExtraMenuEdit()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdminControlPanel frmAdminControlPanel = new FrmAdminControlPanel();
            frmAdminControlPanel.ShowDialog();
        }

        private void FrmTAExtraMenuEdit_Load(object sender, EventArgs e)
        {
            btnVegetable.Click += Btn_Click;
            btnVegetable2.Click += Btn_Click;
            btnBean.Click += Btn_Click;
            btnMeat.Click += Btn_Click;
            btnSeafood.Click += Btn_Click;
            btnSauce.Click += Btn_Click;
            btnTaste.Click += Btn_Click;
            btnFruit.Click += Btn_Click;
            btnCooking.Click += Btn_Click;
            btnOthers.Click += Btn_Click;
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtBtnName.Text = btn.Text;
        }

        private void chkTasteItem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTasteItem.Checked)
            {
                
            }
        }
    }
}

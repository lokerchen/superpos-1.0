using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperPOS.UI.Admin
{
    public partial class FrmUsrMaintenance : Form
    {
        public FrmUsrMaintenance()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdminControlPanel frmAdminControl = new FrmAdminControlPanel();
            frmAdminControl.ShowDialog();
        }
    }
}

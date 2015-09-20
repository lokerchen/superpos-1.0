using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.DAL;

namespace SuperPOS.UI.Admin
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetShiftCodeList();
            dgvUserList.DataSource = CommonData.UsrList;

            dgvUserList.Columns[1].Width = 60;
            dgvUserList.Columns[0].Visible = false;
            dgvUserList.Columns[4].Visible = false;
        }
    }
}

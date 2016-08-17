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
    public partial class FrmTAPendOrder : Form
    {
        public FrmTAPendOrder()
        {
            InitializeComponent();
        }

        private void FrmPendOrder_Load(object sender, EventArgs e)
        {
            //dgvPendOrder.DataSource = lstTest;

            dgvPendOrder.Columns[0].Visible = false;
            dgvPendOrder.Columns[0].Width = 5;
            dgvPendOrder.Columns[1].HeaderText = @"Order No";
            dgvPendOrder.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[2].HeaderText = @"Time";
            dgvPendOrder.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[2].Width = 40;
            dgvPendOrder.Columns[3].HeaderText = @"Postcode";
            dgvPendOrder.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[3].Width = 50;
            dgvPendOrder.Columns[4].HeaderText = @"Postcode Zone";
            dgvPendOrder.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[4].Width = 40;
            dgvPendOrder.Columns[5].HeaderText = @"Address";
            dgvPendOrder.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[5].Width = 40;
            dgvPendOrder.Columns[6].HeaderText = @"Type";
            dgvPendOrder.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[6].Width = 40;
            dgvPendOrder.Columns[7].HeaderText = @"Customer Name";
            dgvPendOrder.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[7].Width = 40;
            dgvPendOrder.Columns[8].HeaderText = @"Total";
            dgvPendOrder.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[8].Width = 40;
            dgvPendOrder.Columns[9].HeaderText = @"Staff";
            dgvPendOrder.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[9].Width = 40;
            dgvPendOrder.Columns[10].HeaderText = @"Driver";
            dgvPendOrder.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendOrder.Columns[10].Width = 40;
        }
    }
}

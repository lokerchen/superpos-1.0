using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmCall : Form
    {
        //送餐类型，默认为D:Delivery
        private string dType = "D";

        public FrmCall()
        {
            InitializeComponent();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            btnCollection.BackColor = Color.Gray;
            dType = "D";
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            btnDelivery.BackColor = Color.Gray;
            dType = "C";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Hide();

        }

        private void FrmCall_Load(object sender, EventArgs e)
        {
            btnAdd5.Click += Btn_Click;
            btnAdd10.Click += Btn_Click;
            btnAdd15.Click += Btn_Click;
            btnAdd20.Click += Btn_Click;
            btnAdd30.Click += Btn_Click;
            btnAdd40.Click += Btn_Click;
            btnAdd50.Click += Btn_Click;
            btnAdd60.Click += Btn_Click;
            btnAdd80.Click += Btn_Click;
        }

        private void Btn_Click(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            txtDCTime.Text = (DateTime.Parse(txtDCTime.Text).AddMinutes(Int32.Parse(btn.Text))).ToLongTimeString();
        }
    }
}

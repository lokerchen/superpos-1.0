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
    public partial class FrmTATastHand : Form
    {
        private string strTast = "";
        private string strClass = "";
        private string strMenuItemKey = "";

        public string ValueString
        {
            get { return txtTasteHand.Text; }
            set { ValueString = value; }
        }

        public FrmTATastHand()
        {
            InitializeComponent();
        }

        public FrmTATastHand(string sMIKey)
        {
            InitializeComponent();
            strMenuItemKey = sMIKey;
        }

        private void btnTasteItem_Click(object sender, EventArgs e)
        {
            btnDrinkItem.BackColor = Color.Gray;
            btnTasteItem.BackColor = Color.FromArgb(128, 128, 255);

            strTast = "1";

            dgvTasteHand.DataSource = CommonData.TaExtraMenuEditList.Where(s => s.TasteOrDrink.Equals("1")).ToList();

            SetDgvFormat("1");
        }

        private void btnDrinkItem_Click(object sender, EventArgs e)
        {
            btnTasteItem.BackColor = Color.Gray;
            btnDrinkItem.BackColor = Color.FromArgb(128, 128, 255);
            strTast = "2";

            dgvTasteHand.DataSource = CommonData.TaExtraMenuEditList.Where(s => s.TasteOrDrink.Equals("1")).ToList();

            SetDgvFormat("1");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTasteHand.Text = "";
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            strClass = btn.Text;
            
            dgvTasteHand.DataSource = string.IsNullOrEmpty(strTast) 
                                    ? CommonData.TaExtraMenuEditList.Where(s => s.BtnName.Equals(strClass)).ToList() 
                                    : CommonData.TaExtraMenuEditList.Where(s => s.BtnName.Equals(strClass) && s.TasteOrDrink.Equals(strTast)).ToList();

            SetDgvFormat("1");
        }

        private void btnProp_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Name.Equals("btnLess"))
            {
                txtTasteHand.Text += @"- ";
            }
            else if (btn.Name.Equals("btnAdd"))
            {
                txtTasteHand.Text += @"+ ";
            }
            else if (btn.Name.Equals("btnMore"))
            {
                txtTasteHand.Text += @"++ ";
            }
            else if (btn.Name.Equals("btnWithout"))
            {
                txtTasteHand.Text += @"X ";
            }
            else if (btn.Name.Equals("btnChange"))
            {
                txtTasteHand.Text += @"\ ";
            }

            btnLess.Enabled = false;
            btnAdd.Enabled = false;
            btnMore.Enabled = false;
            btnWithout.Enabled = false;
            btnChange.Enabled = false;

            btnClear.Enabled = false;

            btnOK.Enabled = false;

        }

        private void FrmTATastHand_Load(object sender, EventArgs e)
        {
            new OnLoadSystemCommonData().GetExtraMenuEdit();
            new OnLoadSystemCommonData().GetTAMenuItemTHList();
            //dgvTasteHand.DataSource = CommonData.TaExtraMenuEditList;

            //dgvTasteHand.Columns[0].Visible = false;
            //dgvTasteHand.Columns[1].Visible = false;
            //dgvTasteHand.Columns[2].Visible = false;
            //dgvTasteHand.Columns[3].HeaderText = @"Item Name";
            //dgvTasteHand.Columns[3].Width = 200;
            //dgvTasteHand.Columns[4].Visible = false;
            //dgvTasteHand.Columns[5].HeaderText = @"Price";
            //dgvTasteHand.Columns[6].Visible = false;

            btnVegetable.Click += btnClass_Click;
            btnVegetable2.Click += btnClass_Click;
            btnBean.Click += btnClass_Click;
            btnMeat.Click += btnClass_Click;
            btnSeafood.Click += btnClass_Click;
            btnSauce.Click += btnClass_Click;
            btnTaste.Click += btnClass_Click;
            btnFruit.Click += btnClass_Click;
            btnCooking.Click += btnClass_Click;
            btnOthers.Click += btnClass_Click;

            btnLess.Click += btnProp_Click;
            btnAdd.Click += btnProp_Click;
            btnMore.Click += btnProp_Click;
            btnWithout.Click += btnProp_Click;
            btnChange.Click += btnProp_Click;

            txtTasteHand.Text = "";

            dgvTasteHand.DataSource = string.IsNullOrEmpty(strMenuItemKey) 
                                        ? CommonData.TaMenuItemTHList 
                                        : CommonData.TaMenuItemTHList.Where(s => s.MenuItemID.Equals(strMenuItemKey)).ToList();

            SetDgvFormat("2");

            //dgvTasteHand.ClearSelection();
        }

        private void dgvTasteHand_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTasteHand.RowCount == 0) return;
            if (dgvTasteHand.CurrentRow?.Index < 0) return;

            btnLess.Enabled = true;
            btnAdd.Enabled = true;
            btnMore.Enabled = true;
            btnWithout.Enabled = true;
            btnChange.Enabled = true;

            btnClear.Enabled = true;

            btnOK.Enabled = true;
            btnExit.Enabled = true;

            if (string.IsNullOrEmpty(txtTasteHand.Text)) return;
            if (txtTasteHand.Text.EndsWith(";")) return;

            if (dgvTasteHand.CurrentRow.Cells[3].Value != null)
                txtTasteHand.Text += dgvTasteHand.CurrentRow.Cells[3].Value.ToString() 
                                     + @"," + dgvTasteHand.CurrentRow.Cells[5].Value.ToString() + @";";
        }

        private void btnShowAllItem_Click(object sender, EventArgs e)
        {
            dgvTasteHand.DataSource = CommonData.TaExtraMenuEditList;

            SetDgvFormat("1");
        }

        private void btnShowPresetItem_Click(object sender, EventArgs e)
        {
            dgvTasteHand.DataSource = string.IsNullOrEmpty(strMenuItemKey)
                                        ? CommonData.TaMenuItemTHList
                                        : CommonData.TaMenuItemTHList.Where(s => s.MenuItemID.Equals(strMenuItemKey)).ToList();

            SetDgvFormat("2");
        }

        private void SetDgvFormat(string strType)
        {
            if (strType.Equals("1"))
            {
                dgvTasteHand.Columns[0].Visible = false;
                dgvTasteHand.Columns[1].Visible = false;
                dgvTasteHand.Columns[2].Visible = false;
                dgvTasteHand.Columns[3].HeaderText = @"Item Name";
                dgvTasteHand.Columns[3].Width = 200;
                dgvTasteHand.Columns[4].Visible = false;
                dgvTasteHand.Columns[5].HeaderText = @"Price";
                dgvTasteHand.Columns[6].Visible = false;
            }
            else
            {
                dgvTasteHand.Columns[0].Visible = false;
                dgvTasteHand.Columns[1].Visible = false;
                dgvTasteHand.Columns[2].Visible = false;
                dgvTasteHand.Columns[3].HeaderText = @"Item Name";
                dgvTasteHand.Columns[3].Width = 200;
                dgvTasteHand.Columns[4].Visible = false;
                dgvTasteHand.Columns[5].HeaderText = @"Price";
                dgvTasteHand.Columns[6].Visible = false;
                dgvTasteHand.Columns[7].Visible = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Hide();
        }
    }
}

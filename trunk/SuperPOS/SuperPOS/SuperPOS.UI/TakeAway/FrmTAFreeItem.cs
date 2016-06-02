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
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAFreeItem : Form
    {
        private Button[] btnFreeItem = new Button[4];
        private string[] strDishCode = new string[4];
        private string sDishCode = "";

        public FrmTAFreeItem()
        {
            InitializeComponent();
        }

        public string DishCode
        {
            get { return sDishCode; }
            set { DishCode = value; }
        }

        private void FrmTAFreeItem_Load(object sender, EventArgs e)
        {
            btnFreeItem[0] = btnFreeItem1;
            btnFreeItem[1] = btnFreeItem2;
            btnFreeItem[2] = btnFreeItem3;
            btnFreeItem[3] = btnFreeItem4;

            btnFreeItem1.Click += BtnFreeItem_Click;
            btnFreeItem2.Click += BtnFreeItem_Click;
            btnFreeItem3.Click += BtnFreeItem_Click;
            btnFreeItem4.Click += BtnFreeItem_Click;

            new OnLoadSystemCommonData().GetTAFreeFoodItemsList();
            new OnLoadSystemCommonData().GetTAMenuItemList();

            int i = 0;
            foreach (var taFreeFoodItemsInfo in CommonData.TAFreeFoodItems)
            {
                if (i >= 4) break;

                if (!string.IsNullOrEmpty(taFreeFoodItemsInfo.FreeCode))
                {
                    if (CommonData.TaMenuItemList.Any(s => s.DishCode.Equals(taFreeFoodItemsInfo.FreeCode)))
                    {
                        TAMenuItemInfo taMenuItemInfo = CommonData.TaMenuItemList.FirstOrDefault(s => s.DishCode.Equals(taFreeFoodItemsInfo.FreeCode));
                        btnFreeItem[i].Text = taMenuItemInfo.EnglishName;
                        strDishCode[i] = taFreeFoodItemsInfo.FreeCode;
                    }
                }

                i++;
            }

            for (int j = i; j < 4; j++)
            {
                btnFreeItem[i].Visible = false;
                strDishCode[i] = "";
            }
        }

        private void BtnFreeItem_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Name.Equals("btnFreeItem1"))
            {
                btnFreeItem1.BackColor = Color.FromArgb(128, 128, 255);
                btnFreeItem2.BackColor = Color.FromArgb(225, 225, 128);
                btnFreeItem3.BackColor = Color.FromArgb(225, 225, 128);
                btnFreeItem4.BackColor = Color.FromArgb(225, 225, 128);
                sDishCode = strDishCode[0];
            }
            else if (btn.Name.Equals("btnFreeItem2"))
            {
                btnFreeItem1.BackColor = Color.FromArgb(225, 225, 128);
                btnFreeItem2.BackColor = Color.FromArgb(128, 128, 255); 
                btnFreeItem3.BackColor = Color.FromArgb(225, 225, 128);
                btnFreeItem4.BackColor = Color.FromArgb(225, 225, 128);
                sDishCode = strDishCode[1];
            }
            else if (btn.Name.Equals("btnFreeItem3"))
            {
                btnFreeItem1.BackColor = Color.FromArgb(225, 225, 128);
                btnFreeItem2.BackColor = Color.FromArgb(225, 225, 128);
                btnFreeItem3.BackColor = Color.FromArgb(128, 128, 255); 
                btnFreeItem4.BackColor = Color.FromArgb(225, 225, 128);
                sDishCode = strDishCode[2];
            }
            else if (btn.Name.Equals("btnFreeItem4"))
            {
                btnFreeItem1.BackColor = Color.FromArgb(225, 225, 128);
                btnFreeItem2.BackColor = Color.FromArgb(225, 225, 128);
                btnFreeItem3.BackColor = Color.FromArgb(225, 225, 128);
                btnFreeItem4.BackColor = Color.FromArgb(128, 128, 255);
                sDishCode = strDishCode[3];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            sDishCode = "";
            this.Hide();
        }
    }
}

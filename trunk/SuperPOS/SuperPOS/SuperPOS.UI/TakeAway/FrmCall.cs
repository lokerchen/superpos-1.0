using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.DAL;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmCall : Form
    {
        //送餐类型，默认为D:Delivery
        private string dType = "D";

        //来电号码
        private string strCallID = "";

        public FrmCall()
        {
            InitializeComponent();
        }

        public FrmCall(string sCallID)
        {
            InitializeComponent();
            strCallID = sCallID;
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
            #region 附件事件
            btnAdd5.Click += Btn_Click;
            btnAdd10.Click += Btn_Click;
            btnAdd15.Click += Btn_Click;
            btnAdd20.Click += Btn_Click;
            btnAdd30.Click += Btn_Click;
            btnAdd40.Click += Btn_Click;
            btnAdd50.Click += Btn_Click;
            btnAdd60.Click += Btn_Click;
            btnAdd80.Click += Btn_Click;
            #endregion

            new OnLoadSystemCommonData().GetTACust();

            if (!string.IsNullOrEmpty(strCallID))
            {
                txtComePhone.Text = strCallID;

                var lstCallId = CommonData.TaCustList.FirstOrDefault(s => s.Phone1.Equals(strCallID));

                if (lstCallId != null)
                {
                    txtPhone.Text = lstCallId.Phone1;
                    txtName.Text = lstCallId.Name;
                    txtHouseNo.Text = lstCallId.HouseNo;
                    txtAddress.Text = lstCallId.Address1;
                    txtPostcode.Text = lstCallId.Postcode1;
                    txtDistance.Text = lstCallId.Distance;
                    txtMapRef.Text = lstCallId.PcZone;
                    txtDelCharge.Text = lstCallId.DelCharge;
                    txtReadyTime.Text = lstCallId.ReadyTime;
                    txtNotes.Text = lstCallId.IntNotes;
                    chkBlackListed.Checked = lstCallId.IsBlackListed.Equals("Y");
                    txtDeliveryCollectionNote.Text = lstCallId.NotesOnBill;
                }
            }
        }

        private void Btn_Click(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            txtDCTime.Text = (DateTime.Parse(txtDCTime.Text).AddMinutes(Int32.Parse(btn.Text))).ToLongTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

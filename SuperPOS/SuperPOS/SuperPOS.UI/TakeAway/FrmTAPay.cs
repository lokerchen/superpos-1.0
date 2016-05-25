using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAPay : Form
    {
        //订单编号
        private string chkNum = "";
        //会员编号
        private string CustNum = "";

        private TextBox[] txtPay = new TextBox[3];
        private Label[] lblPaySurcharge = new Label[3];
        private Label[] lblPayType = new Label[3];
        private Button[] btnDriver = new Button[6];

        public FrmTAPay()
        {
            InitializeComponent();
        }

        public FrmTAPay(string strChkNum, string strCustNum)
        {
            InitializeComponent();
            chkNum = strChkNum;
            CustNum = strCustNum;
        }

        #region 退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void FrmTAPay_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAPayType();
            #region 查询会员
            //查询会员
            new OnLoadSystemCommonData().GetTACust();

            var custList = CommonData.TaCustList.Where(s => s.SystemKey.ToString().Equals(CustNum));

            if (custList.Any())
            {
                TACustInfo taCustInfo = custList.FirstOrDefault();
                txtPhone.Text = taCustInfo.Phone1;
                txtName.Text = taCustInfo.Name;
                txtHouseNo.Text = taCustInfo.HouseNo;
                txtAddress.Text = taCustInfo.Address1;
                txtPostcode.Text = taCustInfo.Postcode1;
                txtDistance.Text = taCustInfo.Distance;
                txtPCZone.Text = taCustInfo.PcZone;
                txtDelCharge.Text = taCustInfo.DelCharge;
                txtReadyTime.Text = taCustInfo.ReadyTime;
                txtIntNotes.Text = taCustInfo.IntNotes;
                txtNotes.Text = taCustInfo.NotesOnBill;
                chkBlackListed.Checked = taCustInfo.IsBlackListed.Equals("Y");
            }
            #endregion

            #region Delivery / Collection Note
            new OnLoadSystemCommonData().GetTAPreDefined();
            var cmbList = CommonData.TaPreDefinedList.Select(lstPD => new { Prevalue = lstPD.PreTxtValue });
            cmbNote.DataSource = cmbList.ToList();
            cmbNote.ValueMember = "Prevalue";
            cmbNote.DisplayMember = "Prevalue";
            #endregion

            #region 控件数组
            lblPayType[0] = lblPayType1;
            lblPayType[1] = lblPayType2;
            lblPayType[2] = lblPayType3;

            txtPay[0] = txtPay1;
            txtPay[1] = txtPay2;
            txtPay[2] = txtPay3;

            lblPaySurcharge[0] = lblSurcharge1;
            lblPaySurcharge[1] = lblSurcharge2;
            lblPaySurcharge[2] = lblSurcharge3;

            //付款
            int i = 0;
            foreach (var taPayTypeInfo in CommonData.TaPayTypeList)
            {
                if (i >= 3) break;

                lblPayType[i].Text = taPayTypeInfo.PaymentType;

                i++;
            }

            i = 0;
            foreach (var taPayTypeInfo in CommonData.TaPayTypeList)
            {
                if (i >= 3) break;

                lblPayType[i].Text = taPayTypeInfo.PaymentType;

                i++;
            }

            //司机清单
            i = 0;
            //foreach (var VARIABLE in CommonData)
            //{

            //}
            #endregion


        }
    }
}

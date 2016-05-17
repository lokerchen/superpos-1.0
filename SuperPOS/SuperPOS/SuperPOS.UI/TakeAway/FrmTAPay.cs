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
        }
    }
}

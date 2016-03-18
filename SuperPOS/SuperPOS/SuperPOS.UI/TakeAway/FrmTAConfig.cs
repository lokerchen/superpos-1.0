﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Common;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;
using SuperPOS.UI.Admin;

namespace SuperPOS.UI.TakeAway
{
    public partial class FrmTAConfig : Form
    {
        private UserInfo userInfo = new UserInfo();
        private Guid TaPayTypeDiscSysKey = Guid.NewGuid();
        private List<TAPayTypeInfo> payTypeList = new List<TAPayTypeInfo>();
        private List<TADistChargeInfo> distChrgList = new List<TADistChargeInfo>();
        private Guid DisChrgRmkSyskey = Guid.NewGuid();
        private readonly EntityControl _control = new EntityControl();
        public FrmTAConfig()
        {
            InitializeComponent();
        }

        public FrmTAConfig(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
        }

        private void FrmTAConfig_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoad = new OnLoadSystemCommonData();
            onLoad.GetTAPayType();
            onLoad.GetTAPayTypeDisc();
            onLoad.GetTADistCharge();
            onLoad.GetTADistChargeRemark();
            onLoad.GetTAPostCode();
            onLoad.GetTAPostCodeRemark();

            #region 绑定General Setting的Payment Type
            payTypeList = CommonData.TaPayTypeList.ToList();
            dgvTAPayType.DataSource = payTypeList;
            dgvTAPayType.Columns[0].Visible = false;
            dgvTAPayType.Columns[5].Visible = false;
            dgvTAPayType.Columns[1].HeaderCell.Value = "Payment Type";
            dgvTAPayType.Columns[2].HeaderCell.Value = "Surcharge Threshold";
            dgvTAPayType.Columns[3].HeaderCell.Value = "Surcharge Amount";
            dgvTAPayType.Columns[4].HeaderCell.Value = "Surcharge %";
            #endregion

            #region General Setting Auto Discount Settings 
            if (CommonData.TaPayTypeDiscList == null || CommonData.TaPayTypeDiscList.Count <= 0)
            {
                txtDeliveryDis.Text = "";
                txtDeliveryDisThres.Text = "";
                txtCollDis.Text = "";
                txtCollDisThres.Text = "";
                txtShopDis.Text = "";
                txtShopDisThres.Text = "";
            }
            else
            {
                var qList = CommonData.TaPayTypeDiscList.FirstOrDefault();
                TaPayTypeDiscSysKey = qList.SystemKey;
                txtDeliveryDis.Text = qList.DeliveryDisc;
                txtDeliveryDisThres.Text = qList.DeliveryDiscThres;
                txtCollDis.Text = qList.CollectionDisc;
                txtCollDisThres.Text = qList.CollectionDiscThres;
                txtShopDis.Text = qList.ShopDisc;
                txtShopDisThres.Text = qList.ShopDiscThres;
            }
            #endregion

            #region Delivery Setting Distance Charge
            distChrgList = CommonData.TaDistChargeList.ToList();
            dgvDSDist.DataSource = distChrgList;
            dgvDSDist.Columns[0].Visible = false;
            dgvDSDist.Columns[4].Visible = false;
            dgvDSDist.Columns[1].HeaderCell.Value = "Distance From";
            dgvDSDist.Columns[2].HeaderCell.Value = "Distance To";
            dgvDSDist.Columns[3].HeaderCell.Value = "Amount To Pay";

            if (CommonData.TaDistChargeRemarkList == null || CommonData.TaDistChargeRemarkList.Count <= 0)
            {
                txtPerMileThereafter.Text = "";
                txtOrderThreshold.Text = "";
                txtSurchargeAmount.Text = "";
                chkDiliveryChargeIncludeInOrder.Checked = false;
                chkIgnoreCharge.Checked = false;
            }
            else
            {
                var qList = CommonData.TaDistChargeRemarkList.FirstOrDefault();
                DisChrgRmkSyskey = qList.SystemKey;
                txtPerMileThereafter.Text = qList.PerMileThereafter;
                chkDiliveryChargeIncludeInOrder.Checked = qList.DeliveryChargeIncludesInOrder.Equals("Y");
                txtIgnoreMiles.Text = qList.IgnoreDeliverySurchargeWhenDistExceeds;
                chkIgnoreCharge.Checked = qList.IgnoreDeliveryDistChargeIfSurchargeAppl.Equals("Y");
                txtOrderThreshold.Text = qList.OrderThreshold;
                txtSurchargeAmount.Text = qList.SurchargeAmount;                
            }
            #endregion

            #region Post Code Setting
            dgvPostCode.DataSource = CommonData.TaPostCodeList;
            dgvPostCode.Columns[0].Visible = false;
            dgvPostCode.Columns[5].Visible = false;
            dgvPostCode.Columns[1].HeaderCell.Value = "Post Code";
            dgvPostCode.Columns[2].HeaderCell.Value = "Address";
            dgvPostCode.Columns[3].HeaderCell.Value = "Map";
            dgvPostCode.Columns[4].HeaderCell.Value = "Distance";

            if (CommonData.TaPostCodeRemarkList == null || CommonData.TaPostCodeRemarkList.Count <= 0)
            {
                txtYourStd.Text = "";
                txtPostCode.Text = "";
                txtYourX.Text = "";
                txtYourY.Text = "";
            }
            else
            {
                var qList = CommonData.TaPostCodeRemarkList.FirstOrDefault();
                txtYourStd.Text = qList.UrSTD;
                txtPostCode.Text = qList.UrPostCode;
                txtYourX.Text = qList.UrX;
                txtYourY.Text = qList.UrY;
            }
            #endregion

        }

        #region General Settings Exit按钮
        private void btnGSExit_Click(object sender, EventArgs e)
        {
            Hide();
            //FrmAdminControlPanel frmAdminControl = new FrmAdminControlPanel();
            //frmAdminControl.ShowDialog();
        }
        #endregion

        #region General Settings Save按钮     
        private void btnGSSave_Click(object sender, EventArgs e)
        {
            // 保存Payment Type
            SavePayType();

            // 保存Pay type discount
            SavePayTypeDisc();
        }
        #endregion  

        #region Delivery Settings Save按钮     
        private void btnDSSave_Click(object sender, EventArgs e)
        {
            //保存Delivery Distance Charge 列表
            SaveDeliDistChrg();

            //保存Delivery Surcharge和Charge Options
            SaveDistChrgRmk();
        }
        #endregion

        #region Delivery Settings Exit按钮
        private void btnDSExit_Click(object sender, EventArgs e)
        {
            Hide();
            //FrmAdminControlPanel frmAdminControl = new FrmAdminControlPanel();
            //frmAdminControl.ShowDialog();
        }
        #endregion

        private void dgvPostCode_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPostCode.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvPostCode.CurrentRow == null)
                return;

            if (dgvPostCode.CurrentRow.Index < 0) return;

            txtYourStd.Text = dgvPostCode.CurrentRow.Cells[1].Value.ToString();
            txtPostCode.Text = dgvPostCode.CurrentRow.Cells[2].Value.ToString();
            txtYourX.Text = dgvPostCode.CurrentRow.Cells[3].Value.ToString();
            txtYourY.Text = dgvPostCode.CurrentRow.Cells[4].Value.ToString();
        }

        #region txtDeliveryDis只允许输入数字
        private void txtDeliveryDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8) e.Handled = true;
        }
        #endregion

        #region txtDeliveryDisThres只允许输入数字
        private void txtDeliveryDisThres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8) e.Handled = true;
        }
        #endregion

        #region txtCollDis只允许输入数字
        private void txtCollDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8) e.Handled = true;
        }
        #endregion

        #region txtCollDisThres只允许输入数字
        private void txtCollDisThres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8) e.Handled = true;
        }
        #endregion

        #region txtShopDis只允许输入数字
        private void txtShopDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8) e.Handled = true;
        }
        #endregion
       
        #region txtShopDisThres只允许输入数字
        private void txtShopDisThres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8) e.Handled = true;
        }
        #endregion
        
        #region txtPerMileThereafter只允许输入数字
        private void txtPerMileThereafter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.';
        }
        #endregion

        #region txtIgnoreMiles只允许输入数字
        private void txtIgnoreMiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.';
        }
        #endregion

        #region txtOrderThreshold只允许输入数字
        private void txtOrderThreshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.';
        }
        #endregion
        
        #region txtSurchargeAmount只允许输入数字
        private void txtSurchargeAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.';
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SavePayType()
        {
            foreach (var payType in payTypeList) { _control.UpdateEntity(payType); }
        }

        private void SavePayTypeDisc()
        {
            TAPayTypeDiscInfo taPayTypeDisc = new TAPayTypeDiscInfo();
            taPayTypeDisc.SystemKey = TaPayTypeDiscSysKey;
            taPayTypeDisc.DeliveryDisc = txtDeliveryDis.Text;
            taPayTypeDisc.DeliveryDiscThres = txtDeliveryDisThres.Text;
            taPayTypeDisc.CollectionDisc = txtCollDis.Text;
            taPayTypeDisc.CollectionDiscThres = txtCollDisThres.Text;
            taPayTypeDisc.ShopDisc = txtShopDis.Text;
            taPayTypeDisc.ShopDiscThres = txtShopDisThres.Text;
            _control.UpdateEntity(taPayTypeDisc);
        }

        private void SaveDeliDistChrg()
        {
            foreach (var distChrg in distChrgList) { _control.UpdateEntity(distChrg); }
        }

        private void SaveDistChrgRmk()
        {
            TADistChargeRemarkInfo taDistChargeRemark = new TADistChargeRemarkInfo();
            taDistChargeRemark.SystemKey = DisChrgRmkSyskey;
            taDistChargeRemark.PerMileThereafter = txtPerMileThereafter.Text;
            taDistChargeRemark.DeliveryChargeIncludesInOrder = chkDiliveryChargeIncludeInOrder.Checked ? "Y" : "N";
            taDistChargeRemark.IgnoreDeliverySurchargeWhenDistExceeds = txtIgnoreMiles.Text;
            taDistChargeRemark.IgnoreDeliveryDistChargeIfSurchargeAppl = chkIgnoreCharge.Checked ? "Y" : "N";
            taDistChargeRemark.OrderThreshold = txtOrderThreshold.Text;
            taDistChargeRemark.SurchargeAmount = txtSurchargeAmount.Text;
            _control.UpdateEntity(taDistChargeRemark);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Domain.Entities;
using SuperPOS.UI.TakeAway;

namespace SuperPOS.UI.Admin
{
    public partial class  FrmAdminControlPanel : Form
    {
        private UserInfo usrInfo = new UserInfo();
        private bool isShowSysCtl = false; //是否显示System Control按钮

        public FrmAdminControlPanel()
        {
            InitializeComponent();
        }

        public FrmAdminControlPanel(UserInfo uInfo, bool isShow)
        {
            InitializeComponent();
            usrInfo = uInfo;
            isShowSysCtl = isShow;
        }

        private void FrmAdminControlPanel_Load(object sender, EventArgs e)
        {
            //if (usrInfo.UsrRight == 1)
            //    gupBoxEatInSetting.Visible = false;
            btnSysControl.Visible = isShowSysCtl;
        }

        private void btnShiftCode_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmShiftCodeEntry frmShiftCodeEntry = new FrmShiftCodeEntry();
            frmShiftCodeEntry.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogon frmLogon = new FrmLogon();
            frmLogon.ShowDialog();
        }

        private void btnSysConfig_Click(object sender, EventArgs e)
        {
            FrmSysConfig frmSysConfig = new FrmSysConfig();
            Hide();
            frmSysConfig.ShowDialog();
        }

        private void btnUsrMaint_Click(object sender, EventArgs e)
        {
            Hide();
            FrmUsrMaintenance frmUsrMaintenance = new FrmUsrMaintenance();
            frmUsrMaintenance.ShowDialog();
        }

        private void btnDataManager_Click(object sender, EventArgs e)
        {

        }

        private void btnComputerAddr_Click(object sender, EventArgs e)
        {
            Hide();
            FrmComputerEntry frmComputerEntry = new FrmComputerEntry();
            frmComputerEntry.ShowDialog();
        }

        private void btnCompactDB_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCompactDB frmCompactDb = new FrmCompactDB();
            frmCompactDb.ShowDialog();
        }

        private void btnTQTakeawayConfig_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTAConfig frmTaConfig = new FrmTAConfig();
            frmTaConfig.ShowDialog();
        }

        private void btnTQManageMenuSet_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTAManageMenuSet frmTaManageMenuSet = new FrmTAManageMenuSet();
            frmTaManageMenuSet.ShowDialog();
        }

        private void btnTQDeptCode_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTADeptCode frmTaDeptCode = new FrmTADeptCode();
            frmTaDeptCode.ShowDialog();
        }

        private void btnTQMenuCategory_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTAMenuCategory frmTaMenuCategory = new FrmTAMenuCategory();
            frmTaMenuCategory.ShowDialog();
        }

        private void btnTQMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTAMenuItem frmTaMenuItem = new FrmTAMenuItem();
            frmTaMenuItem.ShowDialog();
        }

        private void btnTQOrderControl_Click(object sender, EventArgs e)
        {

        }

        private void btnTQTableSetup_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTATblSetup frmTaTblSetup = new FrmTATblSetup();
            frmTaTblSetup.ShowDialog();
        }

        private void btnTQExtraMenuEdit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTAExtraMenuEdit frmTAExtraMenuEdit = new FrmTAExtraMenuEdit();
            frmTAExtraMenuEdit.ShowDialog();
        }

        private void btnTQPrintSetup_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTAPrtSetup frmTaPrtSetup = new FrmTAPrtSetup();
            frmTaPrtSetup.ShowDialog();
        }

        private void btnSysControl_Click(object sender, EventArgs e)
        {
            FrmSysCtl frmSysCtl = new FrmSysCtl();
            Hide();
            frmSysCtl.ShowDialog();
        }
    }
}

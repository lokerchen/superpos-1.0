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

        public FrmAdminControlPanel()
        {
            InitializeComponent();
        }

        public FrmAdminControlPanel(UserInfo uInfo)
        {
            InitializeComponent();
            usrInfo = uInfo;
        }

        private void FrmAdminControlPanel_Load(object sender, EventArgs e)
        {
            //if (usrInfo.UsrRight == 1)
            //    gupBoxEatInSetting.Visible = false;
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
    }
}

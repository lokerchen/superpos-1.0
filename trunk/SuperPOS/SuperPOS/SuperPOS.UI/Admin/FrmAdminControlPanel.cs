using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Common;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;
using SuperPOS.UI.TakeAway;

namespace SuperPOS.UI.Admin
{
    public partial class  FrmAdminControlPanel : Form
    {
        private UserInfo userInfo = new UserInfo();
        private bool isShowSysCtl = false; //是否显示System Control按钮
        private UserMaintenanceInfo userMaintenance = null;

        public FrmAdminControlPanel()
        {
            InitializeComponent();
        }

        public FrmAdminControlPanel(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
            //isShowSysCtl = isShow;
        }

        private void FrmAdminControlPanel_Load(object sender, EventArgs e)
        {
            //picBoxWelCome.Image = Image.FromFile(CommonBase.IMG_PATH_DEFAULT + CommonBase.IMG_FILE_LOGO_LOGON);
            string strImgWelcome = "";
            strImgWelcome = CommonFunction.GetSysImg("1");
            picBoxWelCome.Image = File.Exists(strImgWelcome) ? Image.FromFile(strImgWelcome) : null;
            
            treeViewMenu.ExpandAll();

            if (userInfo.IsSysCtrl.Equals("0"))
            {
                treeViewMenu.Nodes.Remove(treeViewMenu.Nodes[4]);
            }
            else
            {
                if (!treeViewMenu.Nodes.Cast<TreeNode>().Any(nd => nd.Text.Equals("System Control") && nd.Name.Equals("5")))
                {
                    TreeNode node = new TreeNode("System Control");
                    node.Name = "5";
                    treeViewMenu.Nodes.Add(node);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSelectMenu frmSelectMenu = new FrmSelectMenu(userInfo);
            frmSelectMenu.ShowDialog();
        }

        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Console.Out.WriteLine(e.Node.Name);
            
        }

        private void treeViewMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string nodeName = e.Node.Name;
            string strMsg = "You do not have permission to access!";
            switch (nodeName)
            {
                case "101":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "402"))
                    {
                        FrmSysConfig frmSysConfig = new FrmSysConfig(userInfo);
                        frmSysConfig.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "102":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "403"))
                    {
                        FrmUsrMaintenance frmUsrMaintenance = new FrmUsrMaintenance(userInfo);
                        frmUsrMaintenance.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "103":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "403"))
                    {
                        
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "104":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "404"))
                    {
                        FrmCompactDB frmCompactDb = new FrmCompactDB(userInfo);
                        frmCompactDb.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "105":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "409"))
                    {
                        FrmComputerEntry frmComputerEntry = new FrmComputerEntry(userInfo);
                        frmComputerEntry.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "106":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "410"))
                    {
                        FrmShiftCodeEntry frmShiftCode = new FrmShiftCodeEntry(userInfo);
                        frmShiftCode.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "201":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "101"))
                    {
                        FrmTAConfig frmTaConfig = new FrmTAConfig(userInfo);
                        frmTaConfig.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "202":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "101"))
                    {
                        FrmTAMenuCategory frmTaMenuCategory = new FrmTAMenuCategory(userInfo);
                        frmTaMenuCategory.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "203":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "101"))
                    {
                        FrmTAMenuItem frmTaMenuItem = new FrmTAMenuItem(userInfo);
                        frmTaMenuItem.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "204":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "101"))
                    {
                        FrmTAManageMenuSet frmTaManageMenuSet = new FrmTAManageMenuSet(userInfo);
                        frmTaManageMenuSet.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "205":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "101"))
                    {
                        FrmTAExtraMenuEdit frmTaExtraMenuEdit = new FrmTAExtraMenuEdit(userInfo);
                        frmTaExtraMenuEdit.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "206":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "101"))
                    {

                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "207":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "101"))
                    {
                        FrmTADeptCode frmTaDeptCode = new FrmTADeptCode(userInfo);
                        frmTaDeptCode.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "208":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "101"))
                    {
                        FrmTATblSetup frmTaTblSetup = new FrmTATblSetup(userInfo);
                        frmTaTblSetup.ShowDialog();
                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "209":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "101"))
                    {

                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "210":
                    if (CommonFunction.GetUsrPermission(userInfo.UsrCode, "101"))
                    {

                    }
                    else MessageBox.Show(strMsg);
                    break;
                case "5":
                    FrmSysCtl frmSysCtl = new FrmSysCtl();
                    frmSysCtl.ShowDialog();
                    break;
            }
        }
    }
}

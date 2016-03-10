using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Common;
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

        public FrmAdminControlPanel(UserInfo uInfo)
        {
            InitializeComponent();
            usrInfo = uInfo;
            //isShowSysCtl = isShow;
        }

        private void FrmAdminControlPanel_Load(object sender, EventArgs e)
        {
            picBoxWelCome.Image = Image.FromFile(CommonBase.IMG_PATH_DEFAULT + CommonBase.IMG_FILE_LOGO_LOGON);

            treeViewMenu.ExpandAll();

            if (usrInfo.IsSysCtrl.Equals("0"))
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
            FrmSelectMenu frmSelectMenu = new FrmSelectMenu(usrInfo);
            frmSelectMenu.ShowDialog();
        }

        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Console.Out.WriteLine(e.Node.Name);
            
        }

        private void treeViewMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string nodeName = e.Node.Name;
            switch (nodeName)
            {
                case "101":
                    break;
                case "102":
                    break;
                case "103":
                    break;
                case "104":
                    break;
                case "105":
                    break;
                case "106":
                    break;
                case "201":
                    break;
                case "202":
                    break;
                case "203":
                    break;
                case "204":
                    break;
                case "205":
                    break;
                case "206":
                    break;
                case "207":
                    break;
                case "208":
                    break;
                case "209":
                    break;
                case "210":
                    break;
                case "5":
                    FrmSysCtl frmSysCtl = new FrmSysCtl();
                    frmSysCtl.ShowDialog();
                    break;
            }
        }
    }
}

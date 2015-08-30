using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using SuperPOS.Common;
using SuperPOS.DAL;

namespace SuperPOS.UI.Admin
{
    public partial class FrmSysConfig : Form
    {
        private int iExistRest = 0;       //是否存在餐厅,0没有餐厅，1有餐厅

        public FrmSysConfig()
        {
            InitializeComponent();
        }

        public FrmSysConfig(int iExist)
        {
            iExistRest = iExist;
            InitializeComponent();
        }

        #region 事件

        #region Exit按钮点击事件
        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdminControlPanel frmAdminControl = new FrmAdminControlPanel();
            frmAdminControl.ShowDialog();
        }
        #endregion

        #region Display Item Code Select选中事件
        private void chkBoxDisItemCodeSelect_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxDisItemCodeSelect.Checked = !chkBoxDisItemCodeSelect.Checked;
        }
        #endregion

        #region Setting Input Number of Persons选中事件
        private void chkBoxInputNumPerson_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxInputNumPerson.Checked = !chkBoxInputNumPerson.Checked;
        }
        #endregion

        #region Use Cash Drawer选中事件
        private void chkBoxUseCashDrawer_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxUseCashDrawer.Checked = !chkBoxUseCashDrawer.Checked;
        }
        #endregion

        #region 窗口Load事件
        private void FrmSysConfig_Load(object sender, EventArgs e)
        {
            GetSysDir();
            GetPrinter();
            SetDefInputPat();

            if (iExistRest != 1) return;
            //有数据
            new OnLoadSystemCommonData().GetSysConfigList();

            var lstSysConfig = CommonData.SysConfigList.First();
            txtShopName.Text = lstSysConfig.ShopName;
            txtAddr.Text = lstSysConfig.ShopAddr;
            chkBoxDisItemCodeSelect.Checked = lstSysConfig.IsDisplayItemCodeSelect.Equals("1");
            chkBoxInputNumPerson.Checked = lstSysConfig.IsInputNumberOfPerson.Equals("1");
            chkBoxBackUpWhenExit.Checked = lstSysConfig.IsBackUpWhenExit.Equals("1");
        }
        #endregion

        #region Save按钮单击事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            string isCtlNull = IsControlNull();
            //判断控件值是否为空
            if (!string.IsNullOrEmpty(isCtlNull))
            {
                //保存
            }
            else
            {
                MessageBox.Show(isCtlNull);
                return;
            }
        }
        #endregion

        #endregion

        #region 方法

        #region 系统所有页面

        private void SetDefInputPat()
        {
            comBoxDefOrderInputPage.Items.Add("System Control"); //0
            comBoxDefOrderInputPage.Items.Add("Takeaway"); //1
            comBoxDefOrderInputPage.Items.Add("Eat In");  //2
            comBoxDefOrderInputPage.Items.Add("Quick Food");  //3
            comBoxDefOrderInputPage.SelectedIndex = 0;
        }
        #endregion

        #region 判断控件值是否空

        private string IsControlNull()
        {
            if (string.IsNullOrEmpty(txtShopName.Text.Trim())) return "Shop name can not empty!";
            if (string.IsNullOrEmpty(txtAddr.Text.Trim())) return "Shop address can not empty!";
            if (string.IsNullOrEmpty(txtTillNum.Text.Trim())) return "Till number can not empty!";
            if (string.IsNullOrEmpty(txtCurrency.Text.Trim())) return "Currency can not empty!";
            if (string.IsNullOrEmpty(txtVATPerct.Text.Trim())) return "VAT Percentage can not empty!";
            if (string.IsNullOrEmpty(txtRoundUpDecimal.Text.Trim())) return "Round up decimal can not empty!";

            if (string.IsNullOrEmpty(txtKey1.Text.Trim())) return "Key1 can not empty!";
            if (string.IsNullOrEmpty(txtKey2.Text.Trim())) return "Key2 can not empty!";
            if (string.IsNullOrEmpty(txtKey3.Text.Trim())) return "Key3 can not empty!";
            if (string.IsNullOrEmpty(txtKey4.Text.Trim())) return "Key4 can not empty!";
            if (string.IsNullOrEmpty(txtKey5.Text.Trim())) return "Key5 can not empty!";
            if (string.IsNullOrEmpty(txtKey6.Text.Trim())) return "Key6 can not empty!";
            if (string.IsNullOrEmpty(txtKey7.Text.Trim())) return "Key7 can not empty!";
            if (string.IsNullOrEmpty(txtKey8.Text.Trim())) return "Key8 can not empty!";
            if (string.IsNullOrEmpty(txtKey9.Text.Trim())) return "Key9 can not empty!";
            if (string.IsNullOrEmpty(txtKey10.Text.Trim())) return "Key10 can not empty!";

            return "";

            //foreach (Control ctl in Controls.Cast<Control>().Where(ctl => ctl.GetType().Name.Equals("TextBox")))
            //{
            //    ctl.Focus();
            //    Console.WriteLine(ctl.GetType().Name.Substring(2));
            //    //return ctl.GetType().Name.Substring(2) + " can not empty!";
            //}

            //return "";
        }

        #endregion

        #region 获得所有系统盘符
        /// <summary>
        /// 获得系统盘符（只有硬盘和可移动磁盘）
        /// </summary>
        private void GetSysDir()
        {
            SelectQuery selectQuery = new SelectQuery(CommonBase.SELECT_WIN32_LOGICALDISK);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(selectQuery);
            //foreach (ManagementObject disk in searcher.Get())
            //{
            //    //获取驱动器盘符
            //    //this.listBox1.Items.Add(disk["Name"].ToString());
            //    //Console.WriteLine(disk["Name"].ToString());
            //    //switch (disk["DriveType"].ToString())
            //    //{
            //    //    case "3":
            //    //}

            //    if (disk["DriveType"].ToString().Equals("3") || disk["DriveType"].ToString().Equals("2"))
            //        Console.WriteLine(disk["Name"].ToString());
            //}
            //只输出3：硬盘和2：可移动磁盘
            foreach (ManagementObject disk in searcher.Get().Cast<ManagementObject>().Where(disk => disk["DriveType"].ToString().Equals("3") || disk["DriveType"].ToString().Equals("2")))
            {
                //Console.WriteLine(disk["Name"].ToString().Trim(':'));
                comBoxBackUpDrive.Items.Add(disk["Name"].ToString().Trim(':'));
            }
            if (comBoxBackUpDrive.Items.Count > 0) comBoxBackUpDrive.SelectedIndex = 0;
        }
        #endregion

        #region 获得所有打印列表

        private void GetPrinter()
        {
            foreach (string sPrint in PrinterSettings.InstalledPrinters)//获取所有打印机名称
            {
                PrintDocument print = new PrintDocument();
                string sDefault = print.PrinterSettings.PrinterName;//默认打印机名

                comBoxRptPrint.Items.Add(sPrint);
                if (sPrint == sDefault)
                    comBoxRptPrint.SelectedIndex = comBoxRptPrint.Items.IndexOf(sPrint);
            }
        }
    #endregion

    #endregion
}
}

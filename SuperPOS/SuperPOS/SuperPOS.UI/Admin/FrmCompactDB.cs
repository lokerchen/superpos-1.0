using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.Admin
{
    public partial class FrmCompactDB : Form
    {
        private string fileName = "";
        private UserInfo userInfo = new UserInfo();
        public FrmCompactDB()
        {
            InitializeComponent();
        }

        public FrmCompactDB(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
        }

        private void btnBackupData_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.Filter = @"Backup Files|*.db";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                    string strDb = Path.GetDirectoryName(Application.ExecutablePath) + @"\SuperPOS.db";
                    if (File.Exists(strDb))
                    {
                        File.Copy(strDb, fileName, true);
                    }
                    else
                    {
                        MessageBox.Show("Can not backup data,Please contact Administrator!");
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can not backup data,Please contact Administrator!");
                return;
                throw;
            }
        }

        private void btnRestoreData_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.Filter = @"Backup Files|*.db";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                    string strDb = Path.GetDirectoryName(Application.ExecutablePath) + @"\SuperPOS.db";
                    if (File.Exists(strDb))
                    {
                        File.Copy(fileName, strDb, true);
                    }
                    else
                    {
                        MessageBox.Show("Can not backup data,Please contact Administrator!");
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can not backup data,Please contact Administrator!");
                return;
                throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            //FrmAdminControlPanel frmAdminControlPanel = new FrmAdminControlPanel();
            //frmAdminControlPanel.ShowDialog();
        }
    }
}

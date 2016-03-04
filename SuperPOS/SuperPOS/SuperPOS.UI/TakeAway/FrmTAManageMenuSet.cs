using System;
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
    public partial class FrmTAManageMenuSet : Form
    {
        private int iStatus;

        private readonly EntityControl _control = new EntityControl();
        public FrmTAManageMenuSet()
        {
            InitializeComponent();
        }

        private void FrmTAManageMenuSet_Load(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoad = new OnLoadSystemCommonData();
            onLoad.GetTAMenuSet();

            comboxFrom1.Items.Add("Takeaway");
            comboxFrom1.Items.Add("Eat-In");
            comboxFrom1.Items.Add("QuickDining");
            comboxTo1.Items.Add("Takeaway");
            comboxTo1.Items.Add("Eat-In");
            comboxTo1.Items.Add("QuickDining");

            comboxFrom1.SelectedIndex = 0;
            comboxTo1.SelectedIndex = 0;

            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAMenuSet();

            for (int i = 1; i < 5; i++)
            {
                TAMenuSetInfo taMenuSetInfo = CommonData.TaMenuSetList.FirstOrDefault(s => s.ID.Equals(i.ToString()));
                if (taMenuSetInfo != null)
                {
                    switch (i)
                    {
                        case 1:
                            txtEngName1.Text = taMenuSetInfo.EnglishName;
                            txtOtherName1.Text = taMenuSetInfo.OtherName;
                            break;
                        case 2:
                            txtEngName2.Text = taMenuSetInfo.EnglishName;
                            txtOtherName2.Text = taMenuSetInfo.OtherName;
                            break;
                        case 3:
                            txtEngName3.Text = taMenuSetInfo.EnglishName;
                            txtOtherName3.Text = taMenuSetInfo.OtherName;
                            break;
                        case 4:
                            txtEngName4.Text = taMenuSetInfo.EnglishName;
                            txtOtherName4.Text = taMenuSetInfo.OtherName;
                            break;
                    }
                }
            }

            IList<string> lstType = CommonData.TaMenuSetList.Select(s => s.EnglishName).ToList();
            comboxFrom2.DataSource = lstType;
            comboxTo2.DataSource = lstType;
            comboxFrom2.SelectedIndex = 0;
            comboxTo2.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetTAMenuSet();

            Guid g = Guid.NewGuid();
            Console.Out.WriteLine(g.ToString());

            try
            {
                for (int i = 1; i < 5; i++)
                {
                    TAMenuSetInfo taMenuSetInfo = CommonData.TaMenuSetList.FirstOrDefault(s => s.ID.Equals(i.ToString()));
                    if (taMenuSetInfo != null)
                    {
                        switch (i)
                        {
                            case 1:
                                taMenuSetInfo.ID = "1";
                                taMenuSetInfo.EnglishName = txtEngName1.Text.Trim();
                                taMenuSetInfo.OtherName = txtOtherName1.Text.Trim();
                                break;
                            case 2:
                                taMenuSetInfo.ID = "2";
                                taMenuSetInfo.EnglishName = txtEngName2.Text.Trim();
                                taMenuSetInfo.OtherName = txtOtherName2.Text.Trim();
                                break;
                            case 3:
                                taMenuSetInfo.ID = "3";
                                taMenuSetInfo.EnglishName = txtEngName3.Text.Trim();
                                taMenuSetInfo.OtherName = txtOtherName3.Text.Trim();
                                break;
                            case 4:
                                taMenuSetInfo.ID = "4";
                                taMenuSetInfo.EnglishName = txtEngName4.Text.Trim();
                                taMenuSetInfo.OtherName = txtOtherName4.Text.Trim();
                                break;
                        }
                        _control.UpdateEntity(taMenuSetInfo);
                    }
                }

                MessageBox.Show("Save success!");
            }
            catch (Exception)
            {
                MessageBox.Show("Save Failed!");
                throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdminControlPanel frmAdminControl = new FrmAdminControlPanel();
            frmAdminControl.ShowDialog();
        }

        private void comboxTo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }
    }
}

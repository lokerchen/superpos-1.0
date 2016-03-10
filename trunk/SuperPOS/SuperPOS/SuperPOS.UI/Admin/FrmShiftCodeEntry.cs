using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperPOS.Common;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.Admin
{
    public partial class FrmShiftCodeEntry : Form
    {
        private readonly EntityControl _control = new EntityControl();
        private int iStatus;
        private UserInfo userInfo = new UserInfo();

        public FrmShiftCodeEntry()
        {
            InitializeComponent();
        }

        public FrmShiftCodeEntry(UserInfo uInfo)
        {
            InitializeComponent();
            userInfo = uInfo;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            //FrmAdminControlPanel frmAdminControlPanel = new FrmAdminControlPanel(userInfo);
            //frmAdminControlPanel.ShowDialog();
        }

        #region 添加功能按钮

        private void btnAdd_Click(object sender, EventArgs e)
        {
            iStatus = 1;
            txtShiftCode.Text = (CommonData.ShiftCodeList.Max(s => s.ShiftCode) + 1).ToString();
            txtShiftName.Text = "";
            txtOtherName.Text = "";
            dtpFrom.Text = DateTime.Now.ToLongTimeString();
            dtpTo.Text = DateTime.Now.ToLongTimeString();

            chkBoxEnable.Enabled = true;
            chkBoxEnable.Checked = false;

            ChkEnableFalse();
            ChkStatusFalse();

            BtnStatus("ADD");
            btnSave.Enabled = true;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
        }

        #endregion

        private void bntEdit_Click(object sender, EventArgs e)
        {
            iStatus = 2;
            txtShiftCode.Enabled = false;
            ControlStatus(1);

            btnSave.Enabled = true;
            btnDel.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtShiftCode.Text.Trim()))
            {
                MessageBox.Show("Shift code is empty,please enter!");
                return;
            }

            if (string.IsNullOrEmpty(txtShiftName.Text.Trim()))
            {
                MessageBox.Show("Shift name is empty,please enter!");
                return;
            }

            if (string.IsNullOrEmpty(txtOtherName.Text.Trim()))
            {
                MessageBox.Show("Other name is empty,please enter!");
                return;
            }

            //验证时间
            if (
                !CommonData.ShiftCodeList.Any(
                    sc => TimeCompare(Convert.ToDateTime(dtpFrom.Text), Convert.ToDateTime(dtpTo.Text),
                        Convert.ToDateTime(sc.DtFrom), Convert.ToDateTime(sc.DtTo))))
            {
                MessageBox.Show("Time setting error, please re-enter！");
                return;
            }

            var shiftCodeInfo = new ShiftCodeInfo();
            shiftCodeInfo.ShiftCode = Convert.ToInt32(txtShiftCode.Text.Trim());
            shiftCodeInfo.ShiftName = txtShiftName.Text.Trim();
            shiftCodeInfo.OtherName = txtOtherName.Text.Trim();
            shiftCodeInfo.DtFrom = dtpFrom.Value.ToShortTimeString();
            shiftCodeInfo.DtTo = dtpTo.Value.ToShortTimeString();
            shiftCodeInfo.SpecialEnable = chkBoxEnable.Checked ? 1 : 0;
            shiftCodeInfo.SpecialContent = "";

            var sb = new StringBuilder();
            sb.Append(",");
            if (chkBoxMonday.Checked) sb.Append("1,");
            if (chkBoxTuesday.Checked) sb.Append("2,");
            if (chkBoxWednesday.Checked) sb.Append("3,");
            if (chkBoxThursday.Checked) sb.Append("4,");
            if (chkBoxFriday.Checked) sb.Append("5,");
            if (chkBoxSaturday.Checked) sb.Append("6,");
            if (chkBoxSunday.Checked) sb.Append("7,");

            shiftCodeInfo.SpecialContent = sb.ToString();
            if (iStatus == 1)
            {
                shiftCodeInfo.SystemKey = new Guid(Guid.NewGuid().ToString().ToUpper());
                _control.AddEntity(shiftCodeInfo);
            }
            else //iStatus == 2
            {
                if (dgvShiftCode.CurrentRow != null)
                    shiftCodeInfo.SystemKey = new Guid(dgvShiftCode.CurrentRow.Cells[0].Value.ToString());

                _control.UpdateEntity(shiftCodeInfo);
            }
            //_control.AddEntity(shiftCodeInfo);
            //_control.SaveOrUpdateEntity(shiftCodeInfo);

            new OnLoadSystemCommonData().GetShiftCodeList();
            dgvShiftCode.DataSource = CommonData.ShiftCodeList;
            //dgvShiftCode.Refresh();

            ControlStatus(0);
            iStatus = 0;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvShiftCode.CurrentRow == null) return;
            new OnLoadSystemCommonData().GetShiftCodeList();
            var shiftCodeInfo =
                CommonData.ShiftCodeList.FirstOrDefault(s => s.SystemKey.Equals(dgvShiftCode.CurrentRow.Cells[0].Value));
            if (shiftCodeInfo != null)
                _control.DeleteEntity(shiftCodeInfo);

            //刷新数据
            new OnLoadSystemCommonData().GetShiftCodeList();
            dgvShiftCode.DataSource = CommonData.ShiftCodeList;
        }

        private void chkBoxEnable_CheckedChanged(object sender, EventArgs e)
        {
            ChkStatus();
        }

        private void FrmShiftCodeEntry_Load(object sender, EventArgs e)
        {
            ChkEnableFalse();

            new OnLoadSystemCommonData().GetShiftCodeList();
            dgvShiftCode.DataSource = CommonData.ShiftCodeList;

            dgvShiftCode.Columns[1].Width = 60;
            dgvShiftCode.Columns[0].Visible = false;
            dgvShiftCode.Columns[4].Visible = false;
            dgvShiftCode.Columns[5].Visible = false;
            dgvShiftCode.Columns[6].Visible = false;
            dgvShiftCode.Columns[7].Visible = false;

            btnSave.Enabled = false;
        }

        private void dgvShiftCode_SelectionChanged(object sender, EventArgs e)
        {
            ChkEnableFalse();
            ChkStatusFalse();

            if (dgvShiftCode.RowCount == 0)
            {
                MessageBox.Show("This table is empty,please add data first!");
                return;
            }

            if (dgvShiftCode.CurrentRow == null)
                return;

            if (dgvShiftCode.CurrentRow.Index < 0) return;
            //ShiftCode
            txtShiftCode.Text = dgvShiftCode.CurrentRow.Cells[1].Value.ToString();
            //ShiftName
            txtShiftName.Text = dgvShiftCode.CurrentRow.Cells[2].Value.ToString();
            //OtherName
            txtOtherName.Text = dgvShiftCode.CurrentRow.Cells[3].Value.ToString();
            //From
            dtpFrom.Text = dgvShiftCode.CurrentRow.Cells[4].Value.ToString();
            //To
            dtpTo.Text = dgvShiftCode.CurrentRow.Cells[5].Value.ToString();

            //Enable
            if (dgvShiftCode.CurrentRow.Cells[6].Value.ToString().Equals("1"))
            {
                chkBoxEnable.Checked = true;
                chkBoxEnable.Enabled = false;

                //List
                ChkEnableFalse();
                var sTemp = dgvShiftCode.CurrentRow.Cells[7].Value.ToString().Split(',');
                foreach (var s in sTemp)
                {
                    //ChkEnableTrue(Convert.ToInt32(s));
                    if (!string.IsNullOrEmpty(s)) ChkStatusTrue(Convert.ToInt32(s));
                }
            }
            else
            {
                chkBoxEnable.Enabled = false;
                chkBoxEnable.Checked = false;

                ChkEnableFalse();

                ChkStatusFalse();
            }
        }

        private void ChkStatus()
        {
            if (chkBoxEnable.Checked) ChkEnableTrue();
            else
            {
                ChkEnableFalse();
                ChkStatusFalse();
            }
        }

        private void ChkEnableFalse()
        {
            chkBoxSunday.Enabled = false;
            chkBoxMonday.Enabled = false;
            chkBoxTuesday.Enabled = false;
            chkBoxWednesday.Enabled = false;
            chkBoxThursday.Enabled = false;
            chkBoxFriday.Enabled = false;
            chkBoxSaturday.Enabled = false;
        }

        private void ChkEnableFalse(int i)
        {
            switch (i)
            {
                case 1:
                    chkBoxMonday.Enabled = false;
                    break;
                case 2:
                    chkBoxTuesday.Enabled = false;
                    break;
                case 3:
                    chkBoxWednesday.Enabled = false;
                    break;
                case 4:
                    chkBoxThursday.Enabled = false;
                    break;
                case 5:
                    chkBoxFriday.Enabled = false;
                    break;
                case 6:
                    chkBoxSaturday.Enabled = false;
                    break;
                case 7:
                    chkBoxSunday.Enabled = false;
                    break;
                default:
                    ChkEnableFalse();
                    break;
            }
        }

        private void ChkEnableTrue()
        {
            chkBoxSunday.Enabled = true;
            chkBoxMonday.Enabled = true;
            chkBoxTuesday.Enabled = true;
            chkBoxWednesday.Enabled = true;
            chkBoxThursday.Enabled = true;
            chkBoxFriday.Enabled = true;
            chkBoxSaturday.Enabled = true;
        }

        private void ChkEnableTrue(int i)
        {
            switch (i)
            {
                case 1:
                    chkBoxMonday.Enabled = true;
                    break;
                case 2:
                    chkBoxTuesday.Enabled = true;
                    break;
                case 3:
                    chkBoxWednesday.Enabled = true;
                    break;
                case 4:
                    chkBoxThursday.Enabled = true;
                    break;
                case 5:
                    chkBoxFriday.Enabled = true;
                    break;
                case 6:
                    chkBoxSaturday.Enabled = true;
                    break;
                case 7:
                    chkBoxSunday.Enabled = true;
                    break;
                default:
                    ChkEnableTrue();
                    break;
            }
        }

        private void ChkStatusFalse()
        {
            chkBoxSunday.Checked = false;
            chkBoxMonday.Checked = false;
            chkBoxTuesday.Checked = false;
            chkBoxWednesday.Checked = false;
            chkBoxThursday.Checked = false;
            chkBoxFriday.Checked = false;
            chkBoxSaturday.Checked = false;
        }

        private void ChkStatusFalse(int i)
        {
            switch (i)
            {
                case 1:
                    chkBoxMonday.Checked = false;
                    break;
                case 2:
                    chkBoxTuesday.Checked = false;
                    break;
                case 3:
                    chkBoxWednesday.Checked = false;
                    break;
                case 4:
                    chkBoxThursday.Checked = false;
                    break;
                case 5:
                    chkBoxFriday.Checked = false;
                    break;
                case 6:
                    chkBoxSaturday.Checked = false;
                    break;
                case 7:
                    chkBoxSunday.Checked = false;
                    break;
                default:
                    ChkStatusFalse();
                    break;
            }
        }

        private void ChkStatusTrue()
        {
            chkBoxSunday.Checked = true;
            chkBoxMonday.Checked = true;
            chkBoxTuesday.Checked = true;
            chkBoxWednesday.Checked = true;
            chkBoxThursday.Checked = true;
            chkBoxFriday.Checked = true;
            chkBoxSaturday.Checked = true;
        }

        #region 各CheckBox状态

        /// <summary>
        ///     各CheckBox状态
        /// </summary>
        /// <param name="i">checkbox名</param>
        private void ChkStatusTrue(int i)
        {
            switch (i)
            {
                case 1:
                    chkBoxMonday.Checked = true;
                    break;
                case 2:
                    chkBoxTuesday.Checked = true;
                    break;
                case 3:
                    chkBoxWednesday.Checked = true;
                    break;
                case 4:
                    chkBoxThursday.Checked = true;
                    break;
                case 5:
                    chkBoxFriday.Checked = true;
                    break;
                case 6:
                    chkBoxSaturday.Checked = true;
                    break;
                case 7:
                    chkBoxSunday.Checked = true;
                    break;
                default:
                    ChkStatusTrue();
                    break;
            }
        }

        #endregion

        #region 判断时间范围

        public bool TimeCompare(DateTime rangStartTime, DateTime rangeEndTime, DateTime startTime, DateTime endTime)
        {
            //单点区间相同
            if (rangStartTime >= rangeEndTime || startTime >= endTime)
            {
                return false;
            }
            if (DateTime.Compare(rangStartTime, startTime) == 0 ||
                DateTime.Compare(rangStartTime, endTime) == 0 ||
                DateTime.Compare(rangeEndTime, endTime) == 0)
            {
                return false;
            }
            //一点落在区间内
            //左区间
            if (DateTime.Compare(rangStartTime, startTime) < 0 &&
                DateTime.Compare(rangeEndTime, startTime) > 0 &&
                DateTime.Compare(rangStartTime, endTime) < 0 &&
                DateTime.Compare(rangeEndTime, endTime) < 0)
            {
                return false;
            }
                //右区间
            if (DateTime.Compare(rangStartTime, startTime) > 0 &&
                DateTime.Compare(rangStartTime, endTime) < 0 &&
                DateTime.Compare(rangeEndTime, endTime) > 0)
            {
                return false;
            }
                //两点同时落在区间内
                //被区间包含
            if (DateTime.Compare(rangStartTime, startTime) < 0 &&
                DateTime.Compare(rangeEndTime, endTime) > 0)
            {
                return false;
            }
                //包含区间
            if (DateTime.Compare(rangStartTime, startTime) > 0 &&
                DateTime.Compare(rangeEndTime, endTime) < 0)
            {
                return false;
            }
            return true;
        }

        #endregion

        #region 各按钮状态

        /// <summary>
        ///     各按钮状态
        /// </summary>
        /// <param name="strBtn">按钮名</param>
        private void BtnStatus(string strBtn)
        {
            switch (strBtn)
            {
                case "ADD": //添加
                    txtShiftCode.Enabled = false;
                    txtShiftName.Enabled = true;
                    txtOtherName.Enabled = true;
                    dtpFrom.Enabled = true;
                    dtpTo.Enabled = true;
                    chkBoxEnable.Enabled = true;
                    ChkEnableFalse();
                    ChkStatusFalse();
                    break;
                //case "SAVE":
                //    break;
                case "EDIT": //编辑
                    txtShiftCode.Enabled = false;
                    txtShiftName.Enabled = true;
                    txtOtherName.Enabled = true;
                    dtpFrom.Enabled = true;
                    dtpTo.Enabled = true;
                    chkBoxEnable.Enabled = true;
                    break;
                //case "DEL":
                //    break;
                default:
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDel.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
        }

        #endregion

        #region 控件状态

        /// <summary>
        ///     控件状态
        /// </summary>
        /// <param name="i">控件状态值</param>
        private void ControlStatus(int i)
        {
            switch (i)
            {
                case 0:
                    //btnEdit.Enabled = false;
                    //btnDel.Enabled = false;
                    txtShiftCode.Enabled = false;
                    txtShiftName.Enabled = false;
                    txtOtherName.Enabled = false;
                    dtpFrom.Enabled = false;
                    dtpTo.Enabled = false;
                    chkBoxEnable.Enabled = false;
                    ChkEnableFalse();
                    ChkStatusFalse();
                    break;
                case 1:
                    //btnEdit.Enabled = true;
                    //btnDel.Enabled = true;
                    txtShiftCode.Enabled = true;
                    txtShiftName.Enabled = true;
                    txtOtherName.Enabled = true;
                    dtpFrom.Enabled = true;
                    dtpTo.Enabled = true;
                    chkBoxEnable.Enabled = true;
                    ChkEnableTrue();
                    break;
            }
        }

        #endregion
    }
}
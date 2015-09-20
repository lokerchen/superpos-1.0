using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperPOS.Common;
using SuperPOS.Domain.Entities;

namespace SuperPOS.DAL
{
    public class OnLoadSystemCommonData
    {
        private EntityControl _control;

        public OnLoadSystemCommonData() { _control = EntityControl.CreateEntityControl(); }

        public void GetUserList() { CommonData.UsrList = _control.SelectAll<UserInfo>(); }

        public void GetShiftCodeList() { CommonData.ShiftCodeList = _control.SelectAll<ShiftCodeInfo>(); }

        public void GetSysConfigList() { CommonData.SysConfigList = _control.SelectAll<SysConfigInfo>(); }

        public void GetUsrMaintenance() { CommonData.UsrMaintenanceList = _control.SelectAll<UsrMaintenanceInfo>(); }
    }
}

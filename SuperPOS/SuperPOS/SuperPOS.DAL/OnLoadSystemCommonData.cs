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

        public void GetUsrMaintenance() { CommonData.UsrMaintenanceList = _control.SelectAll<UserMaintenanceInfo>(); }

        public void GetCompAddr() { CommonData.CompAddrList = _control.SelectAll<CompAddrInfo>(); }

        public void GetTAPayType() { CommonData.TaPayTypeList = _control.SelectAll<TAPayTypeInfo>(); }

        public void GetTAPayTypeDisc() { CommonData.TaPayTypeDiscList = _control.SelectAll<TAPayTypeDiscInfo>(); }

        public void GetTADistCharge() { CommonData.TaDistChargeList = _control.SelectAll<TADistChargeInfo>(); }

        public void GetTADistChargeRemark() { CommonData.TaDistChargeRemarkList = _control.SelectAll<TADistChargeRemarkInfo>(); }

        public void GetTAPostCode() { CommonData.TaPostCodeList = _control.SelectAll<TAPostCodeInfo>(); }

        public void GetTAPostCodeRemark() { CommonData.TaPostCodeRemarkList = _control.SelectAll<TAPostCodeRemarkInfo>(); }

        public void GetTAMenuSet() { CommonData.TaMenuSetList = _control.SelectAll<TAMenuSetInfo>(); }

        public void GetTADeptCode() { CommonData.TaDeptCodeList = _control.SelectAll<TADeptCodeInfo>(); }

        public void GetTADeptCodeDetail() { CommonData.TaDeptCodeDetailList = _control.SelectAll<TADeptCodeDetailInfo>(); }

        public void GetTAMenuCategory() { CommonData.TaMenuCategoryList = _control.SelectAll<TAMenuCategoryInfo>(); }

        public void GetSysControlList() { CommonData.SysControlList = _control.SelectAll<SysControlInfo>(); }
    }
}

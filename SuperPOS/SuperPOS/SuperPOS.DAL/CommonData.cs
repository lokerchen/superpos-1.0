using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperPOS.Domain.Entities;

namespace SuperPOS.DAL
{
    public class CommonData
    {
        public static IList<UserInfo> UsrList { get; set; }

        public static IList<ShiftCodeInfo> ShiftCodeList { get; set; }

        public static IList<SysConfigInfo> SysConfigList { get; set; }

        public static IList<UserMaintenanceInfo> UsrMaintenanceList { get; set; }

        public static IList<CompAddrInfo> CompAddrList { get; set; }

        public static IList<TAPayTypeInfo> TaPayTypeList { get; set; }

        public static IList<TAPayTypeDiscInfo> TaPayTypeDiscList { get; set; }

        public static IList<TADistChargeInfo> TaDistChargeList { get; set; } 

        public static IList<TADistChargeRemarkInfo> TaDistChargeRemarkList { get; set; }

        public static IList<TAPostCodeInfo> TaPostCodeList { get; set; }

        public static IList<TAPostCodeRemarkInfo> TaPostCodeRemarkList { get; set; }

        public static IList<TAMenuSetInfo> TaMenuSetList { get; set; } 

        public static IList<TADeptCodeInfo> TaDeptCodeList { get; set; }

        public static IList<TADeptCodeDetailInfo> TaDeptCodeDetailList { get; set; }

        public static IList<TAMenuCategoryInfo> TaMenuCategoryList { get; set; }

        public static IList<SysControlInfo> SysControlList { get; set; }

        public static IList<TAMenuItemInfo> TaMenuItemList { get; set; }
    }
}

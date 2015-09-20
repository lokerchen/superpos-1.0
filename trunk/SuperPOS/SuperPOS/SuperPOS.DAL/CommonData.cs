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

        public static IList<UsrMaintenanceInfo> UsrMaintenanceList { get; set; }
    }
}

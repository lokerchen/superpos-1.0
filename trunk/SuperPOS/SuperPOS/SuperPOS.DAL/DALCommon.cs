using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperPOS.DAL
{
    public static class DALCommon
    {
        #region 加载所有系统数据，所有系统List
        /// <summary>
        ///  加载所有系统数据，所有系统List
        /// </summary>
        public static void GetAllInfoList()
        {
            OnLoadSystemCommonData onLoad = new OnLoadSystemCommonData();
            //User List
            onLoad.GetUserList();
            //Shift Code
            onLoad.GetShiftCodeList();
            //System Configuration
            onLoad.GetSysConfigList();
            //User Maintenance
            onLoad.GetUsrMaintenance();
            //Computer Address
            onLoad.GetCompAddr();
        }
        #endregion
    }
}

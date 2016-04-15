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
            //Take away Payment Type
            onLoad.GetTAPayType();
            onLoad.GetTAPayTypeDisc();
            //Take away Delivery Distance Charge
            onLoad.GetTADistCharge();
            onLoad.GetTADistChargeRemark();
            //Take away Post Code
            onLoad.GetTAPostCode();
            onLoad.GetTAPostCodeRemark();
            //Take away Menu Set
            onLoad.GetTAMenuSet();
            //Dept Code
            onLoad.GetTADeptCode();
            //Dept Code Detail
            onLoad.GetTADeptCodeDetail();
            //Take away Menu Category
            onLoad.GetTAMenuCategory();
            //System Control
            onLoad.GetSysControlList();
            //Menu Item
            onLoad.GetTAMenuItemList();
            onLoad.GetTAMenuItemSCList();
            onLoad.GetTAMenuItemTCList();
            onLoad.GetTAMenuItemTHList();
            onLoad.GetTAMenuItemSubMenuList();
            onLoad.GetTAMenuItemSubMenuDetailList();
        }
        #endregion
    }
}

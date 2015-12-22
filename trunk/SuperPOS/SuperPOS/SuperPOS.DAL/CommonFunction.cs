using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Criterion;
using SuperPOS.Common;
using SuperPOS.Domain.Entities;

namespace SuperPOS.DAL
{
    public static class CommonFunction
    {
        #region 判断是否有GSSSystemConfig权限
        /// <summary>
        /// 判断是否有GSSSystemConfig权限
        /// </summary>
        /// <param name="strPwd">用户密码</param>
        /// <returns></returns>
        public static bool GetAuthorityGSSysConf(string strPwd)
        {
            new OnLoadSystemCommonData().GetUsrMaintenance();
            new OnLoadSystemCommonData().GetUserList();

            var uList = CommonData.UsrMaintenanceList.Join(CommonData.UsrList, umList => umList.UsrCode,
                usrList => usrList.UsrCode, (umList, usrList) => new {uPwd = usrList.UsrPwd, uGSSSysConfig = umList.GSSSystemConfig });

            //if (!uList.Any())
            //    return false;
            //else
            //{
            //    return uList.Any(s => s.uPwd.Equals(strPwd) && s.uGSSSysConfig.Equals("Y"));
            //}
            return uList.Any() && uList.Any(s => s.uPwd.Equals(strPwd) && s.uGSSSysConfig.Equals("Y"));
        }
        #endregion
    }
}

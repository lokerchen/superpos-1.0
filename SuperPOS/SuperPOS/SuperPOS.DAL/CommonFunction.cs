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
        public static bool GetAuthorityGSSysConf(string strPwd)
        {
            new OnLoadSystemCommonData().GetUsrMaintenance();
            new OnLoadSystemCommonData().GetUserList();

            var uList = CommonData.UsrMaintenanceList.Join(CommonData.UsrList, umList => umList.UsrCode,
                usrList => usrList.UsrCode, (umList, usrList) => new {uPwd = usrList.UsrPwd, uGSSSysConfig = umList.GSSSystemConfig });

            if (!uList.Any())
                return false;
            else
            {
                return uList.Any(s => s.uPwd.Equals(strPwd) && s.uGSSSysConfig.Equals("Y"));
            }
            //var uList = CommonData.UsrMaintenanceList.Where(s => s.UsrCode.Equals(strPwd));

            //if (uList == null || !uList.Any())
            //    return false;
            //else
            //    return uList.FirstOrDefault().GSSSystemConfig.Equals("Y");
            //return strPwd.Equals(CommonBase.SYS_CONTROL_PWD) ||
            //       uList.Any() && uList.FirstOrDefault().GSSSystemConfig.Equals("Y");
        }
    }
}

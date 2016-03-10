using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Criterion;
using SuperPOS.Common;
using SuperPOS.Domain.Entities;

namespace SuperPOS.DAL
{
    public class CommonFunction
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

        #region 获得系统设置图片和变量
        /// <summary>
        /// 获得系统设置图片和变量
        /// </summary>
        /// <param name="strPathNo">获得数据编号</param>
        /// <returns></returns>
        public static string GetSysImg(string strPathNo)
        {
            OnLoadSystemCommonData onLoadSystemCommonData = new OnLoadSystemCommonData();
            onLoadSystemCommonData.GetSysControlList();

            string strImg = "";
            if (CommonData.SysControlList.Any())
            {
                var qList = CommonData.SysControlList.FirstOrDefault();

                switch (strPathNo)
                {
                    case "1":
                        strImg = qList.ImgPath1;
                        break;
                    case "2":
                        strImg = qList.ImgPath2;
                        break;
                    case "3":
                        strImg = qList.ImgPath3;
                        break;
                    case "4":
                        strImg = qList.ImgPath4;
                        break;
                    case "5":
                        strImg = qList.ImgPath5;
                        break;
                }
            }

            return strImg;
        }
        #endregion
    }
}

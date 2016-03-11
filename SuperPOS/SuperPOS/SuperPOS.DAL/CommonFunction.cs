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

        #region 获得用户权限
        /// <summary>
        /// 获得用户权限
        /// </summary>
        /// <param name="sUsrCode">用户Code</param>
        /// <param name="sPermissionCode">权限编号</param>
        /// <returns></returns>
        public static bool GetUsrPermission(string sUsrCode, string sPermissionCode)
        {
            OnLoadSystemCommonData onLoadSystemData = new OnLoadSystemCommonData();
            onLoadSystemData.GetUsrMaintenance();

            var uList = CommonData.UsrMaintenanceList.Where(s => s.UsrCode.Equals(sUsrCode)).ToList();

            if (uList.Any())
            {
                UserMaintenanceInfo userMaintenance = new UserMaintenanceInfo();
                userMaintenance = uList.FirstOrDefault();

                switch (sPermissionCode)
                {
                    //Takeaway Access
                    case "101": return userMaintenance.TACtlPanel.Equals("Y");
                    case "102": return userMaintenance.TAChangePrice.Equals("Y");
                    case "103": return userMaintenance.TASOPrtAcctSum.Equals("Y");
                    case "104": return userMaintenance.TASOChangePayment.Equals("Y");
                    case "105": return userMaintenance.TASOEditOrder.Equals("Y");
                    case "106": return userMaintenance.TASOPrtReceipt.Equals("Y");
                    case "107": return userMaintenance.TACLExportData.Equals("Y");

                    //Quick Dining Access
                    case "201": return userMaintenance.QDCtlPanel.Equals("Y");
                    case "202": return userMaintenance.QDChangePrice.Equals("Y");
                    case "203": return userMaintenance.QDSOPrtAcctSum.Equals("Y");
                    case "204": return userMaintenance.QDSOChangePayment.Equals("Y");
                    case "205": return userMaintenance.QDSOEditOrder.Equals("Y");
                    case "206": return userMaintenance.QDSOPrtReceipt.Equals("Y");

                    //Eat-In Access
                    case "301": return userMaintenance.EICtlPanel.Equals("Y");
                    case "302": return userMaintenance.EIPay.Equals("Y");
                    case "303": return userMaintenance.EIPrtBill.Equals("Y");
                    case "304": return userMaintenance.EIRemoveItemAfterPrt.Equals("Y");
                    case "305": return userMaintenance.EITblBooking.Equals("Y");
                    case "306": return userMaintenance.EISOPrtAcctSum.Equals("Y");
                    case "307": return userMaintenance.EISOChangePayment.Equals("Y");
                    case "308": return userMaintenance.EISOEditOrder.Equals("Y");
                    case "309": return userMaintenance.EISOPrtReceipt.Equals("Y");
                    case "310": return userMaintenance.EIPBDicount.Equals("Y");

                    //General Access
                    case "401": return userMaintenance.GSSSystemConfig.Equals("Y");
                    case "402": return userMaintenance.GSSUsrMaint.Equals("Y"); ;
                    case "403": return userMaintenance.GSSDataManager.Equals("Y"); ;
                    case "404": return userMaintenance.GSSCompactDb.Equals("Y"); ;
                    case "405": return userMaintenance.GRpt.Equals("Y"); ;
                    case "406": return userMaintenance.GRAccountSum.Equals("Y"); ;
                    case "407": return userMaintenance.GASSumView.Equals("Y");
                    case "408": return userMaintenance.GExitPos.Equals("Y"); ;
                    case "410": return userMaintenance.GSSCoputAdd.Equals("Y");
                    case "411": return userMaintenance.GSSShiftCode.Equals("Y");
                    case "412": return userMaintenance.GTakeawayConfig.Equals("Y");
                    case "413": return userMaintenance.GEatInConfig.Equals("Y");
                    case "414": return userMaintenance.GTakeawayConfig.Equals("Y");
                    case "415": return userMaintenance.GEatInPrtSetUp.Equals("Y");
                    case "416": return userMaintenance.GASPrtSalesRpt.Equals("Y");
                    case "417": return userMaintenance.GOpenCash.Equals("Y");
                    default: return true;
                }
            }
            else return false;
        }
        #endregion
    }
}

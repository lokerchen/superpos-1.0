using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.Print
{
    public class PrtCommon
    {
        #region 打印分隔符
        /// <summary>
        /// 打印分隔符
        /// </summary>
        /// <returns></returns>
        private string GetSplit()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < PrtStatic.PRT_LINE_SIZE; i++)
            {
                sb.Append(PrtStatic.PRT_SPLIT_CHAR);
            }

            return sb.ToString();
        }
        #endregion

        #region 打印空格
        /// <summary>
        /// 打印空格
        /// </summary>
        /// <param name="i">空格数量</param>
        /// <returns></returns>
        public StringBuilder GetSpace(int i)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < i; j++)
            {
                sb.Append(' ');
            }
            return sb;
        }
        #endregion

        #region 打印订单抬头


        #endregion

        #region 获得餐厅名称
        /// <summary>
        /// 获得餐厅名称
        /// </summary>
        /// <returns></returns>
        public string GetRestName()
        {
            new OnLoadSystemCommonData().GetSysControlList();
            var firstOrDefault = CommonData.SysControlList.FirstOrDefault();
            return firstOrDefault != null ? firstOrDefault.ShopName : "";
        }
        #endregion

        #region 获得餐厅地址
        /// <summary>
        /// 获得餐厅地址
        /// </summary>
        /// <returns></returns>
        public string GetRestAddr()
        {
            new OnLoadSystemCommonData().GetSysControlList();
            var firstOrDefault = CommonData.SysControlList.FirstOrDefault();
            return firstOrDefault != null ? firstOrDefault.Address : "";
        }
        #endregion

        #region 获得餐厅电话
        /// <summary>
        /// 获得餐厅电话
        /// </summary>
        /// <returns></returns>
        public string GetRestTel()
        {
            new OnLoadSystemCommonData().GetTAPrtInfo();
            var firstOrDefault = CommonData.TAPrtInfos.FirstOrDefault();
            return firstOrDefault != null ? "Tel:" + firstOrDefault.TelNo : "";
        }
        #endregion

        #region 获得餐厅VAT NO
        /// <summary>
        /// 获得餐厅VAT NO
        /// </summary>
        /// <returns></returns>
        public string GetRestVATNo()
        {
            new OnLoadSystemCommonData().GetTAPrtInfo();
            var firstOrDefault = CommonData.TAPrtInfos.FirstOrDefault();
            return firstOrDefault != null ? "VAT No:" + firstOrDefault.VATNo : "";
        }
        #endregion

        #region 获得打印时间和日期
        /// <summary>
        /// 打印时间和日期
        /// </summary>
        /// <returns></returns>
        public string GetPrtDateTime()
        {
            return "Date:" + DateTime.Now.ToShortDateString() + "  Time:" + DateTime.Now.ToShortTimeString();
        }
        #endregion
        
        #region 打印Bill-双语

        public string GetPrintBillBilingual()
        {
            StringBuilder sb = new StringBuilder();
            string L = GetSplit();
            string L1 = "";

            return sb.ToString();
        }
        #endregion
    }
}

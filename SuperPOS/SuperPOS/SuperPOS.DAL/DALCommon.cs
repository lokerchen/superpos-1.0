﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using SuperPOS.Common;
using SuperPOS.Domain.Entities;

namespace SuperPOS.DAL
{
    public static class DALCommon
    {
        private static readonly EntityControl _control = new EntityControl();

        //Menu Item每页大小
        public static int PAGESIZE_MENUITEM = 16;

        //Menu Category每页大小
        public static int PAGESIZE_MENUCATE = 35;

        //页码
        private static int PAGE_NUM = 0;

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
            //TA Table Setup
            onLoad.GetTaTblSetup();
            //TA Extra Menu Edit
            onLoad.GetExtraMenuEdit();
            //TA Customer 
            onLoad.GetTACust();
            //TA OrderItem
            onLoad.GetTAOrderItem();
            //System Vlaue
            onLoad.GetSysValueList();
            //TA Config Pre-Defined
            onLoad.GetTAPreDefined();
            //TA Driver Setup
            onLoad.GetTADriverSetUp();
            //TA Payment
            onLoad.GetTAPaymentList();
            //Free Food Items
            onLoad.GetTAFreeFoodItemsList();
            //Print setup -> General -> Print Information
            onLoad.GetTAPrtInfo();
            //Postcode Assignment
            onLoad.GetPostcodeChargeList();
            onLoad.GetPostcodeZoneList();
        }
        #endregion

        #region 获取excel表数据
        /// <summary>
        /// 获取excel表数据
        /// </summary>
        /// <param name="excelFile">excel文件路径</param>
        /// <param name="sheetName">excel工作表名</param>
        /// <returns></returns>
        public static DataSet GetExcelFileData(string excelFile, string sheetName)
        {
            DataSet ds = new DataSet();
            //获取全部数据  
            //string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + excelFile + ";" + "Extended Properties=Excel 8.0;HDR=NO; IMEX=1";
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + excelFile + ";" + "Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1\"";
            OleDbConnection conn = new OleDbConnection(strConn);
            try
            {

                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                //strExcel = string.Format("select * from [{0}$]", sheetName);
                strExcel = $"select * from [{sheetName}$]";
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                myCommand.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }
        #endregion

        #region 导入数据到数据表 Menu Category
        /// <summary>
        /// 导入数据到数据库Menu Category
        /// </summary>    
        /// <param name="outFile">文件</param>
        /// <returns></returns>
        public static bool ImportMenuCate(string importFile, string SheetName)
        {
            DataTable dt = GetExcelFileData(importFile, SheetName).Tables[0];
            try
            {
                //清除Menu Cate中的数据
                new OnLoadSystemCommonData().GetTAMenuCategory();
                foreach (var taMenuCate in CommonData.TaMenuCategoryList)
                {
                    _control.DeleteEntity(taMenuCate);
                }

                //添加数据
                foreach (DataRow item in dt.Rows)
                {
                    if (!string.IsNullOrEmpty(item[0].ToString())
                        && !string.IsNullOrEmpty(item[1].ToString())
                        && !string.IsNullOrEmpty(item[2].ToString())
                        && !string.IsNullOrEmpty(item[3].ToString()))
                    {
                        TAMenuCategoryInfo taMenuCategoryInfo = new TAMenuCategoryInfo();
                        taMenuCategoryInfo.SystemKey = Guid.NewGuid();
                        taMenuCategoryInfo.Remark = item[0].ToString();
                        taMenuCategoryInfo.DisplayPosition = item[1].ToString();
                        taMenuCategoryInfo.EnglishName = item[2].ToString();
                        taMenuCategoryInfo.OtherName = item[3].ToString();
                        _control.AddEntity(taMenuCategoryInfo);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // MessBox.Show("");
                string aa = ex.Message;
                return false;
            }
        }
        #endregion

        #region 导入数据到数据表MenuItem
        /// <summary>
        /// 导入数据到数据库Menu Item
        /// </summary>    
        /// <param name="outFile">文件</param>
        /// <returns></returns>
        public static bool ImportMenuItem(string importFile, string SheetName)
        {
            DataTable dt = GetExcelFileData(importFile, SheetName).Tables[0];
            try
            {
                //清除Menu中的数据
                new OnLoadSystemCommonData().GetTAMenuItemList();
                foreach (var taMenuItem in CommonData.TaMenuItemList)
                {
                    _control.DeleteEntity(taMenuItem);
                }

                //添加数据
                foreach (DataRow item in dt.Rows)
                {
                    if (!string.IsNullOrEmpty(item[0].ToString())
                        && !string.IsNullOrEmpty(item[1].ToString())
                        && !string.IsNullOrEmpty(item[2].ToString())
                        && !string.IsNullOrEmpty(item[3].ToString())
                        && !string.IsNullOrEmpty(item[4].ToString())
                        && !string.IsNullOrEmpty(item[5].ToString()))
                    {
                        new OnLoadSystemCommonData().GetTAMenuCategory();
                        var qList = CommonData.TaMenuCategoryList.Where(
                                s => s.Remark.Equals(item[0].ToString()));
                        if (qList.Any())
                        {
                            TAMenuItemInfo taMenuItemInfo = new TAMenuItemInfo();
                            taMenuItemInfo.SystemKey = Guid.NewGuid();
                            taMenuItemInfo.DisplayPosition = item[1].ToString();
                            taMenuItemInfo.DishCode = item[2].ToString();
                            taMenuItemInfo.EnglishName = item[3].ToString();
                            taMenuItemInfo.OtherName = item[4].ToString();
                            taMenuItemInfo.wRegular = item[5].ToString();
                            taMenuItemInfo.MenuCateID = qList.FirstOrDefault().EnglishName + ",";
                            _control.AddEntity(taMenuItemInfo);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // MessBox.Show("");
                string aa = ex.Message;
                return false;
            }
        }
        #endregion

        #region Menu Item 分页
        /// <summary>
        /// Menu Item 分页
        /// </summary>
        /// <param name="iPageNum">页码</param>
        /// <returns></returns>
        public static List<TAMenuItemInfo> GetListQueryPageMenuItem(int iPageNum, string sMenuCate, string strMenuSetID)
        {
            new OnLoadSystemCommonData().GetTAMenuItemList();

            //return CommonData.TaMenuItemList.Where(s => s.MenuCateID.Equals(sMenuCate)).Skip(PAGESIZE_MENUITEM * (iPageNum - 1)).Take(PAGESIZE_MENUITEM).ToList();
            //return string.IsNullOrEmpty(sMenuCate) ? CommonData.TaMenuItemList.Skip(PAGESIZE_MENUITEM * (iPageNum - 1)).Take(PAGESIZE_MENUITEM).ToList() : CommonData.TaMenuItemList.Where(s => s.MenuCateID.Equals(sMenuCate)).Skip(PAGESIZE_MENUITEM * (iPageNum - 1)).Take(PAGESIZE_MENUITEM).ToList();
            if (string.IsNullOrEmpty(sMenuCate))
            {
                //return CommonData.TaMenuItemList.Skip(PAGESIZE_MENUITEM * (iPageNum - 1)).Take(PAGESIZE_MENUITEM).ToList();
                if (string.IsNullOrEmpty(strMenuSetID))
                {
                    return
                    CommonData.TaMenuItemList.Skip(PAGESIZE_MENUITEM * (iPageNum - 1))
                        .Take(PAGESIZE_MENUITEM)
                        .ToList();
                }
                else
                {
                    return
                    CommonData.TaMenuItemList.Where(s => !string.IsNullOrEmpty(s.MenuSetID) && s.MenuSetID.Equals(strMenuSetID))
                        .Skip(PAGESIZE_MENUITEM * (iPageNum - 1))
                        .Take(PAGESIZE_MENUITEM)
                        .ToList();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(strMenuSetID))
                {
                    return
                    CommonData.TaMenuItemList.Where(s => s.MenuCateID.Equals(sMenuCate))
                        .Skip(PAGESIZE_MENUITEM * (iPageNum - 1))
                        .Take(PAGESIZE_MENUITEM)
                        .ToList();
                }
                else
                {
                    return
                    CommonData.TaMenuItemList.Where(s => s.MenuCateID.Equals(sMenuCate) && !string.IsNullOrEmpty(s.MenuSetID) && s.MenuSetID.Equals(strMenuSetID))
                        .Skip(PAGESIZE_MENUITEM * (iPageNum - 1))
                        .Take(PAGESIZE_MENUITEM)
                        .ToList();
                }
            }
        }

        #endregion

        #region Menu Item 关键字查询分页
        /// <summary>
        /// Menu Item 分页
        /// </summary>
        /// <param name="iPageNum">页码</param>
        /// <returns></returns>
        public static List<TAMenuItemInfo> GetListQueryPageMenuItem(int iPageNum, string sKeyWord)
        {
            new OnLoadSystemCommonData().GetTAMenuItemList();

            if (string.IsNullOrEmpty(sKeyWord))
            {
                return CommonData.TaMenuItemList.Skip(PAGESIZE_MENUITEM * (iPageNum - 1)).Take(PAGESIZE_MENUITEM).ToList();
            }
            else
            {
                //
                //SqlMethods.Like(s.EnglishName, "%" + sKeyWord + "%")
                return CommonData.TaMenuItemList.Where(s => s.DishCode.Equals(sKeyWord) || s.EnglishName.ToUpper().Contains(sKeyWord.ToUpper()))
                        .Skip(PAGESIZE_MENUITEM * (iPageNum - 1))
                        .Take(PAGESIZE_MENUITEM)
                        .ToList();
            }
        }

        #endregion

        #region Menu Category分页
        /// <summary>
        /// Menu Category分页
        /// </summary>
        /// <param name="iPageNum">页码</param>
        /// <returns></returns>
        public static List<TAMenuCategoryInfo> GetListQueryPageMenuCate(int iPageNum, string strMenuSetKey)
        {
            new OnLoadSystemCommonData().GetTAMenuCategory();

            //return CommonData.TaMenuCategoryList.Where(s => s.MenuSetID.Equals(strMenuSetKey)).Skip(PAGESIZE_MENUCATE * (iPageNum - 1)).Take(PAGESIZE_MENUITEM).ToList();
            if (string.IsNullOrEmpty(strMenuSetKey))
            {
                return
                    CommonData.TaMenuCategoryList.Skip(PAGESIZE_MENUCATE*(iPageNum - 1))
                        .Take(PAGESIZE_MENUITEM)
                        .ToList();
            }
            else
            {
                return CommonData.TaMenuCategoryList.Where(s => !string.IsNullOrEmpty(s.MenuSetID) && s.MenuSetID.Equals(strMenuSetKey))
                    .Skip(PAGESIZE_MENUCATE * (iPageNum - 1))
                    .Take(PAGESIZE_MENUITEM).ToList();
            }
        }
        #endregion

        public static bool ImportCust(string importFile, string SheetName)
        {
            DataTable dt = GetExcelFileData(importFile, SheetName).Tables[0];
            try
            {
                //清除TA Customer中的数据
                new OnLoadSystemCommonData().GetTACust();
                foreach (var taCust in CommonData.TaCustList)
                {
                    _control.DeleteEntity(taCust);
                }

                //添加数据
                foreach (DataRow item in dt.Rows)
                {
                    if (!string.IsNullOrEmpty(item[0].ToString())
                        && !string.IsNullOrEmpty(item[1].ToString())
                        && !string.IsNullOrEmpty(item[2].ToString())
                        && !string.IsNullOrEmpty(item[3].ToString())
                        && !string.IsNullOrEmpty(item[4].ToString())
                        && !string.IsNullOrEmpty(item[5].ToString())
                        && !string.IsNullOrEmpty(item[6].ToString()))
                    {
                        TACustInfo taCustInfo = new TACustInfo();
                        taCustInfo.SystemKey = Guid.NewGuid();
                        taCustInfo.Phone1 = item[0].ToString();
                        taCustInfo.Name = item[1].ToString();
                        taCustInfo.Address1 = item[2].ToString();
                        taCustInfo.Postcode1 = item[3].ToString();
                        taCustInfo.Distance = item[4].ToString();
                        taCustInfo.PcZone = item[5].ToString();
                        taCustInfo.IsBlackListed = item[6].ToString().ToUpper().Equals("YES") ? "Y" : "N";
                        _control.AddEntity(taCustInfo);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // MessBox.Show("");
                string aa = ex.Message;
                return false;
            }
        }
    }
}

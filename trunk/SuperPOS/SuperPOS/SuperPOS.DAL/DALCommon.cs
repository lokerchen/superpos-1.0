using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using SuperPOS.Common;
using SuperPOS.Domain.Entities;

namespace SuperPOS.DAL
{
    public static class DALCommon
    {
        private static readonly EntityControl _control = new EntityControl();

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

        #region 导入数据到数据表
        /// <summary>
        /// 导入数据到数据库
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
                    TAMenuCategoryInfo taMenuCategoryInfo = new TAMenuCategoryInfo();
                    taMenuCategoryInfo.SystemKey = Guid.NewGuid();
                    taMenuCategoryInfo.Remark = item[0].ToString();
                    taMenuCategoryInfo.DisplayPosition = item[1].ToString();
                    taMenuCategoryInfo.EnglishName = item[2].ToString();
                    taMenuCategoryInfo.OtherName = item[3].ToString();
                    _control.AddEntity(taMenuCategoryInfo);
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
    }
}

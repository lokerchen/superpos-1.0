﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperPOS.DAL;
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.Print
{
    public class PrtPrint
    {
        private List<string> textList;       //打印内容行

        #region 根据内容进行分行
        /// <summary>
        /// 根据内容进行分行
        /// </summary>
        /// <param name="linelen">每行字数</param>
        /// <param name="text">原文字行（段落）文字</param>
        /// <returns></returns>
        private List<string> GetArr(int linelen, string text)
        {
            var list = new List<string>();
            int listcount = text.Length % linelen == 0 ? text.Length / linelen : (text.Length / linelen) + 1;
            for (int j = 0; j < listcount; j++)
            {
                try
                {
                    list.Add(text.Substring(j * linelen, linelen));
                }
                catch (Exception)
                {
                    list.Add(text.Substring(j * linelen));
                }
            }
            return list;
        }
        #endregion

        #region 打印Bill-双语

        public string GetPrtStrBillBilingual(List<TAOrderItemInfo> lstOI, Hashtable ht)
        {
            StringBuilder sb = new StringBuilder();
            string L = PrtCommon.GetSplit();
            string L1 = PrtCommon.GetRestName();
            string L2 = PrtCommon.GetRestAddr();
            string L3 = PrtCommon.GetRestTel();
            string L4 = PrtCommon.GetRestVATNo();
            string L5 = PrtCommon.GetPrtTime();
            string L6 = PrtCommon.GetPrtDateTime();
            string L7 = "Staff:" + (string)ht["Staff"] + "   " + @"Order No:" + (string)ht["OrderNo"];

            //餐厅名称
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE_20 - L1.Length) / 2) + L1);
            sb.Append(Environment.NewLine);

            //餐厅地址
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L2.Length)/2) + L2);
            sb.Append(Environment.NewLine);

            //Tel
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L3.Length) / 2) + L3);
            sb.Append(Environment.NewLine);

            //VAT
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L4.Length) / 2) + L4);
            sb.Append(Environment.NewLine);

            //分隔行
            sb.Append(L);
            sb.Append(Environment.NewLine);

            //时间
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE_20 - L5.Length) / 2) + L5);
            sb.Append(Environment.NewLine);

            //分隔行
            sb.Append(L);
            sb.Append(Environment.NewLine);

            sb.Append(PrtCommon.GetSpace(6) + L6);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetSpace(6) + L7);
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);

            sb.Append("Code" + PrtCommon.GetSpace(2) + "Qty" + PrtCommon.GetSpace(2) + "Name" + PrtCommon.GetSpace(17) + "Price" + PrtCommon.GetSpace(2));
            sb.Append(Environment.NewLine);

            foreach (var taOrderItemInfo in lstOI)
            {
                sb.Append(PrtCommon.GetTab(taOrderItemInfo.ItemCode, taOrderItemInfo.ItemQty,
                    taOrderItemInfo.ItemDishName, taOrderItemInfo.ItemTotalPrice));
                sb.Append(Environment.NewLine);
                var CNameList = CommonData.TaMenuItemList.Where(s => s.DishCode.Equals(taOrderItemInfo.ItemCode));
                if (CNameList.Any())
                {
                    sb.Append(PrtCommon.GetHanZiTab(CNameList.FirstOrDefault().OtherName));
                    sb.Append(Environment.NewLine);
                }
            }

            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetItemTotal((string)ht["ItemQty"], (string)ht["SubTotal"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetTotal((string)ht["Total"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetPay((string)ht["PayType"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtStatic.PRT_COMP_NAME);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetSpace(8) + PrtStatic.PRT_COMP_WEBSITE);
            sb.Append(Environment.NewLine);

            return sb.ToString();
        }
        #endregion

        #region 打印Bill内容事件
        /// <summary>
        /// 打印Bill内容事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prt_Content_BillBilingual(object sender, PrintPageEventArgs e)
        {
            var mark = 0;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            foreach (var item in textList)
            {
                //e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), fontSize), System.Drawing.Brushes.Black, 0, mark * lineSize);
                if (mark == 0)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == 1)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == 5)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == textList.Count - 4)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == textList.Count - 6)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else 
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }

                mark++;
            }
        }
        #endregion

        #region 打印Bill主体打印事件
        public void PrtBillBilingual(List<TAOrderItemInfo> lstOI, Hashtable ht)
        {
            if (string.IsNullOrWhiteSpace(GetPrtStrBillBilingual(lstOI, ht)))
            {
                return;
            }

            //原文字行或者段落内容
            var sourceTexts = GetPrtStrBillBilingual(lstOI, ht).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            //重新把文字进行分行树立
            textList = new List<string>();
            foreach (var item in sourceTexts)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    if (item.Length > PrtStatic.PRT_LINE_SIZE)
                    {
                        textList.AddRange(GetArr(PrtStatic.PRT_LINE_SIZE, item));
                    }
                    else
                    {
                        textList.Add(item);
                    }
                }
            }


            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Prt_Content_BillBilingual);
            //纸张设置默认
            //PaperSize pageSize = new PaperSize("自定义纸张", fontSize * lineSize, (textList.Count * (int)(58 / 25.4 * 100)));
            PaperSize pageSize = new PaperSize("自定义纸张", (textList.Count * (int)(58 / 25.4 * 100)), 600);
            pd.DefaultPageSettings.PaperSize = pageSize;
            //pd.PrinterSettings.PrinterName
            try
            {
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("打印失败." + ex.Message);
            }
        }
        #endregion


        #region 打印Bill - 纯英文，无汉字
        public string GetPrtStrBillNoChinese(List<TAOrderItemInfo> lstOI, Hashtable ht)
        {
            StringBuilder sb = new StringBuilder();
            string L = PrtCommon.GetSplit();
            string L1 = PrtCommon.GetRestName();
            string L2 = PrtCommon.GetRestAddr();
            string L3 = PrtCommon.GetRestTel();
            string L4 = PrtCommon.GetRestVATNo();
            string L5 = PrtCommon.GetPrtTime();
            string L6 = PrtCommon.GetPrtDateTime();
            string L7 = "Staff:" + (string)ht["Staff"] + "   " + @"Order No:" + (string)ht["OrderNo"];

            //餐厅名称
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE_20 - L1.Length) / 2) + L1);
            sb.Append(Environment.NewLine);

            //餐厅地址
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L2.Length) / 2) + L2);
            sb.Append(Environment.NewLine);

            //Tel
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L3.Length) / 2) + L3);
            sb.Append(Environment.NewLine);

            //VAT
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L4.Length) / 2) + L4);
            sb.Append(Environment.NewLine);

            //分隔行
            sb.Append(L);
            sb.Append(Environment.NewLine);

            //时间
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE_20 - L5.Length) / 2) + L5);
            sb.Append(Environment.NewLine);

            //分隔行
            sb.Append(L);
            sb.Append(Environment.NewLine);

            sb.Append(PrtCommon.GetSpace(6) + L6);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetSpace(6) + L7);
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);

            sb.Append("Code" + PrtCommon.GetSpace(2) + "Qty" + PrtCommon.GetSpace(2) + "Name" + PrtCommon.GetSpace(17) + "Price" + PrtCommon.GetSpace(2));
            sb.Append(Environment.NewLine);

            foreach (var taOrderItemInfo in lstOI)
            {
                sb.Append(PrtCommon.GetTab(taOrderItemInfo.ItemCode, taOrderItemInfo.ItemQty,
                    taOrderItemInfo.ItemDishName, taOrderItemInfo.ItemTotalPrice));
                sb.Append(Environment.NewLine);
            }

            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetItemTotal((string)ht["ItemQty"], (string)ht["SubTotal"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetTotal((string)ht["Total"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetPay((string)ht["PayType"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtStatic.PRT_COMP_NAME);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetSpace(8) + PrtStatic.PRT_COMP_WEBSITE);
            sb.Append(Environment.NewLine);

            return sb.ToString();
        }
        #endregion

        #region 打印Bill内容事件 - 纯英文，无汉字
        /// <summary>
        /// 打印Bill内容事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prt_Content_BillNoChinese(object sender, PrintPageEventArgs e)
        {
            var mark = 0;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            foreach (var item in textList)
            {
                if (mark == 0)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == 1)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == 5)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == textList.Count - 4)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == textList.Count - 6)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }

                mark++;
            }
        }
        #endregion

        #region 打印Bill主体打印事件
        public void PrtBillNoChinese(List<TAOrderItemInfo> lstOI, Hashtable ht)
        {
            if (string.IsNullOrWhiteSpace(GetPrtStrBillNoChinese(lstOI, ht)))
            {
                return;
            }

            //原文字行或者段落内容
            var sourceTexts = GetPrtStrBillNoChinese(lstOI, ht).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            //重新把文字进行分行树立
            textList = new List<string>();
            foreach (var item in sourceTexts)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    if (item.Length > PrtStatic.PRT_LINE_SIZE)
                    {
                        textList.AddRange(GetArr(PrtStatic.PRT_LINE_SIZE, item));
                    }
                    else
                    {
                        textList.Add(item);
                    }
                }
            }


            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Prt_Content_BillNoChinese);
            //纸张设置默认
            PaperSize pageSize = new PaperSize("自定义纸张", (textList.Count * (int)(58 / 25.4 * 100)), 600);
            pd.DefaultPageSettings.PaperSize = pageSize;
            //pd.PrinterSettings.PrinterName
            try
            {
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("打印失败." + ex.Message);
            }
        }
        #endregion


        #region 打印Receipt
        public string GetPrtStrReceipt(List<TAOrderItemInfo> lstOI, Hashtable ht)
        {
            StringBuilder sb = new StringBuilder();
            string L = PrtCommon.GetSplit();
            string L1 = PrtCommon.GetRestName();
            string L2 = PrtCommon.GetRestAddr();
            string L3 = PrtCommon.GetRestTel();
            string L4 = PrtCommon.GetRestVATNo();
            string L5 = PrtCommon.GetPrtTime();
            string L6 = PrtCommon.GetPrtDateTime();
            string L7 = (string)ht["Staff"];

            //餐厅名称
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE_20 - L1.Length) / 2) + L1);
            sb.Append(Environment.NewLine);

            //餐厅地址
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L2.Length) / 2) + L2);
            sb.Append(Environment.NewLine);

            //Tel
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L3.Length) / 2) + L3);
            sb.Append(Environment.NewLine);

            //VAT
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L4.Length) / 2) + L4);
            sb.Append(Environment.NewLine);

            //分隔行
            sb.Append(L);
            sb.Append(Environment.NewLine);

            //时间
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE_20 - L5.Length) / 2) + L5);
            sb.Append(Environment.NewLine);

            //分隔行
            sb.Append(L);
            sb.Append(Environment.NewLine);

            sb.Append(PrtCommon.GetSpace(6) + L6);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetSpace(6) + L7);
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);

            sb.Append("Code" + PrtCommon.GetSpace(2) + "Qty" + PrtCommon.GetSpace(2) + "Name" + PrtCommon.GetSpace(17) + "Price" + PrtCommon.GetSpace(2));
            sb.Append(Environment.NewLine);

            foreach (var taOrderItemInfo in lstOI)
            {
                sb.Append(PrtCommon.GetTab(taOrderItemInfo.ItemCode, taOrderItemInfo.ItemQty,
                    taOrderItemInfo.ItemDishName, taOrderItemInfo.ItemTotalPrice));
                sb.Append(Environment.NewLine);
            }

            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetItemTotal((string)ht["ItemQty"], (string)ht["SubTotal"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetTotal((string)ht["Total"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetText("Tendered:", (string)ht["Tendered"]));
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetText("Change:", (string)ht["Change"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetPay((string)ht["PayType"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtStatic.PRT_COMP_NAME);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetSpace(8) + PrtStatic.PRT_COMP_WEBSITE);
            sb.Append(Environment.NewLine);

            return sb.ToString();
        }
        #endregion

        #region 打印Receipt内容事件
        /// <summary>
        /// 打印Receipt内容事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prt_Content_Receipt(object sender, PrintPageEventArgs e)
        {
            var mark = 0;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            foreach (var item in textList)
            {
                if (mark == 0)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == 1)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == 5)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == textList.Count - 4)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == textList.Count - 6)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == textList.Count - 7)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == textList.Count - 9)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }

                mark++;
            }
        }
        #endregion

        #region 打印Receipt主体打印事件
        public void PrtReceipt(List<TAOrderItemInfo> lstOI, Hashtable ht)
        {
            if (string.IsNullOrWhiteSpace(GetPrtStrReceipt(lstOI, ht)))
            {
                return;
            }

            //原文字行或者段落内容
            var sourceTexts = GetPrtStrReceipt(lstOI, ht).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            //重新把文字进行分行树立
            textList = new List<string>();
            foreach (var item in sourceTexts)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    if (item.Length > PrtStatic.PRT_LINE_SIZE)
                    {
                        textList.AddRange(GetArr(PrtStatic.PRT_LINE_SIZE, item));
                    }
                    else
                    {
                        textList.Add(item);
                    }
                }
            }


            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Prt_Content_Receipt);
            //纸张设置默认
            PaperSize pageSize = new PaperSize("自定义纸张", (textList.Count * (int)(58 / 25.4 * 100)), 700);
            pd.DefaultPageSettings.PaperSize = pageSize;
            //pd.PrinterSettings.PrinterName
            try
            {
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("打印失败." + ex.Message);
            }
        }
        #endregion

        #region 打印Receipt
        public string GetPrtStrCashBilingual(List<TAOrderItemInfo> lstOI, Hashtable ht)
        {
            StringBuilder sb = new StringBuilder();
            string L = PrtCommon.GetSplit();
            string L1 = PrtCommon.GetRestName();
            string L2 = PrtCommon.GetRestAddr();
            string L3 = PrtCommon.GetRestTel();
            string L4 = PrtCommon.GetRestVATNo();
            string L5 = PrtCommon.GetPrtTime();
            string L6 = PrtCommon.GetPrtDateTime();
            string L7 = (string)ht["Staff"];

            //餐厅名称
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE_20 - L1.Length) / 2) + L1);
            sb.Append(Environment.NewLine);

            //餐厅地址
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L2.Length) / 2) + L2);
            sb.Append(Environment.NewLine);

            //Tel
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L3.Length) / 2) + L3);
            sb.Append(Environment.NewLine);

            //VAT
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE - L4.Length) / 2) + L4);
            sb.Append(Environment.NewLine);

            //分隔行
            sb.Append(L);
            sb.Append(Environment.NewLine);

            //时间
            sb.Append(PrtCommon.GetSpace((PrtStatic.PRT_LINE_SIZE_20 - L5.Length) / 2) + L5);
            sb.Append(Environment.NewLine);

            //分隔行
            sb.Append(L);
            sb.Append(Environment.NewLine);

            sb.Append(PrtCommon.GetSpace(6) + L6);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetSpace(6) + L7);
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);

            sb.Append("Code" + PrtCommon.GetSpace(2) + "Qty" + PrtCommon.GetSpace(2) + "Name" + PrtCommon.GetSpace(17) + "Price" + PrtCommon.GetSpace(2));
            sb.Append(Environment.NewLine);

            foreach (var taOrderItemInfo in lstOI)
            {
                sb.Append(PrtCommon.GetTab(taOrderItemInfo.ItemCode, taOrderItemInfo.ItemQty,
                    taOrderItemInfo.ItemDishName, taOrderItemInfo.ItemTotalPrice));
                sb.Append(Environment.NewLine);
            }

            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetItemTotal((string)ht["ItemQty"], (string)ht["SubTotal"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetTotal((string)ht["Total"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetPay((string)ht["PayType"]));
            sb.Append(Environment.NewLine);
            sb.Append(L);
            sb.Append(Environment.NewLine);
            sb.Append(PrtStatic.PRT_COMP_NAME);
            sb.Append(Environment.NewLine);
            sb.Append(PrtCommon.GetSpace(8) + PrtStatic.PRT_COMP_WEBSITE);
            sb.Append(Environment.NewLine);

            return sb.ToString();
        }
        #endregion

        #region 打印Receipt内容事件
        /// <summary>
        /// 打印Receipt内容事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prt_Content_CashBilingual(object sender, PrintPageEventArgs e)
        {
            var mark = 0;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            foreach (var item in textList)
            {
                if (mark == 0)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == 1)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == 5)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == textList.Count - 4)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else if (mark == textList.Count - 6)
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }
                else
                {
                    e.Graphics.DrawString(item, new Font(new FontFamily("宋体"), 20), System.Drawing.Brushes.Black, 0, mark * 20);
                }

                mark++;
            }
        }
        #endregion

        #region 打印Receipt主体打印事件
        public void PrtCashBilingual(List<TAOrderItemInfo> lstOI, Hashtable ht)
        {
            if (string.IsNullOrWhiteSpace(GetPrtStrCashBilingual(lstOI, ht)))
            {
                return;
            }

            //原文字行或者段落内容
            var sourceTexts = GetPrtStrCashBilingual(lstOI, ht).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            //重新把文字进行分行树立
            textList = new List<string>();
            foreach (var item in sourceTexts)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    if (item.Length > PrtStatic.PRT_LINE_SIZE)
                    {
                        textList.AddRange(GetArr(PrtStatic.PRT_LINE_SIZE, item));
                    }
                    else
                    {
                        textList.Add(item);
                    }
                }
            }


            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Prt_Content_CashBilingual);
            //纸张设置默认
            PaperSize pageSize = new PaperSize("自定义纸张", (textList.Count * (int)(58 / 25.4 * 100)), 700);
            pd.DefaultPageSettings.PaperSize = pageSize;
            //pd.PrinterSettings.PrinterName
            try
            {
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("打印失败." + ex.Message);
            }
        }
        #endregion



        public void PrtDrawStr(PrintPageEventArgs e, string strItem, int intFontSize, float fRow)
        {
            e.Graphics.DrawString(strItem, new Font(new FontFamily("宋体"), intFontSize), System.Drawing.Brushes.Black, 0, fRow);
        }
    }
}

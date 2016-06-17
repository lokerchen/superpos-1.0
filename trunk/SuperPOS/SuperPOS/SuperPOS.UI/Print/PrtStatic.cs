using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPOS.UI.Print
{
    public class PrtStatic
    {
        //10号字体每行最多可打印字符数
        public static int PRT_LINE_SIZE = 39;

        //打印行高 1/100英寸
        public static int PRT_LINE_HEIGHT = 100;

        //字体大小 1/10英寸
        public static int PRT_FONT_SIZE = 10;

        //分割符
        public static string PRT_SPLIT_CHAR = "-";

        //15号字体每行最多可打印字符数
        public static int PRT_LINE_SIZE_15 = 27;

        //20号字体每行最多可打印字符数
        public static int PRT_LINE_SIZE_20 = 21;
    }
}

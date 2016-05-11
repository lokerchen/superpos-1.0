using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperPOS.Common
{
    public class CommonBase
    {
        //文件存放默认路径
        public static string IMG_PATH_DEFAULT= @"C:\program files\SuperPOS\";

        //启动画面logo图片
        public static string IMG_FILE_LOGO_MY = @"mylogo.jpg";

        //登录画面logo图片
        public static string IMG_FILE_LOGO_LOGON = @"logo.jpg";

        //客户餐厅logo图片
        public static string IMG_FILE_CUSTOMER_LOGO = @"cuslogo.jpg";

        //打开网上订餐系统
        public static string URL_DEFAULT = @"http://www.abcrestaurant.co.uk";

        //TeamView默认路径
        public static string FILE_TEAMVIEW_DEFAULT_X86 = @"C:\Program Files\TeamViewer\";
        public static string FILE_TEAMVIEW_DEFAULT_X64 = @"C:\Program Files (x86)\TeamViewer\";

        //TeamView程序名称
        public static string FILE_TEAMVIEW_NAME = @"TeamViewer.exe";

        //查询所有磁盘
        public static string SELECT_WIN32_LOGICALDISK = @"SELECT * FROM WIN32_LOGICALDISK";

        //默认管理员密码
        public static string SYS_CONTROL_PWD = "111";

        //Order Type
        public static string ORDER_TYPE_SHOP= "SHOP";
        public static string ORDER_TYPE_DELIVERY = "DELIVERY";
        public static string ORDER_TYPE_COLLECTION = "COLLECTION";

        //System Value
        public static string SYS_VALUE_PROP_MODE_TA = "TA";
        public static string SYS_VALUE_PROP_NAME_CHECKCODE = "CHECKCODE";
    }
}

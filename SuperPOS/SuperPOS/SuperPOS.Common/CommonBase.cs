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

        public static string FILE_TEAMVIEW_NAME = @"TeamViewer.exe";
    }
}

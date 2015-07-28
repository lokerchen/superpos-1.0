using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SuperPOS.UI;

namespace SuperPOS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isNewApp;

            using (Mutex mutex = new Mutex(true, Application.ProductName, out isNewApp))
            {
                if (isNewApp)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    try
                    {
                        FrmWelcome frmWelcome = new FrmWelcome();
                        DialogResult dr = frmWelcome.ShowDialog();
                        if (DialogResult.Cancel == dr)
                            return;
                        frmWelcome.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("发生错误在程序启动时");
                        throw ex;
                    }

                }
                else
                    MessageBox.Show("一次只能运行一个程序");
            }
        }
    }
}

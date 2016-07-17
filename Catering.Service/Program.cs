using Catering.Service.customize;
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering.Service
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            OSProcess.HasSingle();
            CustomConfig.Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogInterface.Listen(CustomConfig._LogDirectoryName.ToString());
            Application.Run(new FrmMain());
        }
    }
}

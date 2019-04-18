using DevExpress.Utils.About;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using RABC.Common;
using RABC.DevExtensions;

namespace RABC
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            DevInit();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ///* 当前用户是管理员的时候，直接启动应用程序
            // * 如果不是管理员，则使用启动对象启动程序，以确保使用管理员身份运行
            //*/
            ////获得当前登录的Windows用户标示
            //System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            //System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
            ////判断当前登录用户是否为管理员
            //if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
            //{
            //    //如果是管理员，则直接运行
            //    Application.Run(new FrmMain());
            //}
            //else
            //{
            //    //创建启动对象
            //    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //    startInfo.UseShellExecute = true;
            //    startInfo.WorkingDirectory = Environment.CurrentDirectory;
            //    startInfo.FileName = Application.ExecutablePath;
            //    //设置启动动作,确保以管理员身份运行
            //    startInfo.Verb = "runas";
            //    try
            //    {
            //        System.Diagnostics.Process.Start(startInfo);
            //    }
            //    catch
            //    {
            //        return;
            //    }
            //}
            
     
            Application.Run(new FrmLogin());

        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Log.Error(e.ToString(), typeof(Program));
            //var logger = LogManager.GetLogger(typeof(Program));
            //logger.Error(e.ToString());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Log.Error(e.ToString(), typeof(Program));
            //var logger = LogManager.GetLogger(typeof(Program));
            //logger.Error(e.Exception.Message);
        }
        private static void DevInit()
        {
            //汉化，在debug下建zh-Hans文件夹，将汉化文件(dll)拷贝进去
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("zh-CN");

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            /*
            * DevExpress的皮肤样式名称
            * Metropolis,McSkin,Visual Studio 2013 Blue
            */
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Blue");
            DevExpress.XtraEditors.Controls.Localizer.Active = new XtraMessageBoxButtonsLocalization();

            //去除注册提示框 
            var fieldInfo = typeof(Utility).GetField("staticAboutShown", BindingFlags.Static | BindingFlags.NonPublic);
            if (fieldInfo != null)
            {
                fieldInfo.SetValue(new Utility(), true);
            }
        }

    }
}

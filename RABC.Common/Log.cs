using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RABC.Common
{
    public class Log
    {
        static Log()
        {
            InitLog4Net();
        }
        private static void InitLog4Net()
        {
            //将log4net.config右键属性->复制到输出目录：如果较新则复制，否则无法生成日志文件
            var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            XmlConfigurator.ConfigureAndWatch(logCfg);
        }

        public static void Error<T>(string message)
        {
            var logger = LogManager.GetLogger(typeof(T));
            logger.Error(message);
        }
        public static void Error(string message, Type type)
        {
            var logger = LogManager.GetLogger(type);
            logger.Error(message);
        }

        public static void Info<T>(string message)
        {
            var logger = LogManager.GetLogger(typeof(T));
            logger.Info(message);
        }
        public static void Info(string message, Type type)
        {
            var logger = LogManager.GetLogger(type);
            logger.Info(message);
        }
    }
}

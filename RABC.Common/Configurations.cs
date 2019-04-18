using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;

namespace RABC.Common
{
    public class Configurations
    {

        /// <summary>
        ///  // product code mismatch(upper exchange,upper product cd:ZD product cd;)TT和公司的Product名字不一样的
        /// </summary>
        public static readonly string ProductCdMap;


        /// <summary>
        /// exchange code mismatch(ZD exchange cd,ZD product cd;)公司交易所名称和品种
        /// 公司和TT交易所名称不一样的
        /// 品种名称一样，交易所不一样
        /// </summary>
        public static readonly string Products;

        /// <summary>
        /// 期货的配置
        /// Futures:TT的交易所名称和品种名称
        /// </summary>
        public static readonly string TargetFutures;

        /// <summary>
        ///Spreads TT的交易所名称和品种名称
        /// </summary>
        public static readonly string TargetSpreads;
        /// <summary>
        /// 
        /// </summary>
        public static readonly string DisplayPrxFactor;
        /// <summary>
        /// 
        /// </summary>
        public static readonly string SessionAndPsw;
        /// <summary>
        /// 
        /// </summary>
        public static readonly string DisorderSpread;
        /// <summary>
        /// 发送到二级行情端口号
        /// </summary>
        public static readonly string MulticastPort;
        /// <summary>
        /// 发送到二级行情IP，可用127.0.0.1代替
        /// </summary>
        public static readonly string MulticastIP;
        /// <summary>
        /// 
        /// </summary>
        public static readonly string FractionalPrxFactor;
        /// <summary>
        /// 程序启动时自动启动服务
        /// </summary>
        public static readonly string AutoStart;
        /// <summary>
        /// 定时清结算价功能数据库配置
        /// </summary>
        public static readonly string FutureConnectStr;
        /// <summary>
        /// 定时清结算价功能数据库配置
        /// </summary>
        public static readonly string ForeignShareStr;
        /// <summary>
        /// 应用程序自动退出时间
        /// </summary>
        public static readonly string ApplicationExitTime;

        /// <summary>
        /// 期权的配置
        /// Options:TT的交易所名称和品种名称
        /// </summary>
        public static readonly string TargetOptions;
        //{
        //    get
        //    {
        //        return _instance.AppSettings.Settings["TargetOptions"]?.Value;
        //    }
        //}

        /// <summary>
        /// 压缩日志时间 0:0:0
        /// </summary>
        public static readonly string ZipLogTime;
        /// <summary>
        /// 是否记录发送给二级行情的数据日志
        /// </summary>
        public static readonly string LogSendMsg;// => _instance.AppSettings.Settings["LogSendMsg"]?.Value;

        static Configurations()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RABC.exe.config");
            ExeConfigurationFileMap filemap = new ExeConfigurationFileMap();
            filemap.ExeConfigFilename = path;//配置文件路径  
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(filemap, ConfigurationUserLevel.None);
            ProductCdMap = configuration.AppSettings.Settings["ProductCdMap"]?.Value;
            Products = configuration.AppSettings.Settings["Products"]?.Value;
            TargetFutures = configuration.AppSettings.Settings["TargetFutures"]?.Value;
            TargetSpreads = configuration.AppSettings.Settings["TargetSpreads"]?.Value;
            DisplayPrxFactor = configuration.AppSettings.Settings["DisplayPrxFactor"]?.Value;
            SessionAndPsw = configuration.AppSettings.Settings["SessionAndPsw"]?.Value;
            DisorderSpread = configuration.AppSettings.Settings["DisorderSpread"]?.Value;
            MulticastPort = configuration.AppSettings.Settings["multicastPort"]?.Value;
            MulticastIP = configuration.AppSettings.Settings["multicastIP"]?.Value;
            FractionalPrxFactor = configuration.AppSettings.Settings["FractionalPrxFactor"]?.Value;
            AutoStart = configuration.AppSettings.Settings["AutoStart"]?.Value;
            FutureConnectStr = configuration.AppSettings.Settings["FutureConnectStr"]?.Value;
            ForeignShareStr = configuration.AppSettings.Settings["ForeignShareStr"]?.Value;
            ApplicationExitTime = configuration.AppSettings.Settings["ApplicationExitTime"]?.Value;
            TargetOptions = configuration.AppSettings.Settings["TargetOptions"]?.Value;
            ZipLogTime = configuration.AppSettings.Settings["ZipLogTime"]?.Value;
            LogSendMsg = configuration.AppSettings.Settings["LogSendMsg"]?.Value;
        }
    }
}

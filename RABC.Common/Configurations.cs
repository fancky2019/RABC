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
        ///  // product code mismatch(upper exchange,upper product cd:ZD product cd;)TT�͹�˾��Product���ֲ�һ����
        /// </summary>
        public static readonly string ProductCdMap;


        /// <summary>
        /// exchange code mismatch(ZD exchange cd,ZD product cd;)��˾���������ƺ�Ʒ��
        /// ��˾��TT���������Ʋ�һ����
        /// Ʒ������һ������������һ��
        /// </summary>
        public static readonly string Products;

        /// <summary>
        /// �ڻ�������
        /// Futures:TT�Ľ��������ƺ�Ʒ������
        /// </summary>
        public static readonly string TargetFutures;

        /// <summary>
        ///Spreads TT�Ľ��������ƺ�Ʒ������
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
        /// ���͵���������˿ں�
        /// </summary>
        public static readonly string MulticastPort;
        /// <summary>
        /// ���͵���������IP������127.0.0.1����
        /// </summary>
        public static readonly string MulticastIP;
        /// <summary>
        /// 
        /// </summary>
        public static readonly string FractionalPrxFactor;
        /// <summary>
        /// ��������ʱ�Զ���������
        /// </summary>
        public static readonly string AutoStart;
        /// <summary>
        /// ��ʱ�����۹������ݿ�����
        /// </summary>
        public static readonly string FutureConnectStr;
        /// <summary>
        /// ��ʱ�����۹������ݿ�����
        /// </summary>
        public static readonly string ForeignShareStr;
        /// <summary>
        /// Ӧ�ó����Զ��˳�ʱ��
        /// </summary>
        public static readonly string ApplicationExitTime;

        /// <summary>
        /// ��Ȩ������
        /// Options:TT�Ľ��������ƺ�Ʒ������
        /// </summary>
        public static readonly string TargetOptions;
        //{
        //    get
        //    {
        //        return _instance.AppSettings.Settings["TargetOptions"]?.Value;
        //    }
        //}

        /// <summary>
        /// ѹ����־ʱ�� 0:0:0
        /// </summary>
        public static readonly string ZipLogTime;
        /// <summary>
        /// �Ƿ��¼���͸����������������־
        /// </summary>
        public static readonly string LogSendMsg;// => _instance.AppSettings.Settings["LogSendMsg"]?.Value;

        static Configurations()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RABC.exe.config");
            ExeConfigurationFileMap filemap = new ExeConfigurationFileMap();
            filemap.ExeConfigFilename = path;//�����ļ�·��  
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

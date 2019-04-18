using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RABC.Common
{
    public class SystemConfig
    {
        public static string RABCConnectionString;
        static SystemConfig()
        {
            //RABCConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            RABCConnectionString = ConfigurationManager.ConnectionStrings["RABCConnectionString"].ConnectionString;
        }
    }
}

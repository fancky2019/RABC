using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RABC.Common
{
   public static class ObjectReflectionExtention
    {
        public static List<string> GetPropertiesInfo(this object obj)
        {
            if(obj==null)
            {
                return null;
            }
            Type type = obj.GetType();
            PropertyInfo[] info = type.GetProperties();
            return type.GetProperties().Select(p => p.Name).ToList();
        }

        public  static object GetValueByString(this Type type, string valueString)
        {

            if (string.IsNullOrEmpty(valueString))
            {
                return null;
            }
            object val = null;
            switch (type.Name)
            {
                case "Int32":
                    val = int.Parse(valueString);
                    break;
                case "String":
                    val = valueString;
                    break;
                case "DateTime":
                    val = DateTime.Parse(valueString);
                    break;
                case "Boolean":
                    val = Boolean.Parse(valueString);
                    break;
                case "Guid":
                    val = Guid.Parse(valueString);
                    break;
                case "Decimal":
                    val = Guid.Parse(valueString);
                    break;
            }
            return val;
        }
    }
}

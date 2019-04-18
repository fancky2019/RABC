using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RABC.Common
{
   public static class ObjectReflectionClone
    {
        public static T CloneModel<T>(this T oModel)
        {
            var oRes = default(T);
            var oType = typeof(T);

            //得到新的对象对象
            oRes = (T)Activator.CreateInstance(oType);

            //给新的对象复制
            var lstPro = oType.GetProperties();
            foreach (var oPro in lstPro)
            {
                //从旧对象里面取值
                var oValue = oPro.GetValue(oModel);

                //复制给新的对象
                oPro.SetValue(oRes, oValue);
            }

            return oRes;
        }
    }
}

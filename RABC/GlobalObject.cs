using System.Collections.Generic;
using WMS.Model.ViewModels;

namespace RABC
{
    public class GlobalObject
    {

        public static UserVM User = null;
        public static List<UserRolesVM> UserRoles = null;
        public static FrmLogin FrmLogOn = null;
        public static FrmMain FrmMain = null;
        static GlobalObject()
        {
            User = new UserVM();
            UserRoles = new List<UserRolesVM>();
        }


    }
}

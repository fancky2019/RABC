using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS.Model.ViewModels
{
    public class RoleMenuAuthoritiesVM
    {
        public int ID { get; set; }
        public int AuthorityID { get; set; }
        public int RoleID { get; set; }
        public int MenuID { get; set; }

        public string AuthorityName { get; set; }
        public string RoleName { get; set; }
        public string MenuName { get; set; }
    }
}

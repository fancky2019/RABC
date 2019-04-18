using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS.Model.ViewModels
{
    public class AuthoritiesVM
    {
        public int ID { get; set; }
        public int MenuID { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }

        public string MenuName { get; set; }

    }
}

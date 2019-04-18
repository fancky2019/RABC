using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS.Model.ViewModels
{
    public class MenusVM
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string FormName { get; set; }
        public string TabHeaderText { get; set; }
        public int SortCode { get; set; }
        public string Remark { get; set; }

        public int RoleID { get; set; }
        public int Status { get; set; }
    }
}

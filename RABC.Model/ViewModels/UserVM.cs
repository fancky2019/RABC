using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS.Model.ViewModels
{
    public class UserVM
    {
        public int ID { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public short Status { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModityTime { get; set; }
        public byte[] TimeStamp { get; set; }

        public bool Checked { get; set; }
    }
}

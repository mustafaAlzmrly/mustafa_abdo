using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS_PRO_MAX.UserP
{
    using System;
    using System.Collections.Generic;
    public class Users
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public bool State { get; set; }
        public int RoleID { get; set; }
  
    }
}

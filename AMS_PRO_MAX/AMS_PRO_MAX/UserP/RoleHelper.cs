using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS_PRO_MAX.UserP
{
    public static class RoleHelper
    {
        public static int GetRoleId(string roleText)
        {
            switch (roleText)
            {
                case "مدير":
                    return 1;
                case "موظف":
                    return 2;
                default:
                    return 0;
            }
        }
        public static string GetRoleText(int roleId)
        {
            switch (roleId)
            {
                case 1:
                    return "مدير";
                case 2:
                    return "موظف";
                default:
                    return string.Empty;
            }
        }

        public static bool CanEditUsers(int roleId)
        {
            return roleId == 1 ;
        }


    }
}

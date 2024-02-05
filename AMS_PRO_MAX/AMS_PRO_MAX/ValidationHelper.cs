using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS_PRO_MAX
{
    public static class ValidationHelper
    {
        public static bool IsFieldEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }
        public static bool CheckIsEmpty(string name,string pass)
        {

            return IsFieldEmpty(name) || IsFieldEmpty(pass);
        }

        public static bool IsUsernameDuplicate(string username)
        {
            DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();
            var user = db.Users.FirstOrDefault(x => x.Username == username);
            return user != null;
        }
        public static bool ValidateAllFields(string name, string username, string password, string comboBoxValue)
        {
            return string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(comboBoxValue);
        }
    }
}

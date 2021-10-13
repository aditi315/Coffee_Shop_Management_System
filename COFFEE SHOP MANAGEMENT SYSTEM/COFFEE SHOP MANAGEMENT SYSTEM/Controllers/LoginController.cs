using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COFFEE_SHOP_MANAGEMENT_SYSTEM.Models;

namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Controllers
{
    public class LoginController
    {
        
        static Database db = new Database();
        static public int AuthenticateUser(string username, string password)
        {
            int result = 0;

            var obj = db.Users.AuthenticateUser(username, password);
            if (obj != null) {
                if (System.Convert.ToInt32(obj.UserType) == 1) { return 1; }
                else if (System.Convert.ToInt32(obj.UserType) == 2) { return 2; }
                else if (System.Convert.ToInt32(obj.UserType) == 3) { return 3; }
            }
            return result;

        }
    }
}


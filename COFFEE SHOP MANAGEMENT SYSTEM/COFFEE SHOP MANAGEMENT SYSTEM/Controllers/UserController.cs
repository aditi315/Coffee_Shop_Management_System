using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COFFEE_SHOP_MANAGEMENT_SYSTEM.Models;

namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Controllers
{
   public class UserController
    {

        static Database db = new Database();
        public static void AddUser(string id,string name, string username, string password,string usertype)
        {
            User u = new User();
            u.Id = id;
            u.Name = name;
            u.Password = password;
            u.Username = username;
            u.UserType = usertype;
            db.Users.AddUser(u);
        }
        public static void UpdateUser(string id, string name, string username, string password, string usertype)
        {
            User u = new User()
            {
                Id = id,
                Name = name,
                Username = username,
                Password = password,
                UserType = usertype
            };
            db.Users.UpdateUser(u);

        }


        public static ArrayList GetAllCustomer()
        {
            ArrayList arr = new ArrayList();
            Users u = new Users();
            arr=u.GetAllCustomer();
            return arr;
        }
        public static ArrayList GetAllEmployee()
        {
            ArrayList arr = new ArrayList();
            Users u = new Users();
            arr = u.GetAllEmployee();
            return arr;
        }

        public void insertIntoOrder(string name,string quantity,string price)
        {
            Order o = new Order();
            o.OrderName = name;
            o.OrderQty = quantity;
            o.OrderPrice = price;
            db.Orders.AddOrder(o);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COFFEE_SHOP_MANAGEMENT_SYSTEM.Models;


namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Controllers
{
   public class OrderController
    {

        
        
            static Database db = new Database();
            public static void AddOrder(string oId, string oName, string oPrice, string oQty)
            {
                Order o = new Order()
                {
                    OrderId = oId,
                    OrderName = oName,
                    OrderPrice = oPrice,
                    OrderQty = oQty,


                };
                db.Orders.AddOrder(o);

            }
            public static ArrayList GetAllOrder()
            {
                return db.Orders.GetAllOrder();
            }
            public static void UpdateOrder(string id, string name, string price, string qty)
            {
                Order o = new Order()
                {
                    OrderId = id,
                    OrderName = name,
                    OrderPrice = price,
                    OrderQty = qty
                };
                db.Orders.UpdateOrder(o);

            }

        }
    }


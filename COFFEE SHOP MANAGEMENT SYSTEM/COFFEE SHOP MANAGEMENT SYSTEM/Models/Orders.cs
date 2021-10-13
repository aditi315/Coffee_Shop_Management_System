using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Models
{
    


        public class Orders
    {
        SqlConnection conn;
        public Orders()
        {
            conn = new SqlConnection("Server=desktop-du2rp3h\\sqlexpress;Database=Coffee;Integrated Security=True");
        }
        public ArrayList GetAllOrder()
        {
            ArrayList orders = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Orders";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Order o = new Order()
                {
                    OrderId = reader.GetString(reader.GetOrdinal("OrderId")),
                    OrderName = reader.GetString(reader.GetOrdinal("OrderName")),
                    OrderPrice = reader.GetString(reader.GetOrdinal("OrderPrice")),
                    OrderQty = reader.GetString(reader.GetOrdinal("OrderQty")),

                };
                orders.Add(o);

            }
            conn.Close();
            return orders;
        }


        public void AddOrder(Order order)
        {
            conn.Open();
            string query = "INSERT INTO Orders (OrderId,OrderName,OrderPrice,OrderQty) VALUES('" + order.OrderId + "','" + order.OrderName + "','" + order.OrderPrice + "','" + order.OrderQty + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteProduct(Order order)
        {
        }



        public Order GetOrder(string OrderName)
        {
            Order o = new Order();
            return o;
        }



        public void UpdateOrder(Order o)
        {
            conn.Open();
            string query = "UPDATE Orders SET OrderName='" + o.OrderName + "', OrderPrice=" + o.OrderPrice + ",OrderQty=" + o.OrderQty + " WHERE OrderId=" + o.OrderId;
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}



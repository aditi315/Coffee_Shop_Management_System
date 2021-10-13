using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Models
{


        public class Products
        {
            SqlConnection conn;
            public Products()
            {
                conn = new SqlConnection("Server=desktop-du2rp3h\\sqlexpress;Database=Coffee;Integrated Security=True");
            }
        public ArrayList GetAllProduct()
        {
            ArrayList products = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product p = new Product()
                {
                    ProductId = reader.GetString(reader.GetOrdinal("ProductId")),
                    ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                    ProductPrice = reader.GetString(reader.GetOrdinal("ProductPrice")),
                    ProductQty = reader.GetString(reader.GetOrdinal("ProductQty")),

                };
                products.Add(p);

            }
            conn.Close();
            return products;
        }

        public ArrayList getProductByName(string productName)
        {
            ArrayList products = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Products where productName='"+productName+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product p = new Product()
                {
                    ProductId = reader.GetString(reader.GetOrdinal("ProductId")),
                    ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                    ProductPrice = reader.GetString(reader.GetOrdinal("ProductPrice")),
                    ProductQty = reader.GetString(reader.GetOrdinal("ProductQty")),

                };
                products.Add(p);

            }
            conn.Close();
            return products;
        }


        public void AddProduct(Product product)
            {
                conn.Open();
                string query = "INSERT INTO Products (ProductId,ProductName,ProductPrice,ProductQty) VALUES('" + product.ProductId + "','" + product.ProductName + "','" + product.ProductPrice + "','" + product.ProductQty + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            public void DeleteProduct(Product product)
            {
            }
           

            
            public Product GetProduct(string productName)
            {
                Product p = new Product();
                return p;
            }

 
      
        public void UpdateProduct(Product p)
        {
            conn.Open();
            string query = "UPDATE Products SET ProductName='" + p.ProductName + "', ProductPrice=" + p.ProductPrice + ",ProductQty=" + p.ProductQty + " WHERE ProductId=" + p.ProductId;
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public ArrayList GetAllProductName()
        {
            ArrayList products = new ArrayList();
            conn.Open();
            string query = "SELECT productname FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList arr = new ArrayList();
            arr.Add("Select Item");
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    arr.Add(reader.GetString(0));
                }
                reader.NextResult();
            }
            conn.Close();
            return arr;
        }

        public float getPrice(string selectedProduct)
        {
            float price = 0.00f;
            conn.Open();
            string query = "SELECT ProductPrice FROM Products where ProductName='"+selectedProduct+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    price=float.Parse(reader.GetString(0));
                }
                reader.NextResult();
            }
            conn.Close();
            return price;
        }
    }
 }


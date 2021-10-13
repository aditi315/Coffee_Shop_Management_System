using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COFFEE_SHOP_MANAGEMENT_SYSTEM.Models;

namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Controllers
{
   
        public class ProductController
    {
        static Database db = new Database();
        public static void AddProduct(string pId,string pName, string pPrice, string pQty)
        {
            Product p = new Product()
            {
                ProductId = pId,
                ProductName = pName,
                ProductPrice = pPrice,
                ProductQty = pQty,
                

            };
            db.Products.AddProduct(p);

        }
        public static ArrayList GetAllProduct()
        {
            return db.Products.GetAllProduct();
        }
        public static void UpdateProduct(string id, string name, string price, string qty)
        {
            Product p = new Product()
            {
                ProductId = id,
                ProductName = name,
                ProductPrice = price,
                ProductQty = qty
            };
            db.Products.UpdateProduct(p);
            
        }
        public static ArrayList getProductByName(string productName)
        {
            return db.Products.getProductByName(productName);
        }

        public static ArrayList GetAllProductName()
        {
            return db.Products.GetAllProductName();
        } 

        public float getPrice(string selecetedProduct)
        {
            return db.Products.getPrice(selecetedProduct);
        }

    }
    
    }


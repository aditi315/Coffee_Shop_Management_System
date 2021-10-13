using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGEMENT_SYSTEM.Models
{
    public class Database
    {
        public Users Users { get; set; }
        public Products Products { get; set; }
        public Orders Orders { get; set; }
        
        public Database()
        {
            Users = new Users();
            Products = new Products();
            Orders = new Orders();
            
        }
    }
}


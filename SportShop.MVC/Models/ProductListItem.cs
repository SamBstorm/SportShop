using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportShop.MVC.Models
{
    public class ProductListItem
    {
        public int Reference { get; set; }
        public string PicsUrl { get; set; }
        public string ProductName { get; set; }
        public string SellerName { get; set; }
        public decimal Price { get; set; }
    }
}

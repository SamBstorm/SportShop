using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.BLL.Entities
{
    public class Product
    {
        public int Reference { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string PicsUrl { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Volume { get; set; }
        public int Weigth { get; set; }
        public Seller Seller { get; set; }
    }
}

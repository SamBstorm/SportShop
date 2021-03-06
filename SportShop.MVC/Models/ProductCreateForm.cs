using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportShop.MVC.Models
{
    public class ProductCreateForm
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string PicsUrl { get; set; }
        public Guid SellerId { get; set; }
        public decimal Price { get; set; }
        public int Weigth { get; set; }
        public int Volume { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}

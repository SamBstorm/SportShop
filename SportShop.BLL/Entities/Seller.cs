using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.BLL.Entities
{
    public class Seller
    {
        public Guid SellerId { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public Seller()
        {

        }
        public Seller(Guid id, string name, Address address, params Product[] products)
        {
            this.SellerId = id;
            this.Name = name;
            this.Address = address;
            this.Products = products.Select(p => {
                p.Seller = this;
                return p;
            });
        }
        public Seller(Guid id, string name, string city, string street, string number, string zipcode, string country)
         : this (id, name, new Address { City = city, Street = street, ZipCode = zipcode, Number = number, Country = country})
        {

        }
    }
}

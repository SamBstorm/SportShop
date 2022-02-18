using Microsoft.EntityFrameworkCore.ChangeTracking;
using SportShop.Common.Repositories;
using SportShop.DAL_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAL_EF.Repositories
{
    public class ProductService : IProductRepository<Product>
    {
        private readonly SportShopContext _context;

        public ProductService(SportShopContext context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {

            try
            {
                Product product = Get(id);
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public IEnumerable<Product> Get()
        {
            return _context.Products;
        }

        public Product Get(int id)
        {
            return _context.Products.Find(id);
        }

        public IEnumerable<Product> GetBySeller(Guid sellerId)
        {
            return _context.Products.Where(p => p.SellerId == sellerId);
        }

        public int Insert(Product newRecord)
        {
            EntityEntry<Product> newProduct = _context.Products.Add(newRecord);
            _context.SaveChanges();
            return newProduct.Entity.Reference;
        }

        public bool Update(int id, Product newValue)
        {
            try
            {
                Product oldProduct = Get(id);
                if (oldProduct is null) return false;
                oldProduct.Model = newValue.Model;
                oldProduct.Price = newValue.Price;
                oldProduct.ProductName = newValue.ProductName;
                oldProduct.ProductDescription = newValue.ProductDescription;
                oldProduct.Color = newValue.Color;
                oldProduct.Volume = newValue.Volume;
                oldProduct.Weigth = newValue.Weigth;
                oldProduct.SellerId = newValue.SellerId;
                oldProduct.PicsUrl = newValue.PicsUrl;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}

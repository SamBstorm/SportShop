using SportShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAL.Repositories
{
    public class ProductService : IProductRepository<Product>
    {
        public bool Delete(int id)
        {
            Product oldValue = this.Get(id);
            if (oldValue is null) throw new ArgumentOutOfRangeException("L'identifiant n'a retourné aucun objet.");
            int oldCount = DataContext.Products.Count();
            DataContext.Products.Remove(oldValue);
            if (oldCount == DataContext.Products.Count()) return false;
            return true;
        }

        public IEnumerable<Product> Get()
        {
            return DataContext.Products;
        }

        public Product Get(int id)
        {
           return DataContext.Products.SingleOrDefault(p => p.Reference == id);
        }

        public IEnumerable<Product> GetBySeller(Guid sellerId)
        {
            return DataContext.Products.Where(p => p.SellerId == sellerId);
        }

        public int Insert(Product newRecord)
        {
            int maxId = DataContext.Products.Max(p => p.Reference);
            newRecord.Reference = maxId + 1;
            DataContext.Products.Add(newRecord);
            return newRecord.Reference;
        }

        public bool Update(int id, Product newValue)
        {
            Product oldValue = this.Get(id);
            if (oldValue is null) throw new ArgumentOutOfRangeException("L'identifiant n'a retourné aucun objet.");
            try
            {
                oldValue.ProductDescription = newValue.ProductDescription;
                oldValue.ProductName = newValue.ProductName;
                oldValue.Price = newValue.Price;
                oldValue.Color = newValue.Color;
                oldValue.Model = newValue.Model;
                oldValue.Volume = newValue.Volume;
                oldValue.Weigth = newValue.Weigth;
                oldValue.SellerId = newValue.SellerId;
                oldValue.PicsUrl = newValue.PicsUrl;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}

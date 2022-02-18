using SportShop.Common.Repositories;
using SportShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAL.Repositories
{
    public class SellerService : ISellerRepository<Seller>
    {
        public bool Delete(Guid id)
        {
            Seller seller = Get(id);
            if (seller is null) return false;
            DataContext.Sellers.Remove(seller);
            return true;
        }

        public IEnumerable<Seller> GetByCountry(string country)
        {
            return DataContext.Sellers.Where(s => s.Country.ToUpper() == country.ToUpper());
        }

        public IEnumerable<Seller> Get()
        {
            return DataContext.Sellers;
        }

        public Seller Get(Guid id)
        {
            return DataContext.Sellers.SingleOrDefault(s => s.SellerId == id);
        }

        public Guid Insert(Seller newRecord)
        {
            Guid newId = Guid.NewGuid();
            newRecord.SellerId = newId;
            DataContext.Sellers.Add(newRecord);
            return newId;
        }

        public bool Update(Guid id, Seller newValue)
        {
            Seller oldValues = Get(id);
            if (oldValues is null) return false;
            oldValues.Name = newValue.Name;
            oldValues.Country = newValue.Country;
            oldValues.City = newValue.City;
            oldValues.Street = newValue.Street;
            oldValues.Number = newValue.Number;
            oldValues.ZipCode = newValue.ZipCode;
            return true;
        }
    }
}

using SportShop.Common.Repositories;
using SportShop.DAL_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAL_EF.Repositories
{
    public class SellerService : ISellerRepository<Seller>
    {
        private readonly SportShopContext _context;

        public SellerService(SportShopContext context)
        {
            _context = context;
        }

        public bool Delete(Guid id)
        {
            try
            {
                Seller seller = Get(id);
                _context.Sellers.Remove(seller);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public IEnumerable<Seller> Get()
        {
            return _context.Sellers;
        }

        public Seller Get(Guid id)
        {
            return _context.Sellers.Find(id);
        }

        public IEnumerable<Seller> GetByCountry(string country)
        {
            return _context.Sellers.Where(s => s.Country == country);
        }

        public Guid Insert(Seller newRecord)
        {
            newRecord.SellerId = Guid.NewGuid();
            _context.Sellers.Add(newRecord);
            _context.SaveChanges();
            return newRecord.SellerId;
        }

        public bool Update(Guid id, Seller newValue)
        {
            try
            {
                Seller oldValue = Get(id);
                if (oldValue is null) return false;
                oldValue.Name = newValue.Name;
                oldValue.City = newValue.City;
                oldValue.Street = newValue.Street;
                oldValue.Number = newValue.Number;
                oldValue.ZipCode = newValue.ZipCode;
                oldValue.Country = newValue.Country;
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

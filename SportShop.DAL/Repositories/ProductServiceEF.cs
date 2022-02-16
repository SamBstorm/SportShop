using SportShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAL.Repositories
{
    public class ProductServiceEF : IRepository<Product, int>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Product newRecord)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Product newValue)
        {
            throw new NotImplementedException();
        }
    }
}

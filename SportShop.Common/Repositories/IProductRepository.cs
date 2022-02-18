using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.Common.Repositories
{
    public interface IProductRepository<TProduct> : IRepository<TProduct, int>
    {
        public IEnumerable<TProduct> GetBySeller(Guid sellerId);
    }
}

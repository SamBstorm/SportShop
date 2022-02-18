using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.Common.Repositories
{
    public interface ISellerRepository<TSeller> : IRepository<TSeller, Guid>
    {
        public IEnumerable<TSeller> GetByCountry(string counrty);
    }
}

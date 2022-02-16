using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAL.Repositories
{
    public interface IRepository<TEntity, TId>
    {
        public IEnumerable<TEntity> Get();
        public TEntity Get(TId id);

        public TId Insert(TEntity newRecord);

        public bool Update(TId id, TEntity newValue);

        public bool Delete(TId id);
    }
}

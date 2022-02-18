using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.Common.Repositories
{
    public interface IRepository<TEntity, TId> where TId : struct
    {
        public IEnumerable<TEntity> Get();
        public TEntity Get(TId id);

        public TId Insert(TEntity newRecord);

        public bool Update(TId id, TEntity newValue);

        public bool Delete(TId id);
    }
}

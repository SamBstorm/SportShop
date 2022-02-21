using SportShop.BLL.Entities;
using SportShop.BLL.Handlers;
using SportShop.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.BLL.Repositories
{
    public class SellerService : ISellerRepository<Seller>
    {
        private readonly ISellerRepository<DAL_EF.Entities.Seller> _sellerRepository;
        private readonly IProductRepository<DAL_EF.Entities.Product> _productRepository;

        public SellerService(ISellerRepository<DAL_EF.Entities.Seller> sellerRepository, IProductRepository<DAL_EF.Entities.Product> productRepository)
        {
            _sellerRepository = sellerRepository;
            _productRepository = productRepository;
        }

        public bool Delete(Guid id)
        {
            return _sellerRepository.Delete(id);
        }

        public IEnumerable<Seller> Get()
        {
            IEnumerable<DAL_EF.Entities.Seller> sellers = _sellerRepository.Get().ToList().ToList();         //Une connexion EntityFramework ne permet pas de pouvoir travailler sur 2 ensemble d'élément à la fois, il nous faut donc finaliser la connection. Une conversion (comme le ToList() ), permet d'intérrompre la connexion.
            IEnumerable<DAL_EF.Entities.Product> products = _productRepository.Get().ToList();
            return sellers.GroupJoin(
                products,
                seller => seller.SellerId,
                product => product.SellerId,
                (seller, prods) => {
                    Seller result =  seller.ToBLL();
                    result.Products = prods.Select(p => p.ToBLL());
                    return result;
                });
        }

        public Seller Get(Guid id)
        {
            return _sellerRepository.Get(id).ToBLL();
        }

        public IEnumerable<Seller> GetByCountry(string counrty)
        {
            return _sellerRepository.GetByCountry(counrty).Select(s => s.ToBLL());
        }

        public Guid Insert(Seller newRecord)
        {
            return _sellerRepository.Insert(newRecord.ToDAL());
        }

        public bool Update(Guid id, Seller newValue)
        {
            return _sellerRepository.Update(id, newValue.ToDAL());
        }
    }
}

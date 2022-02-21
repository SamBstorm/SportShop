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
    public class ProductService : IProductRepository<Product>
    {
        private readonly IProductRepository<DAL_EF.Entities.Product> _productRepository;
        private readonly ISellerRepository<DAL_EF.Entities.Seller> _sellerRepository;

        public ProductService(IProductRepository<DAL_EF.Entities.Product> repository, ISellerRepository<DAL_EF.Entities.Seller> sellerRepository)
        {
            _productRepository = repository;
            _sellerRepository = sellerRepository;
        }

        public bool Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public IEnumerable<Product> Get()
        {
            IEnumerable<DAL_EF.Entities.Product> products = _productRepository.Get().ToList();
            products = products.Select(p =>
            {
                p.Seller = _sellerRepository.Get(p.SellerId);
                return p;               //return p car le SELECT demande un résultat final,
                                        //qui ici reste toujours notre Product,
                                        //pour ajouter une information le Select doit être fait en 2 étapes
                                        //: modification et retour
            });
            return products.Select(p => p.ToBLL());
        }

        public Product Get(int id)
        {
            DAL_EF.Entities.Product result = _productRepository.Get(id);
            result.Seller = _sellerRepository.Get(result.SellerId);
            return result.ToBLL();
        }

        public IEnumerable<Product> GetBySeller(Guid sellerId)
        {
            return _productRepository.GetBySeller(sellerId).Select(p => p.ToBLL());
        }

        public int Insert(Product newRecord)
        {
            return _productRepository.Insert(newRecord.ToDAL());
        }

        public bool Update(int id, Product newValue)
        {
            return _productRepository.Update(id, newValue.ToDAL());
        }
    }
}

using B = SportShop.BLL.Entities;
using D = SportShop.DAL_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.BLL.Handlers
{
    public static class Mapper
    {
        #region Product
        public static B.Product ToBLL(this D.Product entity)
        {
            if (entity is null) return null;
            return new B.Product()
            {
                Reference = entity.Reference,
                ProductName = entity.ProductName,
                ProductDescription = entity.ProductDescription,
                Volume = entity.Volume,
                Weigth = entity.Weigth,
                PicsUrl = entity.PicsUrl,
                Color = entity.Color,
                Model = entity.Model,
                Seller = entity.Seller.ToBLL()
            };
        }

        public static D.Product ToDAL(this B.Product entity)
        {
            if (entity is null) return null;
            return new D.Product()
            {
                Reference = entity.Reference,
                ProductName = entity.ProductName,
                ProductDescription = entity.ProductDescription,
                Volume = entity.Volume,
                Weigth = entity.Weigth,
                PicsUrl = entity.PicsUrl,
                Color = entity.Color,
                Model = entity.Model,
                SellerId = entity.Seller.SellerId
            };
        }
        #endregion
        #region Seller
        public static B.Seller ToBLL(this D.Seller entity)
        {
            if (entity is null) return null;
            return new B.Seller(
                entity.SellerId,
                entity.Name,
                entity.City,
                entity.Street,
                entity.Number,
                entity.ZipCode,
                entity.Country);
        }

        public static D.Seller ToDAL(this B.Seller entity)
        {
            if (entity is null) return null;
            return new D.Seller()
            {
                SellerId = entity.SellerId,
                Name = entity.Name,
                City = entity.Address.City,
                Street = entity.Address.Street,
                Number = entity.Address.Number,
                ZipCode = entity.Address.ZipCode,
                Country = entity.Address.Country
            };
        }
        #endregion
    }
}

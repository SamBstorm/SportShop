using SportShop.DAL.Entities;
using SportShop.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportShop.MVC.Handlers
{
    public static class Mapper
    {
        public static ProductListItem ToListItem(this Product entity)
        {
            if (entity is null) return null;
            return new ProductListItem()
            {
                Reference = entity.Reference,
                ProductName = entity.ProductName,
                Price = entity.Price,
                PicsUrl = entity.PicsUrl,
                SellerName = entity.SellerName
            };
        }

        public static ProductDetails ToDetails(this Product entity)
        {
            if (entity is null) return null;
            return new ProductDetails() {
                Reference = entity.Reference,
                ProductName = entity.ProductName,
                Price = entity.Price,
                PicsUrl = entity.PicsUrl,
                SellerName = entity.SellerName,
                Color = entity.Color,
                Model = entity.Model,
                Volume = entity.Volume,
                Weigth = entity.Weigth,
                ProductDescription = entity.ProductDescription
            };
        }
        public static Product ToProduct(this ProductCreateForm entity)
        {
            if (entity is null) return null;
            return new Product()
            {
                //Reference = default,
                ProductName = entity.ProductName,
                Price = entity.Price,
                PicsUrl = entity.PicsUrl,
                SellerName = entity.SellerName,
                Color = entity.Color,
                Model = entity.Model,
                Volume = entity.Volume,
                Weigth = entity.Weigth,
                ProductDescription = entity.ProductDescription
            };
        }
    }
}

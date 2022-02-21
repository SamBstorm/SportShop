using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportShop.Common.Repositories;
using SportShop.BLL.Entities;
using SportShop.MVC.Handlers;
using SportShop.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SportShop.MVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductRepository<Product> _service;
        public ShopController(IProductRepository<Product> service)
        {
            _service = service;
        }
        public IActionResult Index([FromQuery]string sellername)
        {
            IEnumerable<ProductListItem> model = _service.Get().Select(p => p.ToListItem());
            if (!(sellername is null)) model = model.Where(p => p.SellerName.ToLower() == sellername.ToLower());
            
            //Normalement, appel du BLL ou de la DAL : productService.Get().ToProductListIem();
            //List<ProductListItem> model = new List<ProductListItem>();
            //model.Add(new ProductListItem() { Reference = 1, PicsUrl = "velo.jpg", ProductName = "Vélo de compet'", SellerName = "Compet'Seller", Price = 1599.99M });
            //model.Add(new ProductListItem() { Reference = 2, PicsUrl = "casque.jpg", ProductName = "Casque de compet'", SellerName = "Compet'Seller", Price = 19.99M });
            //model.Add(new ProductListItem() { Reference = 3, PicsUrl = "gourde.jpg", ProductName = "Gourde de compet'", SellerName = "Compet'Seller", Price = 12.99M });
            //model.Add(new ProductListItem() { Reference = 4, PicsUrl = "velo2.jpeg", ProductName = "Vélo débutant", SellerName = "Newbie'Seller", Price = 599.99M });
            //model.Add(new ProductListItem() { Reference = 5, PicsUrl = "roue.jpg", ProductName = "Roue de compet'", SellerName = "Compet'Seller", Price = 599.99M });
            return View(model);
        }

        public IActionResult Details(int id)
        {
            ProductDetails model = _service.Get(id).ToDetails();
            if (model is null) return RedirectToAction(nameof(Index));
            return View(model);
        }

        public IActionResult Create()
        {
            ProductCreateForm model = new ProductCreateForm();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(ProductCreateForm collection)
        {
            _service.Insert(collection.ToProduct());
            return View(collection);
        }

        public IActionResult Test(int id)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < id; i++)
            {
                numbers.Add(i);
            }
            return View(numbers);
        }
    }
}

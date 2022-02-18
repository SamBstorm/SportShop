﻿using Microsoft.AspNetCore.Mvc;
using SportShop.DAL.Entities;
using SportShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportShop.MVC.Controllers
{
    public class SellerController : Controller
    {
        private readonly ISellerRepository<Seller> _sellerService;

        public SellerController(ISellerRepository<Seller> sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            _sellerService.GetByCountry("BELGIUM");
            return View();
        }
    }
}
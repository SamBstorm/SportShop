using SportShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAL
{
    public static class DataContext
    {
        public static List<Product> Products = new List<Product> {
            new Product() { Reference = 1, PicsUrl = "velo.jpg", ProductName = "Vélo de compétition", SellerName = "Compet'Seller", Price = 1599.99M, Color="Vert", Volume = 3, Weigth = 4000, Model = "Pro", ProductDescription = "Vélo de compet' tout terrain avec toute les options..." },
            new Product() { Reference = 2, PicsUrl = "casque.jpg", ProductName = "Casque de compet'", SellerName = "Compet'Seller", Price = 19.99M, Color="Jaune", Volume = 1, Weigth = 500, Model = "XL", ProductDescription = "Casque pour éviter les bobos..." },
            new Product() { Reference = 3, PicsUrl = "gourde.jpg", ProductName = "Gourde de compet'", SellerName = "Compet'Seller", Price = 12.99M, Color = "Bleue",Volume = 1 , Weigth = 100, Model = "0.5L", ProductDescription = "Gourde pour pouvoir boire quand on veut!" },
            new Product() { Reference = 4, PicsUrl = "velo2.jpeg", ProductName = "Vélo débutant", SellerName = "Newbie'Seller", Price = 599.99M, Volume =  2, Weigth=3000, Color="Jaune", Model="Enfant", ProductDescription="Vélo pour bien débuter à tout âge!" },
            new Product() { Reference = 5, PicsUrl = "roue.jpg", ProductName = "Roue de compet'", SellerName = "Compet'Seller", Price = 599.99M, Color="Gris", Volume=1, Weigth=500, Model="24\"", ProductDescription="Roue haute performance pour rouler plus vite!" }
        };
    }
}

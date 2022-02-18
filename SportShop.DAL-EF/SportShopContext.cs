using Microsoft.EntityFrameworkCore;
using SportShop.DAL_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAL_EF
{
    public class SportShopContext : DbContext
    {
        private static IEnumerable<Seller> _sellers = new[] {
            new Seller() { SellerId = Guid.NewGuid(), Name = "Compet'Seller", City = "Bruxelles", Country="BELGIUM", ZipCode="BE1000",Street="Avenue de l'avenir",Number="254" },
            new Seller() { SellerId = Guid.NewGuid(), Name = "Newbie'Seller", City = "London", Country="UNITEDKINGDOM", ZipCode="UK12000",Street="Backer's street",Number="211" }
        };
        private IEnumerable<Product> _products = new[] {
            new Product() { Reference = 1, PicsUrl = "velo.jpg", ProductName = "Vélo de compétition", SellerId =_sellers.SingleOrDefault(s=> s.Name == "Compet'Seller").SellerId, Price = 1599.99M, Color="Vert", Volume = 3, Weigth = 4000, Model = "Pro", ProductDescription = "Vélo de compet' tout terrain avec toute les options..." },
            new Product() { Reference = 2, PicsUrl = "casque.jpg", ProductName = "Casque de compet'", SellerId =_sellers.SingleOrDefault(s=> s.Name == "Compet'Seller").SellerId, Price = 19.99M, Color="Jaune", Volume = 1, Weigth = 500, Model = "XL", ProductDescription = "Casque pour éviter les bobos..." },
            new Product() { Reference = 3, PicsUrl = "gourde.jpg", ProductName = "Gourde de compet'", SellerId =_sellers.SingleOrDefault(s=> s.Name == "Compet'Seller").SellerId, Price = 12.99M, Color = "Bleue",Volume = 1 , Weigth = 100, Model = "0.5L", ProductDescription = "Gourde pour pouvoir boire quand on veut!" },
            new Product() { Reference = 4, PicsUrl = "velo2.jpeg", ProductName = "Vélo débutant", SellerId =_sellers.SingleOrDefault(s=> s.Name == "Newbie'Seller").SellerId, Price = 599.99M, Volume =  2, Weigth=3000, Color="Jaune", Model="Enfant", ProductDescription="Vélo pour bien débuter à tout âge!" },
            new Product() { Reference = 5, PicsUrl = "roue.jpg", ProductName = "Roue de compet'", SellerId =_sellers.SingleOrDefault(s=> s.Name == "Compet'Seller").SellerId, Price = 599.99M, Color="Gris", Volume=1, Weigth=500, Model="24\"", ProductDescription="Roue haute performance pour rouler plus vite!" }
        };
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public SportShopContext()
        {

        }
        public SportShopContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seller>().HasData(_sellers);
            modelBuilder.Entity<Product>().HasData(_products);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }

    }
}

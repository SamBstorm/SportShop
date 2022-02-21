using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportShop.Common.Repositories;
using D = SportShop.DAL_EF.Entities;
using B = SportShop.BLL.Entities;
using DS = SportShop.DAL_EF.Repositories;
using BS = SportShop.BLL.Repositories;
using SportShop.DAL_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportShop.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<SportShopContext>(
                option => option.UseSqlServer(
                    Configuration.GetConnectionString("default"))
                );

            services.AddScoped<IProductRepository<D.Product>, DS.ProductService>();
            services.AddScoped<IProductRepository<B.Product>, BS.ProductService>();
            services.AddScoped<ISellerRepository<D.Seller>, DS.SellerService>();
            services.AddScoped<ISellerRepository<B.Seller>, BS.SellerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Shop}/{action=Index}/{id?}");
            });
        }
    }
}

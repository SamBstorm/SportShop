// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportShop.DAL_EF;

namespace SportShop.DAL_EF.Migrations
{
    [DbContext(typeof(SportShopContext))]
    partial class SportShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportShop.DAL_EF.Entities.Product", b =>
                {
                    b.Property<int>("Reference")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Reference")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("NVARCHAR(16)")
                        .HasColumnName("Color");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("NVARCHAR(16)")
                        .HasColumnName("Model");

                    b.Property<string>("PicsUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(256)")
                        .HasColumnName("PicsUrl");

                    b.Property<decimal>("Price")
                        .HasColumnType("MONEY")
                        .HasColumnName("Price");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(4000)
                        .HasColumnType("NVARCHAR(4000)")
                        .HasColumnName("ProductDescription");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("NVARCHAR(64)")
                        .HasColumnName("ProductName");

                    b.Property<Guid>("SellerId")
                        .HasColumnType("UNIQUEIDENTIFIER")
                        .HasColumnName("SellerId");

                    b.Property<int>("Volume")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Volume");

                    b.Property<int>("Weigth")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Weigth");

                    b.HasKey("Reference");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Reference = 1,
                            Color = "Vert",
                            Model = "Pro",
                            PicsUrl = "velo.jpg",
                            Price = 1599.99m,
                            ProductDescription = "Vélo de compet' tout terrain avec toute les options...",
                            ProductName = "Vélo de compétition",
                            SellerId = new Guid("c8810229-a2f6-4634-b199-d25318372a0f"),
                            Volume = 3,
                            Weigth = 4000
                        },
                        new
                        {
                            Reference = 2,
                            Color = "Jaune",
                            Model = "XL",
                            PicsUrl = "casque.jpg",
                            Price = 19.99m,
                            ProductDescription = "Casque pour éviter les bobos...",
                            ProductName = "Casque de compet'",
                            SellerId = new Guid("c8810229-a2f6-4634-b199-d25318372a0f"),
                            Volume = 1,
                            Weigth = 500
                        },
                        new
                        {
                            Reference = 3,
                            Color = "Bleue",
                            Model = "0.5L",
                            PicsUrl = "gourde.jpg",
                            Price = 12.99m,
                            ProductDescription = "Gourde pour pouvoir boire quand on veut!",
                            ProductName = "Gourde de compet'",
                            SellerId = new Guid("c8810229-a2f6-4634-b199-d25318372a0f"),
                            Volume = 1,
                            Weigth = 100
                        },
                        new
                        {
                            Reference = 4,
                            Color = "Jaune",
                            Model = "Enfant",
                            PicsUrl = "velo2.jpeg",
                            Price = 599.99m,
                            ProductDescription = "Vélo pour bien débuter à tout âge!",
                            ProductName = "Vélo débutant",
                            SellerId = new Guid("9e603da6-a21c-41fb-970d-c762d52b6700"),
                            Volume = 2,
                            Weigth = 3000
                        },
                        new
                        {
                            Reference = 5,
                            Color = "Gris",
                            Model = "24\"",
                            PicsUrl = "roue.jpg",
                            Price = 599.99m,
                            ProductDescription = "Roue haute performance pour rouler plus vite!",
                            ProductName = "Roue de compet'",
                            SellerId = new Guid("c8810229-a2f6-4634-b199-d25318372a0f"),
                            Volume = 1,
                            Weigth = 500
                        });
                });

            modelBuilder.Entity("SportShop.DAL_EF.Entities.Seller", b =>
                {
                    b.Property<Guid>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("UNIQUEIDENTIFIER")
                        .HasColumnName("SellerId");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("NVARCHAR(64)")
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("NVARCHAR(16)")
                        .HasColumnName("Country");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("NVARCHAR(64)")
                        .HasColumnName("Name");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("NVARCHAR(16)")
                        .HasColumnName("Number");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR(128)")
                        .HasColumnName("Street");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("NVARCHAR(8)")
                        .HasColumnName("ZipCode");

                    b.HasKey("SellerId");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            SellerId = new Guid("c8810229-a2f6-4634-b199-d25318372a0f"),
                            City = "Bruxelles",
                            Country = "BELGIUM",
                            Name = "Compet'Seller",
                            Number = "254",
                            Street = "Avenue de l'avenir",
                            ZipCode = "BE1000"
                        },
                        new
                        {
                            SellerId = new Guid("9e603da6-a21c-41fb-970d-c762d52b6700"),
                            City = "London",
                            Country = "UNITEDKINGDOM",
                            Name = "Newbie'Seller",
                            Number = "211",
                            Street = "Backer's street",
                            ZipCode = "UK12000"
                        });
                });

            modelBuilder.Entity("SportShop.DAL_EF.Entities.Product", b =>
                {
                    b.HasOne("SportShop.DAL_EF.Entities.Seller", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("SportShop.DAL_EF.Entities.Seller", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

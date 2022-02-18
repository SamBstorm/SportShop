using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportShop.DAL_EF.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    SellerId = table.Column<Guid>(type: "UNIQUEIDENTIFIER", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(64)", maxLength: 64, nullable: false),
                    City = table.Column<string>(type: "NVARCHAR(64)", maxLength: 64, nullable: false),
                    Street = table.Column<string>(type: "NVARCHAR(128)", maxLength: 128, nullable: false),
                    Number = table.Column<string>(type: "NVARCHAR(16)", maxLength: 16, nullable: false),
                    ZipCode = table.Column<string>(type: "NVARCHAR(8)", maxLength: 8, nullable: false),
                    Country = table.Column<string>(type: "NVARCHAR(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SellerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Reference = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "NVARCHAR(64)", maxLength: 64, nullable: false),
                    ProductDescription = table.Column<string>(type: "NVARCHAR(4000)", maxLength: 4000, nullable: true),
                    PicsUrl = table.Column<string>(type: "VARCHAR(256)", maxLength: 256, nullable: false),
                    SellerId = table.Column<Guid>(type: "UNIQUEIDENTIFIER", nullable: false),
                    Price = table.Column<decimal>(type: "MONEY", nullable: false),
                    Weigth = table.Column<int>(type: "INTEGER", nullable: false),
                    Volume = table.Column<int>(type: "INTEGER", nullable: false),
                    Model = table.Column<string>(type: "NVARCHAR(16)", maxLength: 16, nullable: false),
                    Color = table.Column<string>(type: "NVARCHAR(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Reference);
                    table.ForeignKey(
                        name: "FK_Products_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "SellerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "City", "Country", "Name", "Number", "Street", "ZipCode" },
                values: new object[] { new Guid("c8810229-a2f6-4634-b199-d25318372a0f"), "Bruxelles", "BELGIUM", "Compet'Seller", "254", "Avenue de l'avenir", "BE1000" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "City", "Country", "Name", "Number", "Street", "ZipCode" },
                values: new object[] { new Guid("9e603da6-a21c-41fb-970d-c762d52b6700"), "London", "UNITEDKINGDOM", "Newbie'Seller", "211", "Backer's street", "UK12000" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Reference", "Color", "Model", "PicsUrl", "Price", "ProductDescription", "ProductName", "SellerId", "Volume", "Weigth" },
                values: new object[,]
                {
                    { 1, "Vert", "Pro", "velo.jpg", 1599.99m, "Vélo de compet' tout terrain avec toute les options...", "Vélo de compétition", new Guid("c8810229-a2f6-4634-b199-d25318372a0f"), 3, 4000 },
                    { 2, "Jaune", "XL", "casque.jpg", 19.99m, "Casque pour éviter les bobos...", "Casque de compet'", new Guid("c8810229-a2f6-4634-b199-d25318372a0f"), 1, 500 },
                    { 3, "Bleue", "0.5L", "gourde.jpg", 12.99m, "Gourde pour pouvoir boire quand on veut!", "Gourde de compet'", new Guid("c8810229-a2f6-4634-b199-d25318372a0f"), 1, 100 },
                    { 5, "Gris", "24\"", "roue.jpg", 599.99m, "Roue haute performance pour rouler plus vite!", "Roue de compet'", new Guid("c8810229-a2f6-4634-b199-d25318372a0f"), 1, 500 },
                    { 4, "Jaune", "Enfant", "velo2.jpeg", 599.99m, "Vélo pour bien débuter à tout âge!", "Vélo débutant", new Guid("9e603da6-a21c-41fb-970d-c762d52b6700"), 2, 3000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SellerId",
                table: "Products",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CsLibrary.Plugins.DataStore.SQL.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BeforeQty = table.Column<int>(type: "int", nullable: false),
                    SoldQty = table.Column<int>(type: "int", nullable: false),
                    CashierName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { new Guid("60d70416-906c-4c1c-8f5e-a0183bf6cada"), "Beverage", "Beverage" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { new Guid("e3980339-1e2e-49b2-acd4-bc80d245e446"), "Bakery", "Bakery" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { new Guid("0bfb6c1a-af0c-4a14-848f-f6912a10e2ab"), "Meat", "Meat" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("3645bfdf-16e7-42a4-abdb-cc38c770eb8a"), new Guid("60d70416-906c-4c1c-8f5e-a0183bf6cada"), "Iced Tea", 1.99, 100 },
                    { new Guid("3a8e9167-a66a-4b19-88f7-8c6ed0821229"), new Guid("60d70416-906c-4c1c-8f5e-a0183bf6cada"), "Canada Dry", 1.99, 200 },
                    { new Guid("a3921483-a45e-4cb7-846d-7c28446bf7a6"), new Guid("e3980339-1e2e-49b2-acd4-bc80d245e446"), "Whole Wheat Bread", 1.5, 300 },
                    { new Guid("70fb6660-0bba-428d-a5a7-814eb3b3bf47"), new Guid("e3980339-1e2e-49b2-acd4-bc80d245e446"), "White Bread", 1.5, 300 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

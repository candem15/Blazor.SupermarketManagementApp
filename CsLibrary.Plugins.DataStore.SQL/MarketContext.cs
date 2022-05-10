using System;
using CsLibrary.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace CsLibrary.Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions opt) : base(opt)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany<Product>(p => p.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<Transaction>()
                .HasKey(k => k.TransactionId)
                .HasName("TransactionId");
            //Seed Data for test purpose
            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = new Guid("60d70416-906c-4c1c-8f5e-a0183bf6cada"), Name = "Beverage", Description = "Beverage" },
                    new Category { CategoryId = new Guid("e3980339-1e2e-49b2-acd4-bc80d245e446"), Name = "Bakery", Description = "Bakery" },
                    new Category { CategoryId = new Guid("0bfb6c1a-af0c-4a14-848f-f6912a10e2ab"), Name = "Meat", Description = "Meat" }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product { ProductId = new Guid("3645bfdf-16e7-42a4-abdb-cc38c770eb8a"), CategoryId = new Guid("60d70416-906c-4c1c-8f5e-a0183bf6cada"), Name = "Iced Tea", Quantity = 100, Price = 1.99 },
                    new Product { ProductId = new Guid("3a8e9167-a66a-4b19-88f7-8c6ed0821229"), CategoryId = new Guid("60d70416-906c-4c1c-8f5e-a0183bf6cada"), Name = "Canada Dry", Quantity = 200, Price = 1.99 },
                    new Product { ProductId = new Guid("a3921483-a45e-4cb7-846d-7c28446bf7a6"), CategoryId = new Guid("e3980339-1e2e-49b2-acd4-bc80d245e446"), Name = "Whole Wheat Bread", Quantity = 300, Price = 1.50 },
                    new Product { ProductId = new Guid("70fb6660-0bba-428d-a5a7-814eb3b3bf47 "), CategoryId = new Guid("e3980339-1e2e-49b2-acd4-bc80d245e446"), Name = "White Bread", Quantity = 300, Price = 1.50 }
                );
        }

    }
}

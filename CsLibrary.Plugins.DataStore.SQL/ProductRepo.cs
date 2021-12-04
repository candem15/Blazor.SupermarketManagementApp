using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.Plugins.DataStore.SQL
{
    public class ProductRepo : IProductRepo
    {
        private readonly MarketContext _context;

        public ProductRepo(MarketContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void AddProduct(Product product)
        {
            product.ProductId = Guid.NewGuid();
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product GetProductById(Guid productId)
        {
            return _context.Products.FirstOrDefault(x => x.ProductId == productId);
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate is not null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
                productToUpdate.CategoryId = product.CategoryId;
                _context.Products.Update(productToUpdate);
                _context.SaveChanges();
            }
        }
    }
}
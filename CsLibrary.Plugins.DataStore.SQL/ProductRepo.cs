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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;

namespace CsLibrary.UseCases.DataStorePluginInterfaces
{
    public interface IProductRepo
    {
         public IEnumerable<Product> GetProducts();
         public void AddProduct(Product product);
        public Product GetProductById(Guid productId);
        public void UpdateProduct(Product product);

    }
}
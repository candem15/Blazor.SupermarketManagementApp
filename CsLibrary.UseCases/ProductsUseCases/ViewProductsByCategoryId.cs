using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class ViewProductsByCategoryId : IViewProductsByCategoryId
    {
        private readonly IProductRepo productRepo;

        public ViewProductsByCategoryId(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }
        public IEnumerable<Product> Execute(Guid categoryId)
        {
            var products = productRepo.GetProductsByCategoryId(categoryId);
            return products;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class ViewProductsUseCase : IViewProductsUseCase
    {
        private readonly IProductRepo _repository;

        public ViewProductsUseCase(IProductRepo repository)
        {
            _repository = repository;
        }
        public IEnumerable<Product> Execute()
        {
            return _repository.GetProducts();
        }
    }
}
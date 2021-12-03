using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductRepo _repository;

        public AddProductUseCase(IProductRepo repository)
        {
            _repository = repository;
        }

        public void Execute(Product product)
        {
            _repository.AddProduct(product);
        }

    }
}
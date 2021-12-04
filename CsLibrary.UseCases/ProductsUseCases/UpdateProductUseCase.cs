using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class UpdateProductUseCase : IUpdateProductUseCase
    {
        private readonly IProductRepo _repository;

        public UpdateProductUseCase(IProductRepo repository)
        {
            _repository=repository;
        }
        public void Execute(Product product)
        {
            _repository.UpdateProduct(product);
        }
    }
}
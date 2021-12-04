using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductRepo _repository;

        public DeleteProductUseCase(IProductRepo repository)
        {
            _repository = repository;
        }
        public void Execute(Guid productId)
        {
            _repository.DeleteProduct(productId);
        }
    }
}
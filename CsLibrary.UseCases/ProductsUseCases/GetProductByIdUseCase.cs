using System;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class GetProductByIdUseCase : IGetProductByIdUseCase
    {
        private readonly IProductRepo _repository;

        public GetProductByIdUseCase(IProductRepo repository)
        {
            _repository = repository;
        }
        public Product Execute(Guid productId)
        {
            return _repository.GetProductById(productId);
        }
    }
}
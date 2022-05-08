using System;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepo productRepository;

        public SellProductUseCase(IProductRepo productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Execute(Guid productId, int quantityToSell)
        {
            var product = productRepository.GetProductById(productId);
            product.Quantity -= quantityToSell;
            productRepository.UpdateProduct(product);
        }
    }
}
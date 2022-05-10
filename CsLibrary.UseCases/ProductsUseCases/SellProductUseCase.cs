using System;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepo productRepository;
        private readonly IRecordTransactionUseCase recordTransactionUseCase;

        public SellProductUseCase(IProductRepo productRepository, IRecordTransactionUseCase recordTransactionUseCase)
        {
            this.productRepository = productRepository;
            this.recordTransactionUseCase = recordTransactionUseCase;
        }
        public void Execute(string cashierName, Guid productId, int quantityToSell)
        {
            var product = productRepository.GetProductById(productId);
            product.Quantity -= quantityToSell;
            productRepository.UpdateProduct(product);
            recordTransactionUseCase.Execute(cashierName, productId, quantityToSell);
        }
    }
}
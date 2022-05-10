using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class RecordTransactionUseCase : IRecordTransactionUseCase
    {
        private readonly ITransactionRepo transactionRepo;
        private readonly IGetProductByIdUseCase getProductByIdUseCase;

        public RecordTransactionUseCase(ITransactionRepo transactionRepo, IGetProductByIdUseCase getProductByIdUseCase)
        {
            this.transactionRepo = transactionRepo;
            this.getProductByIdUseCase = getProductByIdUseCase;
        }
        public void Execute(string cashierName, Guid productId, int quantity)
        {
            var product = getProductByIdUseCase.Execute(productId);
            transactionRepo.Save(cashierName, productId, product.Name, product.Price.Value, product.Quantity.Value, quantity);
        }
    }
}
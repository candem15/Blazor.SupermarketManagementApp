using System;

namespace CsLibrary.UseCases
{
    public interface IRecordTransactionUseCase
    {
        public void Execute(string cashierName, Guid productId, int quantity);
    }
}
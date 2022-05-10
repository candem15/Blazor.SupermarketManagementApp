using System;

namespace CsLibrary.UseCases
{
    public interface ISellProductUseCase
    {
        public void Execute(string cashierName, Guid productId, int quantityToSell);
    }
}
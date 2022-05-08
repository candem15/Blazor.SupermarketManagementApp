using System;

namespace CsLibrary.UseCases
{
    public interface ISellProductUseCase
    {
        public void Execute(Guid productId, int quantityToSell);
    }
}
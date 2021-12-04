using System;

namespace CsLibrary.UseCases
{
    public interface IDeleteProductUseCase
    {
        public void Execute(Guid productId);
    }
}
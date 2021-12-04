using System;
using CsLibrary.CoreBusiness;

namespace CsLibrary.UseCases
{
    public interface IGetProductByIdUseCase
    {
        public Product Execute(Guid productId);
    }
}
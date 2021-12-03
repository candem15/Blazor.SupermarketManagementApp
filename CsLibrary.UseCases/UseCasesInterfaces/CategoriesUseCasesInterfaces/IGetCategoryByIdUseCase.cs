using System;
using CsLibrary.CoreBusiness;

namespace CsLibrary.UseCases
{
    public interface IGetCategoryByIdUseCase
    {
        public Category Execute(Guid categoryId);
    }
}
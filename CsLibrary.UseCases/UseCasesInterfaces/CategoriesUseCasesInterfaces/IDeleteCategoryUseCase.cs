using System;

namespace CsLibrary.UseCases
{
    public interface IDeleteCategoryUseCase
    {
        void Execute(Guid categoryId);
    }
}
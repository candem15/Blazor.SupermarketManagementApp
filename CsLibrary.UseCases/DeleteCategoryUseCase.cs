using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepo _repository;

        public DeleteCategoryUseCase(ICategoryRepo repository)
        {
            _repository = repository;
        }
        public void Execute(Guid categoryId)
        {
            _repository.DeleteCategory(categoryId);
        }
    }
}
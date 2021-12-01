using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class UpdateCategoryUseCase : IUpdateCategoryUseCase
    {
        private readonly ICategoryRepo _repository;

        public UpdateCategoryUseCase(ICategoryRepo repository)
        {
            _repository=repository;
        }
        public void Execute(Category category)
        {
            _repository.UpdateCategory(category);
        }
    }
}
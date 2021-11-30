using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class AddCategoryUseCase : IAddCategoryUseCase
    {
        private readonly ICategoryRepo _repository;

        public AddCategoryUseCase(ICategoryRepo repository)
        {
            _repository = repository;
        }

        public void Execute(Category category)
        {
            _repository.AddCategory(category);
        }

    }
}
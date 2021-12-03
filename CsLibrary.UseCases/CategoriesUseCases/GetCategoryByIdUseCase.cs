using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepo _repository;

        public GetCategoryByIdUseCase(ICategoryRepo repository)
        {
            _repository = repository;
        }
        public Category Execute(Guid categoryId)
        {
            return _repository.GetCategoryById(categoryId);
        }
    }
}
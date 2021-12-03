using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;

namespace CsLibrary.UseCases
{
    public interface IAddCategoryUseCase
    {
        void Execute(Category category);
    }
}
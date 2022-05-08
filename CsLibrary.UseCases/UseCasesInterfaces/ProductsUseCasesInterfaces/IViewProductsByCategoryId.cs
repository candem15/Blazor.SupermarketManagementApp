using System;
using System.Collections.Generic;
using CsLibrary.CoreBusiness;

namespace CsLibrary.UseCases
{
    public interface IViewProductsByCategoryId
    {
        public IEnumerable<Product> Execute(Guid categoryId);
    }
}
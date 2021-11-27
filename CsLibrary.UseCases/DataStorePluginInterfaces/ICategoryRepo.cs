using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;

namespace CsLibrary.UseCases.DataStorePluginInterfaces
{
    public interface ICategoryRepo
    {
        public IEnumerable<Category> GetCategories();
    }
}
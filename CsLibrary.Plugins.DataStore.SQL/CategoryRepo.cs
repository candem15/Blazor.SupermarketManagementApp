using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.Plugins.DataStore.SQL
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly MarketContext _context;

        public CategoryRepo(MarketContext context)
        {
            _context = context;
        }

        public void AddCategory(Category category)
        {
            category.CategoryId = Guid.NewGuid();
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
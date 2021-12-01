using CsLibrary.CoreBusiness;

namespace CsLibrary.UseCases
{
    public interface IUpdateCategoryUseCase
    {
        public void Execute(Category category);
    }
}
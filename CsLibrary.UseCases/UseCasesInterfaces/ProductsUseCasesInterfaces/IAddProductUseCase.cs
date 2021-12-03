using CsLibrary.CoreBusiness;

namespace CsLibrary.UseCases
{
    public interface IAddProductUseCase
    {
        public void Execute(Product product);
    }
}
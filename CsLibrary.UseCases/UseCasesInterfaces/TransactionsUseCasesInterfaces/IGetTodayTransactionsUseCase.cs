using System.Collections.Generic;
using CsLibrary.CoreBusiness;

namespace CsLibrary.UseCases
{
    public interface IGetTodayTransactionsUseCase
    {
        public IEnumerable<Transaction> Execute(string cashierName);
    }
}
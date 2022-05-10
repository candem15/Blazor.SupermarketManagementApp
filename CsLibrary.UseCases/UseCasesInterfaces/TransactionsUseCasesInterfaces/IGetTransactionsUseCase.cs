using System;
using System.Collections.Generic;
using CsLibrary.CoreBusiness;

namespace CsLibrary.UseCases
{
    public interface IGetTransactionsUseCase
    {
        public IEnumerable<Transaction> Execute(string cashierName,DateTime startDate,DateTime endDate);
    }
}
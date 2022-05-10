using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class GetTransactionsUseCase : IGetTransactionsUseCase
    {
        private readonly ITransactionRepo transactionRepo;

        public GetTransactionsUseCase(ITransactionRepo transactionRepo)
        {
            this.transactionRepo = transactionRepo;
        }
        public IEnumerable<Transaction> Execute(string cashierName,DateTime startDate,DateTime endDate)
        {
            return transactionRepo.Search(cashierName,startDate,endDate);
        }
    }
}
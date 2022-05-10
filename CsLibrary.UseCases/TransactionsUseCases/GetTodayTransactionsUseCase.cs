using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.UseCases
{
    public class GetTodayTransactionsUseCase : IGetTodayTransactionsUseCase
    {
        private readonly ITransactionRepo transactionRepo;

        public GetTodayTransactionsUseCase(ITransactionRepo transactionRepo)
        {
            this.transactionRepo = transactionRepo;
        }
        public IEnumerable<Transaction> Execute(string cashierName)
        {
            return transactionRepo.GetByDay(cashierName, DateTime.Now);
        }
    }
}
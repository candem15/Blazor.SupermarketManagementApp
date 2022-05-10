using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;
using CsLibrary.UseCases.DataStorePluginInterfaces;

namespace CsLibrary.Plugins.DataStore.SQL
{
    public class TransactionRepo : ITransactionRepo
    {
        private readonly MarketContext context;

        public TransactionRepo(MarketContext context)
        {
            this.context = context;
        }

        public IEnumerable<Transaction> Get(string cashierName)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return context.Transactions;
            else
                return context.Transactions.Where(x =>
                    string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return context.Transactions.Where(x => x.TimeStamp == date.Date);
            else
                return context.Transactions.Where(x => x.CashierName.ToLower() == cashierName.ToLower() && x.TimeStamp.DayOfYear == date.Date.DayOfYear);
        }

        public void Save(string cashierName, Guid productId, string productName, double price, int beforeQty, int soldQty)
        {
            context.Transactions.Add(new Transaction
            {
                TransactionId = Guid.NewGuid(),
                ProductId = productId,
                ProductName = productName,
                TimeStamp = DateTime.Now,
                BeforeQty = beforeQty,
                SoldQty = soldQty,
                Price = price,
                CashierName = cashierName
            });
            context.SaveChanges();
        }
    }
}
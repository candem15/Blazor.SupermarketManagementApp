using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsLibrary.CoreBusiness;

namespace CsLibrary.UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepo
    {
        public IEnumerable<Transaction> Get(string cashierName);
        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date);
        public void Save(string cashierName, Guid productId,string productName, double price, int beforeQty, int soldQty);
    }
}
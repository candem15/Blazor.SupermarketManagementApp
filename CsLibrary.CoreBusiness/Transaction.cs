using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsLibrary.CoreBusiness
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int BeforeQty { get; set; }
        public int SoldQty { get; set; }
        public string CashierName { get; set; }
    }
}
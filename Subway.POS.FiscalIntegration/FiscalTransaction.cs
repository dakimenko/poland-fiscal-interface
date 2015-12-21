using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    /// <summary>
    /// 
    /// </summary>
    public class FiscalTransaction
    {
        public IEnumerable<MenuItemLine> MenuItems { get; set; }

        public decimal Total { get; set; }

        public int OrderId { get; set; }

        public DateTime TransactionDateTime { get; set; }

        public string POSId { get; set; }

        public TransactionType TransactionType { get; set; }

        public IEnumerable<PaymentLine> Payments { get; set; } 
    }
}

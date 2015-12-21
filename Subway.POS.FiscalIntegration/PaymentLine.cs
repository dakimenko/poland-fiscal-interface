using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    /// <summary>
    /// 
    /// </summary>
    public class PaymentLine
    {
        public decimal Amount { get; set; }
        public Tender TenderType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    /// <summary>
    /// 
    /// </summary>
    public class Tender
    {
        public int Id { get; set; }
        public decimal ExchangeRate { get; set; }
        public string Name { get; set; }
        public TenderType Type { get; set; }
    }
}

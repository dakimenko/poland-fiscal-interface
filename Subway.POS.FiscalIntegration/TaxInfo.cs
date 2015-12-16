using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    public class TaxInfo
    {
        public int Id { get; set; }
        public decimal Rate { get; set; }
        public bool Status { get; set; }

    }
}

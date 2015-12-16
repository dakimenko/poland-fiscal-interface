using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    public class MenuItemInfo
    {
        public int Id { get; set; }
        public string PLU { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public TaxInfo TaxInfo { get; set; }
        public bool IsPromotion { get; set; }


    }
}

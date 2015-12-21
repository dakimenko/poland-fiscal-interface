using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    public class MenuItemLine
    {
        public MenuItemInfo MenuItem { get; set; }
        public decimal SalesPrice { get; set; }
        public int Quantity { get; set; }
    }
}

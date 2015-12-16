using System.Collections.Generic;

namespace Subway.POS.FiscalIntegration
{
    public class DeviceInitConfiguration
    {
        public IEnumerable<string> ReceiptHeader { get; set; }
        public IEnumerable<string> ReceiptFooter { get; set; }

        public Dictionary<string, string> CommunicationConfigurationParameters { get; set; }

        public Dictionary<string, string> OperationConfigurationParameters { get; set; }

        public IEnumerable<TaxInfo> TaxTablesConfiguration { get; set; }

        public IEnumerable<MenuItemInfo> MenuItemConfiguration { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration.TestDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new FiscalDeviceFactory();
            var device = factory.CreateFiscalDevice("poland@posnet");
            var configuration = new DeviceInitConfiguration
            {
                ReceiptHeader = new List<string> {"Header Line 1", "header line 2", "Address", "Phone Number"},
                ReceiptFooter = new List<string> {"Footer line 1", "Footer Line 2", "Thank you for shopping at Subway"},
                CommunicationConfigurationParameters = new Dictionary<string, string>
                {
                    {"comport", "COM1"},
                    {"baudrate", "57600"},
                    {"tcpaddress", "1.0.0.1"},
                    {"usb", "true"},
                    {"usbprotocol", "1"}
                },
                OperationConfigurationParameters = new Dictionary<string, string>
                {
                    {"printXReportAfterCashierLogin", "false"},
                    {"linewidth", "5"}
                }
            };

            device.Init(configuration);
        }
    }
}

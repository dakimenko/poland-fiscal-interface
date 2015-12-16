using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    public class DeviceResponseResult : ResponseResultBase
    {
        /// <summary>
        /// Fiscal device status in XML format. ( lasr receipt number, GT amount, device serial number, etc.)
        /// </summary>
        public string DeviceData { get; set; }

    }
}

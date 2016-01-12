using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    public class DeviceResponseResult : ResponseResultBase
    {
        /// <summary>
        /// Available width of non-fiscal report printout (for Application reports formatting)
        /// </summary>
        public int PrintoutWidth { get; set; }

        /// <summary>
        /// Flag to inform operator that receipt paper is near to end 
        /// </summary>
        public bool AddMorePaper { get; set; }

        public string FiscalNumber { get; set; }
    }
}

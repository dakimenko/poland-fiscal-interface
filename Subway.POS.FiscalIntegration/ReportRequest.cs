using System;

namespace Subway.POS.FiscalIntegration
{
    /// <summary>
    /// Represnet a request for a Fiscal Device Report
    /// </summary>
    public class ReportRequest
    {
        /// <summary>
        /// The type of report to request
        /// </summary>
        public ReportType ReportType { get; set; }

        /// <summary>
        /// The starting (date or number) when requesting a report range
        /// The receipt number if requesting only one parameter
        /// </summary>
        public string StartParam { get; set; }

        /// <summary>
        /// The ending (date or number) when requesting a report range
        /// </summary>
        public string EndParam { get; set; }

    }
}

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
        /// The internal receipt number to reprint when requesting a reprint
        /// </summary>
        public int? ReceiptNumber { get; set; }

        /// <summary>
        /// The starting date when requesting a report range
        /// </summary>
        DateTime? StartDate { get; set; }

        /// <summary>
        /// The ending date when requesting a report range
        /// </summary>
        DateTime? EndDate { get; set; }

    }
}

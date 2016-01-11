using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    public enum ReportType
    {
            XReport,
            Zreport,
            PeriodicalReportByDateFull,
            PeriodicalReportByDateSummary,
            PeriodicalReportByNumberFull,
            PeriodicalReportByNumberSummary,
            PeriodicalReportMonthlySalesFull,
            PeriodicalReportMonthlySalesSummary,
            PeriodicalReportAccountingFull,
            PeriodicalReportAccountingSummary,
            ClosureReportReprint,
            ReceiptReprintLast,
            ReceiptReprintByNumber
    }
}

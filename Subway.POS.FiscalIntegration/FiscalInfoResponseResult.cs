namespace Subway.POS.FiscalIntegration
{
    public class FiscalInfoResponseResult : ResponseResultBase
    {

        public int ReceiptNumber { get; set; }

        public decimal GrandTotalSale { get; set; }

        public decimal GrandTotalRefund { get; set; }
    }
}

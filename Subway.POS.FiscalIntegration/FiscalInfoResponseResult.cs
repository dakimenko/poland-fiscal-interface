namespace Subway.POS.FiscalIntegration
{
    public class FiscalInfoResponseResult : ResponseResultBase
    {
        /// <summary>
        /// an xml with the results
        /// </summary>
        public string InfoData { get; set; }
    }
}

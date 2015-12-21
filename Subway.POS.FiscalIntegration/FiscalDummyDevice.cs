using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    class FiscalDummyDevice : IFiscalDevice
    {
        public Status Init(DeviceInitConfiguration configuration)
        {
            throw new NotImplementedException();
        }

        public Status OpenDevice()
        {
            throw new NotImplementedException();
        }

        public Status CloseDevice()
        {
            throw new NotImplementedException();
        }

        public Status OpenBusinessDay(DateTime businessDate)
        {
            throw new NotImplementedException();
        }

        public Status CloseBusinessDay(DateTime businessDate)
        {
            throw new NotImplementedException();
        }

        public Status CashierLogin(string POSIndentifier, int cashierID, string cashierName)
        {
            throw new NotImplementedException();
        }

        public Status CashierLogout(string POSIndentifier, int cashierID, string cashierName)
        {
            throw new NotImplementedException();
        }

        public Status MoneyIn(string POSIndentifier, int cashierID, string cashierName, Tender tenderType, decimal amount)
        {
            throw new NotImplementedException();
        }

        public Status MoneyOut(string POSIndentifier, int cashierID, string cashierName, Tender tenderType, decimal amount)
        {
            throw new NotImplementedException();
        }

        public Status PrintNonFiscalDocument(IEnumerable<string> lines)
        {
            throw new NotImplementedException();
        }

        public FiscalInfoResponseResult GetFiscalInformation()
        {
            throw new NotImplementedException();
        }

        public DateTime GetFiscalTime()
        {
            throw new NotImplementedException();
        }

        public Status LineDisplayOut(IEnumerable<string> lines)
        {
            throw new NotImplementedException();
        }

        public Status OpenCashDrawer()
        {
            throw new NotImplementedException();
        }

        public DeviceResponseResult GetDeviceStatus(DeviceStatusType statusType)
        {
            throw new NotImplementedException();
        }

        public Status PrintFiscalReport(ReportRequest reportRequest)
        {
            throw new NotImplementedException();
        }

        public FiscalInfoResponseResult RegisterFiscalTransaction(FiscalTransaction transaction)
        {
            throw new NotImplementedException();
        }

        public Status GetLastError()
        {
            throw new NotImplementedException();
        }
    }
}

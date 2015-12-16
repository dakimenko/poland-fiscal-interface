using System;
using System.Collections.Generic;
using Subway.POS.FiscalIntegration;

namespace Subway.POS.FiscalIntegration
{
    public class FiscalPolandPosnet : IFiscalDevice
    {
        
        private static readonly Status SuccessStatus = new Status{ErrorCode = ErrorCode.Success, ErrorMessage = "Success"};

        private static readonly FiscalInfoResponseResult FiscalInfoResponseResult = new FiscalInfoResponseResult()
        {
            Response = SuccessStatus,
            InfoData = "<infoData></infoData>"
        };

        private static readonly DeviceResponseResult DeviceResponseResult = new DeviceResponseResult()
        {
            Response = SuccessStatus,
            DeviceData = "<deviceData></deviceData>"           
        };

        public Status Init(DeviceInitConfiguration configuration)
        {
            return SuccessStatus;
        }

        public Status OpenDevice()
        {
            return SuccessStatus;
        }

        public Status CloseDevice()
        {
            return SuccessStatus;
        }

        public Status OpenBusinessDay(DateTime businessDate)
        {
            return SuccessStatus;
        }

        public Status CloseBusinessDay(DateTime businessDate)
        {
            return SuccessStatus;
        }

        public Status CashierLogin(string POSIndentifier, int cashierID, string cashierName)
        {
            return SuccessStatus;
        }

        public Status CashierLogout(string POSIndentifier, int cashierID, string cashierName)
        {
            return SuccessStatus;
        }

        public Status MoneyIn(string POSIndentifier, int cashierID, string cashierName, Tender tenderType, decimal amount)
        {
            return SuccessStatus;
        }

        public Status MoneyOut(string POSIndentifier, int cashierID, string cashierName, Tender tenderType, decimal amount)
        {
            return SuccessStatus;
        }

        public Status PrintNonFiscalDocument(IEnumerable<string> lines)
        {
            return SuccessStatus;
        }

        public FiscalInfoResponseResult GetFiscalInformation()
        {
            return FiscalInfoResponseResult;
        }

        public DateTime GetFiscalTime()
        {
            return DateTime.Now;
        }

        public Status LineDisplayOut(IEnumerable<string> lines)
        {
            return SuccessStatus;
        }

        public Status OpenCashDrawer()
        {
            return SuccessStatus;
        }

        public DeviceResponseResult GetDeviceStatus(DeviceStatusType statusType)
        {
            return DeviceResponseResult;
        }

        public Status PrintFiscalReport(ReportRequest reportRequest)
        {
            return SuccessStatus;
        }

        public FiscalInfoResponseResult RegisterFiscalTransaction(string xmlDocument)
        {
            return FiscalInfoResponseResult;
        }

        public Status GetLastError()
        {
            return SuccessStatus;
        }
    }
}

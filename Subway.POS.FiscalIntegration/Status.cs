using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    public class Status
    {
        public ErrorCode ErrorCode { get; set; }

        public string ErrorMessage { get; set; }
    }

    public enum ErrorCode
    {
        Success = 0,
        Failure = 1,
        DeviceDisconnected = 2,
        TimeSynchronizationWarning = 1000
    }
}

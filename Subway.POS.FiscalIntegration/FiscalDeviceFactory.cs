using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    public class FiscalDeviceFactory
    {
        // device name is the string in format “<Country> @ <printer supplier>”
        // i.e. “poland@posnet” or “PL@POSNET”
        public virtual IFiscalDevice CreateFiscalDevice(string deviceName)
        {
            switch (deviceName)
            {
                case "poland@posnet":
                    return new FiscalPolandPosnet();
                default:
                    return new FiscalDummyDevice();
            }
        }
    }
}

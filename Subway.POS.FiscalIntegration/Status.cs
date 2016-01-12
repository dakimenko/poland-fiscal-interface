using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    public class Status
    {
        /// <summary>
        /// If Success != true  -> Some error happened (critical or not)  
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// If ErrorMessage is not empty - message has to be shown on the POS screen (not depend Success or not)
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// If !Success && IsCritical ->   App should show errorMessage and repeat the operation (or exit the App)
        /// </summary>
        public bool IsCritical { get; set; }
    }

}

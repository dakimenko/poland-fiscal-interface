﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subway.POS.FiscalIntegration
{
    /// <summary>
    /// 
    /// </summary>
    public class PaymentLine
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Tender TenderType { get; set; }

        /// <summary>
        /// Define, is payment line true payment or change
        /// </summary>
        public bool IsChange { get; set; }
    }
}

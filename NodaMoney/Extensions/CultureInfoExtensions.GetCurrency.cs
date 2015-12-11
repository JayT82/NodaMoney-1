using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NodaMoney.Extensions
{
    public static class CultureInfoExtensions
    {
        /// <summary>
        /// This extensionmethod provides a Currency from a CultureInfo
        /// </summary>
        /// <param name="cultureInfo">
        /// this is the provided CultureInfo object as base of getting the ISOCurrencySymbol</param>
        /// <returns>A currency object with properties corresponding to the ISOCurrencySymbol</returns>
        public static Currency GetCurrency(this CultureInfo cultureInfo)
        {   
            return Currency.FromCode(new RegionInfo(cultureInfo.Name).ISOCurrencySymbol);
        }
    }
}

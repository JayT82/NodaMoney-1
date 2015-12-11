using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodaMoney.Extensions
{
    public static class RegionInfoExtensions
    {
        /// <summary>
        /// This extensionmethod provides a Currency from a CultureInfo
        /// </summary>
        /// <param name="regionInfo">
        /// this is the provided RegionIndo object as base of getting the ISOCurrencySymbol</param>
        /// <returns>A currency object with properties corresponding to the ISOCurrencySymbol/Currency.code</returns>
        public static Currency GetCurrency(this RegionInfo regionInfo)
        {
            return Currency.FromCode(regionInfo.ISOCurrencySymbol);
        }
    }
}

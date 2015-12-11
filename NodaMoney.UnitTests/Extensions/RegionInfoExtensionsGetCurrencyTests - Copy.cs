using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

using FluentAssertions;

namespace NodaMoney.UnitTests.Extensions
{
    public class RegionInfoExtensionsGetCurrencyTests
    {
        [TestClass]
        public class GivenIWantToGetCurrencyFromRegionInfoThreeLetterIsoCurrencyName
        {
            

            [TestMethod]
            public void WhenGivenARegionInfo_IShouldGetCorrespondingCurrency()
            {
                RegionInfo regioninfo = new RegionInfo("nl-NL");
                Currency currency;
                string nspace = "ISO-4217";

                bool nspace_and_code_exist_in_registry = new CurrencyRegistry().TryGet(
                    regioninfo.ISOCurrencySymbol,
                    nspace,
                    out currency);

                nspace_and_code_exist_in_registry.ShouldBeEquivalentTo(true);
                currency.Should().NotBe(null);
                currency.Code.ShouldBeEquivalentTo(regioninfo.ISOCurrencySymbol);

            }
        }
    }
}

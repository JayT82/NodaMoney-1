using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

using FluentAssertions;

namespace NodaMoney.UnitTests.Extensions
{
    public class CultureInfoExtensionsGetCurrencyTests
    {
        [TestClass]
        public class GivenIWantToGetCurrencyFromCulturInfoName
        {
            

            [TestMethod]
            public void WhenGivenACultureInfo_IShouldGetCorrespondingCurrency()
            {
                CultureInfo cinfo = new CultureInfo("nl-NL");
                RegionInfo regioninfo = new RegionInfo(cinfo.Name);
                Currency currency;
                string nspace = "ISO-4217";

                bool nspace_and_code_exist_in_registry = new CurrencyRegistry().TryGet(
                    regioninfo.ISOCurrencySymbol,
                    nspace,
                    out currency);

                nspace_and_code_exist_in_registry.ShouldBeEquivalentTo(true);
                currency.Should().NotBe(null);
                currency.Code.ShouldBeEquivalentTo(regioninfo.ISOCurrencySymbol);

                currency.Code.ShouldBeEquivalentTo(Currency.FromCode(new RegionInfo(cinfo.Name).ISOCurrencySymbol).Code);
            }

            [TestMethod]
            public void WhenGivenACultureInfoWithoutExistingCultureName_IShouldGetCultureNotFoundMessage()
            {
            }

            [TestMethod]
            public void WhenGivenACultureInfoWithoutName_IShouldGetCurrencyNotFoundMessage()
            {
            }

        }
    }
}

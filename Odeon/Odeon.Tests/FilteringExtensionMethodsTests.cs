using System.Collections.Generic;
using System.Linq;
using Odeon.Extensions;
using Odeon.Models;
using Xunit;

namespace Odeon.Tests
{
    public class FilteringExtensionMethodsTests
    {
        [Fact]
        public void FilterByCode_Test1()
        {
            var currencies = new List<TcmbCurrencyData>
            {
                new TcmbCurrencyData {CurrencyCode = "USD"},
                new TcmbCurrencyData {CurrencyCode = "TRY"},
                new TcmbCurrencyData {CurrencyCode = "CHF"}
            };

            List<TcmbCurrencyData> result = currencies.FilterByCode("USD");

            Assert.Single(result);
            Assert.Equal("USD", result.First().CurrencyCode);
        }

        [Fact]
        public void FilterByCode_Test2()
        {
            var currencies = new List<TcmbCurrencyData>
            {
                new TcmbCurrencyData {CurrencyCode = "TRY"},
                new TcmbCurrencyData {CurrencyCode = "CHF"}
            };

            List<TcmbCurrencyData> result = currencies.FilterByCode("USD");

            Assert.Empty(result);
        }

        // tests case sensitiveness
        [Fact]
        public void FilterByCode_Test3()
        {
            var currencies = new List<TcmbCurrencyData>
            {
                new TcmbCurrencyData {CurrencyCode = "TRY"},
                new TcmbCurrencyData {CurrencyCode = "CHF"}
            };

            List<TcmbCurrencyData> result = currencies.FilterByCode("try");

            Assert.Empty(result);
        }

        [Fact]
        public void ExcludeNullCrossRateUsd_Test1()
        {
            var currencies = new List<TcmbCurrencyData>
            {
                new TcmbCurrencyData
                {
                    CurrencyNameEnglish = "CHF",
                    CrossRateUsd = null
                }
            };

            List<TcmbCurrencyData> result = currencies.ExcludeNullCrossRateUsd();

            Assert.Empty(result);
        }
    }
}
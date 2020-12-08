using System.Collections.Generic;
using Odeon.Models;
using Xunit;

namespace Odeon.Tests
{
    public class SortingStrategyTests
    {
        [Fact]
        public void SortByNameStrategy_Test()
        {
            var currencies = new List<TcmbCurrencyData>
            {
                new TcmbCurrencyData {CurrencyNameEnglish = "USD"},
                new TcmbCurrencyData {CurrencyNameEnglish = "TRY"},
                new TcmbCurrencyData {CurrencyNameEnglish = "CHF"}
            };

            SortByNameStrategy strategy = new SortByNameStrategy();
            List<TcmbCurrencyData> sortedList = strategy.Sort(currencies);

            Assert.Equal("CHF", sortedList[0].CurrencyNameEnglish);
            Assert.Equal("TRY", sortedList[1].CurrencyNameEnglish);
            Assert.Equal("USD", sortedList[2].CurrencyNameEnglish);
        }

        [Fact]
        public void SortByForexSellingStrategy_Test()
        {
            var currencies = new List<TcmbCurrencyData>
            {
                new TcmbCurrencyData {ForexSelling = 1},
                new TcmbCurrencyData {ForexSelling = 2},
                new TcmbCurrencyData {ForexSelling = 3},
            };

            SortByNameStrategy strategy = new SortByNameStrategy();
            List<TcmbCurrencyData> sortedList = strategy.Sort(currencies);

            Assert.Equal(1, sortedList[0].ForexSelling);
            Assert.Equal(2, sortedList[1].ForexSelling);
            Assert.Equal(3, sortedList[2].ForexSelling);
        }

        [Fact]
        public void DefaultSortingStrategy_Test()
        {
            var currencies = new List<TcmbCurrencyData>
            {
                new TcmbCurrencyData {CurrencyNameEnglish = "USD"},
                new TcmbCurrencyData {CurrencyNameEnglish = "TRY"},
                new TcmbCurrencyData {CurrencyNameEnglish = "CHF"}
            };

            DefaultSortingStrategy strategy = new DefaultSortingStrategy();
            List<TcmbCurrencyData> sortedList = strategy.Sort(currencies);

            Assert.Equal("USD", sortedList[0].CurrencyNameEnglish);
            Assert.Equal("TRY", sortedList[1].CurrencyNameEnglish);
            Assert.Equal("CHF", sortedList[2].CurrencyNameEnglish);
        }
    }
}

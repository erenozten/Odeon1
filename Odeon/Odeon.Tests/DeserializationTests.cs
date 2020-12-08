using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using AutoMapper;
using Odeon.Helpers;
using Odeon.Models;
using Odeon.Models.Xml;
using Xunit;

namespace Odeon.Tests
{
    public class ProfileTests
    {
        [Fact]
        public void Test()
        {
            var parentXml = new TcmbXmlParent()
            {
                Tarih = "22.11.2020",
                Date = "22.11.2020",
                BultenNo = "2020/231",

                Currencies = new[]
                {
                    new TcmbXmlChild()
                    {
                        Tarih = "22.11.2020",
                        Date = "22.11.2020",
                        BultenNo = "2020/231",

                        CrossOrder = "1",
                        Kod = "USD",
                        CurrencyCode = "USD",
                        Unit = "1",

                        CurrencyNameTurkish= "ABD DOLARI",
                        CurrencyNameEnglish = "US DOLLAR",

                        ForexBuying = "2.1",
                        ForexSelling = "1.1",

                        BanknoteBuying = "3.1",
                        BanknoteSelling = "4.1",

                        CrossRateUSD = "1.99",
                        CrossRateOther = "1.33",
                    },
                }
            };

            TcmbCurrencyData resultTcmbCurrencyData = CustomMapper.Map(parentXml).First();

            Assert.Equal(new DateTime(2020, 11, 22), resultTcmbCurrencyData.Tarih);
            Assert.Equal(new DateTime(2020, 11, 22), resultTcmbCurrencyData.Date);
            Assert.Equal("2020/231", parentXml.BultenNo);

            Assert.Equal(1, resultTcmbCurrencyData.CrossOrder);
            Assert.Equal("USD", resultTcmbCurrencyData.Kod);
            Assert.Equal("USD", resultTcmbCurrencyData.CurrencyCode);
            Assert.Equal("1", resultTcmbCurrencyData.Unit);

            Assert.Equal("ABD DOLARI", resultTcmbCurrencyData.CurrencyNameTurkish);
            Assert.Equal("US DOLLAR", resultTcmbCurrencyData.CurrencyNameEnglish);

            Assert.Equal(2.1M, resultTcmbCurrencyData.ForexBuying);
            Assert.Equal(1.1M, resultTcmbCurrencyData.ForexSelling);

            Assert.Equal(3.1M, resultTcmbCurrencyData.BanknoteBuying);
            Assert.Equal(4.1M, resultTcmbCurrencyData.BanknoteSelling);

            Assert.Equal(1.99M, resultTcmbCurrencyData.CrossRateUsd);
            Assert.Equal(1.33M, resultTcmbCurrencyData.CrossRateOther);
        }

        [Fact]
        public void Test2()
        {
            var parentXml = new TcmbXmlParent()
            {
                Tarih = "10.10.2020",
                Date = "10.10.2020",
                Currencies = new[]
                {
                    new TcmbXmlChild()
                    {
                        ForexSelling = "",
                        ForexBuying = "",
                        BanknoteBuying = "",
                        BanknoteSelling = "",
                        CrossRateOther = "",
                        CrossRateUSD = "",
                    },
                }
            };

            TcmbCurrencyData result = CustomMapper.Map(parentXml).First();
            Assert.Equal(new DateTime(2020, 10, 10), result.Tarih);
            Assert.Equal(new DateTime(2020, 10, 10), result.Date);

            Assert.Null(result.ForexSelling);
            Assert.Null(result.ForexBuying);
            Assert.Null(result.BanknoteBuying);
            Assert.Null(result.BanknoteSelling);
            Assert.Null(result.CrossRateOther);
            Assert.Null(result.CrossRateUsd);
        }
    }
}
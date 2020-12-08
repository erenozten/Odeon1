using System;
using System.Collections.Generic;
using System.Globalization;
using Odeon.Models;
using Odeon.Models.Xml;

namespace Odeon.Helpers
{
    public static class CustomMapper
    {
        public static List<TcmbCurrencyData> Map(TcmbXmlParent tcmbXmlParent)
        {
            var result = new List<TcmbCurrencyData>();

            foreach (TcmbXmlChild tcmbXmlChild in tcmbXmlParent.Currencies)
            {
                TcmbCurrencyData tcmbCurrencyData = new TcmbCurrencyData()
                {
                    Tarih = DateTime.ParseExact(tcmbXmlParent.Tarih, "dd/MM/yyyy", new CultureInfo("tr-TR")),
                    Date = DateTime.ParseExact(tcmbXmlParent.Date, "dd/MM/yyyy", new CultureInfo("tr-TR")),
                    BultenNo = tcmbXmlParent.BultenNo,

                    Kod = tcmbXmlChild.Kod,
                    CurrencyCode = tcmbXmlChild.CurrencyCode,
                    Unit = tcmbXmlChild.Unit,

                    CrossOrder = TryParseInt(tcmbXmlChild.CrossOrder),
                    CurrencyNameTurkish = tcmbXmlChild.CurrencyNameTurkish,
                    CurrencyNameEnglish = tcmbXmlChild.CurrencyNameEnglish,

                    ForexBuying = TryParseDecimal(tcmbXmlChild.ForexBuying),
                    ForexSelling = TryParseDecimal(tcmbXmlChild.ForexSelling),

                    BanknoteBuying = TryParseDecimal(tcmbXmlChild.BanknoteBuying),
                    BanknoteSelling = TryParseDecimal(tcmbXmlChild.BanknoteSelling),

                    CrossRateUsd = TryParseDecimal(tcmbXmlChild.CrossRateUSD),
                    CrossRateOther = TryParseDecimal(tcmbXmlChild.CrossRateOther)
                };

                result.Add(tcmbCurrencyData);
            }

            return result;
        }

        private static decimal? TryParseDecimal(string str)
        {
            bool parseResult = decimal.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result);
            if (parseResult)
            {
                return result;
            }

            return null;
        }


        public static int TryParseInt(string gelenText)
        {
            var result = 0;
            var isSuccess = int.TryParse(gelenText, out result);
            if (isSuccess)
            {
                return result;
            }
            return 0;
        }
    }
}

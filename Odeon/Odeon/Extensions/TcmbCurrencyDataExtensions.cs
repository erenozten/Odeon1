using System.Collections.Generic;
using System.Linq;
using Odeon.Models;

namespace Odeon.Extensions
{
    public static class TcmbCurrencyDataFilterExtensions
    {
        public static List<TcmbCurrencyData> FilterByCode(this List<TcmbCurrencyData> list, string code)
        {
            return list.Where(t => t.CurrencyCode == code).OrderBy(c=>c.CrossOrder).ToList();
        }

        public static List<TcmbCurrencyData> ExcludeNullCrossRateUsd(this List<TcmbCurrencyData> list)
        {
            return list.Where(t => t.CrossRateUsd.HasValue).OrderBy(c => c.CrossOrder).ToList();
        }
    }
}
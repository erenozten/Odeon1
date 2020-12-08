using System.Collections.Generic;
using System.Linq;
using Odeon.Models;

namespace Odeon
{
    public class SortByNameStrategy : ISortingStrategy
    {
        public List<TcmbCurrencyData> Sort(List<TcmbCurrencyData> tcmbCurrencyData)
        {
            return tcmbCurrencyData.OrderBy(t => t.CurrencyNameEnglish).ToList();
        }
    }
}
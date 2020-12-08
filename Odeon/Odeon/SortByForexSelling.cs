using System.Collections.Generic;
using System.Linq;
using Odeon.Models;

namespace Odeon
{
    public class SortByForexSelling : ISortingStrategy
    {
        public List<TcmbCurrencyData> Sort(List<TcmbCurrencyData> tcmbCurrencyData)
        {
            return tcmbCurrencyData.OrderBy(t => t.ForexSelling).ToList();
        }
    }
}
using System.Collections.Generic;
using Odeon.Models;

namespace Odeon
{
    public class DefaultSortingStrategy : ISortingStrategy
    {
        public List<TcmbCurrencyData> Sort(List<TcmbCurrencyData> tcmbCurrencyData)
        {
            return tcmbCurrencyData;
        }
    }
}
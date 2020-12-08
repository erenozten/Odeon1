using System.Collections.Generic;
using Odeon.Models;

namespace Odeon
{
    public interface ISortingStrategy
    {
        List<TcmbCurrencyData> Sort(List<TcmbCurrencyData> tcmbCurrencyData);
    }
}
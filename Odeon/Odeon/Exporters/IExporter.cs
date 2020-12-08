using System.Collections.Generic;
using Odeon.Models;

namespace Odeon.Exporters
{
    public interface IExporter
    {
        string Export(List<TcmbCurrencyData> tcmbCurrencyDatas);
    }
}
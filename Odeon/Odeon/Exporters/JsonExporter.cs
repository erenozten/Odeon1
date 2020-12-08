using System;
using System.Collections.Generic;
using Odeon.Models;

namespace Odeon.Exporters
{
    public class JsonExporter : IExporter
    {
        public string Export(List<TcmbCurrencyData> tcmbCurrencyData)
        {
            //var stringAsJson = JsonSerializer.Serialize(tcmbCurrencyData);
            //return stringAsJson;
            throw new NotImplementedException();
        }
    }
}
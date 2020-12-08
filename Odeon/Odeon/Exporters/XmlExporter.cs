using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Odeon.Models;

namespace Odeon.Exporters
{
    public class XmlExporter: IExporter
    {
        private readonly ISortingStrategy _sortingStrategy;

        public XmlExporter(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public string Export(List<TcmbCurrencyData> tcmbCurrencyDatas)
        {
            Type type = typeof(TcmbCurrencyData);
            XmlSerializer serializer = new XmlSerializer(typeof(List<TcmbCurrencyData>));

            using MemoryStream memStream = new MemoryStream();
            using StreamWriter streamWriter = new StreamWriter(memStream);

            serializer.Serialize(streamWriter, tcmbCurrencyDatas);
            var xmlAsString = Encoding.UTF8.GetString(memStream.ToArray());

            return xmlAsString;
        }
    }
}
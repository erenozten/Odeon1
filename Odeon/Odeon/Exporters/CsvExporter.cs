using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using Odeon.Models;

namespace Odeon.Exporters
{
    public class CsvExporter : IExporter
    {
        private readonly ISortingStrategy _sortingStrategy;

        public CsvExporter(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public string Export(List<TcmbCurrencyData> tcmbCurrencyData)
        {
            tcmbCurrencyData = _sortingStrategy.Sort(tcmbCurrencyData);

            using (var memStream = new MemoryStream())
            using (var stream = new StreamReader(memStream))
            using (var writer = new StreamWriter(memStream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(tcmbCurrencyData);
                writer.Flush();
                memStream.Position = 0;
                string csvAsString = stream.ReadToEnd();
                return csvAsString;
            }
        }
    }
}
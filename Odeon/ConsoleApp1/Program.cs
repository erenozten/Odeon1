using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Odeon;
using Odeon.Exporters;
using Odeon.Extensions;
using Odeon.Helpers;
using Odeon.Models;
using Odeon.Models.Xml;
using Odeon.Services;

namespace ConsoleApp1
{
    // Bu console Application'da, oluşturmuş olduğumuz bazı servislerin örnek kullanımları gösterilmektedir.

    class Program
    {
        static async Task Main(string[] args)
        {
            TcmbCurrencyDataService tcmbCurrencyDataService = new TcmbCurrencyDataService(new TcmbDownloader());

            List<TcmbCurrencyData> tcmbCurrencyDataForCsvExport1 = await tcmbCurrencyDataService.GetCurrencyData();
            List<TcmbCurrencyData> tcmbCurrencyDataForCsvExport2 = await tcmbCurrencyDataService.GetCurrencyData();

            CsvExporter csvExporter = new CsvExporter(new SortByNameStrategy());
            CsvExporter csvExporter2 = new CsvExporter(new DefaultSortingStrategy());
            string csvAsString = csvExporter.Export(tcmbCurrencyDataForCsvExport1);
            string csvAsString2 = csvExporter2.Export(tcmbCurrencyDataForCsvExport2);

            List<TcmbCurrencyData> tcmbCurrencyDataForXmlExport1 = await tcmbCurrencyDataService.GetCurrencyData();
            List<TcmbCurrencyData> tcmbCurrencyDataForXmlExport2 = await tcmbCurrencyDataService.GetCurrencyData();

            XmlExporter xmlExporter = new XmlExporter(new SortByNameStrategy());
            XmlExporter xmlExporter2 = new XmlExporter(new SortByForexSelling());
            string xmlAsString = xmlExporter.Export(tcmbCurrencyDataForXmlExport1);
            string xmlAsString2 = xmlExporter2.Export(tcmbCurrencyDataForXmlExport2);

            Sorter sorter = new Sorter();

            List<TcmbCurrencyData> tcmbCurrencyData = await tcmbCurrencyDataService.GetCurrencyData();

            List<TcmbCurrencyData> tcmbCurrencyData1 = sorter.SortByBanknoteBuying(tcmbCurrencyData);
            Console.WriteLine("Data sorted by BanknoteBuying property are shown below (Ascending):\n");
            foreach (var item in tcmbCurrencyData1)
            {
                if (item.BanknoteBuying.HasValue)
                {
                    Console.WriteLine(item.BanknoteBuying);
                }
            }

            List<TcmbCurrencyData> tcmbCurrencyData2 = sorter.SortByBanknoteBuyingDescending(tcmbCurrencyData);
            Console.WriteLine("\nData sorted by BanknoteBuying property are shown below (Descending):\n");
            foreach (var item in tcmbCurrencyData2)
            {
                if (item.BanknoteBuying.HasValue)
                {
                    Console.WriteLine(item.BanknoteBuying);
                }
            }

            List<TcmbCurrencyData> tcmbCurrencyData3 = tcmbCurrencyData.FilterByCode("USD");
            Console.WriteLine("\nData filtered by CurrencyCode property with the text 'USD' and sorted by CrossOrder property are shown below (Ascending):\n");
            foreach (var item in tcmbCurrencyData3)
            {
                if (item.BanknoteBuying.HasValue)
                {
                    Console.WriteLine(item.BanknoteBuying);
                }
            }

            List<TcmbCurrencyData> tcmbCurrencyData4 = tcmbCurrencyData.ExcludeNullCrossRateUsd();
            Console.WriteLine("\nData filtered by excluding null CrossRateUsd property and sorted by CrossOrder property are shown below (Ascending):\n");
            foreach (var item in tcmbCurrencyData4)
            {
                if (item.BanknoteBuying.HasValue)
                {
                    Console.WriteLine(item.BanknoteBuying);
                }
            }
        }
    }
}

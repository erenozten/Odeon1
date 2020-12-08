using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Odeon.Helpers;
using Odeon.Models;
using Odeon.Models.Xml;

namespace Odeon.Services
{
    public class TcmbCurrencyDataService
    {
        private readonly ITcmbDownloader _odeonDownloader;

        public TcmbCurrencyDataService(ITcmbDownloader odeonDownloader)
        {
            _odeonDownloader = odeonDownloader;
        }

        public async Task<List<TcmbCurrencyData>> GetCurrencyData()
        {
            HttpResponseMessage httpResponse = await _odeonDownloader.DownloadCurrencyDataAsync();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TcmbXmlParent));
            Stream stream = await httpResponse.Content.ReadAsStreamAsync();

            TcmbXmlParent tcmbXmlParent = (TcmbXmlParent)xmlSerializer.Deserialize(stream);
            List<TcmbCurrencyData> currencies = CustomMapper.Map(tcmbXmlParent);

            return currencies;
        }
    }
}

using System.Net.Http;
using System.Threading.Tasks;

namespace Odeon
{
    public class TcmbDownloader : ITcmbDownloader
    {
        public const string Url = "https://www.tcmb.gov.tr/kurlar/today.xml";
        public static HttpClient HttpClient = new HttpClient();

        public async Task<HttpResponseMessage> DownloadCurrencyDataAsync()
        {
            HttpResponseMessage responseMessage = await HttpClient.GetAsync(Url);
            return responseMessage;
        }
    }
}
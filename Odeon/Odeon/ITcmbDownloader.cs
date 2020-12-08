using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Odeon
{
    public interface ITcmbDownloader
    {
        Task<HttpResponseMessage> DownloadCurrencyDataAsync();
    }
}
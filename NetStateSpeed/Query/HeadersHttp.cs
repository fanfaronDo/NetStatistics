using System.Net;
using System.Net.Http;


namespace NetStateSpeed
{
    interface IHedersHttp
    {
        public HttpClient GetHeadersHttp();
    }

    class HeadersHttp : IHedersHttp
    {
        
        public HttpClient GetHeadersHttp()
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            };
            var httpClient = new HttpClient(handler);

            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate, sdch");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.133 Safari/537.36");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "en-US,en;q=0.8");

            return httpClient;

        }

        



    }
}

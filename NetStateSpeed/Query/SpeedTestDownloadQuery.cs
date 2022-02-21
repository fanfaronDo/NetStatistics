using System;
using System.Threading.Tasks;

namespace NetStateSpeed.Query
{
    class SpeedTestDownloadQuery
    {
        private static IHedersHttp hedersHttp;

        public async Task<bool> GetDownloadSpeed(string url)
        {
            hedersHttp = new HeadersHttp();

            var response = await hedersHttp.GetHeadersHttp().GetAsync($"{url}?x={Guid.NewGuid()}");

            return response.IsSuccessStatusCode;
        }
    }
}

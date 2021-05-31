using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetStateSpeed.Query
{
    class SpeedTestQuery
    {
        private static IHedersHttp hedersHttp;
        public async Task<bool> GetUploadRes(string url, string payload)
        {
            hedersHttp = new HeadersHttp();

            var response = await hedersHttp.GetHeadersHttp().PostAsync($"{url}?x={Guid.NewGuid()}", new StringContent(payload));

            
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> GetDownloadSpeed(string url)
        {
            hedersHttp = new HeadersHttp();

            var response = await hedersHttp.GetHeadersHttp().GetAsync($"{url}?x={Guid.NewGuid()}");
            
            return response.IsSuccessStatusCode;
        }
    }
}

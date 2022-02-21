using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetStateSpeed.Query
{
    class SpeedTestUploadQuery
    {
        private static IHedersHttp hedersHttp;

        public async Task<bool> GetUploadRes(string url, string payload)
        {
            hedersHttp = new HeadersHttp();

            var response = await hedersHttp.GetHeadersHttp().PostAsync($"{url}?x={Guid.NewGuid()}", new StringContent(payload));

            
            return response.IsSuccessStatusCode;
        }

        
    }
}

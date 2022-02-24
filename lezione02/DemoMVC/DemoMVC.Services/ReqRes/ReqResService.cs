using DemoMVC.Models.ReqRes;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMVC.Services.ReqRes
{
    public class ReqResService : IReqResData
    {
        private readonly IHttpClientFactory httpClientFactory;
        private CancellationTokenSource cancellationTokenSource;

        public ReqResService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public void CancellaRichiesta()
        {
            cancellationTokenSource?.Cancel();
        }

        public async Task<ReqResResponse> Crea(ReqResNewUser newUser)
        {
            var httpClient = httpClientFactory.CreateClient("reqres");
            using var response = await httpClient.PostAsJsonAsync<ReqResNewUser>("users", newUser);
            if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ReqResResponse>();
            } else
            {
                return null;
            }
        }

        public async Task<ReqResData> EstraiDati()
        {
            var httpClient = httpClientFactory.CreateClient("reqres");
            cancellationTokenSource = new CancellationTokenSource();
            using var response = await httpClient.GetAsync("users", HttpCompletionOption.ResponseHeadersRead, cancellationTokenSource.Token);

            if(response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<ReqResData>();
                return data;

            } else
            {
                return null;
            }
        }
    }
}

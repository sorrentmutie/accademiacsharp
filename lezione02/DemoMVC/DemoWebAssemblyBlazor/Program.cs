using DemoMVC.Services.ReqRes;
using DemoMVC.Services.Restaurants;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Polly;

namespace DemoWebAssemblyBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddHttpClient("reqres", client => { client.BaseAddress = new Uri("https://reqres.in/api/"); })
                .AddTransientHttpErrorPolicy(x => x.WaitAndRetryAsync(new[] {TimeSpan.FromSeconds(1),
                TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(20)}));

            builder.Services.AddSingleton<IRestaurantsService, StaticRestaurantsService>();
            builder.Services.AddScoped<IReqResData, ReqResService>();

            await builder.Build().RunAsync();
        }
    }
}

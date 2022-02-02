using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVuotaVersione5.Interfaces;
using WebApplicationVuotaVersione5.Interfaces.Implementations;

namespace WebApplicationVuotaVersione5
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISalute, MockSalute>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ISalute salute, 
            ILogger<Startup> logger )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseWelcomePage();
            app.UseStaticFiles();
            app.Use(async (context,next) => {
                logger.LogCritical("Sono nel mio middleware");
                await next.Invoke();
            });

            app.Use(async (context, next) => {
                logger.LogWarning("Sono nel mio secondo middleware");
                var request = context.Request;
                if (request.Path.StartsWithSegments("/esempio"))
                {
                    await context.Response.WriteAsync("Esci da qui!");
                } else
                {
                    await next.Invoke();
                }
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>  
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync($"{salute.GetSalute()}");
                });
            });
        }
    }
}

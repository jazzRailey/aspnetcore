using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OdeToFood.Services;

namespace OdeToFood
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddScoped<IRestaurantData, InMemoryRestaurantData>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,IConfiguration configuration, IGreeter greeter)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseWelcomePage(new WelcomePageOptions {
                Path = "/wp"
            });
            //// The default file is pointing to index.html
            //app.UseDefaultFiles();
            //// use to serve STATIC Files (e.g. Html, js, css, file
            //app.UseStaticFiles();

            // To replace those 2 lines of codes -- app.UseDefaultFiles(); and app.UseStaticFiles();
            // You may use this line of code instead


            //app.UseMvcWithDefaultRoute();
            //app.UseFileServer();

            app.UseMvc(ConfigureRoutes);

            app.Run(async (context) =>
            {
                //throw new Exception();
                var greetingValue = configuration["Greeting"];
                var greetingFromIGreeter = greeter.GetMessageOfTheDay();
                await context.Response.WriteAsync(greetingValue + " " + greetingFromIGreeter + " And your on the " + env.EnvironmentName + " Environment");
            });
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default",
                    "{controller=Home}/{action=Index}/{id?}");
        }
    }
}

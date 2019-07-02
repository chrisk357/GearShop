using GearShop.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace GearShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
         //    .UseApplicationInsights()
             .UseKestrel()
             .UseContentRoot(Directory.GetCurrentDirectory())
             .UseIISIntegration()
             .UseStartup<Startup>()
             .Build();

            host.Run();
        }







        //   CreateWebHostBuilder(args).Build().Run();


        /*        var host = CreateWebHostBuilder(args).Build();

                    using (var scope = host.Services.CreateScope())
                    {
                        var services = scope.ServiceProvider;
                        try
                        {
                            var context = services.GetRequiredService<AppDbContext>();
                            DbInitializer.Seed(context);
                        }
                        catch (Exception)
                        {
                            //We could log this in a real situation
                        }
                    }
                    host.Run();
                }

                public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
                    WebHost.CreateDefaultBuilder(args)
                        .UseStartup<Startup>();
                        */
    }
}










/*
            var host = BuildWebHost(args);
            SeedDb(host);
            host.Run();
        }
        private static void SeedDb(IWebHost host)
        {
            var scopeFactory = host.Services.GetService<IServiceScopeFactory>();
            using (var scope = scopeFactory.CreateScope())
            {
                var seeder = scope.ServiceProvider.GetService<StoreSeeder>();
                seeder.SeedAsync().Wait();
            }
        }
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(SetupConfiguration)
            .UseStartup<Startup>()
            .Build();

        private static void SetupConfiguration(WebHostBuilderContext ctx, IconfigurationBuilder builder)
        {
            builder.Sources.Clear();
            builder.AddJsonFile("config.json", false, true)
                .AddEnvironmentVariables();
        }
    }

*/

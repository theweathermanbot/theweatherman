using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using TheWeatherman.Api.WebApi.Configuration;

namespace TheWeatherman.Api.WebApi
{
    public class Program
    {
        private static IConfiguration Configuration { get; } = ConfigurationExtension.LoadConfiguration();

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog();
        
        public static void Main(string[] args)
        {
            Log.Logger = ConfigurationExtension.LoadLogger(Configuration);

            try
            {
                Log.Information("Starting TheWeatherman");
                
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "TheWeatherman terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
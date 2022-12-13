using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System;

namespace CeCheng.SmartScenicSpot.Webapi.Controller
{
    /// <summary>
    /// Auth Jason 2022-09-10
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                  .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                  .MinimumLevel.Override("System", LogEventLevel.Warning)
                  .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
                  .Enrich.FromLogContext()
                  .WriteTo.Console().WriteTo.Async(c => c.File("Logs/logs.txt", rollOnFileSizeLimit: true, fileSizeLimitBytes: 1024 * 1024 * 3, retainedFileCountLimit: 50))
                  .CreateLogger();
            try
            {
                Log.Information($"====={DateTime.Now}====Starting CeChengWebApi host==========");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly!");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.ConfigureKestrel(options =>
                    {
                        options.Limits.MaxRequestBodySize = 1024*1024*300;//全局最大文件为300M
                    });
                }).UseServiceProviderFactory(new AutofacServiceProviderFactory()).UseSerilog();
    }
}

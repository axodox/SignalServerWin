using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Globalization;
using System.Threading;

namespace SignalServer.Service
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var culture = new CultureInfo("EN-US");
      Thread.CurrentThread.CurrentCulture = culture;
      CultureInfo.DefaultThreadCurrentCulture = culture;

      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}

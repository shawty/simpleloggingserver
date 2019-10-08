using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace loggingserver.Server
{
  public class Program
  {
    public static void Main(string[] args)
    {
      BuildWebHost(args).Run();
    }

    public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseConfiguration(new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build())
            .UseUrls("http://*:5000/")
            .UseStartup<Startup>()
            .Build();
  }
}

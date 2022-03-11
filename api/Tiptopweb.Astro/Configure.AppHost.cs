using Funq;
using ServiceStack;
using Tiptopweb.Astro.ServiceInterface;

[assembly: HostingStartup(typeof(Tiptopweb.Astro.AppHost))]

namespace Tiptopweb.Astro;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        })        
        .ConfigureAppConfiguration((hostingContext, config) => {
            // we read the settings from AWS Parameter Store
            config.AddSystemsManager("/astro/");
        });

    public AppHost() : base("Tiptopweb.Astro", typeof(AstroServices).Assembly) {}

    public override void Configure(Container container)
    {
        // Configure ServiceStack only IOC, Config & Plugins
        SetConfig(new HostConfig {
            UseSameSiteCookies = true,
        });
    }
}

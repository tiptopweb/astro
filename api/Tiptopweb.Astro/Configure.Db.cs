using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

[assembly: HostingStartup(typeof(Tiptopweb.Astro.ConfigureDb))]

namespace Tiptopweb.Astro
{
    // Example Data Model
    // public class MyTable
    // {
    //     [AutoIncrement]
    //     public int Id { get; set; }
    //     public string Name { get; set; }
    // }

    public class ConfigureDb : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureServices((context, services) => {
                services.AddSingleton<IDbConnectionFactory>(new OrmLiteConnectionFactory(
                    context.Configuration.GetConnectionString("DefaultConnection")
                    ?? "films.sqlite",
                    SqliteDialect.Provider));
            });
            /* Create non-existing Table and add Seed Data Example
            .ConfigureAppHost(appHost => {
                using var db = appHost.Resolve<IDbConnectionFactory>().Open();
                if (db.CreateTableIfNotExists<MyTable>())
                {
                    db.Insert(new MyTable { Name = "Seed Data for new MyTable" });
                }
            });
            */
    }
}

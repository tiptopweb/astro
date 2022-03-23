using ServiceStack.Data;
using ServiceStack.OrmLite;

using Tiptopweb.Astro.ServiceModel.Types;

[assembly: HostingStartup(typeof(Tiptopweb.Astro.ConfigureDb))]

namespace Tiptopweb.Astro
{
    public class ConfigureDb : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureServices((context, services) => {
                 services.AddSingleton<IDbConnectionFactory>(new OrmLiteConnectionFactory(
                     "films.sqlite", SqliteDialect.Provider));
                 
                 //services.AddSingleton<IDbConnectionFactory>(new OrmLiteConnectionFactory(
                 //    context.Configuration.GetConnectionString("DbConnectionString"),
                 //    SqlServerDialect.Provider));
            })
            // Create non-existing Table and add Seed Data Example
            .ConfigureAppHost(appHost => {
                using var db = appHost.Resolve<IDbConnectionFactory>().Open();
                db.CreateTableIfNotExists<Article>();
                db.CreateTableIfNotExists<Media>();
            });
    }
}

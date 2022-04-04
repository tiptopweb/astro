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
                if (db.CreateTableIfNotExists<Article>())
                {
                    var article = new Article
                    {
                        DateCreated = DateTime.Now,
                        UrlKey = "test",
                        EnglishTitle = "The Title",
                        FrenchTitle = "Le Title",
                        Synopsis = "Description",
                        Director = "Bob",
                        Cast = "John, Emma",
                        Year = 2022,
                        Published = true,
                        Deleted = false,
                        Status = 0,
                        Type = 0,
                    };
                    db.Insert(article);
                }
                if (db.CreateTableIfNotExists<Image>())
                {
                    var image = new Image
                    {
                        ArticleId = 1,
                        UrlProxy = string.Empty,
                        Published = true,
                        IsFeatured = false,
                        Deleted = false,
                        Status = 0,
                        Type = 0,
                        DisplayOrder = 1,
                        Name = string.Empty
                    };
                    db.Insert(image);
                }
            });
    }
}

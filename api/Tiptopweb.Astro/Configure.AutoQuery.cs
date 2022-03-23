using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.Configuration;
using Tiptopweb.Astro.ServiceModel.Types;

[assembly: HostingStartup(typeof(Tiptopweb.Astro.ConfigureAutoQuery))]

namespace Tiptopweb.Astro
{
    public class ConfigureAutoQuery : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureAppHost(appHost => {
                
                var skipTables = new List<string>
                {
                    nameof(AppUser),
                    nameof(UserAuthDetails),
                    nameof(UserAuthRole)
                };

                appHost.Plugins.Add(new AutoQueryFeature {
                    GenerateCrudServices = new GenerateCrudServices {
                       AutoRegister = true,
                       ServiceFilter = (op, req) =>
                       {
                           if (op.IsCrud())
                           {
                               //op.Request.AddAttributeIfNotExists(new ValidateRequestAttribute("IsAuthenticated"),
                               //    x => x.Validator == "IsAuthenticated");
                               op.Request.AddAttributeIfNotExists(new ValidateHasRoleAttribute(RoleNames.Admin));
                           }
                       },
                       TypeFilter = (type, req) =>
                       {
                       },
                       IncludeService = op => !skipTables.Any(table => op.ReferencesAny(table))
                    }
                });
                
                // Can use to configure both code-first + generated types
                
                appHost.ConfigureTypes(type =>
                {
                    switch (type.Name)
                    {
                        case nameof(Article):
                             break;
                        
                        case nameof(Image):
                            type.Property("ArticleId").Ref = new() { Model = "Article", RefId = "Id", RefLabel = "EnglishTitle" };
                            break;
                    }
                });
                
            });
    }
}
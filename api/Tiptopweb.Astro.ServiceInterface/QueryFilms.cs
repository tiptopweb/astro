using ServiceStack;
using Tiptopweb.Astro.ServiceModel;
using Tiptopweb.Astro.ServiceModel.Types;

namespace Tiptopweb.Astro.ServiceInterface;

public partial class AstroServices : Service
{
    public object Any(QueryFilms query)
    {
        using var db = AutoQuery.GetDb(query, base.Request);
        var sql = AutoQuery.CreateQuery(query, base.Request, db);

        // additional filtering
        sql = sql.Where<Article>(x => 
            x.ApplicationId == 1 && 
            x.SectionId == 4 &&
            x.Published &&
            !x.Deleted
            );
        
        return AutoQuery.Execute(query, sql, base.Request, db);
    }
}
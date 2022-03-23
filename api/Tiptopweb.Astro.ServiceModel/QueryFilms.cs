using ServiceStack;

using Tiptopweb.Astro.ServiceModel.Types;

namespace Tiptopweb.Astro.ServiceModel;

[Route("/query-films")]
public class QueryFilms : QueryDb<Article>
{
    public int Year { get; set; }
}





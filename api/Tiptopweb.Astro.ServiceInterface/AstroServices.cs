using ServiceStack;

namespace Tiptopweb.Astro.ServiceInterface;

public partial class AstroServices : Service
{
    // for Custom AutoQuery
    public IAutoQueryDb AutoQuery { get; set; }
}
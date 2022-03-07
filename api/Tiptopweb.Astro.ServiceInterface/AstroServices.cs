using ServiceStack;
using Tiptopweb.Astro.ServiceModel;

namespace Tiptopweb.Astro.ServiceInterface;

public class AstroServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }
    
    
}
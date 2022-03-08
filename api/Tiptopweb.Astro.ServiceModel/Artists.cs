using System;
using System.Collections.Generic;

using ServiceStack;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel;

[Route("/find-artists")]
public class FindArtists : QueryDb<Artist>
{
}
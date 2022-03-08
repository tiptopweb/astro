using System;
using System.Collections.Generic;

using ServiceStack.DataAnnotations;

namespace Tiptopweb.Astro.ServiceModel;

[Alias("Albums")]
public class Album
{
    [AutoIncrement]
    public long AlbumId { get; set; }

    [Required]
    public string Title { get; set; }

    public long ArtistId { get; set; }

    [Reference]
    public List<Track> Tracks { get; set; } 
}

[Alias("Artists")]
public class Artist
{
    [AutoIncrement]
    public long ArtistId { get; set; }

    public string Name { get; set; }
    
    [Reference]
    public List<Album> Albums { get; set; } 
}

[Alias("Tracks")]
public class Track
{
    [AutoIncrement]
    public long TrackId { get; set; }

    [Required]
    public string Name { get; set; }

    public long? AlbumId { get; set; }
    public long MediaTypeId { get; set; }
    public long? GenreId { get; set; }
    public string Composer { get; set; }
    public long Milliseconds { get; set; }
    public long? Bytes { get; set; }
    public decimal UnitPrice { get; set; }
}
using System;
using ServiceStack.DataAnnotations;

using ServiceStack.Model;
using System.Collections.Generic;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwLocation")]
    public partial class Location : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int ZoneId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int OldId { get; set; }
        public string ListYears { get; set; }
        [Required]
        public int LinkType { get; set; }              // 1: palace smart link, 2: orpheum
        public string LinkCinemaId { get; set; }
        public string Slug { get; set; }               // For Palace API

        public LocationParam CpxParam { get; set; }

        public Location()
        {
            CpxParam = new LocationParam();
        }
    }

    public class LocationParam
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Postcode { get; set; }
        public string Phone { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        
        // from the API
        public List<LocationScreen> Screens { get; set; }
    }

    public class LocationScreen
    {
        public int Number { get; set; }
        public int SeatsAvailable { get; set; }
        public int CapacityPourcent { get; set; }
    }
}

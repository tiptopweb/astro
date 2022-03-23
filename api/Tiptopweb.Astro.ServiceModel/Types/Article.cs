using System;
using System.Collections.Generic;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    public partial class Article : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public Guid Guid { get; set; }
        [Required]
        public string UrlKey { get; set; }
        [Required]
        public string EnglishTitle { get; set; }
        public string FrenchTitle { get; set; }
        public string Synopsis { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public int Year { get; set; }
        [Required]
        public bool Published { get; set; }
        [Required]
        public bool Deleted { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public int Type { get; set; }
        
        [Reference]
        public List<Media> Media { get; set; } 
    }
}

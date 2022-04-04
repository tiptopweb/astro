using System;
using System.Collections.Generic;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    public class Article
    {
        [AutoIncrement]
        public long Id { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }    

        [Required]
        public string UrlKey { get; set; }
        
        [Required]
        public string EnglishTitle { get; set; }
        
        public string FrenchTitle { get; set; }
        
        public string Synopsis { get; set; }
        
        public string Director { get; set; }
        
        public string Cast { get; set; }
        
        public long Year { get; set; }
        
        [Required]
        public bool Published { get; set; }
        
        [Required]
        public bool Deleted { get; set; }
        
        [Required]
        public long Status { get; set; }
        
        [Required]
        public long Type { get; set; }
        
        [Reference]
        public List<Image> Images { get; set; } 
    }
}

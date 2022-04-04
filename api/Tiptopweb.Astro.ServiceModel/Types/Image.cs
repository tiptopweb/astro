using System;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    public class Image
    {
        [AutoIncrement]
        public long Id { get; set; }
        
        [Required]
        public long ArticleId { get; set; }
        
        [Required]
        public string UrlProxy { get; set; }    

        [Required]
        public bool Published { get; set; }
        
        [Required]
        public bool IsFeatured { get; set; }
        
        [Required]
        public bool Deleted { get; set; }
        
        [Required]
        public long Status { get; set; }
        
        [Required]
        public long Type { get; set; }
        
        [Required]
        public long DisplayOrder { get; set; }
        
        public string Name { get; set; }          
    }
}

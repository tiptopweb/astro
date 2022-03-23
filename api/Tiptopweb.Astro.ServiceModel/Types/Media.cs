using System;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    public partial class Media : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int ArticleId { get; set; }
        [Required]
        public Guid Guid { get; set; }
        [Required]
        public string UrlCdn { get; set; }        
        [Required]
        public string UrlProxy { get; set; }        
        [Required]
        public bool Published { get; set; }
        [Required]
        public bool IsFeatured { get; set; }
        [Required]
        public bool Deleted { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        public string Name { get; set; }          
    }
}

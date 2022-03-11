using System;

using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwMediaMapping")]
    public partial class MediaMapping : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int FromSectionId { get; set; }
        [Required]
        public int ToSectionId { get; set; }
        [Required]
        public int FromMediaId { get; set; }
        [Required]
        public int ToArticleId { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        [Required]
        public bool Published { get; set; }
        [Required]
        public bool Deleted { get; set; }
        [Required]
        public bool IsFeatured { get; set; }

        public MediaMappingParam CpxParam { get; set; }

        public MediaMapping()
        {
            CpxParam = new MediaMappingParam();
        }
    }

    public class MediaMappingParam
    {
    }

}

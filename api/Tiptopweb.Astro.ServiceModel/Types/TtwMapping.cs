using System;

using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwMapping")]
    public partial class Mapping : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int FromSectionId { get; set; }
        [Required]
        public int ToSectionId { get; set; }
        [Required]
        public int FromArticleId { get; set; }
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

        public MappingParam CpxParam { get; set; }

        public Mapping()
        {
            CpxParam = new MappingParam();
        }
    }

    public class MappingParam
    {
    }

}

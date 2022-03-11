using System;

using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwSection")]
    public partial class Section : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public Guid Guid { get; set; }
        public string UrlKey { get; set; }
        public string Name { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        [Required]
        public int OldId { get; set; }

        public SectionParam CpxParam { get; set; }

        public Section()
        {
            CpxParam = new SectionParam();
        }
    }

    public class SectionParam
    {
    }

}

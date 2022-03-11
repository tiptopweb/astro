using System;

using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwSectionMapping")]
    public partial class TtwSectionMapping : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int FromSectionId { get; set; }
        [Required]
        public int ToSectionId { get; set; }
    }
}

using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwFilter")]
    public partial class Filter : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UrlKey { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        [Required]
        public FilterParam CpxParam { get; set; }

        public Filter()
        {
            CpxParam = new FilterParam();
        }
    }

    public class FilterParam
    {
    }

}

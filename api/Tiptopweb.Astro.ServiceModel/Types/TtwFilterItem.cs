using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwFilterItem")]
    public partial class FilterItem : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int FilterId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UrlKey { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        [Required]
        public FilterItemParam CpxParam { get; set; }

        public FilterItem()
        {
            CpxParam = new FilterItemParam();
        }
    }

    public class FilterItemParam
    {
    }

}

using System;

using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwZone")]
    public partial class Zone : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public string Name { get; set; }
        public string UrlKey { get; set; }
        [Required]
        public int OldId { get; set; }
        public string ListYears { get; set; }

        public ZoneParam CpxParam { get; set; }

        public Zone()
        {
            CpxParam = new ZoneParam();
        }
    }

    public class ZoneParam
    {

    }

}

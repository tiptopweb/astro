using System;

using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwZoneInfo")]
    public partial class ZoneInfo : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int ZoneId { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public ZoneInfoParam CpxParam { get; set; }

        public ZoneInfo()
        {
            CpxParam = new ZoneInfoParam();
        }
    }

    public class ZoneInfoParam
    {
        public int HighlightsArticleId { get; set; }
        public int ScheduleArticleId { get; set; }
        public int TicketingArticleId { get; set; }
        public int SponsorsArticleId { get; set; }
        public int SchoolScreeningsArticleId { get; set; }
        public int FilmsArticleId { get; set; }
        public bool HasProgram { get; set; }
        public string ProgramFileName { get; set; }
        public string StartDate { get; set; } // to remove
        public string EndDate { get; set; } // to remove
        public DateTime? FestivalStart { get; set; }
        public DateTime? FestivalEnd { get; set; }
    }

}

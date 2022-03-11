using System;
using System.Collections.Generic;

using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwSession")]
    public partial class Session : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int ArticleId { get; set; }
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public DateTime SessionStart { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int OldId { get; set; }

        [Required]
        public SessionParam CpxParam { get; set; }

        public Session()
        {
            CpxParam = new SessionParam();
        }
    }

    public class SessionParam
    {
        public string BuyLink { get; set; }
        public string Text { get; set; }
        public bool Part2 { get; set; }

        // from the API, we can have several Palace sessions (different screens)
        public List<PalaceSession> PalaceSessions { get; set; }
    }

    public class PalaceSession
    {
        public string SessionId { get; set; }
        public int SeatsAvailable { get; set; }
        public int ScreenNumber { get; set; }
    }

    // For the Schedule 

    public class ScheduleDay
    {
        public int DayOfYear { get; set; }
        public List<ScheduleSession> Sessions { get; set; }
    }

    public class ScheduleSession
    {
        public int Type { get; set; }
        public int LocationId { get; set; }
        public int DayId { get; set; }
        public string TimeCode { get; set; }
        public int FilmId { get; set; }
        public int CategoryId { get; set; }
        public List<int> TrendIds { get; set; }
        public List<int> GenreIds { get; set; }
    }

}

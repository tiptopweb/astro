using System;
using System.Collections.Generic;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwArticle")]
    public partial class Article : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int ParentId { get; set; }
        [Required]
        public int SectionId { get; set; }
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public int ZoneId { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public Guid Guid { get; set; }
        public string UrlKey { get; set; }
        public string Name { get; set; }
        public string Keywords { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? DateLastUpdate { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
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
        public int Depth { get; set; }
        [Required]
        public int OldId { get; set; }

        public ArticleTitle CpxTitle { get; set; }
        public ArticleText CpxText { get; set; }
        public ArticleParam CpxParam { get; set; }

        public Article()
        {
            CpxTitle = new ArticleTitle();
            CpxText = new ArticleText();
            CpxParam = new ArticleParam();
        }
        
        [Reference]
        public List<Media> Media { get; set; } 
    }

    public class ArticleTitle
    {
        public string EnglishTitle { get; set; }
        public string FrenchTitle { get; set; }
        public string ChineseTitle { get; set; }
    }

    public class ArticleText
    {
        public string EnglishSynopsis { get; set; }
        public string FrenchSynopsis { get; set; }
        public string ChineseSynopsis { get; set; }
        public string AdditionalSynopsis { get; set; }
        public string Body { get; set; }
        public string Summary { get; set; }
        public string Additional { get; set; }
        public string DecodedBody { get; set; } // to remove
    }

    public class ArticleParam
    {
        public string Director { get; set; }
        public string Cast { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string Duration { get; set; }
        public string Country { get; set; }
        public string Rating { get; set; }
        public string Caption { get; set; }
        public string Language { get; set; }

        public bool AuPremiere { get; set; }
        public bool HasVideo { get; set; }
        public bool HasPoster { get; set; }

        public int CategoryId { get; set; }
        public List<int> ListTrendIds { get; set; }
        public List<int> ListGenreIds { get; set; }
        public List<int> ListFilterTypeIds { get; set; }

        public int[] Recommendations { get; set; }

        public Tuple<string, string>[] Awards { get; set; }
        public Tuple<string, string>[] Quotes { get; set; }

        public string LabelCast { get; set; }   // default is STARRING, sometimes we want to replace it

        // code from cinema
        public string PalaceHoCode { get; set; }
        public string PalaceHoCode2 { get; set; }
        public string OrpheumCode { get; set; }
        public string RiversideCode { get; set; }

        // for HK
        public string YoutubeId { get; set; }
        public string FerveUrl { get; set; }

        // For SEO
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }


        public ArticleParam()
        {
            Recommendations = new int[3];
        }
    }
}

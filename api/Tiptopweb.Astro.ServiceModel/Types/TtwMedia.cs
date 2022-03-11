using System;
using System.Collections.Generic;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace Tiptopweb.Astro.ServiceModel.Types
{
    [Alias("TtwMedia")]
    public partial class Media : IHasId<int>
    {
        [Alias("Id")]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int ArticleId { get; set; }
        public string Name { get; set; }          // we will use this to replace the name via proxy
        public string UrlKey { get; set; }        // we will use this to replace the name via proxy
        [Required]
        public Guid Guid { get; set; }
        public DateTime? DateCreated { get; set; }
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
        public int DisplayOrder { get; set; }
        [Required]
        public int OldId { get; set; }

        public MediaParam CpxParam { get; set; }

        public Media()
        {
            CpxParam = new MediaParam();
        }
    }

    public class MediaParam
    {
        public string BlobContainer { get; set; }

        // info about file uploaded
        public string OriginalExtension { get; set; }
        public string OriginalMimeType { get; set; }
        public string OriginalName { get; set; }
        public bool IsVertical { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }

        // Display Parameters
        public string Title { get; set; }  // for alt-tag
        public string LinkUrl { get; set; }
        public int Col { get; set; }
        public int ColSm { get; set; }

        public Dictionary<string, MediaImage> Images { get; set; }   // we use a Dictionary to have "small", "large" definitions to get to the images

        public MediaParam()
        {
            Images = new Dictionary<string, MediaImage>();
        }
    }

    public class MediaImage
    {
        public string BlobFileName { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public string Extension { get; set; }
        public string MimeType { get; set; }
        public int ProcessingType { get; set; }

        // remove later
        public string Title { get; set; }  // for alt-tag
        public string LinkUrl { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hayna.AlumniProfileEntries.Web.Areas.Manage.Models.Posts
{
    public class ThumbnailViewModel
    {
        public Guid? PostId { get; set; }
        public IFormFile Thumbnail { get; set; }
    }
}
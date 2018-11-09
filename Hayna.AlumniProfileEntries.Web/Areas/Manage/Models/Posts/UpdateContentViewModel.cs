using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hayna.AlumniProfileEntries.Web.Areas.Manage.Models.Posts
{
    public class UpdateContentViewModel
    {
        public Guid? PostId { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
    }
}
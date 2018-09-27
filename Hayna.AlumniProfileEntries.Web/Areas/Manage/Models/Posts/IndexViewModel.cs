using Hayna.AlumniProfileEntries.Web.Infrastructures.Data.Helpers;
using Hayna.AlumniProfileEntries.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hayna.AlumniProfileEntries.Web.Areas.Manage.Models.Posts
{
    public class IndexViewModel
    {
        public Page<Post> Posts { get; set; }
    }
}


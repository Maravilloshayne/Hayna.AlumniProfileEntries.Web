using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hayna.AlumniProfileEntries.Web.Areas.Manage.Models.Posts
{
    public class UpdateTitleViewModel
    {
        public Guid? Id { get; set; }

        public string Company { get; set; }

        public string Position { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public DateTime ToDate { get; set; }

        
    }
}
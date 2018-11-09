using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hayna.AlumniProfileEntries.Web.VIewModels
{
    public class PostViewModel
    {
        public Guid? PostId { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
    }
}
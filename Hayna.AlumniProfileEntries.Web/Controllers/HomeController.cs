using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hayna.AlumniProfileEntries.Web.Models;
using Hayna.AlumniProfileEntries.Web.Infrastructures.Data.Helpers;
using Hayna.AlumniProfileEntries.Web.Infrastructures.Data.Models;

namespace Hayna.AlumniProfileEntries.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly DefaultDbContext _context;

        public HomeController(DefaultDbContext context)
        {
            _context = _context;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Init()
        {
            var post = this._context.Posts.FirstOrDefault();

            if (post == null)
            {
                Post post1 = new Post()
                {
                    Id = Guid.Parse("3a88bea9-8a65-4c23-941a-972a6195b940"),
                    Description = @"The International 2018 was the eight iteration of 
                                Dota 2's flagship annual championship. Hosted by Valve Corporation,
                                it took place at the Rogers Arena in Vancouver,
                                British Columbia, being the first to be celebrated 
                                outside of the United States.",
                  IsPublished = true,
                    Position = "Worker",
                    ToDate = DateTime.UtcNow,
                    Location = "CSM BATAAN",
                    Timestamp = DateTime.UtcNow,
                    Company= "Lakad Matatag!!!"
                };
                this._context.Posts.Add(post1);


                Post post2 = new Post()
                {
                    Id = Guid.Parse("3a88bea9-8a65-4c23-941a-972a6195b940"),
                    Description = @"The International 2018 was the eight iteration of 
                                Dota 2's flagship annual championship. Hosted by Valve Corporation,
                                it took place at the Rogers Arena in Vancouver,
                                British Columbia, being the first to be celebrated 
                                outside of the United States.",
                    IsPublished = true,
                    Position = "Worker2",
                    ToDate = DateTime.UtcNow,
                    Location = "CSM BATAAN",
                    Timestamp = DateTime.UtcNow,
                    Company = "Exbatallion"
                };
                this._context.Posts.Add(post2);

                Post post3 = new Post()
                {
                    Id = Guid.Parse("3a88bea9-8a65-4c23-941a-972a6195b940"),
                    Description = @"The International 2018 was the eight iteration of 
                                Dota 2's flagship annual championship. Hosted by Valve Corporation,
                                it took place at the Rogers Arena in Vancouver,
                                British Columbia, being the first to be celebrated 
                                outside of the United States.",
                    IsPublished = true,
                    Position = "Worker3",
                    ToDate = DateTime.UtcNow,
                    Location = "CSM BATAAN",
                    Timestamp = DateTime.UtcNow,
                    Company = "HypeBeast!!!"
                };
                this._context.Posts.Add(post3);

                this._context.SaveChanges();
            }

            return RedirectPermanent("~/posts/index");
}


[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

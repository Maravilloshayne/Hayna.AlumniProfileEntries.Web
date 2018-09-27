﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hayna.AlumniProfileEntries.Web.Infrastructures.Data.Helpers;
using Hayna.AlumniProfileEntries.Web.VIewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hayna.AlumniProfileEntries.Web.Controllers
{
    public class PostsController : Controller
    {
        private readonly DefaultDbContext _context;

        public PostsController(DefaultDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(new IndexViewModel()
            {
                Posts = this._context.Posts.ToList()
            });
        }

        public IActionResult Post(Guid? postId)
        {
            return View();
        }

        public IActionResult Carousel()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }
    }
}
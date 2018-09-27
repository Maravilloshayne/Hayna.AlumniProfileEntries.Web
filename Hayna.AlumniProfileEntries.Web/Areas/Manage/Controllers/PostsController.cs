﻿using Hayna.AlumniProfileEntries.Web.Areas.Manage.Models.Posts;
using Hayna.AlumniProfileEntries.Web.Infrastructures.Data.Helpers;
using Hayna.AlumniProfileEntries.Web.Infrastructures.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hayna.AlumniProfileEntries.Web.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class PostsController : Controller
    {
        private readonly DefaultDbContext _context;

        public PostsController(DefaultDbContext context)
        {
            _context = context;
        }


        [HttpGet, Route("manage/posts/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("manage/posts/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            Post post = new Post()
            {
                Id = Guid.NewGuid(),
                Position = model.Position,
                Company = model.Company,
                Description = model.Description,
                 Location = model.Location,
                ToDate = model.ToDate,
            };

            this._context.Posts.Add(post);
            this._context.SaveChanges();

            return View();
        }


        [HttpGet, Route("manage/posts/index")]
        [HttpGet, Route("manage/posts")]
        public IActionResult Index(int pageIndex = 1, int pageSize = 2, string keyword = "")
        {
            Page<Post> result = new Page<Post>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Post> postQuery = (IQueryable<Post>)this._context.Posts;

            if (string.IsNullOrEmpty(keyword) == false)
            {
                postQuery = postQuery.Where(u => u.Company.ToLower().Contains(keyword.ToLower()));
            }

            long queryCount = postQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Post> users = postQuery.ToList();

            result.Items = users.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Posts = result
            });
        }

    }
}
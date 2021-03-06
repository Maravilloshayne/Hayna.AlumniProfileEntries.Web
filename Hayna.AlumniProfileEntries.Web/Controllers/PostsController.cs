﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hayna.AlumniProfileEntries.Web.Infrastructures.Data.Helpers;
using Hayna.AlumniProfileEntries.Web.VIewModels;
using Microsoft.AspNetCore.Mvc;
using CodeKicker.BBCode;

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

        [HttpGet, Route("/posts/index/{postId}")]
        public IActionResult Post(Guid? postId)
        {
            var post = this._context.Posts.FirstOrDefault(p => p.Id == postId);
            if (post != null)
            {
                return View(new PostViewModel()
                {
                    PostId = post.Id,
                    Company = post.Company,
                    Description = ParseBBCode(post.Description)
                });
            }
            return StatusCode(404);
        }
        public string ParseBBCode(string bbcode)
        {
            var parser = new BBCodeParser(new[]
                {
                    new BBTag("img", "<img src=\"${content}\" />", "", false, true),
                    new BBTag("b", "<strong>", "</strong>"),
                    new BBTag("color","<font  color=\"${color}\">","</font >", new BBAttribute("color", ""), new BBAttribute("color", "color")),
                    new BBTag("i", "<span style=\"font-style:italic;\">", "</span>"),
                    new BBTag("u", "<span style=\"text-decoration:underline;\">", "</span>"),
                    new BBTag("code", "<pre class=\"prettyprint\">", "</pre>"),
                    new BBTag("quote", "<blockquote>", "</blockquote>"),
                    new BBTag("list", "<ul>", "</ul>"),
                    new BBTag("*", "<li>", "</li>", true, false),
                    new BBTag("url", "<a href=\"${href}\">", "</a>", new BBAttribute("href", ""), new BBAttribute("href", "href")),
                    new BBTag("youtube", "<div class='video'><iframe width='550px' height='309px' src='//www.youtube.com/embed/${content}' allowFullScreen></iframe></div>","", false, true),
                });
            return parser.ToHtml(bbcode);
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
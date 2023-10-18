﻿using Blogger.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace Blogger.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async Task<IActionResult> Index()
        { 
            var articles=await articleService.GetAllArticlesAsync();
            return View(articles);
        }
    }
}

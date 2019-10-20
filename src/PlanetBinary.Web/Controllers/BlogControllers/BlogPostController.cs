using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PlanetBinary.Web.Controllers.BlogControllers
{
    public class BlogPostController : Controller
    {
		private readonly BlogPostService _BlogPostService;


		[Route ("Blog")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
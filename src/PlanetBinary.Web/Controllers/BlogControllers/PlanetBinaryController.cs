using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace PlanetBinary.Web.Controllers.BlogControllers
{
    public class PlanetBinaryController : Controller
    {
        protected ILogger<ControllerBase> Logger { get; }

		public PlanetBinaryController(ILogger<ControllerBase> logger)
		{
			if (null != logger) Logger = logger;
		}

		protected string GetPostUrl(LinkGenerator linkGenerator, DateTime publishDate, string postSlug)
		{
			var link = linkGenerator.GetUriByAction(HttpContext, action: "Slug", controller: "Post",
				values: new
				{
					year = publishDate.Year,
					month = publishDate.Month,
					day = publishDate.Day,
					postSlug = postSlug
				});
			return link;
		}

    }
}
using MVCBlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogSite.Controllers
{
	public class PostsController : Controller
	{
		DatabaseContext context = new DatabaseContext();
		// GET: Posts
		public ActionResult Index()
		{
			return View(context.Posts.ToList());
		}
		public ActionResult Detail(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			var data = context.Posts.Find(id);
			if (data == null)
			{
				return HttpNotFound();
			}

			return View(data);
		}
	}
}

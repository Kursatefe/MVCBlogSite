using MVCBlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogSite.Areas.Admin.Controllers
{
	[Authorize]


	public class PostsController : Controller
	{
		DatabaseContext context = new DatabaseContext();
		// GET: Admin/Posts
		public ActionResult Index()
		{
			return View(context.Posts.ToList());
		}

		// GET: Admin/Posts/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Admin/Posts/Create
		public ActionResult Create()
		{
			ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
			return View();
		}

		// POST: Admin/Posts/Create
		[HttpPost]
		public ActionResult Create(Post collection, HttpPostedFileBase Image)
		{
			if (ModelState.IsValid)
			{
				try
				{
					if (Image != null)
					{
						collection.Image = Image.FileName;
						Image.SaveAs(Server.MapPath("/Images/" + Image.FileName));
					}
					context.Posts.Add(collection);
					context.SaveChanges();

					return RedirectToAction("Index");
				}
				catch
				{
					ModelState.AddModelError("", "Hata Oluştu!");
				}
			}
			ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
			return View(collection);
		}

		// GET: Admin/Posts/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Admin/Posts/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Admin/Posts/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Admin/Posts/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}

using MVCBlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogSite.Areas.Admin.Controllers
{
	[Authorize]
	public class CategoriesController : Controller
	{
		private DatabaseContext context = new DatabaseContext();

		// GET: Admin/Categories
		public ActionResult Index()
		{
			var categories = context.Categories.ToList();
			return View(categories);
		}

		// GET: Admin/Categories/Details/5
		public ActionResult Details(int id)
		{
			var category = context.Categories.Find(id);
			return View(category);
		}

		// GET: Admin/Categories/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Admin/Categories/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Category category)
		{
			if (ModelState.IsValid)
			{
				context.Categories.Add(category);
				context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(category);
		}

		// GET: Admin/Categories/Edit/5
		public ActionResult Edit(int id)
		{
			var category = context.Categories.Find(id);
			return View(category);
		}

		// POST: Admin/Categories/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(Category category)
		{
			if (ModelState.IsValid)
			{
				context.Entry(category).State = System.Data.Entity.EntityState.Modified;
				context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(category);
		}

		// GET: Admin/Categories/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				// id null ise, hata işleme veya uygun bir yanıt döndürme
			}
			else
			{
				// id null değilse, normal işlemlere devam etme
			}
			var category = context.Categories.Find(id);
			return View(category);
		}

		// POST: Admin/Categories/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Category collection)
		{
			try
			{
				var data = context.Categories.Find(id);
				context.Categories.Remove(data);
				context.SaveChanges();

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}

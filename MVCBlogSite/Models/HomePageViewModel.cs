using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBlogSite.Models
{
	public class HomePageViewModel
	{
		public List<Category> Categories { get; set; }
		public List<Post> Posts { get; set; }
	}
}
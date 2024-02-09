using System;
using System.Data.Entity;
using System.Linq;

namespace MVCBlogSite.Models
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<User> Users { get; set; }


	}
}
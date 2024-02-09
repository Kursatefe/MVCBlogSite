namespace MVCBlogSite.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<MVCBlogSite.Models.DatabaseContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(MVCBlogSite.Models.DatabaseContext context)
		{
			if (!context.Users.Any())
			{
				context.Users.Add(
					new Models.User()
					{
						Email = "admin@mvckurumsal.net",
						IsActive = true,
						IsAdmin = true,
						Name = "Admin",
						Surname = "User",
						Password = "Admin123"
					}
					);
				context.SaveChanges();
			}
		}
	}
}

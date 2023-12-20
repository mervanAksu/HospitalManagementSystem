using Hospital.Models;
using Hospital.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Utilities
{
	public class DbInitializer : IDbInitializer
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly ApplicationDbContext _context;

		public DbInitializer(UserManager<IdentityUser> userManager, 
			RoleManager<IdentityRole> roleManager, 
			ApplicationDbContext context)
		{
			_userManager = userManager;
			_roleManager = roleManager;
			_context = context;
		}

		public void Initialize()
		{
			try
			{
				if (_context.Database.GetPendingMigrations().Any()) // Count() > 0 kullanılabilirdi fakat Any() daha performanslı
				{
                    _context.Database.Migrate();
                }
            }
			catch (Exception)
			{

				throw;
			}
			if (!_roleManager.RoleExistsAsync(WebSiteRoles.WebSite_Admin).GetAwaiter().GetResult())
			{
				_roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Admin)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Patient)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Doctor)).GetAwaiter().GetResult();

				_userManager.CreateAsync(new ApplicationUser
				{
					UserName = "Mervan",
					Email = "mervan.aksu@ogr.sakarya.edu.tr"
				}, "Mervan@123").GetAwaiter().GetResult();
				var Appuser = _context.ApplicationUsers.FirstOrDefault(x => x.Email == "mervan.aksu@ogr.sakarya.edu.tr");
				if (Appuser != null)
				{
					_userManager.AddToRoleAsync(Appuser, WebSiteRoles.WebSite_Admin).GetAwaiter().GetResult();
				}
			}
		}
	}
}

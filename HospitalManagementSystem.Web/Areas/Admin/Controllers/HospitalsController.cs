using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Web.Areas.Admin.Controllers
{
	public class HospitalsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

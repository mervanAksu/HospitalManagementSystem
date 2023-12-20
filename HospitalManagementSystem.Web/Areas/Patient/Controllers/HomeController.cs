using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Web.Areas.Patient.Controllers
{
	[Area("Patient")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

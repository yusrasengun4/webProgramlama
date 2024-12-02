using Microsoft.AspNetCore.Mvc;

namespace webProgramlama.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

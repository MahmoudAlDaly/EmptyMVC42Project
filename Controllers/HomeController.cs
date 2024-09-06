using Microsoft.AspNetCore.Mvc;

namespace MVC42Route.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		// /home/ShowMessage
		public string ShowMessage()
		{
			return "Show Message Method";
		}
	}
}

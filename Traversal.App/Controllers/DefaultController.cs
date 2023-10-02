using Microsoft.AspNetCore.Mvc;

namespace Traversal.App.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

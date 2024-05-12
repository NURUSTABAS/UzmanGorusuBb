
using Microsoft.AspNetCore.Mvc;

namespace UzmanGorusuB.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error1()
		{
			return View();
		}
	}
}

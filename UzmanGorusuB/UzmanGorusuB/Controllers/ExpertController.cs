using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;

namespace UzmanGorusuB.Controllers
{
	public class ExpertController : Controller
	{
		ExpertManager em = new ExpertManager(new EfExpertRepository());

        [AllowAnonymous]
		public IActionResult Index()
		{
			var values = em.GetList();
			return View(values);
		}

        public IActionResult ExpertDetails(int id)
        {
			HttpContext.Session.SetInt32("ExpertID", id);
			ViewBag.i = id;
            var values = em.GetExpertByID(id);
            return View(values);
        }
    }
}

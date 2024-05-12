using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UzmanGorusuB.Controllers
{

    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EfAboutRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = abm.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            id = 2;
            var aboutvalue = abm.TGetById(id);
            return View(aboutvalue);
        }
        [HttpPost]
        public IActionResult EditAbout(About p)
        {

            p.AboutID = 2;
            p.AboutStatus = true;
            abm.TUpdate(p);
            return RedirectToAction("EditAbout", "About");
        }
    }
}

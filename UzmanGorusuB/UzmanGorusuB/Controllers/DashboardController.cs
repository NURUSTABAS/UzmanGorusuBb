using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UzmanGorusuB.Controllers
{

    public class DashboardController : Controller
    {
     
      public IActionResult Index()
        {
            Context c = new Context();
            var applicantName = User.Identity.Name;
            var applicantMail = c.Users.Where(x => x.UserName == applicantName).Select(y => y.Email).FirstOrDefault();
           var applicantid=c.Applicants.Where(x=>x.ApplicantMail==applicantMail).Select(y=>y.ApplicantID).FirstOrDefault();

            ViewBag.v1=c.Links.Count().ToString();
            ViewBag.v2 = c.Links.Where(x => x.ApplicantID == applicantid).Count();
            ViewBag.v3 = c.Categories.Count();
            return View();
        }
    }
}

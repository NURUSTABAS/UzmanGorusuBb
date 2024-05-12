using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UzmanGorusuB.Areas.Admin.Models;
using UzmanGorusuB.Models;

namespace UzmanGorusuB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApplicantController : Controller
    {
        Context c = new Context();
        ApplicantManager apm = new ApplicantManager(new EfApplicantRepository());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ApplicantList()
        {
            var applicants = c.Applicants.ToList();
            var jsonApplicants = JsonConvert.SerializeObject(applicants);
            return Json(jsonApplicants);
        }

        public IActionResult GetApplicantByID(int applicantid)
        {
            var applicants = c.Applicants.ToList();
            var findapplicant = applicants.FirstOrDefault(x => x.ApplicantID == applicantid);
            var jsonApplicants = JsonConvert.SerializeObject(findapplicant);
            return Json(jsonApplicants);

        }



    }
}

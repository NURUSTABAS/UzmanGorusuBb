using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace UzmanGorusuB.Controllers
{
    public class RegisterController : Controller
    {
        ApplicantManager apm = new ApplicantManager(new EfApplicantRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Applicant a)
        {
           ApplicantValidator av = new ApplicantValidator();
            ValidationResult results = av.Validate(a);
            if (results.IsValid)
            {
                a.ApplicantCertificate = "Deneme Test";
                a.ApplicantStatus = true;
                a.ApplicantAbout = "Deneme";
                apm.TAdd(a);
                return RedirectToAction("Index", "Expert");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
          return View();
        }
    }
}

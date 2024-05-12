using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UzmanGorusuB.Models;

namespace UzmanGorusuB.Controllers
{
   
    public class ApplicantController : Controller
    {
        ApplicantManager apm = new ApplicantManager(new EfApplicantRepository());
        Context c  =new Context();

        private readonly UserManager<AppUser> userManager;

        public ApplicantController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
           Context c = new Context();
            var applicantname = c.Applicants.Where(x => x.ApplicantMail == usermail).Select(y => y.ApplicantName).FirstOrDefault(); 
            ViewBag.v2= applicantname;  

            return View();
        }


        public IActionResult ApplicantProfile()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test() {
            return View();

        }

        [AllowAnonymous]
        public PartialViewResult ApplicantNavbarPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public PartialViewResult ApplicantFooterPartial()
        {
            return PartialView();
        }
 
        [HttpGet]
        public async Task< IActionResult> ApplicantEditProfile()
        {
            //var applicantName = User.Identity.Name;
            //var userMail = c.Users.Where(x => x.UserName == applicantName).Select(y => y.Email).FirstOrDefault();
            //var applicantID = c.Applicants.Where(x => x.ApplicantMail == userMail).Select(y => y.ApplicantID).FirstOrDefault();
            ////var values = apm.GetApplicantById(applicantID);
            //var applicantvalues = apm.TGetById(applicantID);  
            //return View(applicantvalues);

            var values = await userManager.FindByNameAsync(User.Identity.Name);
            return View();
        }

     
        [HttpPost]
        public IActionResult ApplicantEditProfile(Applicant p)
        {
            ApplicantValidator al = new ApplicantValidator();
            ValidationResult results = al.Validate(p);
            if(results.IsValid)
            {
                apm.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult ApplicantAdd()
        {
            return View();  
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult ApplicantAdd(AddProfileImage p)
        {
            Applicant w =new Applicant();
            if(p.ApplicantImage != null)
            {
                var extension = Path.GetExtension(p.ApplicantImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserImageFile/",newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.ApplicantImage.CopyTo(stream);
                w.ApplicantImage = newimagename;
            }  
            w.ApplicantMail=p.ApplicantMail;
            w.ApplicantName=p.ApplicantName;
            w.ApplicantSurname=p.ApplicantSurname;
            w.ApplicantAge=p.ApplicantAge;
            w.ApplicantPassword=p.ApplicantPassword;
            w.ApplicantGender   =p.ApplicantGender;
            w.ApplicantUniversity =p.ApplicantUniversity;
            w.ApplicantUniversityDepartment = p.ApplicantUniversityDepartment;
            w.ApplicantGradition=p.ApplicantGradition;
            w.ApplicantCertificate=p.ApplicantCertificate;  
            w.LanguageProficiency=p.LanguageProficiency;
            w.ApplicantStatus = true;
            w.ApplicantAbout=p.ApplicantAbout;
            apm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}

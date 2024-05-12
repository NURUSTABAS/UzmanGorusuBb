using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UzmanGorusuB.Models;

namespace UzmanGorusuB.Controllers
{
    public class ApplicantExpertController : Controller
    {
        ApplicantExpertManager aem = new ApplicantExpertManager(new EfApplicantExpertRepository());
        Context c = new Context();
        // [AllowAnonymous]
        public IActionResult Index()
        {
            var values = aem.GetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDiscussionStatus(int id, bool isDiscussed)
        {
            // Veritabanında ilgili kaydın IsDiscussed alanını güncelleyin
            c.ApplicantExperts.FirstOrDefault(a => a.ApplicantExpertID == id).Discussed = true;
            c.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateAcceptanceStatus(int id, bool isAccepted)
        {
            // Veritabanında ilgili kaydın IsAccepted alanını güncelleyin
            c.ApplicantExperts.FirstOrDefault(a => a.ApplicantExpertID == id).IsAccpted = true;
            c.SaveChanges();

            return Ok();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult ExpertAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult ExpertAdd(ExpertCv p)
        {

            ApplicantExpert w = new ApplicantExpert();
            var allowedExtensions = new[] { ".pdf", ".doc", ".docx" };
            var maxFileSize = 10 * 1024 * 1024; // Maksimum dosya boyutu 10MB olarak belirleyin

            if (p.ApplicantExpertCV != null && p.ApplicantExpertCV.Length > 0)
            {
                var extension = Path.GetExtension(p.ApplicantExpertCV.FileName);
                if (!allowedExtensions.Contains(extension.ToLower()))
                {
                    // Geçersiz dosya uzantısı, hata mesajı gösterin veya işlemi durdurun
                    ModelState.AddModelError("ApplicantExpertCV", "Geçersiz dosya uzantısı. Lütfen PDF, DOC veya DOCX dosyası yükleyin.");
                    return View();
                }
                if (p.ApplicantExpertCV.Length > maxFileSize)
                {
                    // Dosya boyutu çok büyük, hata mesajı gösterin veya işlemi durdurun
                    ModelState.AddModelError("ApplicantExpertCV", "Maksimum dosya boyutu 10MB'ı geçemez.");
                    return View();
                }
                var newcvname = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ExpertCV/", newcvname);
                var stream = new FileStream(location, FileMode.Create);
                p.ApplicantExpertCV.CopyTo(stream);
                w.ApplicantExpertCV = newcvname;
            }
            else
            {
                ModelState.AddModelError("ApplicantExpertCV", "Lütfen cv inizi ekleyin");
                return View();
            }
            w.ApplicantExpertMail = p.ApplicantExpertMail;
            w.ApplicantExpertName = p.ApplicantExpertName;
            w.ApplicantExpertSurname = p.ApplicantExpertSurname;
            w.ApplicantExpertAge = p.ApplicantExpertAge;
            w.ApplicantExpertGender = p.ApplicantExpertGender;
            w.ApplicantExpertTitle = p.ApplicantExpertTitle;
            w.ApplicantExpertStatus = p.ApplicantExpertStatus;
            w.IsAccpted = p.IsAccpted;
            aem.TAdd(w);
            return RedirectToAction("Index", "Expert"); //Başvurunuz alınmıştır alerti ekle 
        }

        [HttpGet]
        public IActionResult ViewPDF(int p)
        {

            ViewBag.i = p;
            var user = aem.GetApplicantExpertById(p);
            ApplicantExpert w = new ApplicantExpert();
            //  ApplicantExpert w = new ApplicantExpert();
            if (user != null && !string.IsNullOrEmpty(w.ApplicantExpertCV))
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/", w.ApplicantExpertCV);

                if (System.IO.File.Exists(filePath))
                {
                    return File(filePath, "application/pdf");
                }
            }

            return NotFound();

        }
    }
}

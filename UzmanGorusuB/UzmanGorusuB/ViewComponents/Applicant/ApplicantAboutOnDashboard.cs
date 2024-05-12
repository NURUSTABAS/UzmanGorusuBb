using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UzmanGorusuB.ViewComponents.Applicant
{
    public class ApplicantAboutOnDashboard :ViewComponent
    {
        ApplicantManager um = new ApplicantManager(new EfApplicantRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var applicantName = User.Identity.Name;
            ViewBag.v = applicantName;
            var applicantMail = c.Users.Where(x => x.UserName == applicantName).Select(y => y.Email).FirstOrDefault()
;            var applicantID = c.Applicants.Where(x => x.ApplicantMail == applicantMail).Select(y => y.ApplicantID).FirstOrDefault();
            var values = um.GetApplicantById(applicantID);
            return View(values);
        }
    }
}

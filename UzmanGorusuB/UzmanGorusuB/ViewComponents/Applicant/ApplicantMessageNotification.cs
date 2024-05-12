using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UzmanGorusuB.ViewComponents.Applicant
{
    public class ApplicantMessageNotification : ViewComponent
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id = 1;
            var values = mm.GetInboxByApplicant(id);
            return View(values);
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UzmanGorusuB.ViewComponents.Link
{
    public class GetLinkDashboard : ViewComponent
    {
        LinkManager lm = new LinkManager(new EfLinkRepository());
        Context c = new Context();
        [AllowAnonymous]
        public IViewComponentResult Invoke()
        {
            var values = lm.GetListWithCategoryByApplicantLm(1);
            return View(values);

        }
    }
}

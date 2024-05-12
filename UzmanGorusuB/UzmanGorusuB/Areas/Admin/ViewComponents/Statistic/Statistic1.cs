using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace UzmanGorusuB.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        ExpertManager em = new ExpertManager(new EfExpertRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Experts.Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();
            ViewBag.v4= c.ApplicantExperts.Count(); 
            ViewBag.v5= c.Applicants.Count();
            ViewBag.v6 = c.ApplicantExperts.OrderByDescending(x => x.ApplicantExpertID).Select(x => x.ApplicantExpertName).Take(1).FirstOrDefault();

            string api = "62792736fc2d4140a9f777a7c59d8dce";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=İstanbul&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v7 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}

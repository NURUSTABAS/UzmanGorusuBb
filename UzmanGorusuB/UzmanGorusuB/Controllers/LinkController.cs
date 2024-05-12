using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

//using System.ComponentModel.DataAnnotations;
using System.Configuration;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;

namespace UzmanGorusuB.Controllers
{
 
    public class LinkController : Controller
    {
        Context c = new Context();
        LinkManager lm = new LinkManager(new EfLinkRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = lm.GetLinkListWithCategory();
            return View(values);
        }

        public IActionResult LinkListByApplicant()
        {
            var applicantMail = User.Identity.Name;
            var applicantID = c.Applicants.Where(x => x.ApplicantMail == applicantMail).Select(y => y.ApplicantID).FirstOrDefault();
            var values = lm.GetListWithCategoryByApplicantLm(applicantID);
            return View(values);

        }

        [HttpGet]
        public IActionResult LinkAdd()
        {

            List<SelectListItem> categorivalue = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.cm = categorivalue;
            return View();
        }
        [HttpPost]
        public IActionResult LinkAdd(Link p)
        {
            var applicantMail = User.Identity.Name;
            var applicantID = c.Applicants.Where(x => x.ApplicantMail == applicantMail).Select(y => y.ApplicantID).FirstOrDefault();
           
            LinkValidator lv = new LinkValidator();
            ValidationResult results = lv.Validate(p);
            if (results.IsValid)
            {

                p.LinkStatus = true;
                p.LinkDate = DateTime.Parse(DateTime.Now.ToString());
                p.ApplicantID = applicantID;
                lm.TAdd(p);
                return RedirectToAction("LinkListByApplicant", "Link");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }



        public IActionResult DeleteLink(int id)
        {
            var linkvalue = lm.TGetById(id);
            lm.TDelete(linkvalue);
            return RedirectToAction("LinkListByApplicant","Link");
        }

        [HttpGet]
        public IActionResult EditLink(int id)
        {
            var linkvalue = lm.TGetById(id);
            List<SelectListItem> categorivalue = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.cm = categorivalue;
            return View(linkvalue);
        }
        [HttpPost]
        public IActionResult EditLink(Link p)
        {
            var applicantMail = User.Identity.Name;
            var applicantID = c.Applicants.Where(x => x.ApplicantMail == applicantMail).Select(y => y.ApplicantID).FirstOrDefault();
            p.ApplicantID = applicantID;
            p.LinkDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.LinkStatus = true;
            lm.TUpdate(p);
            return RedirectToAction("LinkListByApplicant","Link");
        }

    }

}


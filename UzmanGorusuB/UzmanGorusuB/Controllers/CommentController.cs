using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using UzmanGorusuB.Models;

namespace UzmanGorusuB.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepsitory());
		public IActionResult Index()
		{
			return View();
		}

        public IActionResult CommentForm()
        {
            // Session'dan uzman ID'sini al
            var expertId = HttpContext.Session.GetInt32("ExpertId");
            if (expertId.HasValue)
            {
                ViewData["ExpertId"] = expertId.Value;
                return View();
            }
            else
            {
				return View();
            }
        }

        [HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}



		[HttpPost]
	public IActionResult PartialAddComment(Comment p)
		{//p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
		 //p.CommentStatus = true;
		 //p.ExpertID = 2;
		 //cm.CommentAdd(p);
		 //return RedirectToAction("ExpertDetails", "Expert", new { id = p.ExpertID });

			var ExpertId = HttpContext.Session.GetInt32("ExpertID");
			if (ExpertId.HasValue)
			{
                p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.CommentStatus = true;
                p.ExpertID = ExpertId.Value;
                cm.CommentAdd(p);
                return RedirectToAction("ExpertDetails", "Expert", new { id = p.ExpertID });
			}
			else
			{
				return View();
			}
        }
		public PartialViewResult CommentListByExpert(int id)
		{
			var values = cm.GetList(id);
			return PartialView(values);
		}
	}
}

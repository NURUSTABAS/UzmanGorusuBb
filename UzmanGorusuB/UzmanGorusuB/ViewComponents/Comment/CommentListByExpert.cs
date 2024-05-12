using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UzmanGorusuB.ViewComponents.Comment
{
    public class CommentListByExpert : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepsitory());
        public IViewComponentResult Invoke(int id) 
        {
            var values = cm.GetList(id);
            return View(values); 
        }

    }
}

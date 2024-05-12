using Humanizer;
using Microsoft.AspNetCore.Mvc;
using UzmanGorusuB.Models;

namespace UzmanGorusuB.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName="Irem"
                },
                new UserComment {
                    ID = 2,
                UserName="Ahmet"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Merve"
                }
            };
            return View(commentvalues);
        }
    }
}

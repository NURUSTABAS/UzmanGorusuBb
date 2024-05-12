using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.AspNetCore.Mvc;
using UzmanGorusuB.Areas.Admin.Models;

namespace UzmanGorusuB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname = "C#",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "SQL",
                categorycount = 12
            });
            list.Add(new CategoryClass
            {
                categoryname = "java",
                categorycount = 14
            });
            return Json(new { jsonlist = list });
        }
    }
}

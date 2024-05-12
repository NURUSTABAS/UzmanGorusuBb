using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using UzmanGorusuB.Areas.Admin.Models;

namespace UzmanGorusuB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LinkController : Controller
    {
        public IActionResult ExportStaticExcelLinkList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Link Listesi");
                worksheet.Cell(1, 1).Value = "Link ID";
                worksheet.Cell(1, 2).Value = "Link Başlığı";

                int LinkRowCount = 2;
                foreach(var item in GetLinkList())
                {
                    worksheet.Cell(LinkRowCount, 1).Value = item.ID;
                    worksheet.Cell(LinkRowCount, 2).Value = item.LinkName;
                    LinkRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content  =stream.ToArray();
                    return File(content,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","LinkListesi.xlsx");
                }
            }
        }
      public List<LinkModel> GetLinkList()
        {
            List<LinkModel> lm = new List<LinkModel>
            {
                new LinkModel {ID=1,LinkName="C# ile uygulama geliştirme"},
                new LinkModel {ID=2, LinkName="Java ile geliştirme"},
                new LinkModel {ID=3, LinkName="Java ile geliştirme"},
            };
            return lm;
        }
        public IActionResult LinkListExel()
        {
            return View();
        }

        public IActionResult ExportDynamicLinkList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Link Listesi");
                worksheet.Cell(1, 1).Value = "Link ID";
                worksheet.Cell(1, 2).Value = "Link Başlığı";

                int LinkRowCount = 2;
                foreach (var item in LinkTitleList())
                {
                    worksheet.Cell(LinkRowCount, 1).Value = item.ID;
                    worksheet.Cell(LinkRowCount, 2).Value = item.LinkName;
                    LinkRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "LinkListesi.xlsx");
                }
            }
        }
        public List<LinkModel2> LinkTitleList()
        {
            List<LinkModel2> lm = new List<LinkModel2>();
            using (var c = new Context())
            {
                lm = c.Links.Select(x => new LinkModel2
                {
                    ID = x.LinkID,
                    LinkName = x.LinkTitle
                }).ToList();
            }
            return lm;
        }
        public IActionResult LinkTitleListExcel()
        {
            return View();
        }
    }
}

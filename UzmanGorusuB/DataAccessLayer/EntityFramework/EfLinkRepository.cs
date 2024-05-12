using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfLinkRepository : GenericRepository<Link>, ILinkDal
    {
        public List<Link> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Links.Include(x => x.Category).ToList();
            }
        }

        public List<Link> GetListWithCategoryByApplicant(int id)
        {
            using (var c = new Context())
            {
                return c.Links.Include(x => x.Category).Where(x => x.ApplicantID == id).ToList();
            }
        }
    }
}

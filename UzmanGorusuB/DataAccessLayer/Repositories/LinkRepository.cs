using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LinkRepository : ILinkDal
    {
        Context c = new Context();
        public void AddLink(Link link)
        {
            c.Add(link);
            c.SaveChanges();

        }
        public void Delete(Link item)
        {
            throw new NotImplementedException();
        }

        public void DeleteLink(Link link)
        {
            c.Remove(link);
            c.SaveChanges();
        }

        public Link GetByID(int id)
        {
            return c.Links.Find(id);
        }

        public List<Link> GetListAll()
        {
            throw new NotImplementedException();
        }

        public List<Link> GetListAll(Expression<Func<Link, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Link> GetListWithCategory()
        {
            throw new NotImplementedException();
        }

        public List<Link> GetListWithCategoryByApplicant(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Link item)
        {
            throw new NotImplementedException();
        }
        public List<Link> ListAllLink()
        {
            return c.Links.ToList();
        }
        public void Update(Link item)
        {
            throw new NotImplementedException();
        }
        public void UpdateLink(Link link)
        {
            c.Update(link);
            c.SaveChanges();
        }
    }
}

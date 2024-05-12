using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LinkManager : ILinkService
    {
        Context dbContext = new Context();
        ILinkDal _linkDal;

        public LinkManager(ILinkDal linkDal)
        {
            _linkDal = linkDal;
        }

        public List<Link> GetLinkByID(int id)
        {
            return _linkDal.GetListAll(x => x.LinkID == id);
        }

        public List<Link> GetLinkListWithCategory()
        {
            return _linkDal.GetListWithCategory();
        }

        public List<Link> GetLinListByApplicant(int id)
        {
            return _linkDal.GetListAll(x => x.ApplicantID == id);
        }

        public List<Link> GetList()
        {
            return _linkDal.GetListAll();
        }

        public void TAdd(Link t)
        {
            _linkDal.Insert(t);
        }

        public void TDelete(Link t)
        {
            _linkDal.Delete(t);
        }

        public Link TGetById(int id)
        {
            return _linkDal.GetByID(id);
        }

        public void TUpdate(Link t)
        {
            _linkDal.Update(t);
        }
        public List<Link> GetListWithCategoryByApplicantLm(int id)
        {
            return _linkDal.GetListWithCategoryByApplicant(id);
        }
    }
}

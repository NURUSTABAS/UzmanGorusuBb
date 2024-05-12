using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILinkService : IGenericService<Link>
    {
        List<Link> GetList();
        List<Link> GetLinkByID(int id);
        List<Link> GetLinListByApplicant(int id);

        List<Link> GetLinkListWithCategory();
    }
}

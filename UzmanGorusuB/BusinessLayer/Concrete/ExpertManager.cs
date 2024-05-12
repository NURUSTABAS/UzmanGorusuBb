
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ExpertManager : IExpertService
	{
		IExpertDal _expertDal;

		public ExpertManager(IExpertDal expertDal)
		{
			_expertDal = expertDal;
		}

		public List<Expert> GetList()
		{
			return _expertDal.GetListAll();	
		}

		public void TAdd(Expert t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Expert t)
		{
			throw new NotImplementedException();
		}

		public Expert TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Expert t)
		{
			throw new NotImplementedException();
		}
		public List<Expert> GetExpertByID(int id)
		{
			return _expertDal.GetListAll(x => x.ExpertID == id);
		}
	}
}

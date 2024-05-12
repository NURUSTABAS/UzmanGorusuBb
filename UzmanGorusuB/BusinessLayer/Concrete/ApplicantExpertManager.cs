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
    public class ApplicantExpertManager : IApplicantExpertService
    {
        IApplicantExpertDal _applicantExperDal;

        public ApplicantExpertManager(IApplicantExpertDal applicantExperDal)
        {
            _applicantExperDal = applicantExperDal;
        }

        public List<ApplicantExpert> GetApplicantExpertById(int id)
        {
            return _applicantExperDal.GetListAll(x => x.ApplicantExpertID == id);
        }

        public List<ApplicantExpert> GetList()
        {
            return _applicantExperDal.GetListAll();
        }

        public void TAdd(ApplicantExpert t)
        {
            _applicantExperDal.Insert(t);
        }

        public void TDelete(ApplicantExpert t)
        {
            throw new NotImplementedException();
        }

        public ApplicantExpert TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ApplicantExpert t)
        {
            _applicantExperDal.Update(t);
        }
    }
}

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
    public class ApplicantManager : IApplicantService
    {
        IApplicantDal _applicantdal;

        public ApplicantManager(IApplicantDal applicantdal)
        {
            _applicantdal = applicantdal;
        }

        public List<Applicant> GetApplicantById(int id)
        {
            return _applicantdal.GetListAll(x => x.ApplicantID == id);
        }

        public List<Applicant> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Applicant t)
        {
            _applicantdal.Insert(t);
        }

        public void TDelete(Applicant t)
        {
            _applicantdal.Delete(t);
        }

        public Applicant TGetById(int id)
        {
             return _applicantdal.GetByID(id);
        }

        public void TUpdate(Applicant t)
        {
            _applicantdal.Update(t);
        }
    

       
    }
}

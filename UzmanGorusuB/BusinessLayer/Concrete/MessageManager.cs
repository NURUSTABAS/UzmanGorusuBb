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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetInboxByApplicant(string p)
        {
            return _messageDal.GetListAll(x=>x.Receiver==p);
        }

        public List<Message> GetList()
        {
           return _messageDal.GetListAll();
        }

   
        public void TAdd(Message t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }

      

        List<Message> IGenericService<Message>.GetList()
        {
            throw new NotImplementedException();
        }

        void IGenericService<Message>.TAdd(Message t)
        {
            throw new NotImplementedException();
        }

        void IGenericService<Message>.TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        Message IGenericService<Message>.TGetById(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericService<Message>.TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}

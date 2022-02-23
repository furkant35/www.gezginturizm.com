using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void Add(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(x => x.ContactId == id);
        }

        public int CountUnreadNotification()
        {
            return _contactDal.CountUnreadNotification();
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }

        public void ChangeReadStatus(int id)
        {
            _contactDal.ChangeReadStatus(id);
        }

        public void SendMail()
        {
            _contactDal.SendMail();
        }
    }
}

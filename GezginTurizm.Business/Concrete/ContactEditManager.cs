using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class ContactEditManager : IContactEditService
    {
        private readonly IContactEditDal _contactEditDal;
        public ContactEditManager(IContactEditDal contactEditDal)
        {
            _contactEditDal = contactEditDal;
        }
        public void Add(ContactEdit entity)
        {
            _contactEditDal.Add(entity);
        }

        public void Delete(ContactEdit entity)
        {
            _contactEditDal.Delete(entity);
        }

        public List<ContactEdit> GetAll()
        {
            return _contactEditDal.GetAll();
        }

        public ContactEdit GetById(int id)
        {
            return _contactEditDal.Get(x => x.Id==id);
        }

        public void Update(ContactEdit entity)
        {
            _contactEditDal.Update(entity);
        }
    }
}

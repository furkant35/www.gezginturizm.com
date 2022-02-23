using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.DataAccess.Concrete.EntityFramework;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class InstitutionalManager : IInstitutionalService
    {
        private readonly IInstitutionalDal _institutionalDal;
        public InstitutionalManager(IInstitutionalDal institutionalDal)
        {
            _institutionalDal = institutionalDal;
        }
        public void Add(Institutional entity)
        {
            _institutionalDal.Add(entity);
        }

        public void Delete(Institutional entity)
        {
            _institutionalDal.Delete(entity);
        }

        public List<Institutional> GetAll()
        {
            return _institutionalDal.GetAll();
        }

        public Institutional GetById(int id)
        {
            return _institutionalDal.Get(x => x.Id == id);
        }

        public void Update(Institutional entity)
        {
            _institutionalDal.Update(entity);
        }
    }
}

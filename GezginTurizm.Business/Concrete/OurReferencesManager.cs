using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class OurReferencesManager : IOurReferencesService
    {
        private readonly IOurReferencesDal _ourReferencesDal;
        public OurReferencesManager(IOurReferencesDal ourReferencesDal)
        {
            _ourReferencesDal = ourReferencesDal;
        }
        public void Add(OurReferences entity)
        {
            _ourReferencesDal.Add(entity);
        }

        public void Delete(OurReferences entity)
        {
            _ourReferencesDal.Delete(entity);
        }

        public List<OurReferences> GetAll()
        {
            return _ourReferencesDal.GetAll();
        }

        public OurReferences GetById(int id)
        {
            return _ourReferencesDal.Get(x => x.Id == id);
        }

        public void Update(OurReferences entity)
        {
            _ourReferencesDal.Update(entity);
        }
    }
}

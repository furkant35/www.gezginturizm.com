using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class OurHistoryManager : IOurHistoryService
    {
        private readonly IOurHistoryDal _ourHistoryDal;
        public OurHistoryManager(IOurHistoryDal ourHistoryDal)
        {
            _ourHistoryDal = ourHistoryDal;
        }
        public void Add(OurHistory entity)
        {
            _ourHistoryDal.Add(entity);
        }

        public void Delete(OurHistory entity)
        {
            _ourHistoryDal.Delete(entity);
        }

        public List<OurHistory> GetAll()
        {
            return _ourHistoryDal.GetAll();
        }

        public OurHistory GetById(int id)
        {
            return _ourHistoryDal.Get(x => x.Id == id);
        }

        public void Update(OurHistory entity)
        {
            _ourHistoryDal.Update(entity);
        }
    }
}

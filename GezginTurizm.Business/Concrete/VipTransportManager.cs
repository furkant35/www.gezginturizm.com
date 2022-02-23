using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class VipTransportManager : IVipTransportService
    {
        private readonly IVipTransportDal _vipTransportDal;
        public VipTransportManager(IVipTransportDal vipTransportDal)
        {
            _vipTransportDal = vipTransportDal;
        }
        public void Add(VipTransport entity)
        {
            _vipTransportDal.Add(entity);
        }

        public void Delete(VipTransport entity)
        {
            _vipTransportDal.Delete(entity);
        }

        public List<VipTransport> GetAll()
        {
            return _vipTransportDal.GetAll();
        }

        public VipTransport GetById(int id)
        {
            return _vipTransportDal.Get(x => x.Id == id);
        }

        public void Update(VipTransport entity)
        {
            _vipTransportDal.Update(entity);
        }
    }
}

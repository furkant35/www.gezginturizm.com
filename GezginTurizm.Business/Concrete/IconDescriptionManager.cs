using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class IconDescriptionManager : IIconDescriptionService
    {
        private readonly IIconDescriptionDal _iconDescriptionDal;
        public IconDescriptionManager(IIconDescriptionDal iconDescriptionDal)
        {
            _iconDescriptionDal = iconDescriptionDal;
        }
        public void Add(IconDescription entity)
        {
            _iconDescriptionDal.Add(entity);
        }

        public void Delete(IconDescription entity)
        {
            _iconDescriptionDal.Delete(entity);
        }

        public List<IconDescription> GetAll()
        {
            return _iconDescriptionDal.GetAll();
        }

        public IconDescription GetById(int id)
        {
            return _iconDescriptionDal.Get(x => x.Id == id);
        }

        public void Update(IconDescription entity)
        {
            _iconDescriptionDal.Update(entity);
        }
    }
}

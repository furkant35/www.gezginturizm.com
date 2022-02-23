using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class PhotoGalleryManager : IPhotoGalleryService
    {
        private readonly IPhotoGalleryDal _photoGalleryDal;
        public PhotoGalleryManager(IPhotoGalleryDal photoGalleryDal)
        {
            _photoGalleryDal = photoGalleryDal;
        }
        public void Add(PhotoGallery entity)
        {
            _photoGalleryDal.Add(entity);
        }

        public void Delete(PhotoGallery entity)
        {
            _photoGalleryDal.Delete(entity);
        }

        public List<PhotoGallery> GetAll()
        {
            return _photoGalleryDal.GetAll();
        }

        public PhotoGallery GetById(int id)
        {
            return _photoGalleryDal.Get(x => x.PhotoId == id);
        }

        public void Update(PhotoGallery entity)
        {
            _photoGalleryDal.Update(entity);
        }
    }
}

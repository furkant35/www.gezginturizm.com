using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class StudentTransportManager : IStudentTransportService
    {
        private readonly IStudentTransportDal _studentTransportDal;
        public StudentTransportManager(IStudentTransportDal studentTransportDal)
        {
            _studentTransportDal = studentTransportDal;
        }
        public void Add(StudentTransport entity)
        {
            _studentTransportDal.Add(entity);
        }

        public void Delete(StudentTransport entity)
        {
            _studentTransportDal.Delete(entity);
        }

        public List<StudentTransport> GetAll()
        {
            return _studentTransportDal.GetAll();
        }

        public StudentTransport GetById(int id)
        {
            return _studentTransportDal.Get(x => x.Id == id);
        }

        public void Update(StudentTransport entity)
        {
            _studentTransportDal.Update(entity);
        }
    }
}

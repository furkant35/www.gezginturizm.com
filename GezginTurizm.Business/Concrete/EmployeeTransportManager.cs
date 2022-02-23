using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class EmployeeTransportManager : IEmployeeTransportService
    {
        private readonly IEmployeeTransportDal _employeeTransportDal;
        public EmployeeTransportManager(IEmployeeTransportDal employeeTransportDal)
        {
            _employeeTransportDal = employeeTransportDal;
        }
        public void Add(EmployeeTransport entity)
        {
            _employeeTransportDal.Add(entity);
        }

        public void Delete(EmployeeTransport entity)
        {
            _employeeTransportDal.Delete(entity);
        }

        public List<EmployeeTransport> GetAll()
        {
            return _employeeTransportDal.GetAll();
        }

        public EmployeeTransport GetById(int id)
        {
            return _employeeTransportDal.Get(x => x.Id == id);
        }

        public void Update(EmployeeTransport entity)
        {
            _employeeTransportDal.Update(entity);
        }
    }
}

using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(Admin entity)
        {
            _adminDal.Add(entity);
        }

        public Admin BringAdmin(int id)
        {
            var bringAdmin = _adminDal.Get(x=>x.AdminId==id);
            Admin admin = new Admin();
            admin.AdminId = bringAdmin.AdminId;
            admin.UserName = bringAdmin.UserName;
            admin.SecretQuestion = bringAdmin.SecretQuestion;
            admin.SecretAnswer = bringAdmin.SecretAnswer;
            return admin;
        }

        public void Delete(Admin entity)
        {
            _adminDal.Delete(entity);
        }


        public List<Admin> GetAll()
        {
            return _adminDal.GetAll();
        }

        public Admin GetById(int id)
        {
            return _adminDal.Get(x=>x.AdminId==id);
        }

        public void Update(Admin entity)
        {
            _adminDal.Update(entity);
        }
    }
}

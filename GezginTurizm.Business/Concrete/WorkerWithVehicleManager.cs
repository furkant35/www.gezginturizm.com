using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class WorkerWithVehicleManager : IWorkerWithVehicleService
    {
        private readonly IWorkerWithVehicleDal _workerWithVehicleDal;
        public WorkerWithVehicleManager(IWorkerWithVehicleDal workerWithVehicleDal)
        {
            _workerWithVehicleDal = workerWithVehicleDal;
        }
        public void Add(WorkerWithVehicle entity)
        {
            _workerWithVehicleDal.Add(entity);
        }

        public void Delete(WorkerWithVehicle entity)
        {
            _workerWithVehicleDal.Delete(entity);
        }

        public List<WorkerWithVehicle> GetAll()
        {
            return _workerWithVehicleDal.GetAll();
        }

        public WorkerWithVehicle GetById(int id)
        {
            return _workerWithVehicleDal.Get(x => x.WorkerId == id);
        }

        public int CountUnreadNotification()
        {
            return _workerWithVehicleDal.CountUnreadNotification();
        }

        public void Update(WorkerWithVehicle entity)
        {
            _workerWithVehicleDal.Update(entity);
        }

        public void ChangeReadStatus(int id)
        {
            _workerWithVehicleDal.ChangeReadStatus(id);
        }

        public void SendMail()
        {
            _workerWithVehicleDal.SendEmail();
        }
    }
}

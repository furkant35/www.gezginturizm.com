using GezginTurizm.Business.Abstract;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Concrete
{
    public class WorkerWithoutVehicleManager : IWorkerWithoutVehicleService
    {
        private readonly IWorkerWithoutVehicleDal _workerWithoutVehicleDal;
        public WorkerWithoutVehicleManager(IWorkerWithoutVehicleDal workerWithoutVehicleDal)
        {
            _workerWithoutVehicleDal = workerWithoutVehicleDal;
        }
        public void Add(WorkerWithoutVehicle entity)
        {
            _workerWithoutVehicleDal.Add(entity);
        }

        public void Delete(WorkerWithoutVehicle entity)
        {
            _workerWithoutVehicleDal.Delete(entity);
        }

        public List<WorkerWithoutVehicle> GetAll()
        {
            return _workerWithoutVehicleDal.GetAll();
        }

        public WorkerWithoutVehicle GetById(int id)
        {
            return _workerWithoutVehicleDal.Get(x => x.WorkerId == id);
        }

        public int CountUnreadNotification()
        {
            return _workerWithoutVehicleDal.CountUnreadNotification();
        }

        public void Update(WorkerWithoutVehicle entity)
        {
            _workerWithoutVehicleDal.Update(entity);
        }

        public void ChangeReadStatus(int id)
        {
            _workerWithoutVehicleDal.ChangeReadStatus(id);
        }

        public void SendMail()
        {
            _workerWithoutVehicleDal.SendMail();
        }
    }
}

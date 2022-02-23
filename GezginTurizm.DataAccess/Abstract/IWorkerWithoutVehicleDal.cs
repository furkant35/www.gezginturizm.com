using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.DataAccess.Abstract
{
    public interface IWorkerWithoutVehicleDal : IEntityRepository<WorkerWithoutVehicle>
    {
        void SendMail();
        void ChangeReadStatus(int id);
        int CountUnreadNotification();
    }
}

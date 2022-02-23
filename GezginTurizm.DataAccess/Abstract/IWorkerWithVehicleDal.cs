using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.DataAccess.Abstract
{
    public interface IWorkerWithVehicleDal : IEntityRepository<WorkerWithVehicle>
    {
        void SendEmail();
        void ChangeReadStatus(int id);
        int CountUnreadNotification();
    }
}

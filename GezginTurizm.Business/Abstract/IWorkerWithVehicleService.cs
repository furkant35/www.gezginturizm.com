using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Abstract
{
    public interface IWorkerWithVehicleService:IGenericService<WorkerWithVehicle>
    {
        void SendMail();
        void ChangeReadStatus(int id);
        int CountUnreadNotification();
    }
}

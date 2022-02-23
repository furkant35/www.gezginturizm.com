using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Abstract
{
    public interface IWorkerWithoutVehicleService:IGenericService<WorkerWithoutVehicle>
    {
        void SendMail();
        void ChangeReadStatus(int id);
        int CountUnreadNotification();
    }
}

using GezginTurizm.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GezginTurizm.WebUI.ViewComponents
{
    public class ManagementHeader : ViewComponent
    {
        private readonly IContactService _contactService;
        private readonly IWorkerWithoutVehicleService _workerWithoutVehicleService;
        private readonly IWorkerWithVehicleService _workerWithVehicleService;
        public ManagementHeader(IContactService contactService, IWorkerWithoutVehicleService workerWithoutVehicleService, IWorkerWithVehicleService workerWithVehicleService)
        {
            _contactService = contactService;
            _workerWithoutVehicleService = workerWithoutVehicleService;
            _workerWithVehicleService = workerWithVehicleService;
        }
        public IViewComponentResult Invoke()
        {
            int count1 = _contactService.CountUnreadNotification();
            ViewBag.count1 = count1;
            int count2 = _workerWithoutVehicleService.CountUnreadNotification();
            ViewBag.count2 = count2;
            int count3 = _workerWithVehicleService.CountUnreadNotification();
            ViewBag.count3 = count3;
            int countSum = count1 + count2 + count3;
            ViewBag.Sum = countSum;
            return View("Default");
        }
    }
}

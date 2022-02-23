using GezginTurizm.Business.Abstract;
using GezginTurizm.Business.Concrete;
using GezginTurizm.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace GezginTurizm.WebUI.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IWorkerWithoutVehicleService _workerWithoutVehicleService;
        private readonly IWorkerWithVehicleService _workerWithVehicleService;
        public ApplicationController(IWorkerWithoutVehicleService workerWithoutVehicleService, IWorkerWithVehicleService workerWithVehicleService)
        {
            _workerWithoutVehicleService = workerWithoutVehicleService;
            _workerWithVehicleService = workerWithVehicleService;
        }
        public IActionResult WorkerWithoutVehicle()
        {
            ViewBag.DriverLicenseType = new SelectList(new List<string>() { "M", "A1", "A2", "A", "B1", "B", "BE", "C1", "C1E", "C", "CE", "D1", "D1E", "D", "DE", "F", "G" });
            return View();
        }
        [HttpPost]
        public IActionResult WorkerWithoutVehicle(WorkerWithoutVehicle model)
        {
            if (ModelState.IsValid)
            {
                _workerWithoutVehicleService.Add(model);
                _workerWithoutVehicleService.SendMail();
                TempData.Add("cCCbExRzTqfYGZqrwqrqrsAdAXaCAVrmAd", string.Format("Başvurunuz başarıyla veritabanımıza kaydedilmiştir"));
                return RedirectToAction("WorkerWithoutVehicle");
            }
            TempData.Add("REDbExRzTqfYGZqrwqrqrsAdAXaCAVrmAd", string.Format("Başvurunuz iletilememiştir"));
            return View("WorkerWithoutVehicle", model);
        }
        public IActionResult WorkerWithVehicle()
        {
            ViewBag.DriverLicenseType = new SelectList(new List<string>() { "M", "A1", "A2", "A", "B1", "B", "BE", "C1", "C1E", "C", "CE", "D1", "D1E", "D", "DE", "F", "G" });
            ViewBag.VehicleModel = new SelectList(new List<int>() { 1970,1971,1972,1973, 1974, 1975, 1976, 1977, 1978, 1979, 1980, 1981 , 1982, 1983, 1984, 1985, 1986, 1987, 1988, 1989,
            1990,1991,1992,1993,1994,1995,1996,1997,1998,1999,2000,2001,2002,2003,2004,2005,2006,2007,2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020,2021,2022});
            ViewBag.NumberOfSeat = new SelectList(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 });
            return View();
        }
        [HttpPost]
        public IActionResult WorkerWithVehicle(WorkerWithVehicle model)
        {
            if (ModelState.IsValid)
            {
                _workerWithVehicleService.Add(model);
                _workerWithVehicleService.SendMail();
                TempData.Add("QaWbExRzTqfYGZqrwqrqrsAdAXaCAVrBxX", string.Format("Başvurunuz başarıyla veritabanımıza kaydedilmiştir"));
                return RedirectToAction("WorkerWithVehicle");
            }
            TempData.Add("REDbExRzTqfYGZqrwqrqrsAdAXaCAVrBxX", string.Format("Başvurunuz iletilememiştir"));
            return View("WorkerWithoutVehicle", model);
        }
        public IActionResult VehicleRequestApplication() => RedirectToAction("Contact", "Home");
    }
}

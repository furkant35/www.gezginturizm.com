using GezginTurizm.Business.Abstract;
using GezginTurizm.Business.Concrete;
using GezginTurizm.Entities.Concrete;
using GezginTurizm.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols;

namespace GezginTurizm.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeTransportService _employeeTransportService;
        private readonly IStudentTransportService _studentTransportService;
        private readonly IVipTransportService _vipTransportService;
        private readonly IInstitutionalService _institutionalService;
        private readonly ISliderService _sliderService;
        private readonly IContactService _contactService;
        private readonly IPhotoGalleryService _photoGalleryService;
        private readonly IOurHistoryService _ourHistoryService;
        private readonly IOurReferencesService _ourReferencesService;
        private readonly IIconDescriptionService _iconDescriptionService;
        private readonly IContactEditService _contactEditService;
        public HomeController(ILogger<HomeController> logger, IEmployeeTransportService employeeTransportService, IContactService contactService,
        IStudentTransportService studentTransportService, IVipTransportService vipTransportService, IInstitutionalService institutionalService,
        ISliderService sliderService, IPhotoGalleryService photoGalleryService, IOurHistoryService ourHistoryService, IOurReferencesService ourReferencesService,
        IIconDescriptionService iconDescriptionService, IContactEditService contactEditService)
        {
            _logger = logger;
            _employeeTransportService = employeeTransportService;
            _studentTransportService = studentTransportService;
            _vipTransportService = vipTransportService;
            _institutionalService = institutionalService;
            _sliderService = sliderService;
            _photoGalleryService = photoGalleryService;
            _contactService = contactService;
            _ourHistoryService = ourHistoryService;
            _ourReferencesService = ourReferencesService;
            _iconDescriptionService = iconDescriptionService;
            _contactEditService = contactEditService;
        }

        public IActionResult Index()
        {
            var slider = _sliderService.GetAll();
            var photoGallery = _photoGalleryService.GetAll();
            var ourHistory = _ourHistoryService.GetAll();
            var ourReferences = _ourReferencesService.GetAll();
            var iconDescription = _iconDescriptionService.GetAll();
            SliderPhotoGalleryModel model = new SliderPhotoGalleryModel();
            model.Slider = slider;
            model.PhotoGallery = photoGallery;
            model.OurHistories = ourHistory;
            model.OurReferences = ourReferences;
            model.IconDescriptions = iconDescription;
            return View(model);
        }
        public IActionResult OurServices()
        {
            var employee = _employeeTransportService.GetAll();
            var student = _studentTransportService.GetAll();
            var vip = _vipTransportService.GetAll();
            OurServicesModel model = new OurServicesModel();
            model.EmployeeTransports = employee;
            model.StudentTransports = student;
            model.VipTransports = vip;
            return View(model);
        }
        public IActionResult Institutional() => View(_institutionalService.GetAll());

        public IActionResult Contact() => View(_contactEditService.GetAll());

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                _contactService.SendMail();
                TempData.Add("QaWbmqwAAaaxZzxcMwqrqrsAdAXaCAVrBxX", string.Format("Mesajınız başarıyla veritabanımıza kaydedilmiştir"));
                return RedirectToAction("Contact");
            }
            TempData.Add("REDbmqwAAaaxZzxcMwqrqrsAdAXaCAVrBxX", string.Format("Başvurunuz iletilememiştir"));
            return View("Contact", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
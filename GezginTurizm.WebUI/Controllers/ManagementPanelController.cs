using GezginTurizm.Business.Abstract;
using GezginTurizm.Business.Concrete;
using GezginTurizm.DataAccess.Concrete.EntityFramework;
using GezginTurizm.Entities.Concrete;
using GezginTurizm.WebUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GezginTurizm.WebUI.Controllers
{
    [Authorize]
    public class ManagementPanelController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IAdminService _adminService;
        private readonly ISliderService _sliderService;
        private readonly IContactService _contactService;
        private readonly IEmployeeTransportService _employeeTransportService;
        private readonly IInstitutionalService _institutionalService;
        private readonly IPhotoGalleryService _photoGalleryService;
        private readonly IStudentTransportService _studentTransportService;
        private readonly IVipTransportService _vipTransportService;
        private readonly IWorkerWithoutVehicleService _workerWithoutVehicleService;
        private readonly IWorkerWithVehicleService _workerWithVehicleService;
        private readonly IOurHistoryService _ourHistoryService;
        private readonly IOurReferencesService _ourReferencesService;
        private readonly IIconDescriptionService _iconDescriptionService;
        private readonly IContactEditService _contactEditService;

        public ManagementPanelController(IWebHostEnvironment env, IAdminService adminService, ISliderService sliderService, IContactService contactService,
            IEmployeeTransportService employeeTransportService, IInstitutionalService institutionalService, IPhotoGalleryService photoGalleryService,
            IStudentTransportService studentTransportService, IVipTransportService vipTransportService, IWorkerWithoutVehicleService workerWithoutVehicleService,
            IWorkerWithVehicleService workerWithVehicleService, IOurHistoryService ourHistoryService, IOurReferencesService ourReferencesService,
            IIconDescriptionService iconDescriptionService, IContactEditService contactEditService)
        {
            _env = env;
            _adminService = adminService;
            _sliderService = sliderService;
            _contactService = contactService;
            _employeeTransportService = employeeTransportService;
            _institutionalService = institutionalService;
            _photoGalleryService = photoGalleryService;
            _studentTransportService = studentTransportService;
            _vipTransportService = vipTransportService;
            _workerWithoutVehicleService = workerWithoutVehicleService;
            _workerWithVehicleService = workerWithVehicleService;
            _ourHistoryService = ourHistoryService;
            _ourReferencesService = ourReferencesService;
            _iconDescriptionService = iconDescriptionService;
            _contactEditService = contactEditService;
        }
        public IActionResult Index() => View();
        public IActionResult SliderAdd() => View();
        [HttpPost]
        public async Task<IActionResult> SliderAdd(IFormFile file, Slider model)
        {
            if (file != null)
            {
                if (file.Length > 5000000)
                {
                    TempData.Add("sDqaCXcvvswetqwQErfsdfqQDRa", string.Format("Dosya boyutu 5 MB üzeri olamaz"));
                    return RedirectToAction("SliderAdd");
                }
                if (file.ContentType == "image/jpeg" || file.ContentType == "image/jpg" || file.ContentType == "image/png")
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\slide", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    model.SliderPhoto = file.FileName;
                    _sliderService.Add(model);
                    TempData.Add("QaWbExRzTqfYGZAXaCAVrBN", string.Format("Başarıyla Eklendi"));
                    return RedirectToAction("SliderControl");
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult WorkerWithoutVehicle() => View(_workerWithoutVehicleService.GetAll());
        public IActionResult WorkerWithVehicle() => View(_workerWithVehicleService.GetAll());
        public IActionResult Contact() => View(_contactService.GetAll());
        public IActionResult WorkerWithVehicleDetail(int id)
        {
            var entity = _workerWithVehicleService.GetAll().Where(x => x.WorkerId == id).ToList();
            var personName = _workerWithVehicleService.GetAll().Where(x => x.WorkerId == id).Select(x => x.WorkerName).FirstOrDefault();
            ViewBag.application = personName;
            return View(entity);
        }
        public IActionResult WorkerWithoutVehicleDetail(int id)
        {
            var entity = _workerWithoutVehicleService.GetAll().Where(x => x.WorkerId == id).ToList();
            var applicationName = _workerWithoutVehicleService.GetAll().Where(x => x.WorkerId == id).Select(x => x.WorkerName + " " + x.WorkerSurname).FirstOrDefault();
            ViewBag.application2 = applicationName;
            return View(entity);
        }
        public IActionResult WorkerWithoutVehicleRead(int id)
        {
            _workerWithoutVehicleService.ChangeReadStatus(id);
            return RedirectToAction("WorkerWithoutVehicle");
        }
        public IActionResult ContactDelete(int id)
        {
            var model = _contactService.GetById(id);
            _contactService.Delete(model);
            return RedirectToAction("Contact");
        }
        public IActionResult ContactRead(int id)
        {
            _contactService.ChangeReadStatus(id);
            return RedirectToAction("Contact");
        }
        public IActionResult WorkerWithVehicleDelete(int id)
        {
            var model = _workerWithVehicleService.GetById(id);
            _workerWithVehicleService.Delete(model);
            return RedirectToAction("WorkerWithVehicle");
        }
        public IActionResult WorkerWithVehicleRead(int id)
        {
            _workerWithVehicleService.ChangeReadStatus(id);
            return RedirectToAction("WorkerWithVehicle");
        }
        public IActionResult WorkerWithoutVehicleDelete(int id)
        {
            var model = _workerWithoutVehicleService.GetById(id);
            _workerWithoutVehicleService.Delete(model);
            return RedirectToAction("WorkerWithoutVehicle");
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult SliderControl() => View(_sliderService.GetAll());
        public IActionResult SliderControlDelete(int id, string fileName)
        {
            var model = _sliderService.GetById(id);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\slide", fileName);
            if (System.IO.File.Exists(path))
            {
                _sliderService.Delete(model);
                System.IO.File.Delete(path);
            }
            TempData.Add("QaWbExRzTqfYGZAXaCAVrfT", string.Format("Başarıyla Silindi"));
            return RedirectToAction("SliderControl");
        }
        public IActionResult PhotoGalleryControl() => View(_photoGalleryService.GetAll());
        public IActionResult PhotoGalleryControlDelete(int id, string fileName)
        {
            var model = _photoGalleryService.GetById(id);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\recent-photos", fileName);
            FileInfo fi = new FileInfo(fileName);
            if (System.IO.File.Exists(path))
            {
                _photoGalleryService.Delete(model);
                System.IO.File.Delete(path);
            }
            TempData.Add("qqewrqbqrwqtmqAAAADazdaRemNBENb", string.Format("Başarıyla silindi"));
            return RedirectToAction("PhotoGalleryControl");
        }
        public IActionResult PhotoGalleryAdd() => View();
        [HttpPost]
        public async Task<IActionResult> PhotoGalleryAdd(IFormFile file, PhotoGallery model)
        {
            if (file != null)
            {
                if (file.Length > 5000000)
                {
                    TempData.Add("qqewrqbqrwqtmqAAAADazdaDEQNBENb", string.Format("Dosya boyutu 5 MB'tan fazla olmaz"));
                    return RedirectToAction("PhotoGalleryAdd");
                }
                if (file.ContentType == "image/jpeg" || file.ContentType == "image/jpg" || file.ContentType == "image/png")
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\recent-photos", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    model.PhotoName = file.FileName;
                    _photoGalleryService.Add(model);
                    TempData.Add("QaWbExRzTqfYGZAXaCAVrBA", string.Format("Başarıyla Eklendi"));
                    return RedirectToAction("PhotoGalleryControl");
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult EmployeeControl()
        {
            var employeControl = _employeeTransportService.GetAll();
            OurServicesModel model = new OurServicesModel();
            model.EmployeeTransports = employeControl;
            return View(model);
        }
        public IActionResult EmployeeControlDelete(EmployeeTransport model)
        {
            _employeeTransportService.Delete(model);
            TempData.Add("qqewrqbqrwqtmqAAAADazdaRemNeMpLoye", string.Format("Başarıyla silindi"));
            return RedirectToAction("EmployeeControl");
        }
        public IActionResult StudentControl()
        {
            var studentControl = _studentTransportService.GetAll();
            OurServicesModel model = new OurServicesModel();
            model.StudentTransports = studentControl;
            return View(model);
        }
        public IActionResult StudentControlDelete(StudentTransport model)
        {
            _studentTransportService.Delete(model);
            TempData.Add("qqewrqbqrwqtmqAAAADazdaRemNstuDenT", string.Format("Başarıyla silindi"));
            return RedirectToAction("StudentControl");
        }
        public IActionResult VipControl()
        {
            var vipControl = _vipTransportService.GetAll();
            OurServicesModel model = new OurServicesModel();
            model.VipTransports = vipControl;
            return View(model);
        }
        public IActionResult VipControlDelete(VipTransport model)
        {
            _vipTransportService.Delete(model);
            TempData.Add("qqewrqbqrwqtmqAAAADazdaRemNviP", string.Format("Başarıyla silindi"));
            return RedirectToAction("VipControl");
        }
        public IActionResult EmployeeControlAdd() => View();
        [HttpPost]
        public IActionResult EmployeeControlAdd(EmployeeTransport model)
        {
            _employeeTransportService.Add(model);
            return RedirectToAction("EmployeeControl");
        }
        public IActionResult StudentControlAdd() => View();
        [HttpPost]
        public IActionResult StudentControlAdd(StudentTransport model)
        {
            _studentTransportService.Add(model);
            return RedirectToAction("StudentControl");
        }
        public IActionResult VipControlAdd() => View();
        [HttpPost]
        public IActionResult VipControlAdd(VipTransport model)
        {
            _vipTransportService.Add(model);
            return RedirectToAction("VipControl");
        }
        public IActionResult InstitutionalControl() => View(_institutionalService.GetAll());
        [HttpPost]
        public IActionResult InstitutionalControl(Institutional model)
        {
            _institutionalService.Delete(_institutionalService.GetAll().First());
            _institutionalService.Add(model);
            TempData.Add("qqewrqbqrwqtmqAAAADazdaRemNinsT", string.Format("Başarıyla güncellendi"));
            return RedirectToAction("InstitutionalControl");
        }
        public IActionResult NewManager()
        {
            ViewBag.SecretQuestions = new SelectList(new List<string>() { "Annenizin kızlık soyadı nedir?", "İlk evcil hayvanınızın adı nedir?", "İlk aracınızın modeli nedir?", "Hangi şehirde doğdunuz?", "Babanızın ortanca ismi nedir?", "Çocukluk lakabınız nedir?" });
            return View();
        }
        [HttpPost]
        public IActionResult NewManager(Admin model)
        {
            if (model.UserName != null & model.Password != null & model.SecretQuestion != null & model.SecretAnswer != null)
            {
                _adminService.Add(model);
                TempData.Add("ADHGSFJSGVnvnAJDcnlzaPsaqQB", string.Format("Başarıyla eklendi"));
                return RedirectToAction("Index");
            }
            TempData.Add("ADHGSFJSGVnvnAJDcnlzaPsaQqB", string.Format("Ekleme işlemi gerçekleşmedi"));
            return RedirectToAction("NewManager");
        }
        public IActionResult FindManager() => View(_adminService.GetAll());
        public IActionResult UpdateManager(int id)
        {
            var model = _adminService.BringAdmin(id);
            return View(new Admin() { AdminId = model.AdminId, SecretQuestion = model.SecretQuestion, UserName = model.UserName });
        }
        [HttpPost]
        public IActionResult UpdateManager(Admin model, int id)
        {
            var entity = _adminService.GetById(id);
            model.UserName = entity.UserName;
            model.SecretQuestion = entity.SecretQuestion;
            if (model.UserName != null && model.Password != null)
            {
                if (entity.SecretAnswer == model.SecretAnswer)
                {
                    entity.Password = model.Password;
                    _adminService.Update(entity);
                    TempData.Add("ADHGSFJSGVnvnsaqrwqwrqrwsZZzzqB", string.Format("Şifre başarıyla değiştirildi"));
                    return RedirectToAction("FindManager");
                }
                TempData.Add("ADHGSFJSGVnvnsasZZzzqBaAAabBAqr", string.Format("Gizli soru cevabınız yanlış"));
                return RedirectToAction("UpdateManager", entity.AdminId);
            }
            TempData.Add("ADHGSFJSGVnvnadaqqQQzzqBaAAabBAqr", string.Format("Kullanıcı adı veya parola boş geçilemez"));
            return RedirectToAction("UpdateManager", entity.AdminId);
        }
        public IActionResult OurHistory() => View(_ourHistoryService.GetAll());
        public IActionResult OurHistoryAdd() => View();
        [HttpPost]
        public IActionResult OurHistoryAdd(OurHistory model)
        {
            _ourHistoryService.Add(model);
            TempData.Add("qqewrqbqrwqtmqAAAADazdaRemNhiStR", string.Format("Başarıyla eklendi"));
            return RedirectToAction("OurHistory");
        }
        public IActionResult OurHistoryDelete(OurHistory model)
        {
            _ourHistoryService.Delete(model);
            TempData.Add("qqewrqbqrwqtmqAAAADazdaRemNhiStRdeL", string.Format("Başarıyla silindi"));
            return RedirectToAction("OurHistory");
        }
        public IActionResult OurReferences() => View(_ourReferencesService.GetAll());
        public IActionResult OurReferencesAdd() => View();
        [HttpPost]
        public async Task<IActionResult> OurReferencesAdd(OurReferences model, IFormFile file)
        {
            if (file != null)
            {
                if (file.Length > 5000000)
                {
                    TempData.Add("sDqaCXcvvswetqwQErfsdfqQDRA", string.Format("Dosya boyutu 5 MB üzeri olamaz"));
                    return RedirectToAction("OurReferencesAdd");
                }
                if (file.ContentType == "image/jpeg" || file.ContentType == "image/jpg" || file.ContentType == "image/png")
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\reference", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    model.ReferenceLogo = file.FileName;
                    _ourReferencesService.Add(model);
                    TempData.Add("QaWbExRzTqfYGZAXaCAVrBn", string.Format("Başarıyla Eklendi"));
                    return RedirectToAction("OurReferences");
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult OurReferencesDelete(OurReferences model, string fileName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\reference", fileName);
            if (System.IO.File.Exists(path))
            {
                _ourReferencesService.Delete(model);
                System.IO.File.Delete(path);
            }
            TempData.Add("QaWbExRzTqfYGZAXaCAVRfT", string.Format("Başarıyla Silindi"));
            return RedirectToAction("OurReferences");
        }
        public IActionResult IconDescription() => View(_iconDescriptionService.GetAll());
        public IActionResult IconDescriptionUpdate(int id)
        {
            ViewBag.Icons = new SelectList(new List<string>() { "bi bi-laptop", "bi-calendar-event", "bi bi-diagram-3", "bi-bug-fill", "ri-police-car-fill", "bi-emoji-smile-fill", "bi bi-alarm", "bi bi-display", "bi bi-arrow-repeat", "bi bi-battery-charging", "bi bi-bell-fill", "bi bi-brightness-high", "bi bi-brightness-alt-high", "bi bi-broadcast-pin", "bi bi-calculator", "bi bi-camera", "bi bi-capslock", "bi bi-chat-left-text", "bi bi-check-circle", "bi bi-cloud-sun", "bi bi-emoji-wink", "bi bi-eye", "bi bi-file-person", "bi bi-file-music", "bi bi-globe2" });
            return View(_iconDescriptionService.GetById(id));
        }
        [HttpPost]
        public IActionResult IconDescriptionUpdate(IconDescription model)
        {
            var entity = _iconDescriptionService.GetById(model.Id);
            if (model.Icon == null)
            {
                TempData.Add("DaSsaWbExRzTqfYGZAXaCAVRfT", string.Format("İkon seçmek zorunludur"));
                return RedirectToAction("IconDescriptionUpdate", model.Id);
            }
            entity.Icon = model.Icon;
            entity.ShortDescription = model.ShortDescription;
            entity.LongDescription = model.LongDescription;
            _iconDescriptionService.Update(entity);
            TempData.Add("QaWbEqwrmqwtmqYGZAaAxVRfT", string.Format("Başarıyla Güncellendi"));
            return RedirectToAction("IconDescription");
        }
        public IActionResult ContactEdit() => View(_contactEditService.GetAll());
        [HttpPost]
        public IActionResult ContactEdit(ContactEdit model)
        {
            _contactEditService.Delete(_contactEditService.GetAll().First());
            _contactEditService.Add(model);
            TempData.Add("qqewrqbqrwqtmqAAAADazdaRemNicooNT", string.Format("Başarıyla güncellendi"));
            return RedirectToAction("ContactEdit");
        }
    }
}

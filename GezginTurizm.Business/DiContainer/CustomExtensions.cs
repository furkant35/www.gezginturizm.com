using GezginTurizm.Business.Abstract;
using GezginTurizm.Business.Concrete;
using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.DiContainer
{
    public static class CustomExtensions
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAdminDal, EfAdminDal>();
            services.AddScoped<IAdminService, AdminManager>();

            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<IEmployeeTransportDal, EfEmployeeTransportDal>();
            services.AddScoped<IEmployeeTransportService, EmployeeTransportManager>();

            services.AddScoped<IInstitutionalDal, EfInstitutionalDal>();
            services.AddScoped<IInstitutionalService, InstitutionalManager>();

            services.AddScoped<IPhotoGalleryDal, EfPhotoGalleryDal>();
            services.AddScoped<IPhotoGalleryService, PhotoGalleryManager>();

            services.AddScoped<ISliderDal, EfSliderDal>();
            services.AddScoped<ISliderService, SliderManager>();

            services.AddScoped<IStudentTransportDal, EfStudentTransportDal>();
            services.AddScoped<IStudentTransportService, StudentTransportManager>();

            services.AddScoped<IVipTransportDal, EfVipTransportDal>();
            services.AddScoped<IVipTransportService, VipTransportManager>();

            services.AddScoped<IWorkerWithoutVehicleDal, EfWorkerWithoutVehicleDal>();
            services.AddScoped<IWorkerWithoutVehicleService, WorkerWithoutVehicleManager>();

            services.AddScoped<IWorkerWithVehicleDal, EfWorkerWithVehicleDal>();
            services.AddScoped<IWorkerWithVehicleService, WorkerWithVehicleManager>();

            services.AddScoped<IOurHistoryDal, EfOurHistoryDal>();
            services.AddScoped<IOurHistoryService, OurHistoryManager>();

            services.AddScoped<IOurReferencesDal, EfOurReferencesDal>();
            services.AddScoped<IOurReferencesService, OurReferencesManager>();

            services.AddScoped<IIconDescriptionDal, EfIconDescriptionDal>();
            services.AddScoped<IIconDescriptionService, IconDescriptionManager>();

            services.AddScoped<IContactEditDal, EfContactEditDal>();
            services.AddScoped<IContactEditService, ContactEditManager>(); ;
        }
    }
}

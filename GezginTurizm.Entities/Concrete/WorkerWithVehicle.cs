using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GezginTurizm.Entities.Concrete
{
    public class WorkerWithVehicle:IEntity
    {
        [Key]
        public int WorkerId { get; set; }
        public string VehiclePlate { get; set; }
        public string VehicleBrand { get; set; }
        public int VehicleModel { get; set; }
        public string VehicleType { get; set; }
        public string VehicleColor { get; set; }
        public int VehicleSeatNumber { get; set; }
        public bool VehiclePersonToWork { get; set; }


        public string WorkerName { get; set; }
        public string WorkerPhone { get; set; }
        public string WorkerAddress { get; set; }
        public bool WorkerWorkingStatus { get; set; }
        public bool WorkerRetirementStatus { get; set; }

        public string DocumentDriverLicenseType { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Evrak Ehliyet Tarih")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DocumentDriverLicenseDate { get; set; }
        public bool DocumentPsychoTechnics { get; set; }
        public bool DocumentDriverIntroduction { get; set; }
        public string DocumentWorkExperience { get; set; }
        public string DocumentReference { get; set; }
        public string DocumentExplanation { get; set; }
        public bool DocumentSRC1 { get; set; }
        public bool DocumentSRC2 { get; set; }
        public bool DocumentSRC3 { get; set; }
        public bool DocumentSRC4 { get; set; }
        public bool isRead { get; set; }
    }
}

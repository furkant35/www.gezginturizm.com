using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GezginTurizm.Entities.Concrete
{
   public class WorkerWithoutVehicle:IEntity
    {
        [Key]
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Isci Ehliyet Tarih")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime WorkerDateOfBirth { get; set; }
        public string WorkerPhone { get; set; }
        public string WorkerAddress { get; set; }
        public bool WorkerRetirementStatus { get; set; }
        public bool WorkerWorkStatus { get; set; }
        public string WorkerDriverLicenseType { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Isci Ehliyet Tarih")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime WorkerDriverLicenseDate { get; set; }
        public bool WorkerPsychotechnics { get; set; }
        public bool WorkerDriverIntroduction { get; set; }
        public string WorkerWorkExperience { get; set; }
        public string Explanation { get; set; }


        public bool WorkerSRC1 { get; set; }
        public bool WorkerSRC2 { get; set; }
        public bool WorkerSRC3 { get; set; }
        public bool WorkerSRC4 { get; set; }
        public bool isRead { get; set; }
    }
}

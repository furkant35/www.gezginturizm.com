using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GezginTurizm.Entities.Concrete
{
    public class Institutional:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string AboutUs { get; set; }
        public string AboutUsPhoto { get; set; }
        public string OurMission { get; set; }
        public string OurMissionPhoto { get; set; }
        public string OurVision { get; set; }
        public string OurVisionPhoto { get; set; }
    }
}

using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GezginTurizm.Entities.Concrete
{
    public class Slider:IEntity
    {
        [Key]
        public int SliderId { get; set; }
        public string SliderPhoto { get; set; }
    }
}

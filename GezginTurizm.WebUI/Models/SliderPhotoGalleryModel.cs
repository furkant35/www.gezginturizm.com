using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GezginTurizm.WebUI.Models
{
    public class SliderPhotoGalleryModel
    {
        public IEnumerable<Slider> Slider { get; set; }
        public IEnumerable<PhotoGallery> PhotoGallery { get; set; }
        public IEnumerable<OurHistory> OurHistories { get; set; }
        public IEnumerable<OurReferences> OurReferences { get; set; }
        public IEnumerable<IconDescription> IconDescriptions { get; set; }
    }
}

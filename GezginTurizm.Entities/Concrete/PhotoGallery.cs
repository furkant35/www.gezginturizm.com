using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GezginTurizm.Entities.Concrete
{
    public class PhotoGallery:IEntity
    {
        [Key]
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
    }
}

using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GezginTurizm.Entities.Concrete
{
    public class StudentTransport:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ServiceCategoryId { get; set; }
        public string Text { get; set; }
    }
}

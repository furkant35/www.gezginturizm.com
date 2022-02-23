using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GezginTurizm.Entities.Concrete
{
    public class OurHistory:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
    }
}

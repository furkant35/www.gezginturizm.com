using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Entities.Concrete
{
    public class IconDescription : IEntity
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}

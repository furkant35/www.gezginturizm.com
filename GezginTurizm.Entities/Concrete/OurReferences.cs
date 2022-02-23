using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Entities.Concrete
{
    public class OurReferences : IEntity
    {
        public int Id { get; set; }
        public string ReferenceWebSite { get; set; }
        public string ReferenceLogo { get; set; }
    }
}

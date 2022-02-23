using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GezginTurizm.WebUI.Models
{
    public class OurServicesModel
    {
        public IEnumerable<EmployeeTransport> EmployeeTransports { get; set; }
        public IEnumerable<StudentTransport> StudentTransports { get; set; }
        public IEnumerable<VipTransport> VipTransports { get; set; }
    }
}

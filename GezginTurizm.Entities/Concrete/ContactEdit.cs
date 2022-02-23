using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Entities.Concrete
{
    public class ContactEdit:IEntity
    {
        public int Id { get; set; }
        public string Maps { get; set; }
        public string Address { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
    }
}

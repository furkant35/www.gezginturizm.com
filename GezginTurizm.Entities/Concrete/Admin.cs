using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GezginTurizm.Entities.Concrete
{
    public class Admin:IEntity
    {
        [Key]
        public int AdminId { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string UserName { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string Password { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
    }
}

using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Abstract
{
    public interface IAdminService : IGenericService<Admin>
    {
        Admin BringAdmin(int id);
    }
}

using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeTransportDal : EfEntityRepositoryBase<EmployeeTransport, GezginContext>, IEmployeeTransportDal
    {
    }
}

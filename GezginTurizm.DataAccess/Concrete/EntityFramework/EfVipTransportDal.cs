﻿using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.DataAccess.Concrete.EntityFramework
{
    public class EfVipTransportDal : EfEntityRepositoryBase<VipTransport, GezginContext>, IVipTransportDal
    {
    }
}

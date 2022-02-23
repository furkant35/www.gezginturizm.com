using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.DataAccess.Abstract
{
    public interface IContactDal : IEntityRepository<Contact>
    {
        void SendMail();
        int CountUnreadNotification();
        void ChangeReadStatus(int id);
    }
}

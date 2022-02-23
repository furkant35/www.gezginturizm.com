using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        void SendMail();
        int CountUnreadNotification();
        void ChangeReadStatus(int id);
    }
}

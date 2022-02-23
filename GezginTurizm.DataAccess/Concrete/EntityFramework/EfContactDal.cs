using GezginTurizm.DataAccess.Abstract;
using GezginTurizm.DataAccess.StringInfo;
using GezginTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace GezginTurizm.DataAccess.Concrete.EntityFramework
{
    public class EfContactDal : EfEntityRepositoryBase<Contact, GezginContext>, IContactDal
    {
        public void ChangeReadStatus(int id)
        {
            using (GezginContext context = new GezginContext())
            {
                var model = context.Contacts.Where(x => x.ContactId == id).FirstOrDefault();
                if (!model.isRead)
                {
                    model.isRead = true;
                    context.SaveChanges();
                }
            }
        }

        public int CountUnreadNotification()
        {
            using (GezginContext context = new GezginContext())
            {
                return context.Contacts.Count(x => x.isRead == false);
            }
        }

        public void SendMail()
        {
            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(SecretInfo.FromEmailAddress, SecretInfo.FromEmailPassword);
            client.Port = 587;
            client.Host = "rd-minio-win.guzelhosting.com";
            client.EnableSsl = true;
            message.To.Add(SecretInfo.ToAddEmailAddress);
            message.From = new MailAddress(SecretInfo.FromEmailAddress);
            message.Subject = "Yeni İletişim Mesajı Bildirimi";
            message.Body = DateTime.Now.ToString() + " tarihinde bir yeni iletişim mesajı alınmıştır.Website paneline giderek kontrol edebilirsiniz.";
            client.Send(message);
        }
    }
}

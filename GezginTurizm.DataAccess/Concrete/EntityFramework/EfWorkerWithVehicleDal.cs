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
    public class EfWorkerWithVehicleDal : EfEntityRepositoryBase<WorkerWithVehicle, GezginContext>, IWorkerWithVehicleDal
    {
        public void ChangeReadStatus(int id)
        {
            using (GezginContext context = new GezginContext())
            {
                var model = context.WorkerWithVehicles.Where(x => x.WorkerId == id).FirstOrDefault();
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
                return context.WorkerWithVehicles.Count(x => x.isRead == false);
            }
        }

        public void SendEmail()
        {
            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(SecretInfo.FromEmailAddress, SecretInfo.FromEmailPassword);
            client.Port = 587;
            client.Host = "rd-minio-win.guzelhosting.com";
            client.EnableSsl = true;
            message.To.Add(SecretInfo.ToAddEmailAddress);
            message.From = new MailAddress(SecretInfo.FromEmailAddress);
            message.Subject = "Yeni Araç ile İşçi Başvurusu Bildirimi";
            message.Body = DateTime.Now.ToString() + " tarihinde bir yeni araç ile işçi başvurusu alınmıştır.Website paneline giderek kontrol edebilirsiniz.";
            client.Send(message);
        }
    }
}

using GezginTurizm.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace GezginTurizm.DataAccess.Concrete.EntityFramework
{
    public class GezginContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("+++++");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EmployeeTransport> EmployeeTransports { get; set; }
        public DbSet<StudentTransport> StudentTransports { get; set; }
        public DbSet<VipTransport> VipTransports { get; set; }
        public DbSet<Institutional> Institutionals { get; set; }
        public DbSet<PhotoGallery> PhotoGalleries { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<WorkerWithoutVehicle> WorkerWithoutVehicles { get; set; }
        public DbSet<WorkerWithVehicle> WorkerWithVehicles { get; set; }
        public DbSet<OurHistory> OurHistories { get; set; }
        public DbSet<OurReferences> OurReferences { get; set; }
        public DbSet<IconDescription> IconDescriptions { get; set; }
        public DbSet<ContactEdit> ContactEdits { get; set; }
    }
}

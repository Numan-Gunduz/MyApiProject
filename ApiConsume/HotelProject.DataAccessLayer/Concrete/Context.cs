using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EV2S3I4; database=ApiDB;integrated security = true; TrustServerCertificate=True");
        }
        public DbSet<Room>Rooms { get; set; }
        public DbSet<Service>Services { get; set; }
        public DbSet<Staff>Staff { get; set; }
        public DbSet<Subscribe>Subscribes { get; set; }
        public DbSet<Testimonial>Testimonials { get; set; }
    }
}

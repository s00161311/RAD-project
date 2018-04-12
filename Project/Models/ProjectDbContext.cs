using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Lecturer> Lecrurers { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
    }
}
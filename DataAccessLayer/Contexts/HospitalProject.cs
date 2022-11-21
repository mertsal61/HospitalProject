using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class HospitalProject:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MERT\\SQLEXPRESS;database=DbHospital;integrated security=true;TrustServerCertificate=True;");
        }

        public DbSet<Reservations> reservations { get; set; }
        public DbSet<Reports> reports { get; set; }
        

    }
}

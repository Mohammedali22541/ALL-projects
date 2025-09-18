using EF_Core_1.AirLine_Models;
using EF_Core_1.ITI_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.DataBaseDbContext
{
    internal class AirLineDbContext:DbContext
    {
        public AirLineDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = MOHAMMEDALI\\MSSQLSERVERR; Database = AirLineEfCore; Trusted_connection = true; TrustServerCertificate = true");
        }

        public DbSet<Aircraft> aircraft { get; set; }
        public DbSet<Aircraft_Routes> aircraft_Routes { get; set; }
        public DbSet<Airline> airlines { get; set; }
        public DbSet<Airline_phones> airline_Phones { get; set; }
        public DbSet<Emp_Qualifications> emp_Qualifications { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Route> routes { get; set; }
        public DbSet<Transaction> transactions { get; set; }
    }
}

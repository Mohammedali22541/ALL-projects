using Microsoft.EntityFrameworkCore;
using Relationship___Assignment_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Relationship___Assignment_3.DataBaseContext
{
    internal class AirlineDbContext:DbContext
    {
        public AirlineDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = MOHAMMEDALI\\MSSQLSERVERR; Database = AirlineCompleted; Trusted_connection = true; TrustServerCertificate = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<AirLinePhones> AirLinePhones { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeQualifications> EmployeeQualifications { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<AircraftRoute> AircraftRoutes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}

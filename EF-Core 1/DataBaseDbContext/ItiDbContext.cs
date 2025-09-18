using EF_Core_1.ITI_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.DataBaseDbContext
{
    internal class ItiDbContext:DbContext
    {
        public ItiDbContext():base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = MOHAMMEDALI\\MSSQLSERVERR; Database = ItiEfCore; Trusted_connection = true; TrustServerCertificate = true");
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Instructors> instructors { get; set; }
        public DbSet<Courses> courses { get; set; }
        public DbSet<Topics> topics { get; set; }
        public DbSet<Stud_course> stud_Courses { get; set; }
        public DbSet<Course_Instructor> course_Instructors { get; set; }


    }
}

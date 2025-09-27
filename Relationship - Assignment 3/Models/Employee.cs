using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship___Assignment_3.Models
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string? EmpAddress { get; set; }
        public string? Gender { get; set; }
        public string Position { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        [InverseProperty(nameof(Airline.Employees))]
        public Airline Airline { get; set; }
        //forign key
        public int AirlineID { get; set; }

        public ICollection<EmployeeQualifications> EmployeeQualifications { get; set; }

    }
}

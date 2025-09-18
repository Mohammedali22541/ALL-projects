using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.ITI_Models
{
    internal class Instructors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public int Bouns { get; set; }
        public decimal Salary { get; set; }
        public decimal Hour_Rate { get; set; }
        public int Dep_Id { get; set; }
    }
}

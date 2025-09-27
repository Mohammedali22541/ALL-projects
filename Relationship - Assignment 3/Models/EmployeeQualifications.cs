using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship___Assignment_3.Models
{
    internal class EmployeeQualifications
    {
        public int EmpId { get; set; }
        public string Qualification { get; set; }

        public Employee Employee { get; set; }

    }
}

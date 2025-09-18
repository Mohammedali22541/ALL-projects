using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.ITI_Models
{
    internal class Students
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string? LName { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public int Dep_Id { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.ITI_Models
{
    internal class Departments
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateTime { get; set; }
        public int Ins_Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.AirLine_Models
{
    internal class Emp_Qualifications
    {
        public int Id { get; set; }

        public int Emp_Id { get; set; }
        public string Qualifications { get; set; }
    }
}

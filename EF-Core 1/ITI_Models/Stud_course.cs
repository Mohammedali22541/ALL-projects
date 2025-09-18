using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.ITI_Models
{
    internal class Stud_course
    {
        public int Id { get; set; }  
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public decimal Grade { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_2.ITI_Models
{
    internal class Course_Instructor
    {
        [Key]
        public int Course_Id { get; set; }
        public int Inst_Id { get; set; }
        [Precision(5,2)]
        public decimal Evaluation { get; set; }
    }
}

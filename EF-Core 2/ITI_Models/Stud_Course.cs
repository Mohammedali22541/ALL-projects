using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_2.ITI_Models
{
    internal class Stud_Course
    {

        [Column("StudentId")]
        [Key]
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        [Precision(5,3)]
        public decimal Grade { get; set; }
    }
}

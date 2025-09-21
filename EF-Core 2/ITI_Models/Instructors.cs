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
    internal class Instructors
    {
        [Column("InstructorId")]
        [Key]
        public int Id { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        public string? Address { get; set; }
        public int Bouns { get; set; }
        [Precision(10,2)]
        public decimal Salary { get; set; }
        [Precision(5,3)]
        public decimal Hour_Rate { get; set; }
        public int Dep_Id { get; set; }
    }
}

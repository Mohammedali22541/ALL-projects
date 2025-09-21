using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_2.ITI_Models
{
    internal class Courses
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Precision(5,2)]
        public decimal Duration { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        public int Top_Id { get; set; }
    }
}

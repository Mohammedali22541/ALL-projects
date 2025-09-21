using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_2.ITI_Models
{
    internal class Students
    {
        [Key]
        [Column("StudentId")]
        public int Id { get; set; }
        [Required]
        [StringLength(20,MinimumLength = 2 , ErrorMessage ="Your First Name Must Be Between 2 To 20")]
     
        public string FName { get; set; }
        public string? LName { get; set; }

        [Range(6,18, ErrorMessage ="Max Age is 18")]
        public int Age { get; set; }
        public string? Address { get; set; }
        public int Dep_Id { get; set; }

    }
}

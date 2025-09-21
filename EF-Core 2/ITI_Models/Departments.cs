using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_2.ITI_Models
{
    internal class Departments
    {
        [Column("DepartmentId")]
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string? Name { get; set; }
        
        public DateTime DateTime { get; set; }
        
        public int Ins_Id { get; set; }
    }
}

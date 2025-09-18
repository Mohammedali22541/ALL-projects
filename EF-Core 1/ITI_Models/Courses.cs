using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.ITI_Models
{
    internal class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Duration { get; set; }
        public string? Description { get; set; }
        public int Top_Id { get; set; }
    }
}

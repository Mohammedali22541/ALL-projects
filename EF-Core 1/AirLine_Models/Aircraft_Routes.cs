using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.AirLine_Models
{
    internal class Aircraft_Routes
    {
        public int Id { get; set; }
        public int Route_Id { get; set; }
        public string Departure { get; set; }
        public int Num_Of_Pass { get; set; }

        public decimal Price { get; set; }
        public decimal Arrival { get; set; }
    }
}

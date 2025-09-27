using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship___Assignment_3.Models
{
    internal class AircraftRoute
    {
        public int NumberOfPassenger { get; set; }
        public decimal Price { get; set; }
        public string Departure { get; set; }
        public DateTime Arrival { get; set; }
        public decimal Duration { get; set; }

        public Aircraft Aircraft { get; set; }
        public Route Route { get; set; }
        public int Aircraft_Id { get; set; }
        public int RouteId { get; set; }


    }
}

using EF_Core_2.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship___Assignment_3.Models
{
    internal class Aircraft
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string? Model { get; set; }
        public Airline Airline { get; set; }
        public int AirlineID { get; set; }

        public Crew Crew { get; set; }

        public ICollection<AircraftRoute> AircraftRoutes { get; set; }

    }
}

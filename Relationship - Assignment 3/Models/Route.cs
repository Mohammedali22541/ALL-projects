using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship___Assignment_3.Models
{
    internal class Route
    {
        public int RouteId { get; set; }
        public string Classification { get; set; }
        public string Distance { get; set; }
        public string Orgin { get; set; }
        public string Distination { get; set; }

        public ICollection<AircraftRoute> AircraftRoutes { get; set; }
    }
}

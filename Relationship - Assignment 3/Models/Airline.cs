using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship___Assignment_3.Models
{
    internal class Airline
    {
        public int AirlineID { get; set; }
        public string AirlineName { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        [InverseProperty(nameof(Employee.Airline))]

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Aircraft> Aircraft { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        public ICollection<AirLinePhones> AirLinePhones { get; set; }

    }
}

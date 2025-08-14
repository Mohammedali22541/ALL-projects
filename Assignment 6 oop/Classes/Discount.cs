using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Classes
{
    internal abstract class Discount
    {
        public abstract string? Name{ get; set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity); 
    }
}

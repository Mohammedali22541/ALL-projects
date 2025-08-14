using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Classes
{
    internal class NoDiscount : Discount
    {
      

        public override string? Name { get; set; }
  public NoDiscount(string? name)
        {
            Name = name;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return 0;
        }
    }
}

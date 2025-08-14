using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Demo
{
    internal class Circle : Shape
    {
        public Circle(decimal radius)
        {
            D1 = D2 = radius;
        }
        public override decimal Perimeter
        {
            get { return 2 * D1 * 3.14M; }
        }

        public override decimal GetArea()
        {
            return (decimal)Math.PI * D1 * D1;
        }
    }
}

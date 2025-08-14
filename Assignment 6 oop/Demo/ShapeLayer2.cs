using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Demo
{
    internal abstract class ShapeLayer2 : Shape
    {

        public override decimal GetArea()
        {
            return D1 * D2; 
        }
    }
}

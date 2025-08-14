using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Demo
{
    internal class Rectangle : ShapeLayer2
    {
        public override decimal Perimeter 
        {
            get { return D1 * D2 * 2; }
        }

       
    }
}

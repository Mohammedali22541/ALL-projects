using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Demo
{
    internal class Square : ShapeLayer2
    {
        public Square(decimal side)
        {
            D1 = D2 = side;
        }
        public override decimal Perimeter
        {
            get { return D1 * 4;   }
        }


      
    }
}

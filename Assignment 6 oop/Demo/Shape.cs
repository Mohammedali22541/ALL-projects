using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Demo
{
    internal abstract class Shape
    {
        public decimal D1 { get; set; }
        public decimal D2 { get; set; }


        public abstract decimal GetArea();

        public abstract decimal Perimeter { get;  }
    }
}

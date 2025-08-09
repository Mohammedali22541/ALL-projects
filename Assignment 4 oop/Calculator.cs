using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_oop
{
    internal class Calculator
    {
        #region Properties
        public int x { get; set; }
        public int y { get; set; }
        #endregion

        #region Methods

        public  int Add (int x, int y)
        {
            return x + y;
        }

        public  int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public  double Add(double x, double y) {  
            return x + y;
        }
        #endregion

    }
}

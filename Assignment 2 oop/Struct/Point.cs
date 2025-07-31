using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop.Struct
{
    internal struct Point
    {
        #region Attributes
        public int x;
        public int y;
        #endregion

        public Point(int X , int Y )
        {
            x = X;
            y = Y;


        }

        

        public override string ToString() {
            return $"x = {x} , y = {y}";
        }
    }
    
     

}

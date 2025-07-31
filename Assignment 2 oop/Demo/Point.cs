using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop.Demo
{
    internal struct Point
    {
        #region Attributes
        public int x;
        public int y;
        #endregion

        #region Constructor Methods
        //default constructor parameterless 
        public Point()
        {
            x = 0;
            y = default;

        }

        /// constructor take parameter
        /// one using this keyword because parameter has same name like attribute
        /// and other not using this
        public Point (int x, int Y)
        {
            this.x = x;
            y = Y;

        }

        /// constructor take one parameter and put it to x and y
        public Point (int number)
        {
            x = y = number;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"x = {x} , y = {y}";
        }


        #endregion
    }
}

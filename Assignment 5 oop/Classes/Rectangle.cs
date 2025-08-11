using Assignment_5_oop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Classes
{
    internal class Rectangle:IRectangle
    {
        #region Properties
        public int Height { get; set; }
        public int Width { get; set; }
        public double Area => Height * Width;
        #endregion

        #region Methods
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"I Am A Rectangle And Area  Is {Area}");
        }

        #endregion
    }
}

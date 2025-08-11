using Assignment_5_oop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Classes
{
    internal class Circle : ICircle
    {
        #region Properties
		
       public double Area { get; set; }
        #endregion

        #region Methods
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This IS Circle and Area is {Area}");
        } 
        #endregion
    }
}

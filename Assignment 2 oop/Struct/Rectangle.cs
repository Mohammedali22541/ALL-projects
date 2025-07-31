using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop.Struct
{
    internal struct Rectangle
    {
        #region attributes
        private double width;
        private double height;
        #endregion

        #region propeties
        public double Width
        {
            get { return width; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Error Width Must Be Positive !");
                }
                else
                {
                    width = value;

                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error Height Must Be Positive !");
                }
                else
                {
                    height = value;

                }
            }
        }

        public double Area
        {
            get { return width * height; }

        }
        #endregion


        #region Method

        //public override string ToString()
        //{
        //    return $"width is {width} and height is {height}";
        //}


        public void DisplayInfo()
        {
            Console.Clear();
            Console.WriteLine($"Height is: {Height} \n and Width is {Width} \n and Area is {Area}");
        }
        #endregion



    }

    
}

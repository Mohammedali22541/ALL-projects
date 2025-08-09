using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_oop
{
    internal class Rectangle
    {
        #region Properties
        public int Height {  get; set; }
        public int Width { get; set; }
        #endregion
      
        public Rectangle()
        {
            Height = 0;
            Width = 0;

        }

        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public Rectangle(int x)
        {
            this.Width = this.Height = x;
        }
    }
}

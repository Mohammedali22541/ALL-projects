using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_oop
{
    internal class Parent
    {
        #region Propeties

        public int x { get; set; }
        public int y { get; set; }
        #endregion

        #region Constructor
        public Parent(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"x = {x} , y = {y}";
        }


        public virtual int Product()
        {
            return x * y;
        }

        public void Myfun()
        {
            Console.WriteLine("I Am Parent");
        }
        #endregion

    }


}

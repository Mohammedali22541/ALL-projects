using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_oop
{
    internal class Child : Parent
    {
        #region Property
        public int z { get; set; }
        #endregion

        #region Constructor

        public Child(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"x = {x} , y = {y} , z = {z}";
        }

        public override int Product()
        {
            return base.Product() * z;
        }

        public new void Myfun()
        {
            Console.WriteLine("Iam Child");
        }
        #endregion
    }
}

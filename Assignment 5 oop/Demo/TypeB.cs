using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Demo
{
    internal class TypeB : TypeA
    {
        #region Properties
        public int B { get; set; }

        #endregion

        #region Constructor
        public TypeB(int a, int b) : base(a)
        {
            A = a;
            B = b;
        }


        #endregion

        #region Methods
        // Non Virtual Method
        public new void Myfun01()
        {
            Console.WriteLine("Iam Type B Child");
        }


        // Virtual Method
        public override void Myfun02()
        {
            Console.WriteLine($"Type B - A = {A} , B = {B}");
        }
        #endregion
    }
}

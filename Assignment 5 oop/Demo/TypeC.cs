using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Demo
{
    internal class TypeC : TypeB
    {
        #region Properties
        public int C { get; set; }
        #endregion

        #region Constructors
        public TypeC(int a, int b, int c) : base(a, b)
        {
            A = a; B = b; C = c;
        }
        #endregion

        #region Methods
        public new void Myfun01()
        {
            Console.WriteLine("Iam Type C Grand Child");
        }

        public override void Myfun02()
        {
            Console.WriteLine($"Type C - A = {A} , B = {B} , C = {C}");
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Demo
{
    internal class TypeD : TypeC
    {
        #region Properties

        public int D { get; set; }
        #endregion

        #region Constructors
        public TypeD(int a , int b , int c , int d):base(a,b,c) {
            A = a; B = b; C = c; D = d;
        }
        #endregion

        #region Methods
        public new void Myfun01()
        {
            Console.WriteLine("Iam Type D Child Of Grand Child");
        }

        public new virtual void Myfun02()
        {
            Console.WriteLine($"Type D - A = {A} , B = {B} , C = {C} , D = {D}");
        }
        #endregion
    }
}

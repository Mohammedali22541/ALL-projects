using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Demo
{
    internal class TypeE:TypeD
    {
        #region Properties
        public int E { get; set; }

        #endregion

        #region Constructors
        public TypeE(int a , int b , int c , int d , int e):base(a , b , c , d) { 
            
            A = a; B = b; C = c; D = d; E = e;
        }
        #endregion


        #region Methods
        public new void Myfun01()
        {
            Console.WriteLine("Iam Type E Grand Child Of Grand Child");
        }

        public override void Myfun02()
        {
            Console.WriteLine($"Type E - A = {A} , B = {B} , C = {C} , D = {D} , E = {E}");
        }
        #endregion
    }
}


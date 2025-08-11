using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Demo
{
    internal class TypeA
    {
        #region Properties
        public int A { get; set; }
        #endregion

        #region Constructors

        public TypeA(int a)
        {
            A = a;
        }
        #endregion

        #region Methods
        public void Myfun01()
        {
            Console.WriteLine("Iam Type A --  Base");
        }

        public virtual void Myfun02()
        {
            Console.WriteLine($"Type A - A={A}");
        }
        #endregion
    }
}

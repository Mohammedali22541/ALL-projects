using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_oop
{
    internal class ComplexNumber
    {
        #region Properties
        public int real { get; set; }
        public int imaginary { get; set; }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{real} + {imaginary} i";
        }
        #endregion

        #region Overloading

        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber
            {
                real = (left?.real ?? 0) + (right?.real ?? 0),
                imaginary = (left?.imaginary ?? 0) + (right?.imaginary ?? 0),
            };
        }

        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber
            {
                real = (left?.real ?? 0) - (right?.real ?? 0),
                imaginary = (left?.imaginary ?? 0) - (right?.imaginary ?? 0),
            };
        }
        #endregion

    }
}

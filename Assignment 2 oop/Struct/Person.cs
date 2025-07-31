using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop.Struct
{
   
    internal struct Person
    {
        #region Attributes
        public string? name;
        public int age;
        #endregion


        #region Method
        public override string ToString()
        {
            return $"name: {name} , age: {age}";
        } 
        #endregion
    }

}
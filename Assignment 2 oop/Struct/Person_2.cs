using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop.Struct
{
    internal struct Person_2
    {
       

        public string? name { get; set; }
        public int age { get; set; }

        public Person_2(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString() {
            return $"name is {name} , age is {age}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Demo
{
    internal class EmployeeNameComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return string.Compare(x.Name, y.Name);
            //return -string.Compare(x.Name, y.Name);
        }
    }
}

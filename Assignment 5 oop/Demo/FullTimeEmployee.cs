using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Demo
{

  
    internal class FullTimeEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; }

        #endregion

        #region Constructors
        public FullTimeEmployee(int id , string? name , int age , decimal salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }
        #endregion

        #region Methods
        public override void GetEmployeeData()
        {
            Console.WriteLine($"Data : Id = {Id} , Name = {Name} , Age = {Age} , Salary = {Salary}");
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Full Time Employee");
        }
        #endregion

    }
}

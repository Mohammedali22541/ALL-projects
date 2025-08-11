using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_oop.Demo
{
    internal class PartTimeEmployee : Employee
    {
        #region Properties
        public int CountOfHours { get; set; }
        public decimal HourRate { get; set; }

        #endregion

        #region Constructors
        public PartTimeEmployee(int id, string? name, int age, int countofHours, decimal hourRate)
        {

            Id = id;
            Name = name;
            Age = age;
            CountOfHours = countofHours;
            HourRate = hourRate;
        }
        #endregion

        #region Methods
        public override void GetEmployeeData()
        {
            Console.WriteLine($"Data : Id = {Id} , Name = {Name} , Age = {Age} , Count Of Hours = {CountOfHours} , Hour Rate = {HourRate}");

        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Part Time Employee");
        }
        #endregion
    }
}

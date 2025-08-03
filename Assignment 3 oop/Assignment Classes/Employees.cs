using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_oop.Assignment_Classes
{
    internal class Employees
    {

        #region Attributes
        private int salary;
        private string? name;
        #endregion

        #region Propeties
        public int EmployeeID { get; set; }
        //public string? EmployeeName { get; set; } // هعمل validation
        public string? EmployeeName
        {
            get {  return name; }
            set
            {
                if (!(value is null))
                {
                        name = value;
                }
                else
                {
                    Console.WriteLine("name cant be null");
                }
            }


        
        }

        public SecurityLevel SecurityLevel { get; set; }
        //public int EmployeeSalary { get; set; } // هعمل validation
        public int EmployeeSalary
        {
            get { return salary; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Salary Must Be Greater Than 0");
                }
                else
                {
                    salary = value;
                }

            }
        }

        //public DateOnly EmployeeHiringDate { get; set; } هغير فيه واخليه من نوع الكلاس اللي لسه عامله في السؤال التاني اللي هو hiring data
        public HiringDate EmployeeHiringDate { get; set; }
        public Gender EmployeeGender { get; set; }

        #endregion

        #region Constructors

      

        public Employees(int employeeID, string? employeeName, SecurityLevel securityLevel, int employeeSalary,HiringDate EmployeeHiringDate, Gender employeeGender)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            SecurityLevel = securityLevel;
            EmployeeSalary = employeeSalary;
            this.EmployeeHiringDate = EmployeeHiringDate;
            EmployeeGender = employeeGender;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            var currencyFormat = new System.Globalization.CultureInfo("en-US");
            return $"ID: {EmployeeID}, Name: {EmployeeName}, SecurityLevel: {SecurityLevel}, salary: {string.Format(currencyFormat , "{0:C}",EmployeeSalary)}, HireDate: {EmployeeHiringDate}, Gender: {EmployeeGender}";
        }
        #endregion


    }
}

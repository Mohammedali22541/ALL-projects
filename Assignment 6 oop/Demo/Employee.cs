using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oop.Demo
{
    internal class Employee :  ICloneable , IComparable<Employee>
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }

        public decimal Salary { get; set; }


        #endregion

        #region Constructors

        public Employee() { }

        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }
        #endregion

        #region Methods


        public object Clone()
        {
            return new Employee()  // اقدر اكتب this  وتعبر عن الcaller
                                   // أو اعمل constructor  فاضي
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary,

            };
        }



        public int CompareTo(Employee? other)
        {
            #region First Method
            ///if (this.Salary > other?.Salary)
            ///{
            ///    return 1;
            ///}
            ///else if (this.Salary < other?.Salary)
            ///{
            ///    return -1;
            ///}
            ///else
            ///{
            ///    return 0;
            ///} 
            #endregion

            #region Second Method 
            // استخدم ال compare to
            // بتاعة ال decimal or int 
            // بما ان كده كده بقارن بين ارقام 

            return this.Salary.CompareTo(other?.Salary);
            //return - this.Salary.CompareTo(other?.Salary);  //لو عايز تعمل reverse


            #endregion
        }

        public override string ToString()
        {
            return $"ID = {Id} , Name = {Name} , Salary = {Salary:c}";
        }

        #endregion
    }
}

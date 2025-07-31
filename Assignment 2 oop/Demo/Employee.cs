using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop.Demo
{
    internal struct Employee
    {

        #region Attributes
        private int id;
        private string? name;
        //private int age;
        public int Age { get; set; } // automatic
        #endregion


        #region Constructor
      ///  public Employee(int id, string? name, int age)
      ///{
      ///    this.id = id;
      ///    this.name = name;
      ///    this.age = age;
      ///} 
        #endregion


        #region Getter setter
        public int GetId()
        {
            return id;
        }

        public void SetId(int Id)
        {
            id = Id;
        }
        #endregion

        #region Properties

        public string? Name {
            get { return name; }
            set { name = value?.Length > 10 ? value.Substring(0, 10) : value;  }
        }


        #region Automatic Property
        //public int Age { get; set; }
        #endregion


        #endregion

        #region Methods
        public override string ToString()
        {
            return $"id is {GetId()} , name is {Name} , age is {Age} ";
        }
        #endregion
    }


}

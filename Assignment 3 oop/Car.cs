using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_oop
{
    internal class Car
    {
        #region Attributes
        private int id;
        private string? name;
        private double speed;
        #endregion

        #region Properties
        public int Id { get { return id; } set { id = value; } }
        public string? Name { get { return name; } set { name = value; } }
        public double Speed { get { return speed; } set { speed = value; } }
        #endregion

        #region Constructors
        //public Car() { }
        public Car(int id , string? name , double speed)
        {
            this.id = id;
            this.name = name;
            this.speed = speed;
            Console.WriteLine("1ST");
        }

        public Car(int id , string name) : this (id , name , 150)
        {
            //this.id = id;
            //this.name = name;
            //this.speed = 150;
            Console.WriteLine("2ND");

        }
        public Car(int id ) : this (id , "Ferrari")
        { 
            //this.id = id;
            //name = "Bughati";
            //speed = 150;
            Console.WriteLine("3RD");
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"id is {id} , name is {name} , speed is {speed}";
        }
        #endregion
    }
}

using Assignment_3_oop.Assignment_Classes;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_3_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 3 oop

            #region Question 1
            ///Design and implement a Class for the employees in a company:

            ///Employees employee1 = new Employees(1, "MohammedAli", SecurityLevel.Developer, 5000, new (2025,7,22), Gender.m);
            ///
            ///Console.WriteLine(employee1);

            #endregion

            #region Question 2
            ///Develop a Class to represent the Hiring Date Data: Consisting of fields to hold the day, month and Years


            ///HiringDate hireDate = new HiringDate(2027, 02 , 22);
            ///Console.WriteLine(hireDate);
            #endregion

            #region Question 3

            ///Create an array of Employees with size three a DBA, Guest and 
            ///the third one is security officer who have full permissions.(Employee[] EmpArr;)

            ///Employees[] empArr = new Employees[3];
            ///empArr[0] = new Employees(1 , "Mohammed" , SecurityLevel.DBA ,3500,new (2020,2, 22),Gender.m  );
            ///empArr[1] = new Employees(2 , "Salma" , SecurityLevel.guest ,2500,new (2024,9, 22),Gender.f  );
            ///empArr[2] = new Employees(3 , "ali" , SecurityLevel.securityOfficer ,5000,new (2019,2, 03),Gender.m  );
            ///
            ///foreach (var Emp in empArr)
            ///{
            ///    Console.WriteLine(Emp);
            ///}
            #endregion

            #endregion

            #region Demo

            #region Ex1

            ///Car car1;
            ///
            ///car1 = new Car(10, "ford", 200);
            ///Console.WriteLine(car1);

            #endregion

            #region Ex2 Constructor Chaining
            // on the same class "Car"

            /// Car c1 = new Car(10);
            /// Console.WriteLine(c1);

            /// Car c2 = new Car(10,"Audi");
            /// Console.WriteLine(c2);
            /// 
            /// Car c3 = new Car(10, "Didi" , 350);
            /// Console.WriteLine(c3);
            #endregion


            #region Ex3 Inheritance

            ///Parent parentObj1 = new Parent(1,2);
            ///Console.WriteLine(parentObj1);
            ///Console.WriteLine(parentObj1.Product());
            ///parentObj1.Myfun();
            ///

            ///Child childObj1 = new Child(10 , 30 , 40);
            ///Console.WriteLine(childObj1);
            ///
            ///Console.WriteLine(childObj1.Product());
            ///
            ///childObj1.Myfun();

            #endregion

            #region Ex4

            #endregion
            #endregion

        }
    }
}
 
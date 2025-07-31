using Assignment_2_oop.Struct;
using System.ComponentModel;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_2_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            ///Define a struct "Person" with properties "Name" and "Age". 
            ///Create an array of three "Person" objects and populate it with data.
            ///Then, write a C# program to display the details of all the persons in the array.


            ///Struct.Person[] persons = new Struct.Person[3];
            ///
            ///persons[0] = new Struct.Person{ name = "mohammed", age = 25 };
            ///persons[1] = new Struct.Person { name = "Ali", age = 22 };
            ///persons[2] = new Struct.Person { name = "Mo Ali", age = 24 };
            ///
            ///
            ///foreach (var person in persons)
            ///{
            ///    Console.WriteLine(person);
            ///}
            #endregion

            #region Question 2
            ///Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". 
            ///Write a C# program that takes two points as input from the user and calculates the distance between them.

            ///Console.Write("Enter First Point X: ");
            ///int.TryParse(Console.ReadLine(), out int x1);
            ///
            ///Console.Write("Enter First Point y: ");
            ///int.TryParse(Console.ReadLine(), out int y1);
            ///
            ///Console.Write("Enter Second Point X2: ");
            ///int.TryParse(Console.ReadLine(), out int x2);
            ///
            ///Console.Write("Enter Second Point y2: ");
            ///int.TryParse(Console.ReadLine(), out int y2);
            ///
            ///Struct.Point p1 = new Struct.Point { x = x1, y = y1 };
            ///Struct.Point p2 = new Struct.Point { x = x2, y = y2 };
            ///
            ///int Sub_X =  p1.x - p2.x;
            ///int Sub_Y =  p1.y - p2.y;
            ///
            ///double result = (Sub_X * Sub_X) + (Sub_Y * Sub_Y);
            ///double distance = Math.Sqrt(result);
            ///Console.WriteLine(distance);
            #endregion

            #region Question 3
            ///Create a struct called "Person" with properties "Name" and "Age".
            ///Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.


            ///Person_2[] person = new Person_2[3];
            ///
            ///for (int i = 0; i < person.Length; i++)
            ///{
            ///    Console.Write($"{i+1}ST Person  name: ");
            ///    string? name = Console.ReadLine();
            ///
            ///    Console.Write($"{i + 1}ST Person  age: ");
            ///    int.TryParse(Console.ReadLine(), out int age);
            ///
            ///    person[i] = new Person_2(){ name = name , age = age};
            ///    
            ///}
            ///Person_2 oldestPerson = person[0];
            ///
            ///for (int i = 0; i < person.Length; i++)
            ///{
            ///    if (oldestPerson.age < person[i].age)
            ///    {
            ///        oldestPerson = person[i];
            ///    }
            ///}
            ///
            ///Console.WriteLine(oldestPerson);
            #endregion

            #region Question 4


          

            Struct.Rectangle rectangle;

           
            Console.Write("enter Height: ");
            double.TryParse(Console.ReadLine(), out double H);
            Console.Write("enter width: ");
            double.TryParse(Console.ReadLine(), out double W);

            rectangle = new Struct.Rectangle()
            {
                Height = H,
                Width = W
            };

            rectangle.DisplayInfo();

            

            #endregion
        }
}
}

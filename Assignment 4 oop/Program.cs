using System;
using System.ComponentModel;
using System.Threading;

namespace Assignment_4_oop
{
    internal class Program
    {
        #region Ex1 Function

        #region OverLoading
        ///static int Sum(int x, int y)
        ///{
        ///    return x + y;
        ///}


        /// OVERLOADING BY NUMBER OF PARAMETERS
        ///static int Sum(int x, int y, int z)
        ///{
        ///    return x + y + z;
        ///}

        /// OVERLOADING BY TYPE OF PARAMETER
        ///static int Sum(double x, double y)
        ///{
        ///    return (int)x + (int)y;
        ///}

        /// OVERLOADING BY ORDER OF PARAMETER
        ///static int Sum(int y, double x)
        ///{
        ///    return (int)x + y;
        ///}
        #endregion

        #region Not OverLodaing
        /// NOT OVERLOADING BECAUSE RETURN TYPE ISN'T IMPORTANT IN OVERLOADING
        ///static double Sum(int x, int y)
        ///{
        ///
        ///    return (double)x + (double)y;
        ///
        ///} 
        #endregion

        #endregion




        static void Main(string[] args)
        {
            #region Assignment

            #region Part 1
            #region Question 1

            ///Q1) Write a class named Calculator that contains a method named Add.Overload the Add method to:
            ///Accept two integers and return their sum.
            ///Accept three integers and return their sum.
            ///Accept two doubles and return their sum.


            ///Calculator calculator = new Calculator();
            ///int result = calculator.Add(10, 12);
            ///Console.WriteLine(result);
            ///
            ///result = calculator.Add(10, 13, 15);
            ///Console.WriteLine(result);
            ///
            ///double res = calculator.Add(10.2, 13.1);
            ///Console.WriteLine(res);




            #endregion

            #region Question 2

            ///Create a class named Rectangle with the following constructors:
            ///A parameterless constructor that sets the width and height to 0.
            ///A constructor that accepts width and height as integers.
            ///A constructor that accepts a single integer and sets both width and height to that value.


            //Class Created 
            /// Rectangle rectangle = new Rectangle();
            /// Rectangle rectangle2 = new Rectangle(5);

            #endregion

            #region Question 3 

            ///ComplexNumber c1 = new ComplexNumber() { real = 15 , imaginary = 20};
            ///ComplexNumber c2 = new ComplexNumber() { real = 2 , imaginary = 13};
            ///ComplexNumber c3;


            ///c3 = c1 + c2;
            ///c3 = c1 - c2;


            ///Console.WriteLine($"c1 is {c1}");
            ///Console.WriteLine($"c2 is {c2}");
            ///Console.WriteLine($"c3 is {c3}");




            #endregion

            #region Question 4

            ///a) Create a base class named Employee with method That Works as it prints    "Employee is  working".
            ///b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
            ///*Ensure that the Manager class also calls the Work method of the Employee class within its Overridden method.



            ///Employee employee = new Employee();
            ///employee.Work();
            ///Manager manager = new Manager();
            ///manager.Work();

            #endregion

            #endregion

            #region Part 2

            #region Question 1 

            ///Duration d1 = new Duration(1, 10, 15);
            ///Duration d2 = new Duration(3600);
            ///Duration d3 = new Duration(7800);
            ///Duration d4 = new Duration(666);
            ///
            ///Console.WriteLine(d1);
            ///Console.WriteLine(d2);
            ///Console.WriteLine(d3);
            ///Console.WriteLine(d4);

            #endregion

            #region Question 2

            ///Duration d1 = new Duration(2,10,51);
            ///Duration d2 = new Duration(1,15,51);
            ///Duration d6 = new Duration(7800);
            ///
            ///Duration d3 = d1 + d2;
            ///Duration d4 = d1 - d2;
            ///Duration d5 = d1 + 7800;
            ///Duration d7 = new Duration(666);
            ///Duration d8 = 666 + d3;





            ///Console.WriteLine($"d1 is {d1}");
            ///Console.WriteLine($"d2 is {d2}");
            ///Console.WriteLine($"d3 is {d3}");
            ///Console.WriteLine($"d4 is {d4}");
            ///Console.WriteLine($"d5 is {d5}");
            ///Console.WriteLine($"d6 is {d6}");
            ///Console.WriteLine($"d7 is {d7}");
            ///Console.WriteLine($"d8 is {d8}");


            Duration d1 = new Duration(2,10,51);
            ///Duration d2 = new Duration(1,15,51);
            ///Duration d3 = new Duration(1,10, 51);
            ///Duration d4 = new Duration(1, 10, 51);

            #region Binary Operator

            ///Duration d1 = new Duration(2, 10, 51);
            ///Duration d2 = new Duration(1, 15, 51);
            ///Duration d3 = d1 + d2;
            ///Console.WriteLine($"d1 is {d1}");
            ///Console.WriteLine($"d2 is {d2}");
            ///Console.WriteLine($"d3 is {d3}"); 
            #endregion



            #region Prefix
            ///Duration d3 = ++d1;
            ///Console.WriteLine("AFTER PREFIX");
            ///Console.WriteLine($"d1 is {d1}");
            ///Console.WriteLine($"d3 is {d3}");


            ///Duration d3 =--d1;
            ///Console.WriteLine("AFTER PREFIX");
            ///Console.WriteLine($"d1 is {d1}");
            ///Console.WriteLine($"d3 is {d3}"); 
            #endregion


            #region Postfix

            ///Duration d3 = d1++;
            ///Console.WriteLine("AFTER Postfix");
            ///Console.WriteLine($"d1 is {d1}");
            ///Console.WriteLine($"d3 is {d3}");


            ///Duration d3 = d1--;
            ///Console.WriteLine("AFTER PREFIX");
            ///Console.WriteLine($"d1 is {d1}");
            ///Console.WriteLine($"d3 is {d3}");
            #endregion

            #region Relational operators
            ///if (d3> d4)
            ///{
            ///    Console.WriteLine("d3 > d4");
            ///}else if (d3<d4)
            ///{
            ///    Console.WriteLine("d3 < d4");
            ///}
            ///else
            ///{
            ///    Console.WriteLine("d3 = d4");
            ///}
            #endregion

            if (d1)
            {
                DateTime dateTime = (DateTime) d1;
                Console.WriteLine(dateTime);
            }


            #endregion
            #endregion

            #endregion


            #region Demo
            #region Ex1 Results
            /// int result = Sum(10, 25);
            /// Console.WriteLine(result); // 35  // sum 2 int numbers
            /// result = Sum(10, 15, 9);
            /// Console.WriteLine(result); // 34  // sum 3 int numbers
            /// result = Sum(10.2, 45.6);
            /// Console.WriteLine(result); // 55  // sum 2 double numbers and retutn int result
            /// result = Sum(5, 6.8);
            /// Console.WriteLine(result); // 11  // sum 1 int and 1 double and return int result 
            #endregion

            #region Overloading Binary operator

            ///Complex c1 = new Complex() {Real = 10 , Imaginary = 6 };
            ///Complex c2 = new Complex() { Real = 12, Imaginary = 4 }; 
            ///Complex c3;
            ///
            ///
            ///Console.WriteLine($"C1 = {c1}");
            ///Console.WriteLine($"C2 = {c2}");
            ///
            ///
            ///c3 = c1 + c2;
            ///Console.WriteLine(c3);
            ///
            ///c3 = c1 - c2;
            ///Console.WriteLine(c3);
            ///

            ///c3 = c1 / c2;
            ///Console.WriteLine(c3);


            #endregion

            #region Overloading uniary operator

            ///Complex c1 = new Complex() {Real = 10 , Imaginary = 6 };
            ///Complex c2 = new Complex() { Real = 12, Imaginary = 4 }; 
            ///Complex c3;

            ///Console.WriteLine($"c1 = {c1}");

            #region Prefix
            ///c3 = ++c1;
            ///Console.WriteLine("AFTER PREFIX");
            ///Console.WriteLine($"c1 = {c1}");
            ///Console.WriteLine($"c3= {c3}"); 

            ///c3 = -- c1;
            ///Console.WriteLine("AFTER PREFIX");
            ///Console.WriteLine($"c1 = {c1}");
            ///Console.WriteLine($"c3= {c3}"); 



            #endregion


            #region Postfix
            ///c3 = c1++;
            ///Console.WriteLine("AFTER Postfix");
            ///Console.WriteLine($"c1 = {c1}");
            ///Console.WriteLine($"c3= {c3}"); 
            ///

            ///c3 = c1--;
            ///Console.WriteLine("AFTER PREFIX");
            ///Console.WriteLine($"c1 = {c1}");
            ///Console.WriteLine($"c3= {c3}");

            #endregion
            #endregion

            #region Overloading Realational operator



            ///Complex c1 = new Complex() {Real = 10 , Imaginary = 6 };
            ///Complex c2 = new Complex() { Real = 10, Imaginary = 6 };
            ///
            ///if (c1 > c2)
            ///{
            ///Console.WriteLine("c1 > c2 ");
            ///
            ///}
            ///else if(c1<c2)
            ///{
            ///    Console.WriteLine("c1 < c2 ");
            ///
            ///}
            ///else
            ///{
            ///    Console.WriteLine("c1 = c2");
            ///}
            #endregion

            #region Overloading Casting Operator

            ///Complex c1 = new Complex() { Real = 10, Imaginary = 6 };
            ///
            ///int real = (int)c1;
            ///Console.WriteLine(real);
            ///
            ///string complex = c1;
            ///string c = (string) c1;
            ///
            ///Console.WriteLine(complex);
            ///Console.WriteLine(c);


            #endregion
            #endregion


        }
    }
}

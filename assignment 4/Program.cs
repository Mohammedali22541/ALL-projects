using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Security.Principal;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Question 1
            //Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            ///Console.Write("Enter an integer: ");
            ///bool isparsed =  int.TryParse(Console.ReadLine(), out int number);
            ///int i = 1;
            ///
            ///if (isparsed && number >=1)
            ///{
            ///    while (number >= i)
            ///    {
            ///        Console.WriteLine(i);
            ///        i++;
            ///    }
            ///}
            ///else
            ///{
            ///    Console.WriteLine("Please Write A valid Number Starts From 1");
            ///}
            #endregion

            #region Question 2

            //Write a program that allows the user to insert an integer thenprint a multiplication table up to 12.
            ///Console.WriteLine("Please Add A Valid Number");
            ///bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            ///if (isParsed && number > 0)
            ///{
            ///    for (int i = 0; i < number * 12; )
            ///    {
            ///        Console.WriteLine(number + i);
            ///        i = i + number;
            ///    }
            ///}
            ///else
            ///{
            ///    Console.WriteLine("please add valid integer");
            ///}

            ///if (isParsed && number > 0)
            ///{
            ///    for (int i = 1; i <= 12; i++)
            ///    {
            ///        Console.WriteLine(number * i);
            ///    }
            ///}
            ///else
            ///{
            ///    Console.WriteLine("Please add a valid integer");
            ///}

            #endregion

            #region Question 3
            //Write a program that allows to user to insert number then print all even numbers between 1 to this number

            ///Console.Write("Enter A Number: ");
            /// bool isParsed =  int.TryParse(Console.ReadLine(), out int number);
            ///int x = 2;
            ///if (isParsed && number > 1)
            ///{
            ///    while (x <= number  )
            ///    {
            ///         Console.WriteLine(x);
            ///        x+= 2;
            ///    }
            ///}
            ///else
            ///{
            ///    Console.WriteLine("Please Enter Valid Integer Number");
            ///}
            #endregion

            #region Question 4
            //Write a program that takes two integers then prints the power.
            ///Console.WriteLine("Please Enter Two Numbers To Calculate The Power");
            ///Console.Write("First Number: ");
            ///bool isParsed1 = int.TryParse(Console.ReadLine(), out int firstNumber);
            ///Console.Write("Second Number: ");
            ///bool isParsed2 = int.TryParse(Console.ReadLine(), out int secondNumber);
            ///if (isParsed1 && isParsed2)
            ///{
            ///    double result = Math.Pow(firstNumber, secondNumber);
            ///
            ///    Console.WriteLine(result);
            ///
            ///} else
            ///{
            ///    Console.WriteLine("Please Enter Valid Integer Numbers");
            ///}

            ///int result = 1;
            ///for (int i = 1; i <= secondNumber; i++ )
            ///{
            ///    result *= firstNumber;
            ///
            ///}
            ///Console.WriteLine(result);
            #endregion

            #region Question 5
            //Write a program to enter marks of five subjects and calculate total, average and percentage.



            ///int[] degres =new int[] { 95, 76, 58, 90, 89 };
            ///
            ///int total = 0;
            ///int average = 0;
            ///double percentage = 0;
            ///for (int i = 0; i < degres.Length; i++)
            ///{
            ///    total += degres[i];
            ///   
            ///
            ///}
            ///
            ///average = total / degres.Length;
            ///percentage = (total / 500.0) * 100;
            ///
            ///Console.WriteLine($"Total Is: {total}" );
            ///Console.WriteLine($"average Is: {average}" );
            ///Console.WriteLine($"percentage Is: {percentage}" );
            #endregion

            #region Question 6

            //Write a program to allow the user to enter a string and print the REVERSE of it.

            ///Console.WriteLine("write any thing");
            ///string message = Console.ReadLine() ?? "No Input";
            ///string reversedMessage = "";
            ///
            ///
            ///
            ///for (int i = message.Length-1; i >= 0; i--)
            ///{
            ///    reversedMessage += message[i];
            ///}
            ///
            ///Console.WriteLine(reversedMessage); 
            #endregion
            
            #region Question 7

            //Write a program to allow the user to enter int and print the REVERSED of it.
            /// Console.WriteLine("Write numbers to reverse");
            /// string numbersString = Console.ReadLine() ?? "0";
            ///
            /// string reversedNumber = "";
            ///
            /// for (int i = numbersString.Length -1; i >= 0; i--)
            /// {
            ///     reversedNumber += numbersString[i];
            /// }
            ///
            ///
            /// int.TryParse(reversedNumber, out int finalReversed);
            /// Console.WriteLine(finalReversed);




            #endregion

            #region Question 8

            //Write a program in C# Sharp to find prime numbers within a range of numbers.
            ///Console.Write("Write a starting Range number: ");
            ///int.TryParse(Console.ReadLine(), out int startingRange);
            ///Console.Write("Write an ending Range number: ");
            ///int.TryParse(Console.ReadLine(), out int endingRange);
            ///
            ///for (int i = startingRange; i <= endingRange; i++)
            ///{
            ///
            ///    if (i > 1)
            ///    {
            ///        Console.WriteLine(i);
            ///
            ///
            ///    }
            ///}

            #endregion

            #region Question 9

            //Write a program in C# Sharp to convert a decimal number into binary without using an array

            ///Console.Write("Enter a decimal number: ");
            ///bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            ///string binary = "";
            ///
            ///if (isParsed)
            ///{
            ///    while (number > 0)
            ///    {
            ///        int result = number % 2;
            ///        binary = result + binary;
            ///        number /= 2;
            ///    }
            ///}
            ///else
            ///{
            ///    Console.WriteLine("invalid Number");
            ///}
            ///
            ///Console.WriteLine(binary);
            #endregion

            #region Question 10

            //Create a program that asks the user to input three points(x1, y1), (x2, y2),
            //and(x3, y3), and determines whether these points lie on a single straight line.


            ///Console.WriteLine("please input the following data");
            ///
            ///Console.Write("x1: ");
            ///int.TryParse(Console.ReadLine(),out int x1);
            ///
            ///Console.Write("y1: ");
            ///int.TryParse(Console.ReadLine(), out int y1);
            ///
            ///Console.Write("x2: ");
            ///int.TryParse(Console.ReadLine(), out int x2);
            ///
            ///Console.Write("y2: ");
            ///int.TryParse(Console.ReadLine(), out int y2);
            ///
            ///Console.Write("x3: ");
            ///int.TryParse(Console.ReadLine(), out int x3);
            ///
            ///Console.Write("y3: ");
            ///int.TryParse(Console.ReadLine(), out int y3);
            ///
            ///
            ///int leftSide = (y2 - y1) * (x3 - x2);
            ///int rightSide = (y3 - y2) * (x2 - x1);
            ///
            ///if (leftSide == rightSide) {
            ///    Console.WriteLine(" these points lie on a single straight line.");
            ///}
            ///else
            ///{
            ///    Console.WriteLine(" these points dont lie on a single straight line.");
            ///}
            #endregion

            #region Question 11
            ///Write a program that prints an identity matrix using for loop,
            ///in other words takes a value n from the user and shows the identity table of size n * n

            ///int num = 5;
            ///
            ///for (int i = 0; i < num; i++)
            ///{
            ///    for (int j = 0; j < num; j++)
            ///    {
            ///        if (i == j)
            ///        {
            ///            Console.Write(1);
            ///        }
            ///        else
            ///        {
            ///            Console.Write(0);
            ///        }
            ///    }
            ///    Console.WriteLine();
            ///}
            #endregion
        }
    }
}

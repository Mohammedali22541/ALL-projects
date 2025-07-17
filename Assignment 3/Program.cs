using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1
            ///Write a program that allows the user to enter a number then print it.
            ///Console.Write("write a number: ");
            ///int.TryParse(Console.ReadLine(), out int number);
            ///Console.WriteLine($"Your Wrote {number}");
            #endregion

            #region Question 2
            ///Write C# program that converts a string to an integer, but the string contains non-numeric characters.
            ///And mention what will happen
            ///string Name = "Mohammed";
            ///int.TryParse(Name, out int number);
            ///Console.WriteLine(number);

            ///what happend here? ====> try parse tryed to converte this string to numeric type but it failed so try parse converte it to 0 


            #endregion

            #region Question 3
            ///Write C# program that Perform a simple arithmetic operation with floating-point numbers 
            ///And mention what will happen
            ///
            ///float x = 10.8f;
            ///float y = 5.3f;
            ///
            ///float result = x + y;
            ///Console.WriteLine(result);

            /// in x and y we must put f at the last because the default value for fractions number is double
            /// the operation get the sum between x and y

            #endregion

            #region question 4
            ///Write C# program that Extract a substring from a given string.

            ///string name = "Mohammed";
            ///string partOfName = name.Substring(0,6);
            ///Console.WriteLine(partOfName);

            #endregion

            #region Question 5
            ///Write C# program that Assigning one value type variable to another and modifying the value of one variable 
            ///and mention what will happen

            ///
            ///int num1 = 10;
            ///int num2 = 20;
            ///Console.WriteLine(num1);
            ///Console.WriteLine(num2);
            ///
            ///Console.WriteLine("after assigned num1 to num2");
            ///
            /// num1 = num2;
            ///
            ///Console.WriteLine(num1);
            ///Console.WriteLine(num2);
            ///
            ///Console.WriteLine("after edit num2 ");
            ///
            ///num2 = 40;
            ///Console.WriteLine(num1);
            ///Console.WriteLine(num2);
            /// when you assign value type variablle to value type variable it take a copy from value 
            /// after change the value-- the anthor variable value cant changed

            #endregion

            #region Question 6

            ///Write C# program that Assigning one reference type variable to another
            ///and modifying the object through one variable and mention what will happen

            //Point p1 = new Point() { x = 1 , y = 3};
            //Point p2 = new Point() { x = 15 , y = 25};
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);


            //Console.WriteLine("After assign p1 to p2");
            //p1 = p2;

            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);


            //Console.WriteLine("After change p2 value ");
            //p2.x = 50;
            //p2.y = 150;

            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);

            /// when you assign refrence type to anthor 
            /// the anthor refrence type refer to to address in heab not copy the value so 
            /// if you changed the first one the second will changed directely 
            #endregion

            #region Question 7
            ///  Write C# program that take two string variables and print them as one variable 
            //Console.Write("Please write your first name: ");
            //string firstName =  Console.ReadLine() ?? "No first name";
            //Console.Write("Please write your last name: ");
            //string lastName =  Console.ReadLine() ?? "No Last name";
            //Console.Clear()
            //string fullName = ($"your fullName is {firstName} {lastName}");
            //Console.WriteLine(fullName);
            #endregion

            #region Question 8
            ///Write a program that calculates the simple interest given the principal amount, rate of interest, and time.
            ///Note : The formula for simple interest is Interest = (principal * rate * time) / 100.


            // Console.Write("Please Enter The Principal Amount: ");
            //bool isValidAmount = decimal.TryParse(Console.ReadLine(), out decimal principalAmount);

            // Console.Write("Please Enter The rate: ");
            // bool isValidRate = decimal.TryParse(Console.ReadLine(), out decimal rate);

            // Console.Write("Please Enter The time: ");
            // bool isValidTime = decimal.TryParse(Console.ReadLine(), out decimal time);

            // Console.Clear();


            // if (isValidAmount && isValidRate && isValidTime) {
            //     decimal interest = (principalAmount * rate * time) / 100;
            //     Console.WriteLine(interest);
            // }
            // else
            // {
            //     Console.WriteLine("Error : Please enter a valid Input");
            // }

            #endregion

            #region Question 9
            ///Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms and height in meters. 
            ///Note: The formula for BMI is BMI = (Weight) / (Height * Height)

            //Console.Write("Please Enter Your Weight: ");
            //bool isValidWeight = double.TryParse(Console.ReadLine(), out double weight);

            //Console.Write("Please Enter Your Height: ");
            //bool isValidHeight = double.TryParse(Console.ReadLine(), out double height);

            //Console.Clear();


            //if (isValidWeight && isValidHeight)
            //{
            //    double bmi = (weight) / (height * height) ;
            //    Console.WriteLine($"your bmi is: {bmi}");
            //}
            //else
            //{
            //    Console.WriteLine("Error : Please enter a valid Input");
            //}

            #endregion

            #region Question 10
            ///Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            ///Assign the result in a variable then display the result. 
            ///Note: that below 10 degrees is "Just Cold" , above 30 degrees is "Just Hot" , anything else is "Just Good"

            //Console.Write("Enter the current temperature degree: ");
            //int.TryParse(Console.ReadLine(), out int currentTemp);

            //string temp = currentTemp < 10 ? "Just Cold" : currentTemp > 30 ? "Just Hot" : "just Good";

            //Console.WriteLine(temp);
            #endregion

            #region Question 11
            /// Write a program that takes the date from the user and displays it in various formats using string interpolation.
            /// Ex:Today’s date : 20 , 11 , 2001 , Today's date : 20 / 11 / 2001 , Today's date : 20 – 11 – 2001

            //Console.WriteLine("Enter The Date like: 22/02/2001: ");
            //string? dateInput = Console.ReadLine()?.Trim();

            //DateTime.TryParse(dateInput,out DateTime date);
            //Console.WriteLine($"Today's date : {date:dd,MM,yyyy}");
            //Console.WriteLine($"Today's date : {date:dd/MM/yyyy}");
            //Console.WriteLine($"Today's date : {date:dd-MM-yyyy}");

            #endregion

            #region Question 12
            ///Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 
            ///otherwise print no.
            ///Example(1) , Input: 12 , Output: Yes
            ///Example(2) , Input: 9 ,Output: No

            // Console.Write("enter a number: ");
            //bool isValidInput = int.TryParse(Console.ReadLine(),out int userInputNumber);

            // if (isValidInput)
            // {
            //     if (userInputNumber % 3 == 0 && userInputNumber % 4 == 0)
            //     {
            //         Console.WriteLine($"Yes , your Number {userInputNumber} can be divided by 3 and 4");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"No , your Number {userInputNumber} can't be divided by 3 and 4");

            //     }
            // }
            // else
            // {
            //     Console.WriteLine("your Input Isn't Valid");
            // }


            #endregion

            #region Question 13
            ///Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1), Input: -5 , Output: negative
            ///Example(2) , Input: 10 , Output: positive

            //Console.Write("enter a number: ");
            //bool isValidNumber = int.TryParse(Console.ReadLine(), out int userNumber);

            //if (isValidNumber)
            //{
            //    if (userNumber >= 0)
            //    {
            //        Console.WriteLine($"Your Number {userNumber} Is Positive");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Your Number {userNumber} Is Negative");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("your Input Isn't Valid");
            //}

            #endregion

            #region Question 14
            ///Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1) , Input: 7,8,5 , Output: max element = 8 , min element = 5


            //Console.Write("Enter Your First Number: ");
            //bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int firstNumber);

            //Console.Write("Enter Your second Number: ");
            //bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int secondNumber);

            //Console.Write("Enter Your Third Number: ");
            //bool isThirdNumberValid = int.TryParse(Console.ReadLine(), out int thirdNumber);

            //Console.Clear();

            //if (isFirstNumberValid && isSecondNumberValid && isThirdNumberValid)
            //{
            //    int maxValue = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
            //    int minValue = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));

            //    Console.WriteLine($"Max Element = {maxValue}");
            //    Console.WriteLine($"Min Element = {minValue}");
            //}
            //else
            //{
            //    Console.WriteLine("your Input Isn't Valid");
            //}

            #endregion

            #region Question 15
            //Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Enter a number: ");
            //bool isNumberValid = int.TryParse(Console.ReadLine(), out int number);


            //if (isNumberValid)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine($"This Number {number} is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"This Number {number} is odd");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("your Input Isn't Valid");
            //}

            #endregion

            #region Question 16

            ///Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) 
            ///otherwise print(consonant).
            ///Example(1) , Input: O , Output: vowel
            ///Example(2) , Input: b , Output: Consonant


            //Console.WriteLine("Write Any Character");
            //string character = Console.ReadLine()?? "NO Character";

            //string lowerCharacter = character.ToLower();
            //string? vowels = "aeiou";

            //if (character.Length == 1)
            //{
            //    if (vowels.Contains(lowerCharacter))
            //    {
            //        Console.WriteLine($"Your Character {lowerCharacter} Is Vowel");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Your Character {lowerCharacter} Is Consonant");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("You Have To Write Only One Character");
            //}


            #endregion

            #region Question 17
            ///Write a program to input the month number and print the number of days in that month.
            ///Example , Input: Month Number: 1 , Output: Days in Month: 31


           // Console.Write("Write A month Number: ");
           //bool isMonthNumberValid = int.TryParse(Console.ReadLine(), out int monthNumber);

           // if (isMonthNumberValid && monthNumber >= 1 && monthNumber <= 12)
           // {
           //     if (monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11)
           //     {
           //         Console.WriteLine("Days in Month: 30 Days");
           //     } else if (monthNumber == 2)
           //     {
           //         Console.WriteLine("Days in Month: 28 Days or 29 Days :) ");

           //     }
           //     else
           //     {
           //         Console.WriteLine("Days in Month: 31 Days");

           //     }
           // }

            #endregion
        }

    }
}

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Question 1
            ///bool isParsed;
            ///int number; 
            ///
            ///do
            ///{
            ///    Console.WriteLine("please enter  a valid number between 1 to 100");
            ///    isParsed = int.TryParse(Console.ReadLine(), out  number);
            ///
            ///    if (isParsed && number >= 1 && number <= 100)
            ///    {
            ///        Console.Clear();
            ///        Console.WriteLine($"Your Number is: {number}");
            ///
            ///    }
            ///    else
            ///    {
            ///        Console.Clear();
            ///        Console.WriteLine($"You Number {number} isn't A Valid Number Between 1 to 100");
            ///    }
            ///
            ///
            ///}
            ///while (!(isParsed && number >= 1 && number <= 100));
            #endregion

            #region Question 2

            ///int number;
            ///int result = 0;
            ///bool isParsed;
            ///
            ///do
            ///{
            ///    Console.Write("Enter Positive Number: ");
            ///    isParsed = int.TryParse(Console.ReadLine(), out number);
            ///    if (!isParsed) {
            ///        Console.WriteLine("Invalid input. Please enter a number.");
            ///    }
            ///    else if (number < 0)
            ///    {
            ///        Console.WriteLine("Please Enter Positive Number: ");
            ///    }
            ///    else
            ///    {
            ///        while (number > 0)
            ///        {
            ///            int num = number % 10;
            ///            result += num;
            ///            number /= 10;
            ///
            ///        }
            ///
            ///    }
            ///}
            ///while (!isParsed || number <0 );
            ///Console.WriteLine(result);
            #endregion

            #region Question 3
            ///Console.Write("Enter A First Triangle Side Length: ");
            ///bool Flag1 = int.TryParse(Console.ReadLine(), out int a);
            ///Console.Write("Enter A Second Triangle Side Length: ");
            ///bool Flag2 = int.TryParse(Console.ReadLine(), out int b);
            ///Console.Write("Enter A Third Triangle Side Length: ");
            ///bool Flag3 = int.TryParse(Console.ReadLine(), out int c);
            ///
            ///if (Flag1 && Flag2 && Flag3)
            ///{
            ///    if (a + b > c && a + c > b && b + c > a)
            ///    {
            ///
            ///
            ///        if (a == b && a == c && b == c)
            ///        {
            ///            Console.WriteLine("Equilateral Triangel");
            ///        }
            ///        else if (a == b || a == c || b == c)
            ///        {
            ///            Console.WriteLine("Isosceles Triangle");
            ///        }
            ///        else
            ///        {
            ///            Console.WriteLine("Scalene Triangle");
            ///        }
            ///       
            ///
            ///    }
            ///    else
            ///    {
            ///        Console.WriteLine("This Is Not A Triangle");
            ///    }
            ///
            ///}
            ///else
            ///{
            ///    Console.WriteLine("Please Enter A Valid Side Lengths");
            ///}
            ///
            #endregion

            #region Question 4
            ///int[] numbers = new int[10];
            ///bool isFound = false;
            ///
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///     Console.Write($"enter {i+1}St Numbers: ");
            ///
            ///    int.TryParse(Console.ReadLine(), out numbers[i]);
            ///
            ///}
            ///Console.Clear();
            ///Console.WriteLine("Enter A Number To Search In Your List");
            ///int.TryParse(Console.ReadLine(), out int NumValue);

            #region First Method

            ///int foundedIndex = Array.IndexOf(numbers, NumValue);
            ///string message =  foundedIndex != -1 ? $"Your Number Exists At Index {foundedIndex}" : "Your Number Doesn't Exist";
            ///Console.WriteLine(message);

            #endregion

            #region Second Method
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///    if (NumValue == numbers[i])
            ///    {
            ///        Console.WriteLine($"Your Number Is Exist AT index {i}");
            ///        isFound = true;
            ///        
            ///    }
            ///
            ///   
            ///
            ///
            ///}
            ///if (isFound == false)
            ///{
            ///    Console.WriteLine("Your Number Doesn't Exist");
            ///
            ///}
            #endregion

            #endregion

            #region Question 5
            ///Console.WriteLine("Enter An Enteger");
            ///bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            ///
            ///if (isParsed)
            ///{
            ///    for (int i = 1; i <= number;  i++)
            ///    {
            ///        for (int j = 1; j <= i; j++)
            ///        {
            ///            Console.Write( j  + " ");
            ///        }
            ///        Console.WriteLine();
            ///    }
            ///}
            #endregion

            #region Question 6

            ///int[] numbers = new int[5];
            ///
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///    Console.Write($"Enter {i+1}ST Number: ");
            ///    int.TryParse(Console.ReadLine(), out numbers[i]);
            ///}
            ///
            ///Console.Clear();

            #region First Method
            ///Array.Sort(numbers);
            ///Array.Reverse(numbers);
            ///int biggestNumber = numbers[0];
            ///
            ///Console.WriteLine(biggestNumber);
            #endregion
            #region Second Method
            ///int maxNumber = numbers[0];
            ///
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///
            ///    if (maxNumber < numbers[i])
            ///    {
            ///        maxNumber = numbers[i];
            ///
            ///    }
            ///}
            ///
            ///Console.WriteLine(maxNumber);
            #endregion

            #endregion

            #region Question 7

            #endregion

            #region question from past task 
            //Write a program to allow the user to enter int and print the REVERSED of it.
            ///Console.Write("Enter Number To Reversed: ");
            ///bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            ///int reversed = 0;
            ///
            ///if (isParsed) {
            ///    while (number > 0) {
            ///       int newNum = number % 10;
            ///        reversed = reversed * 10 + newNum; 
            ///        number /= 10;
            ///    }      
            ///}
            ///Console.WriteLine(reversed);
            #endregion

        }






    }
}

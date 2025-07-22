namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1 
            ///Console.WriteLine("Enter The Time You Spent To Finish Your Task");
            ///bool isParsed = double.TryParse(Console.ReadLine(), out double timePerTask);
            ///
            ///if (isParsed)
            ///{
            ///    if (timePerTask >= 2 && timePerTask< 3 )
            ///    {
            ///        Console.WriteLine("Your Are Considered Highly Efficient.");
            ///    }else if (timePerTask >= 3 && timePerTask < 4)
            ///    {
            ///        Console.WriteLine("Your Have To Increase Your Speed..");
            ///
            ///    } else if (timePerTask >= 4 && timePerTask <= 5)
            ///    {
            ///        Console.WriteLine("Your Are Provided With Training To Enhance Your Speed.");
            ///    }
            ///    else
            ///    {
            ///        Console.WriteLine("You Have To Leave The Company");
            ///    }
            ///}
            ///else
            ///{   
            ///    Console.WriteLine("Please Enter A Valid Time");
            ///}
            #endregion

            #region Question 2
            ///Console.Write("Enter A Valid Number: ");
            ///bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            ///
            ///if (isParsed)
            ///{
            ///    for (int i = 0; i < number; i++)
            ///    {
            ///        for (int j = 0; j < number; j++)
            ///        {
            ///            if (i == j)
            ///            {
            ///                Console.Write(1);
            ///            }
            ///            else
            ///            {
            ///                Console.Write(0);
            ///            }
            ///        }
            ///        Console.WriteLine();
            ///    }
            ///}
            ///else
            ///{
            ///    Console.WriteLine("Enter A Valid Number");
            ///}
            #endregion

            #region Question 3

            ///int[] numbers = new int[4];
            ///bool isParsed = false;
            ///int result = 0;
            ///
            ///for (int i = 0; i < numbers.Length; i++)
            ///{ 
            ///    Console.WriteLine("Enter Four Numbers To Sum");
            ///    Console.Write($"{i+ 1}ST Number: ");
            ///    isParsed = int.TryParse(Console.ReadLine(),out numbers[i] );
            ///}
            ///
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///    result += numbers[i];
            ///}
            ///
            ///Console.WriteLine(result);
            #endregion

            #region Question 4

            ///int[] firstSet = { 1, 5, 3, 4 };
            ///int[] secondSet = { 2, 8, 6, 7 };
            ///
            ///int[] sortedSet = new int[firstSet.Length + secondSet.Length];
            ///
            ///for (int i = 0; i < firstSet.Length; i++)
            ///{
            ///    sortedSet[i] += firstSet[i];
            ///}
            ///for (int i = 0; i < secondSet.Length; i++)
            ///{
            ///    sortedSet[firstSet.Length + i] = secondSet[i];
            ///
            ///}
            ///
            ///Array.Sort(sortedSet);  
            ///
            ///foreach (int item in sortedSet)
            ///{
            ///    Console.WriteLine(item);
            ///}

            #endregion

            #region Question 5

            #endregion

            #region Question 6

            ///int[] numbers = [10, 20, 30, 40, 50];
            ///int Max = numbers[0];
            ///int Min = numbers[0];
            ///
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///    if (Max <  numbers[i])
            ///    {
            ///        Max = numbers[i];
            ///    }else if (Min > numbers[i])
            ///    {
            ///        Min = numbers[i];
            ///    }
            ///}
            ///
            ///Console.WriteLine($"Max Number Is : {Max}");
            ///Console.WriteLine($"Min Number Is : {Min}");


            #endregion

            #region Question 7      

            ///int[] numbers = [50, 20, 30, 40, 10 , 40, 10];
            ///int max = 1;
            ///int secondMaxNumber = 2;
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///    if (max < numbers[i])
            ///    {
            ///        secondMaxNumber = max;
            ///        max = numbers[i];
            ///
            ///    }else if (secondMaxNumber < numbers[i] && numbers[i] != max)
            ///     {
            ///         secondMaxNumber = numbers[i];
            ///     }
            ///}
            ///
            ///Console.WriteLine($"Max Number Is : {max}");
            ///Console.WriteLine($"Second Max Number Is : {secondMaxNumber}");

            #endregion

            #region Question 8

            ///Console.WriteLine("Enter The Following Data");
            ///
            ///int[] numbers = new int[12];
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///    Console.Write($"Enter {i+1}ST Number: ");
            ///        int.TryParse( Console.ReadLine(), out numbers[i] );
            ///}
            ///
            ///int distance = 0;
            ///for (int i = 0; i < numbers.Length; i++)
            ///{
            ///    for (int j = i +1  ; j < numbers.Length; j++)
            ///    {
            ///        if (numbers[i] == numbers[j])
            ///        {
            ///            if ((j-i) -1 > distance)
            ///            {
            ///                distance = (j - i) - 1;
            ///
            ///            }
            ///
            ///        }
            ///
            ///      
            ///    }
            ///}
            ///Console.WriteLine(distance);
            #endregion

            #region Question 9

            ///Console.WriteLine("enter any Thing");
            ///string userMessage = Console.ReadLine()??"NO message";
            ///
            ///string[] message = userMessage.Split(" ");
            ///
            ///Array.Reverse(message);
            ///
            ///foreach (var name in message)
            ///{
            ///    Console.WriteLine(name);
            ///}

            #endregion

            #region Question 10

            ///int[,] arr1 = new int[3,3];
            ///int[,] arr2 = new int[arr1.GetLength(0) , arr1.GetLength(1)];
            ///
            ///for (int i = 0; i < arr1.GetLength(0); i++)
            ///{
            ///    for (int j = 0; j < arr1.GetLength(1); j++)
            ///    {
            ///        Console.WriteLine("Enter Your x , y numbers");
            ///        int.TryParse(  Console.ReadLine(), out arr1[i,j] );
            ///    }
            ///}
            ///
            ///
            ///for (int i = 0; i < arr1.GetLength(0); i++)
            ///{
            ///    for (int j = 0; j < arr1.GetLength(1); j++)
            ///    {
            ///        arr2[i, j] = arr1[i, j];
            ///    }
            ///
            ///}
            ///
            ///for (int i = 0; i < arr2.GetLength(0); i++)
            ///{
            ///    for (int j = 0; j < arr2.GetLength(1); j++)
            ///    {
            ///        Console.WriteLine(arr2[i,j]);
            ///    
            ///    }
            ///}
            ///
            ///   
            #endregion

            #region Question 11

            ///int[] numbers = new int[4];
            ///for (int i = 0; i <  numbers.Length; i++)
            ///{
            ///    Console.Write($"Enter Your {i+1}St Number: ");
            ///    int.TryParse( Console.ReadLine(), out numbers[i]);
            ///}
            ///
            ///Array.Reverse(numbers);
            ///foreach (var num in numbers)
            ///{
            ///    Console.WriteLine(num);
            ///}
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

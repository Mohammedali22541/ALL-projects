using System.Reflection.Metadata;

namespace Assignment_6
{
    internal class Program
    {

        ///passing value by value
        ///public static int SumValue(int x , int y) {
        ///    x = 100;
        ///   int sum = x + y;
        ///    return sum;
        ///}

        ///passing value by ref
        ///public static int SumValueByRef(ref int x, ref int y) {
        ///
        ///    x = 100;
        ///    int sum = x + y;
        ///    return sum;
        ///
        ///}


        ///passing reference type by value 
        ///public static int CalcArray(int[] arr)
        ///{
        ///   int sumArray = 0;
        ///    
        ///    arr[0] = 100;
        ///
        ///    for (int i = 0; i < arr.Length; i++)
        ///    {
        ///        sumArray += arr[i];
        ///
        ///    }
        ///
        ///    return sumArray;
        ///}

        ///passing reference type by Ref 
        ///public static int SumArray(ref int[] arr)
        ///{
        ///    int sumArray = 0;
        ///
        ///    // reassign a new array
        ///    arr = new int[] { 10, 20, 30, 40 };
        ///    for (int i = 0; i < arr.Length; i++)
        ///    {
        ///        sumArray += arr[i];
        ///
        ///    }
        ///
        ///    return sumArray;
        ///}

        ///passing parameter by out to return 2 value from void function (sum , sub)
        ///public static void CalcInt(int n1 , int n2, int n3, int n4,out int sum , out int sub)
        ///{
        ///    sum = n1 + n2;    
        ///    sub = n3 - n4;
        ///
        ///
        ///}

        ///calculate the sum of the individual digits of a given number
        ///public static int CalcSumOfIndividualDigit(int number)
        ///{
        ///    int sum = 0;
        ///
        ///    while (number > 0)
        ///    {
        ///        int digit = number % 10;
        ///        sum += digit;
        ///        number /= 10;
        ///    }
        ///    return sum; 
        ///
        ///}
        ///

        ///isprime function to show if input number is prime or not    
        ///public static bool IsPrime(int num)
        ///{
        ///
        ///    if (num <= 1)
        ///    {
        ///        return false;
        ///    }
        ///
        ///    for (int i = 2; i * i <= num; i++)
        ///    {
        ///
        ///        if (num % i == 0)
        ///        {
        ///           return false;
        ///        }
        ///        
        ///    }
        ///
        ///   
        ///    return true;
        ///
        ///}

        ///Create a function  MinMaxArray to return the minimum and maximum values
        ///public static void MinMaxArray(int[] numbers, ref int minmum , ref int maximum) { 
        ///
        ///    minmum = numbers[0];
        ///    maximum = numbers[0];
        ///
        ///    //for (int i = 0; i < numbers.Length; i++)
        ///    //{
        ///    //    if (numbers[i] > maximum )
        ///    //    {
        ///    //        maximum = numbers[i];
        ///    //    }else if (numbers[i] < minmum)
        ///    //    {
        ///    //        minmum = numbers[i];
        ///    //    }
        ///    //}
        ///
        ///    //طريقة تانية
        ///    minmum = numbers.Min();
        ///    maximum = numbers.Max();
        ///}

        /// calculate the factorial of the number 
        ///public static int CalcFactorial(int number) { 
        ///
        ///    int factorial = 1;
        ///    for (int i = 1; i <= number; i++)
        ///    {
        ///        factorial = factorial * i;
        ///    }
        ///    return factorial;
        ///
        ///}

        /// function named "ChangeChar" to modify a letter

        public static void ChangeChar(string message , string character)
        {
            Console.WriteLine ($"{message}\r{character}" );

        }
        static void Main(string[] args)
        {

            #region Question 1


            #region passing value type by value

            ///When you passing value type by value to function ... it take a copy from the input values to the function and if you edit the inputs inside the function
            ///the input will not be edited when the function end .. because when you call function and its completed the function stack frame will be deleted from stack in memory

            //int a = 10;
            //int b = 20;
            //
            //int result =  SumValue(a, b);
            //
            //Console.WriteLine(result); // 120
            //Console.WriteLine("a after function = " + a);  // a = 10 even it was 100 in the function stack frame


            #endregion

            #region passing value type by ref
            ///when you use ref the function dont take a copy from value
            ///but it will take the same value [location of these value in memory]
            ///so when you edit any of these value in function it will be updated
            ///even after the function stack frame deleted from stack.

            //int a = 50;
            //int b = 20;
            //
            //Console.WriteLine($"a before function {a}"); // 50
            //
            //
            //int result = SumValueByRef(ref a, ref b); 
            //
            //Console.WriteLine(result); // 120
            //Console.WriteLine($"a after function {a}"); // 100

            #endregion


            #endregion


            #region Question 2

            #region passing reference type by value
            ///when you passing reference type like array by value it will take a copy from value (numbers) in stack
            ///this copy of value in stack is the address
            ///This means both the  variable and the parameter inside the function point to the same object in memory (heap)
            ///so if you edit in one the second will detect this change also...



            ///int[] numbers = { 1, 2, 3, 4 };
            ///Console.WriteLine($"numbers[0] before calling the function = {numbers[0]}"); // = 1
            ///
            ///int result =  CalcArray(numbers);
            ///Console.WriteLine(result); // it will equals 109
            ///Console.WriteLine($"numbers[0] after calling the function = {numbers[0]}"); // = 100

            #endregion
            #region passing reference type by ref
            /// like passing reference type by value it will detect any changes happen in array
            /// but if you use ref it will also detect if the array reassigned and its address changed 
            /// because it will have the reference it self 
            /// it wont create this parameter in function stackframe because its already have the address




            ///int[] numbers = [1, 2, 3, 4];
            ///
            ///Console.WriteLine($"numbers[0] before calling the function = {numbers[0]}"); // = 1
            ///
            ///int result =  SumArray(ref numbers);
            ///Console.WriteLine(result); // it will equals 100
            ///Console.WriteLine($"numbers[0] after calling the function and assign anew array in function = {numbers[0]}"); // = 10


            #endregion

            #endregion

            #region Question 3

            ///int a = 10;
            ///int b = 20; 
            ///int c = 40;
            ///int d = 30;
            /// 
            ///CalcInt(a, b, c, d ,out int sum ,out int sub);
            ///
            ///Console.WriteLine(sum);
            ///Console.WriteLine(sub);

            #endregion

            #region Question 4

            ///Console.Write("Please Enter A Number To Sum: ");
            ///bool isParsed =  int.TryParse(Console.ReadLine(), out int number);
            ///
            /// if (isParsed)
            /// {
            ///     int result = CalcSumOfIndividualDigit(number);
            ///     Console.WriteLine(result);
            /// }
            /// else
            /// {
            ///     Console.WriteLine("Please Enter A Valid Number");
            /// }
            #endregion

            #region Question 5
            ///Console.Write("Enter Number To Check If Its Prime Or Not: ");
            ///bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            ///if (isParsed)
            ///{
            ///  bool isNumberPrime =  IsPrime(number);
            ///    Console.WriteLine(isNumberPrime);
            ///}
            ///else
            ///{
            ///    Console.WriteLine("Please Enter A Valid Number");
            ///}

            #endregion

            #region Question 6
            //int[] numbers = new int[6];
            //
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter {i+1}ST Number:  ");
            //    int.TryParse( Console.ReadLine(),out numbers[i] );
            //}
            //
            //int minmum = 0;
            //int maxmum = 0;
            //MinMaxArray(numbers,ref minmum , ref maxmum);
            //
            //Console.WriteLine($"Minmum Number is: {minmum}");
            //Console.WriteLine($"maxmum Number is: {maxmum}");

            // او تتعمل باستخدام min and max 
            // بتاعة ال array method

            #endregion

            #region Question 7

            ///int factorialResult = CalcFactorial(6);
            ///Console.WriteLine(factorialResult);
            #endregion

            #region Question 8

            //ChangeChar("Mohammed", "j");



            #endregion
        }
    }
}

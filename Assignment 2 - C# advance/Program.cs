using System.Collections;
using System.Collections.Generic;

namespace Assignment_2___C__advance
{
    internal class Program
    {
        public static void Swap(ref ArrayList arr)
        {
           Stack<int> stack = new Stack<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                stack.Push(  (int)arr[i]  );
            }

            arr.Clear();    
            while (stack.Count>0)
            {
                arr.Add(stack.Pop());

            }
        }

        public static List<int> GetEvenNumbers(List<int> list)
        {
            List<int> EvenList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0 )
                {
                    EvenList.Add( list[i]);
                }
            }
            return EvenList;
        }
        public static Queue<T> ReverseUsingQueue<T>(Queue<T> queue)
        {

            Stack<T> values = new Stack<T>(queue.Count);


            while (queue.Count > 0)
            {
                values.Push(queue.Dequeue());


            }

            while (values.Count > 0)
            {
                queue.Enqueue(values.Pop());

            }


            return queue;

        }

        public static bool Balanced(string value)
        {

            char[] chars = value.ToCharArray();
            Stack<char> stack = new Stack<char>(chars.Length);

            for (int i = 0; i < chars.Length; i++)
            {
                //char c = chars[i];
                if (chars[i] == '{' || chars[i] == '(' || chars[i] == '[')
                {
                    stack.Push(chars[i]);
                }
                else if (chars[i] == '}' || chars[i] == ')' || chars[i] == ']')
                {
                    if (stack.Count==0)
                    {
                        return false;
                    }
                    else
                    {
                        char StackChar = stack.Pop();
                        if (chars[i] == ')' && StackChar != '(' || chars[i] == '}' && StackChar != '{' || chars[i] == ']' && StackChar != '[')
                        {
                            return false;
                        }
                    }
                }
            }
            return stack.Count==0;



        }

        public static ArrayList RemoveOdd(ArrayList list) {

            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < list.Count; i++)
            {
                if ((int?)list[i] % 2 != 1)
                {
                    arrayList.Add(list[i]);
                }
            }
            return arrayList;
        }

        public static string searchInStack(int[] nums, int searchNumber)
        {
            Stack<int> stack = new Stack<int>(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                stack.Push(nums[i]);
            }

            int count = 0;

            while (stack.Count > 0)
            {

                if (stack.Pop() == searchNumber)
                {
                    return $"Target was found successfully and the count is {count}";
                }
                count++;



            }
            return "Target was not found";
        }

        public static List<int> intersection(int[] arr1, int[] arr2)
        {

            List<int> resultList = new List<int>();
            List<int> arrtwo = new List<int>(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arrtwo.Contains(arr1[i]))
                {
                    resultList.Add(arr1[i]);

                }
            }
            return resultList;
        }

        public static ArrayList contiguousSub(ArrayList arrayList , int targetSum)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                int sum = 0;
                ArrayList resultList = new ArrayList();


                for (int j = i; j < arrayList.Count; j++)
                {
                    sum += (int)arrayList[j];
                    resultList.Add(arrayList[j]);

                    if (sum == targetSum)
                    {
                        return resultList;
                    }
                    else if(sum > targetSum)
                    {
                        break;
                    }
                }
            }
            return new ArrayList();
        }

        public static Queue<int> Reverse(Queue<int> ints , int k)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(ints.Dequeue());
            }
            //for (int i = k; i < stack.Count; i++)
            //{
            //    stack.Push(ints.Dequeue());

            //}

            while (stack.Count > 0)
            {
                ints.Enqueue(stack.Pop());
            }
            int counts = ints.Count;
            for (int i = 0; i < counts-k; i++)
            {
                ints.Enqueue(ints.Dequeue());
            }

            return ints;


        }


        static void Main(string[] args)
        {
            #region Part 1
            #region Question 1

            ///ArrayList numbers = new ArrayList(){ 1, 2, 3, 4, 5, 6 };
            ///Swap(ref numbers);
            ///foreach (int num in numbers)
            ///{
            ///    Console.WriteLine(num);
            ///}
            #endregion

            #region Question 2
            List<int> ints = new List<int>( new int[] {1,2,3,4,5,6,7,8,9,10});
            List<int> EvenNums;
            EvenNums = GetEvenNumbers(ints);
            foreach (int item in EvenNums)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion
            #region part 2
            #region Quedtion 1

            ///int[] ints = Array.Empty<int>();
            ///
            ///string? strings;
            ///do
            ///{
            ///    Console.WriteLine("Enter Numbers -- dont forget space between each number");
            ///    strings = Console.ReadLine();
            ///}
            ///while (string.IsNullOrWhiteSpace(strings));
            ///
            ///
            ///
            ///
            ///string[]? SplitedNums = strings?.Trim().Split((char[]?) null ,StringSplitOptions.RemoveEmptyEntries);
            ///
            ///if (SplitedNums is not null)
            ///{
            ///    ints = new int[SplitedNums.Length];
            ///    for (int i = 0; i < SplitedNums.Length; i++)
            ///    {
            ///        if (!int.TryParse(SplitedNums[i], out ints[i]))
            ///        {
            ///            Console.WriteLine("Invalid Inputs");
            ///        }
            ///
            ///
            ///
            ///    }
            ///}
            ///
            ///
            ///
            ///bool flag;
            ///int Query;
            ///int count = 0;
            ///do
            ///{
            ///    Console.Write("Enter Number TO Check ");
            ///    flag =  int.TryParse(Console.ReadLine(), out Query);
            ///
            ///}
            ///while (!flag);
            ///for (int i = 0; i < ints.Length; i++)
            ///{
            ///    if (ints[i] > Query)
            ///    {
            ///        count += 1;
            ///    }
            ///  
            ///
            ///
            ///}
            ///
            ///
            ///Console.WriteLine($"Count of Number Bigger Than {Query} is {count}");







            #endregion

            #region Question 2
            ///bool flag;
            ///int num;
            ///do
            ///{
            ///    Console.Write("Please Enter The Size Of Array: ");
            ///    flag = int.TryParse(Console.ReadLine(), out num);
            ///}
            ///while (!flag);
            ///
            ///int[] ints = new int[num];
            ///bool isParsed = false;
            ///
            ///for (int i = 0; i < ints.Length; i++)
            ///{
            ///    do
            ///    {
            ///        Console.Write($"Enter Number {i + 1}: ");
            ///        isParsed =   int.TryParse(Console.ReadLine(), out ints[i]);
            ///    }
            ///    while (!isParsed);
            ///}
            ///bool IsNumPalindrome = true;
            ///for (int i = 0; i < ints.Length / 2; i++)
            ///{
            ///
            ///    if (ints[i] != ints[ints.Length - 1 - i])
            ///    {
            ///        IsNumPalindrome = false;
            ///        break;
            ///        
            ///    }               
            ///}
            ///if (IsNumPalindrome)
            ///{
            ///Console.WriteLine("Yes");
            ///}
            ///else
            ///{
            ///    Console.WriteLine("No");
            ///
            ///
            ///}






            #endregion

            #region Question 3

            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });


            //Queue<int> reversedInt = ReverseUsingQueue(queue);

            //foreach (int item in reversedInt)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Question 4
            ///Console.WriteLine("Please add parentheses to check Balance");
            ///string? value = Console.ReadLine();
            ///bool isBalanced = false;
            ///if (!string.IsNullOrEmpty(value))
            ///{
            ///
            ///     isBalanced = Balanced(value);
            ///
            ///  
            ///}  
            ///if (isBalanced)
            ///    {
            ///    Console.WriteLine("Balanced");
            ///    }
            ///else
            ///{
            ///    Console.WriteLine("Not Balanced");
            ///
            ///
            ///}
            #endregion

            #region Question 5

            ///int[] nums = new int[] { 10, 20, 30, 40, 50, 10 };
            ///nums = nums.Distinct().ToArray();
            ///foreach (var item in nums)
            ///{
            ///    Console.WriteLine(item);
            ///
            ///}

            #region 2

            ///List<int> list = new List<int>();
            ///
            ///for (int i = 0; i < nums.Length; i++)
            ///{
            ///    if (!list.Contains(nums[i]))
            ///    {
            ///        list.Add(nums[i]);
            ///    }
            ///
            ///}
            ///
            ///
            ///nums = list.ToArray();
            ///
            ///foreach (var item in list)
            ///{
            ///    Console.WriteLine(item);
            ///
            ///} 
            #endregion

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 1 + i; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            nums[j] = 0
            //        }
            //    }
            //}

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 6

            ///ArrayList arrayList = new ArrayList();
            ///arrayList.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            ///arrayList = RemoveOdd(arrayList);
            ///
            ///foreach (var item in arrayList)
            ///{
            ///    Console.WriteLine(item);
            ///}
            #endregion

            #region Question 7

            ///Queue queue = new Queue();
            ///queue.Enqueue(1);
            ///queue.Enqueue("apple");
            ///queue.Enqueue(5.28);
            ///
            ///foreach (var item in queue)
            ///{
            ///    Console.WriteLine(item);
            ///}
            #endregion

            #region Question 8

            ///int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ///Console.Write("enter Number TO Search: ");
            ///int.TryParse(Console.ReadLine(), out int searchedNum);
            ///string message = searchInStack(num, searchedNum);
            ///Console.WriteLine(message);

            #endregion

            #region Question 9

            ///int[] nums1 = new int[] { 1, 2, 3, 4, 4 };
            ///int[] nums2 = new int[] { 10, 4, 4 };
            ///
            ///List<int> list = new List<int>();
            ///list = intersection(nums1, nums2);
            ///foreach (var item in list)
            ///{
            ///    Console.WriteLine(item);
            ///}

            #endregion

            #region Question 10

            //ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 7, 5 });
            //int target = 12;
            //ArrayList result = contiguousSub(arrayList, target);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question 11
            ///Queue<int> nums = new Queue<int>(new int[] {1,2,3,4,5});
            ///int k = 3;
            ///Queue <int> queue = Reverse(nums, k);
            ///
            ///foreach (var item in queue)
            ///{
            ///    Console.WriteLine(item);
            ///}
            #endregion
            #endregion

        }
    }
}
    


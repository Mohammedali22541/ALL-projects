using System;
using System.Collections;

namespace Collections_Part_2___Session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 6, 1, 2, 5 };

            //Hashtable nums = new Hashtable();


            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (!nums.ContainsKey(numbers[i]))
            //    {
            //        nums.Add(numbers[i],1);
            //    }
            //    else
            //    {
            //        nums[numbers[i]] = (int?)nums[numbers[i]] + 1;
            //    }
            //}

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Question 2

            ///Hashtable Numbers = new()
            ///{
            ///    {"1", 2},
            ///    {"2", 6},
            ///    {"3", 5},
            ///    {"4", 4},
            ///    {"5", 8},
            ///    {"6", 9},
            ///
            ///};
            ///
            ///int maxValue = 0;
            ///object maxKey = 0;
            ///foreach (DictionaryEntry item in Numbers)
            ///{
            ///
            ///    if((int)item.Value > maxValue)
            ///    {
            ///        maxValue = (int)item.Value;
            ///        maxKey = item.Key;
            ///
            ///    }
            ///}
            ///
            ///Hashtable maxHashTable = new() { {maxKey , maxValue } };
            ///foreach (var item in maxHashTable)
            ///{
            ///    Console.WriteLine(item);
            ///    
            ///}

            #endregion

            #region Question 3
            //Hashtable Fruits = new Hashtable()
            //{
            //{"key1" , "apple" },
            //{"key2" , "banana" },
            //{"key3" , "apple" }

            //};

            //Console.Write("Enter Target Value: ");
            //string? targetValue = Console.ReadLine();



            //bool founded = false;

            //foreach (DictionaryEntry item in Fruits)
            //{
            //    if ((string?)item.Value == targetValue)
            //    {
            //        Console.WriteLine(item.Key);   
            //        founded = true;
            //    }


            //}
            //if (!founded)
            //{
            //    Console.WriteLine("Key Not Found");
            //}


            #endregion

            #region Question 5
            //int[] nums = [1, 2, 3, 4, 5, 6, 5, 2, 3, 1];
            //HashSet<int> ints = new HashSet<int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //if (!ints.Contains(nums[i]))
            //{
            //ints.Add(nums[i]);
            //}
            //else
            //{
            //Console.WriteLine($"this {nums[i]} is Duplicated"); 
            //}

            //}

            //foreach (int item in ints)
            //{
            //Console.WriteLine(item);
            //}



            #endregion

            #region Question 6

            //SortedDictionary<int , string> Students = new SortedDictionary<int , string>()
            //{
            //    {1 , "Mo" },
            //    {2 , "ali" },
            //    {3 , "Ahmed" },
            //    {4 , "salma" },
            //    {5 , "mona" },
            //    {6 , "alaa" },

            //};

            //Students.TryAdd(7, "maryam"); //[1, Mo][2, ali][3, Ahmed][4, salma][5, mona][6, alaa][7, maryam]

            //Students.Remove(5);//           [1, Mo][2, ali][3, Ahmed][4, salma][6, alaa][7, maryam]

            //Console.WriteLine("Student Names: ");
            //foreach (var item in Students)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Question 7


            //SortedList<int , string> EmployeeDirectory = new SortedList<int , string>()
            //{
            //     {1 , "Mo" },
            //     {2 , "ali" },
            //     {8 , "Ahmed" },
            //     {5 , "salma" },
            //     {3 , "mona" },
            //     {6 , "alaa" },
            //};

            //EmployeeDirectory.Add(7,"Salma");

            //foreach (var item in EmployeeDirectory)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question 8
            //int N = 12;
            //int[] ints = { 1, 2, 3 , 5,8,9,12};
            //SortedSet<int> nums = new SortedSet<int>(ints);
            //SortedSet<int> MissingNums = new SortedSet<int>();

            //for (int i = 1; i < N; i++)
            //{
            //    if (!nums.Contains(i))
            //    {
            //        MissingNums.Add(i); 
            //    }
            //}

            //foreach (int item in MissingNums)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 9
            //int[] ints = { 1, 2, 3, 4, 2, 3, 5, 6, 1, 3, 2, 5, 8 };
            //List<int> nums = new List<int>(ints);  // عشان قالي list of int

            //HashSet<int> UniqueNums = new HashSet<int>(nums);
            //foreach (int item in UniqueNums)
            //{
            //Console.WriteLine(item);
            //}
            #endregion

            #region Question 10

            //Hashtable Table = new Hashtable()
            //{
            //    {1 , "Mohammed" },
            //    {2 , "Ali" },
            //    {3 , "Mahmoud" },
            //    {4 , "Salma" },
            //    {5 , "Maryam" }
            //};

            //Hashtable UniqueTable = new Hashtable();

            //foreach (DictionaryEntry item in Table)
            //{
            //   UniqueTable.Add((string?)item.Value,(int) item.Key);
            //}

            //foreach (var item in UniqueTable)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion

            #region Question 11

            //HashSet<int> set1 = new HashSet<int>(new[] {1,2,3,4,5,6,7,8});
            //HashSet<int> set2 = new HashSet<int>(new[] {6,7,8,9,10,11,12});

            //set1.UnionWith(set2);

            //foreach (int item in set1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 12

            //Dictionary<string , int> dict = new Dictionary<string , int>()
            //{
            //{"apple",1},
            //{"animal",2},
            //{"airport",3}
            //};

            //Console.Write("Enter Char to Check: ");
            //string? charr = Console.ReadLine();
            //int count = 0;
            //foreach (var item in dict)
            //{
            //if (item.Key.StartsWith(charr , StringComparison.OrdinalIgnoreCase))
            //{
            //count++;
            //}
            //}

            //Console.WriteLine($"count of Key Started With {charr} is {count}");
            #endregion

            #region Question 13

            //SortedSet<int> Numbers = new SortedSet<int>() { 10,2,3,6,8,9,7,1,5};
            //SortedSet<int> nums = new SortedSet<int>();


            //Console.Write("Enter Target Number To Check: ");
            //int.TryParse(Console.ReadLine(), out int targetNum);

            //foreach (int item in Numbers)
            //{
            //if (item > targetNum)
            //{
            //nums.Add(item);
            //}
            //}

            //foreach (int item in nums)
            //{
            //Console.WriteLine(item);
            //}

            #endregion

            #region Question 14

            //SortedList<string , int> Slist = new SortedList<string , int>()
            //{
                //{"Key 1" , 1 }, 
                //{"Key 2" , 5 }, 
                //{"Key 3" , 6 }, 
                //{"Key 4" , 3 }, 
                //{"Key 5" , 2 }, 
                //{"Key 6" , 4 }, 
                //{"Key 7" , 7 },
            //};
            
            //foreach (var item in Slist)
            //{
                //if (item.Value % 2 == 0)
                //{
                    //Console.WriteLine(item.Key);
                //}
            //}
            #endregion
        }
    }
}

using Demo.Data;
using LinQ___Session_1.Classes;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using System.Xml.Linq;
using static LinQ___Session_1.Classes.ListGenrator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LinQ___Session_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region Q1
            //1. Find all products that are out of stock.
            //var result = ProductsList?.Where(p => p.UnitsInStock > 0);
            //foreach (var item in result ?? Enumerable.Empty<Product>()) { Console.WriteLine(item); }
            #endregion
            #region Q2
            // 2.Find all products that are in stock and cost more than 3.00 per unit.

            //var result = ProductsList?.Where(p => p.UnitsInStock > 0 && p.UnitsInStock> 3);
            //foreach (var item in result ?? Enumerable.Empty<Product>()) { Console.WriteLine(item); }
            #endregion
            #region Q3
            // 3.Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((n, i) => n.Length < i);
            //foreach (var item in result) { Console.WriteLine(item); }
            #endregion

            #endregion

            #region LINQ - Ordering Operators
            #region Q1
            // 1. Sort a list of products by name

            //var result = ProductsList?.OrderBy(p=> p.ProductName);
            //foreach (var item in result ?? Enumerable.Empty<Product>()) Console.WriteLine(item);
            #endregion
            #region Q2
            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(a=>a,new CaseSensetive());

            //foreach (var item in result) Console.WriteLine(item);

            #endregion
            #region Q3
            // 3.Sort a list of products by units in stock from highest to lowest.

            //var result = ProductsList?.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result?? Enumerable.Empty<Product>()) Console.WriteLine(item);

            #endregion
            #region Q4
            // 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.OrderBy(a => a.Length).ThenBy(a=> a);

            //foreach (var item in result) Console.WriteLine(item);



            #endregion
            #region Q5
            // 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(a => a.Length).ThenBy(a => a,new CaseSensetive());
            //foreach (var item in result) Console.WriteLine(item);




            #endregion
            #region Q6
            // 6.Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result = ProductsList?.OrderBy(p=> p.Category).ThenByDescending(p=> p.UnitPrice);
            //foreach (var item in result ?? Enumerable.Empty<Product>()) Console.WriteLine(item);

            #endregion
            #region Q7
            // 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(a => a.Length).ThenByDescending(a => a, new CaseSensetive());
            //foreach (var item in result) Console.WriteLine(item);



            #endregion
            #region Q8
            //8. Create a list of all digits in the array whose second letter is 'i'
            //that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.Select(a => a).Where(a => a.Length > 1 && a[1] == 'i').Reverse();
            //foreach (var item in result) Console.WriteLine(item);
            
               
            
            #endregion

            #endregion

            #region LINQ – Transformation Operators
            #region Q1
            // 1. Return a sequence of just the names of a list of products.

            // var result = ProductsList?.Select(p => p.ProductName);
            // foreach (var item in result ?? Enumerable.Empty<string>() ) Console.WriteLine(item);


            #endregion
            #region Q2
            // 2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(p=> new
            //{
            //    upper = p.ToUpper(), 
            //    lower = p.ToLower(),
            //});
            //foreach (var item in result) Console.WriteLine(item);

            #endregion
            #region Q3
            //3.Produce a sequence containing some properties of Products,
            //including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductsList?.Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    price = p.UnitPrice
            //});
            //foreach (var item in result??Enumerable.Empty<object>()) Console.WriteLine(item);
            //{

            //}
            #endregion
            #region Q4
            //4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((x, i) => new
            //{
            //    Number = x,
            //    InPlace = x == i

            //});
            //Console.WriteLine("Number: In-place");
            //foreach (var item in result) Console.WriteLine($"{item.Number} : {item.InPlace}");

            #endregion
            #region Q5
            //5.Returns all pairs of numbers from both arrays such that the number from numbersA
            //is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };



            //var result = numbersA.SelectMany(n1=> numbersB ,(a,b)=> new
            //{
            //     a, b
            //}).Where(nums => nums.a <nums.b);

            //Console.WriteLine("Pairs where a < b:");
            //foreach (var item in result) Console.WriteLine($"{item.a} is less than {item.b}");

            #endregion
            #region Q6
            // 6. Select all orders where the order total is less than 500.00.

            //var result = CustomersList?.SelectMany(o => o.Orders).Where(n => n.Total < 500);
            //foreach (var item in result ?? Enumerable.Empty<Order>()) Console.WriteLine(item);

            #endregion
            #region Q7
            //7.Select all orders where the order was made in 1998 or later.

            //var result = CustomersList?.SelectMany(o => o.Orders).Where(o => o.OrderDate.Year >= 1998 );
            //foreach (var item in result ?? Enumerable.Empty<Order>()) Console.WriteLine(item);

            #endregion



            #endregion

        }
    }
}

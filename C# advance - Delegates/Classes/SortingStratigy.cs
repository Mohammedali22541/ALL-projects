using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__advance___Delegates.Classes
{
    internal static class SortingStratigy
    {
        public static bool GreaterThan(int x , int y)
        {
            return x > y;
        }
        public static bool LessThan(int x, int y)
        {
            return x < y;
        }
        public static bool GreaterThan(string a , string b)
        {
            return a.Length > b.Length;
        }
        public static bool LessThan(string? a, string? b)
        {
            return a?.Length < b?.Length;
        }

        




    }
}

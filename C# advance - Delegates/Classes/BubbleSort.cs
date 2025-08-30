using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__advance___Delegates.Classes
{

    public delegate TResult SortingStratigyFuncDelegate<in T1  , in T2 ,out TResult>(T1 a , T2 b);
    internal static class BubbleSort<T>
    {
        public static void BubbleSortt(ref T[] arr , SortingStratigyFuncDelegate<T , T , bool>? sortingStratigy )
        {
            if (arr?.Length > 0  && sortingStratigy is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length-1-i; j++)
                    {
                        if (sortingStratigy.Invoke(arr[j], arr[j+1]))
                        {
                            Swap(ref arr[j] ,ref  arr[j+1]);
                        }
                    }
                }
            }
        }

        private static void Swap(ref T v1,ref T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}

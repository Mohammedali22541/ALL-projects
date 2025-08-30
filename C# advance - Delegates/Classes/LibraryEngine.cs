using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__advance___Delegates.Classes
{
    //public delegate string ProcessStratigyFuncDelegate(Book book);

    //internal class LibraryEngine
    //{
    //    public static void ProcessBook(List<Book> bookList, ProcessStratigyFuncDelegate processStratigy)
    //    {
    //        if (bookList is null || processStratigy is null)
    //        {
    //            return;
    //        }
    //        foreach (Book book in bookList)
    //        {
    //            string result = processStratigy(book);
    //            Console.WriteLine(result);
    //        }
    //    }
    //}







    internal class LibraryEngine
    {
        public static void ProcessBook(List<Book> bookList, Func<Book , string> func)
        {
            if (bookList is null || func is null)
            {
                return;
            }
            foreach (Book book in bookList)
            {
                string result = func(book);
                Console.WriteLine(result);
            }
        }
    }
}

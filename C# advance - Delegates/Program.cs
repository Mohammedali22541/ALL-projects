using C__advance___Delegates.Classes;

namespace C__advance___Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List <Book> books = new List<Book>()
            {
                 new Book("150B" , "Love Story" , new [] {"Mohammed", "Ali"} ,new DateTime(2001,02,22) , 5000 ),
                 new Book("200A" , "Who Am I" , new [] {"ali" , "alaa"}  , new DateTime(2025,08,30) , 3000)
            };

            #region User Defined
            //ProcessStratigyFuncDelegate Title = BookFunctions.GetTitle;
            //ProcessStratigyFuncDelegate Author = BookFunctions.GetAuthor;

            //LibraryEngine.ProcessBook(books , Title);
            //LibraryEngine.ProcessBook(books , Author); 
            #endregion

            #region Built-In Delegates
            //Func< Book, string> Title = BookFunctions.GetTitle;
            //Func< Book, string> Price = BookFunctions.GetPrice;

            //LibraryEngine.ProcessBook(books, Title );
            //LibraryEngine.ProcessBook(books, Price); 
            #endregion

            #region Anonymous Method
            //Func<Book, string> Title = delegate (Book book) { return $"Book Title Is: {book.Title}."; };
            //Func<Book, string> Price = delegate (Book book) { return $"Book Price Is {book.Price}."; };
            //Func<Book, string> Isbn = delegate (Book book) { return $"Book Isbn Is: {book.Isbn}."; };



            //LibraryEngine.ProcessBook(books, Title);
            //LibraryEngine.ProcessBook(books, Price);
            //LibraryEngine.ProcessBook (books, Isbn);
            #endregion

            #region  Lambda Expression 

            //Func<Book, string> Title = book => $"Book Title Is: {book.Title}.";
            //Func<Book, string> Price = (book) => $"Book Price Is {book.Price}.";
            //Func<Book, string> PublicationDate = book => $"Book Publication Date Is {book.PublicationDate}";



            //LibraryEngine.ProcessBook(books, Title);
            //LibraryEngine.ProcessBook(books, Price);
            //LibraryEngine.ProcessBook(books, PublicationDate);
            #endregion

            #region EX
            //int[] arrNums = [1, 5, 7, 1, 3, 2, 4, 8, 9];

            //string[] Names = { "Mo", "Lolo", "Salma" };
            //BubbleSort<string>.BubbleSortt(ref Names, SortingStratigy.LessThan);
            //foreach (var item in Names)
            //{
            //    Console.WriteLine(item);

            //}

            //BubbleSort<int>.BubbleSortt(ref  arrNums , SortingStratigy.LessThan);
            //foreach (int item in arrNums)
            //{
            //    Console.WriteLine(item);

            //} 
            #endregion
        }
    }
}
    
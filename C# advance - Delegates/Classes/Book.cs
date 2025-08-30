using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__advance___Delegates.Classes
{
    public class Book
    {
        #region Properties
        public string? Isbn { get; set; }
        public string? Title { get; set; }
        public string[]? Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Constructors
        public Book(string? isbn, string? title, string[]? author, DateTime publicationDate, decimal price)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            Price = price;
        }
        #endregion

        #region OverRide Methods
        public override string ToString()
        {
            string author = (Author is null || Author.Length == 0)? "No Author" : string.Join(", ", Author);
            return $"This Is Book Information \n  Isbn: {Isbn} , Title: {Title} , Authors: {author} , PublicationDate: {PublicationDate} , Price: {Price}";
        }
        #endregion
    }
}

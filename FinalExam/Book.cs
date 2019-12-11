using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    /// <summary>
    /// Represents a single book.
    /// </summary>
    public class Book
    {
        ////////////////////////////////////////////////////////////////////
        ///////////////// Auto implemented properties //////////////////////
        /// <summary>
        /// The title of the book.
        /// </summary>
        public string BookTitle { get; set; }
        /// <summary>
        /// The book's ISBN number (International Standard Book Number).
        /// </summary>
        public string BookISBN { get; set; }
        /// <summary>
        /// The price of the book.
        /// </summary>
        public decimal BookPrice { get; set; }
        ///////////////// Auto implemented properties //////////////////////
        ////////////////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////
        //////////////////////// Constructors //////////////////////////////
        /// <summary>
        /// Default constructor
        /// </summary>
        public Book()
        {
        }
        /// <summary>
        /// Creates a book with a title, ISBN, and price.
        /// </summary>
        /// <param name="ISBN"></param>
        /// <param name="title"></param>
        /// <param name="price"></param>
        public Book(string title, string ISBN, decimal price) 
        {
            BookTitle = title;
            BookISBN = ISBN;
            BookPrice = price;
        }
        //////////////////////// Constructors //////////////////////////////
        ////////////////////////////////////////////////////////////////////
        

        /// <summary>
        /// Return a user friendly display string for this Book instance.
        /// </summary>
        /// <returns></returns>
        public string GetDisplayText()
        {
            return $"Title: {BookTitle} ISBN: {BookISBN} Price: {BookPrice.ToString()}";
        }

        public override string ToString()
        {
            return $"{BookTitle}";
        }
    }
}

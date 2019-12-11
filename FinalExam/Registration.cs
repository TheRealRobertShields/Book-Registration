using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Registration
    {
        ////////////////////////////////////////////////////////////////////
        ///////////////// Auto implemented properties //////////////////////
        /// <summary>
        /// The ID number of the customer.
        /// </summary>
        public int CustomerID { get; set; }
        /// <summary>
        /// The book's ISBN number (International Standard Book Number).
        /// </summary>
        public string BookISBN { get; set; }
        ///////////////// Auto implemented properties //////////////////////
        ////////////////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////
        //////////////////////// Constructors //////////////////////////////
        /// <summary>
        /// Default constructor
        /// </summary>
        public Registration()
        {
        }
        /// <summary>
        /// Creates an instance of a Customer that Registered a Book.
        /// </summary>
        /// <param name="custID"></param>
        /// <param name="ISBN"></param>
        public Registration(int custID, string ISBN)
        {
            CustomerID = custID;
            BookISBN = ISBN;
        }
        //////////////////////// Constructors //////////////////////////////
        ////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Return a user friendly display string for this Registration instance.
        /// </summary>
        /// <returns></returns>
        public string GetDisplayText()
        {
            return $"Customer: {CustomerID.ToString()} registered book: {BookISBN}";
        }
    }
}

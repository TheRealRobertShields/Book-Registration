using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    /// <summary>
    /// Represents a single customer.
    /// </summary>
    public class Customer
    {
        ////////////////////////////////////////////////////////////////////
        ///////////////// Auto implemented properties //////////////////////
        /// <summary>
        /// The ID number of the customer.
        /// </summary>
        public int CustomerID { get; set; }
        /// <summary>
        /// The customer's first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The customer's last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The birth date of the customer.
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        ///////////////// Auto implemented properties //////////////////////
        ////////////////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////
        //////////////////////// Constructors //////////////////////////////
        /// <summary>
        /// Default constructor
        /// </summary>
        public Customer()
        {
        }
        /// <summary>
        /// Creates a customer with a CustomerID, FirstName, LastName, and DOB.
        /// </summary>
        /// <param name="custID"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="DOB"></param>
        public Customer(int custID, string fName, string lName, DateTime DOB)
        {
            CustomerID = custID;
            FirstName = fName;
            LastName = lName;
            DateOfBirth = DOB;
        }
        //////////////////////// Constructors //////////////////////////////
        ////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Return a user friendly display string for this Customer instance.
        /// </summary>
        /// <returns></returns>
        public string GetDisplayText()
        {
            return $"First Name: {FirstName} Last Name: {LastName} Date Of Birth: {DateOfBirth.ToString("MMM dd yyyy")} CustomerID: {CustomerID.ToString()}";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}

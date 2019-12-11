using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    /// <summary>
    /// Helper class to get a connection to the Books database.
    /// </summary>
    static class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            // HOME CONNECTION STRING //
            string con = @"Data Source=DESKTOP-FL9KNKA\SQLEXPRESS;Initial Catalog=BookRegistration;Integrated Security=True";

            // CLOVER PARK CONNECTION STRING //
            //string con = @"Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True";
            return new SqlConnection(con);
        }
    }
}

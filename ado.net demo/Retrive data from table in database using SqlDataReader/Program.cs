using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retrive_data_from_table_in_database_using_SqlDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = @"Data Source=ANANTH\ANANTH;Initial Catalog=Anantha Kumar;Integrated Security=True";
            using(SqlConnection connection=new SqlConnection(connectionstring))
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand("select * from School", connection);
                using(SqlDataReader schoolDataReader=selectCommand.ExecuteReader())
                {
                    while(schoolDataReader.Read())
                    {
                        Console.WriteLine("retrive data based on table column names\n");
                        Console.WriteLine("{0} {1} {2} {3} {4} {5}",schoolDataReader["studentId"], schoolDataReader["studentName"], schoolDataReader["fatherName"], schoolDataReader["DateOfBirth"], schoolDataReader["PhoneNumber"], schoolDataReader["Address"]);
                        
                        Console.WriteLine("\nretrive data based on table column index values\n");
                        Console.WriteLine("Student Id:{0} Name:{1} Father Name:{2} date of Birth:{3} Phone Number:{4} Address:{5}",schoolDataReader[0],schoolDataReader[1],schoolDataReader[2],schoolDataReader[3],schoolDataReader[4],schoolDataReader[5]);
                        Console.WriteLine("");
                    }
                }
            }
            
        }
    }
}

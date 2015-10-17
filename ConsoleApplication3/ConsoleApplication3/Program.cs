using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString=@"Data Source=ANANTH\ANANTH;Initial Catalog=Anantha Kumar;Integrated Security=True";
            using (SqlConnection connection1 = new SqlConnection(connectionString))
            {
                string selectQuery = "Select email from Employees";
                SqlCommand cmd2 = new SqlCommand(selectQuery, connection1);
                  using(SqlDataReader emailReader=cmd2.ExecuteReader())
                  {
                      while(emailReader.Read())
                      {
                          if(emailReader['email']==email)
                          {
                              MessageBox.Show(" email id already exist.please enter another email id");
                          }

                      }
                  }
                
            }
               
        }
    }
}

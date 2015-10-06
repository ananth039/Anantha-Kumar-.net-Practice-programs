using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_table_in_database
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=ANANTH\\ANANTH;Initial Catalog=Anantha Kumar;Integrated Security=True";
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                try
                {
                    string query = "create table MobileShop(mobileId int,mobileBrand varchar(100),mobilemodel varchar(100),mobilePrice int)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Table is created");
                    connection.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine("already table is created");
                   
                    connection.Close();
                }

            }
        }
    }
}

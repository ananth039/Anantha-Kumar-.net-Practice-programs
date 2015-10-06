using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_the_values_in_to_table
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString=@"Data Source=ANANTH\ANANTH;Initial Catalog=Anantha Kumar;Integrated Security=True";
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                try
                {
                    Console.WriteLine("Enter Mobile Id");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Mobile Brand");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Enter Mobile Model");
                    string model = Console.ReadLine();
                    Console.WriteLine("Enter Mobile Price");
                    int price = int.Parse(Console.ReadLine());
                    string query = "insert into MobileShop(mobileId,mobileBrand,mobilemodel,mobilePrice) values({0},'{1}','{2}',{3})";
                    SqlCommand cmd = new SqlCommand(string.Format(query, id, brand, model, price), connection);
                    connection.Open();
                    int effect = cmd.ExecuteNonQuery();
                    Console.WriteLine("{0} rows effected", effect);
                    connection.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    connection.Close();
                }
            }
        }
    }
}

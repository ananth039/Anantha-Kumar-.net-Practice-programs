using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace update_the_tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString=@"Data Source=ANANTH\ANANTH;Initial Catalog=Anantha Kumar;Integrated Security=True";
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                string query="update MobileShop set mobileBrand='{0}' where mobileId={1}";
                Console.WriteLine("upadate mobileBrand******* ");
                Console.WriteLine("Enter MobileBrand name");
                string brand = Console.ReadLine();
                Console.WriteLine(" which mobile is update enter Mobile  Id");
                int id = int.Parse(Console.ReadLine());
                SqlCommand cmd = new SqlCommand(string.Format(query, brand, id), connection);
                connection.Open();
                int effect = cmd.ExecuteNonQuery();
                Console.WriteLine("{0} rows updated",effect);
                
                connection.Close();
            }
        }
    }
}

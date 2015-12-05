using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Configuration.Assemblies;

namespace DataAccessLayer
{
    public class DAEmployee
    {

        public string Name { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        static string connectionString = ConfigurationManager.ConnectionStrings["empdetails"].ConnectionString;

        static SqlConnection con = new SqlConnection(connectionString);
        public DataTable GetDepartmentData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tblDepartment", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int insertEmployee(DAEmployee dacObject)
        {
            SqlCommand cmd = new SqlCommand("insert into tblEmployee(ename,Salary,did) values(@ename,@esal,@did)", con);
            cmd.Parameters.AddWithValue("@ename", dacObject.Name);
            cmd.Parameters.AddWithValue("@esal", dacObject.Salary);
            cmd.Parameters.AddWithValue("@did", dacObject.DepartmentId);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }

    }
}

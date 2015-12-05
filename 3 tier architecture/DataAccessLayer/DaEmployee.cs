using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DataAccessLayer
{
    public class DaEmployee
    {
        public string  Name { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["empdetails"].ConnectionString);
        public DataTable GetDeptDetails()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tblDepartment", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int InsertEmployeeDetails(DaEmployee dacobject)
        {
            SqlCommand cmd = new SqlCommand("insert into tblEmployee(ename,Salary,did) values(@ename,@salary,@Did)", con);
            cmd.Parameters.AddWithValue("@ename", dacobject.Name);
            cmd.Parameters.AddWithValue("@salary", dacobject.Salary);
            cmd.Parameters.AddWithValue("@Did", dacobject.DepartmentId);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}

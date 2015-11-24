using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace images_in_gridview
{
    public class EmployeeDataAccessLayer
    {
        public static List<Employee> GetAllEmployee()
        {
            List<Employee> listemployees = new List<Employee>();
            string cs = ConfigurationManager.ConnectionStrings["empdetails"].ConnectionString;
            using(SqlConnection con=new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from EmployeeData", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    Employee emp = new Employee();
                    emp.Eid = Convert.ToInt32(rdr["Eid"]);
                    emp.Name = rdr["Name"].ToString();
                    emp.Gender = rdr["Gender"].ToString();
                    emp.City = rdr["City"].ToString();
                    emp.photo = rdr["photo"].ToString();
                    listemployees.Add(emp);
                }
            }

            return listemployees;

        }
    }
}
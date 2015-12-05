using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{

    public class DaStudent
    {

        public string Sname { get; set; }
        public int Subject1 { get; set; }
        public int Subject2 { get; set; }
        public int Subject3 { get; set; }

        public string Result { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["studentconnection"].ConnectionString);
        public int InsertStudentDetails(DaStudent dastd)
        {
            int i = 0;
            SqlCommand cmd = new SqlCommand("sp_insertStudentDetails", con);
            cmd.Parameters.AddWithValue("@Name", dastd.Sname);
            cmd.Parameters.AddWithValue("@Subject1", dastd.Subject1);
            cmd.Parameters.AddWithValue("@Subject2", dastd.Subject2);
            cmd.Parameters.AddWithValue("@Subject3", dastd.Subject3);
           
            cmd.Parameters.AddWithValue("@Result",dastd.Result);
            con.Open();

            cmd.CommandType = CommandType.StoredProcedure;
           
                i = cmd.ExecuteNonQuery();
             con.Close();
            return i;

        }

        public DataTable GetSudentStdetails()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Student", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace DataAcessLayer
{
    public class Admin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int LoginId { get; set; }
        public int ArticleId { get; set; }

        public string Status { get; set; }


        //connection is established to  dotnetProject database.
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dotnetProject"].ConnectionString);

        

        public int LoginUserAuthentication(Admin admin)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from Admin where UserName=@Username and password=@Password", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Username", admin.Username);
            cmd.Parameters.AddWithValue("@Password", admin.Password);
          
            int i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }
        public DataTable GetUserDetails()
        {
            SqlDataAdapter da = new SqlDataAdapter("select LoginId,Name,Username,SecQuestion,Answer,Status from Login", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string GetUserStatus(Admin admin)
        {
          
            con.Open();
            SqlCommand cmd = new SqlCommand("select Status from Login where LoginId=@LoginId", con);
            cmd.Parameters.AddWithValue("@LoginId", admin.LoginId);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                Status = dr[0].ToString();
            con.Close();
            return Status;
            
        }
        public int UpdateStatus(Admin admin)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Login set Status=@status where LoginId=@LoginId", con);
            cmd.Parameters.AddWithValue("@status", admin.Status);
            cmd.Parameters.AddWithValue("@LoginId", admin.LoginId);
           int updatestatus=cmd.ExecuteNonQuery();
            con.Close();
            return updatestatus;
        }

        public DataTable GetAllArticles()
        {
            SqlDataAdapter da = new SqlDataAdapter("select A.*,L.Username from Articles A inner join Login L on L.LoginId=A.LognId", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int DeleteArticle(Admin admin)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Articles  where ArticleId=@ArticleId", con);
            cmd.Parameters.AddWithValue("@ArticleId", admin.ArticleId);
            int deletestatus = cmd.ExecuteNonQuery();
            con.Close();
            return deletestatus;
        }
    }
}

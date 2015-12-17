using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAUsers
    {
        public int LoginId { get; set; }
        public string  Name { get; set; }
        public string Phno { get; set; }
        public string Email { get; set; }
        public string  Username { get; set; }
        public string Password { get; set; }
        public string SecQuestion { get; set; }
        public string Answer { get; set; }
        public string Status { get; set; }
        public string message { get; set; }
        public string Imagepath { get; set; }

        //connection is established to  dotnetProject database.
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dotnetProject"].ConnectionString);

      
        //insert the user details in Login Table
        public int insertUserDetails(DAUsers dausrs)
       {
          
          SqlCommand cmd = new SqlCommand("insert into Login(LoginId,Name,Phno,email,Username,Password,SecQuestion,Answer) values(@LoginId,@Name,@Phno,@email,@Username,@Password,@SecQuestion,@Answer)", con);
          cmd.Parameters.AddWithValue("@LoginId",(int)dausrs.LoginId);
          cmd.Parameters.AddWithValue("@Name",dausrs.Name);
            cmd.Parameters.AddWithValue("@Phno",dausrs.Phno);
            cmd.Parameters.AddWithValue("@email", dausrs.Email);
            cmd.Parameters.AddWithValue("@Username", dausrs.Username);
            cmd.Parameters.AddWithValue("@Password", dausrs.Password);
            cmd.Parameters.AddWithValue("@SecQuestion", dausrs.SecQuestion);
            cmd.Parameters.AddWithValue("@Answer", dausrs.Answer);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
       }
        
        //Generate the Login Id Automatically by count of records and increament by 1
        public int AutoGenerateLoginId()
        {
            SqlCommand cmd1 = new SqlCommand("Select count(*) from Login", con);
            con.Open();
            int id=(int)cmd1.ExecuteScalar();
            con.Close();
            id = id + 1;
            return id;
        }

        //validate the user credentials and status should be Enable
        public int LoginUserAuthentication(DAUsers dausr)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from Login where Username=@Username and Password=@Password and Status=@Status", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Username", dausr.Username);
            cmd.Parameters.AddWithValue("@Password", dausr.Password);
            cmd.Parameters.AddWithValue("@Status", "Enabled");
            int i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }

        //check UserName is exist or not and check  secquestion and answer  exits or not
        public int checkUser(DAUsers dausr)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Login where Username=@Username  and SecQuestion=@SecQuestion and Answer=@Answer ", con); 
            cmd.Parameters.AddWithValue("@Username", dausr.Username);
            cmd.Parameters.AddWithValue("@SecQuestion", dausr.SecQuestion);
            cmd.Parameters.AddWithValue("@Answer", dausr.Answer);
            int countUserCheck = (int)cmd.ExecuteScalar();
            con.Close();
            return countUserCheck;
        }

        //Retrive the password from table based on username,security question and answer.
      
        public string GetPassword(DAUsers dausr)
        {
            SqlCommand cmd = new SqlCommand("Select Password from Login where Username=@Username and SecQuestion=@SecQuestion and Answer=@Answer", con);
           con.Open();
            cmd.Parameters.AddWithValue("@Username", dausr.Username);
            cmd.Parameters.AddWithValue("SecQuestion", dausr.SecQuestion);
            cmd.Parameters.AddWithValue("@Answer", Answer);
            SqlDataReader dr = cmd.ExecuteReader();
            string password="";
                if (dr.Read())
                    password = dr[0].ToString();
            con.Close();
            return password;

        }

        //Retrive email address from users table
        public string GetEmailId(DAUsers dausr)
        {

            string EmailId="";

            con.Open();

            SqlCommand cmd = new SqlCommand("Select email from Login where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", dausr.Username);
          
            SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                    EmailId = dr[0].ToString();

             con.Close();

             return EmailId;
        }
    
        //retrive the imageapath from users table
        public string getImage(DAUsers dausr)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select PhotoPath from Login where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", dausr.Username);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                Imagepath = dr[0].ToString();

            con.Close();
            
            return Imagepath;
        }

        public int GetLoginId(DAUsers dausr)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select LoginId from Login where Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", dausr.Username);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                LoginId =Convert.ToInt32(dr[0]);

            con.Close();

            return LoginId;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    
        
      
   public class DaFourms
    {
        
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public int ReplyId { get; set; }
        public string Reply { get; set; }
        public int LoginId { get; set; }

   

        //connection is established to  dotnetProject database.
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dotnetProject"].ConnectionString);


        //generate question id from Forums table
        public int AutoGenerateQuestionId()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select count(*) from Fourms", con);
           
            int Questid = (int)cmd1.ExecuteScalar();
            con.Close();
            Questid = Questid + 1;

            return Questid;

        }
       public int InsertpostQueries(DaFourms fourms)
        {
           con.Open();
           SqlCommand cmd=new SqlCommand("insert into Fourms(QuestionId,Question,LoginId) values(@QuestionId,@Question,@LoginId)",con);
           cmd.Parameters.AddWithValue("@QuestionId",fourms.QuestionId);
           cmd.Parameters.AddWithValue("@Question",fourms.Question);
           cmd.Parameters.AddWithValue("@LoginId",fourms.LoginId);
           int i=cmd.ExecuteNonQuery();
           con.Close();
           return i;
        }




    }   
}


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
            SqlCommand cmd = new SqlCommand("insert into Fourms(QuestionId,Question,LoginId) values(@QuestionId,@Question,@LoginId)", con);
            cmd.Parameters.AddWithValue("@QuestionId", fourms.QuestionId);
            cmd.Parameters.AddWithValue("@Question", fourms.Question);
            cmd.Parameters.AddWithValue("@LoginId", fourms.LoginId);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
       public DataTable GetAllQuestions()
       {
           SqlDataAdapter da = new SqlDataAdapter("select f.QuestionId,f.Question,l.Username from Fourms f inner join Login l on l.LoginId=f.LoginId", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


       public string GetQuestion(DaFourms fourm)
       {
           string question="";
          con.Open();
           SqlCommand cmd = new SqlCommand("Select Question from Fourms where QuestionId=@QuestionId", con);
           cmd.Parameters.AddWithValue("@QuestionId",fourm.QuestionId);
           SqlDataReader dr = cmd.ExecuteReader();
           if(dr.Read())
               question = dr["Question"].ToString();
           con.Close();
           return question;
       }
      
       public int InsertFourmsReply(DaFourms fourms)
       {
           con.Open();
           SqlCommand cmd = new SqlCommand("insert into FourmReply(QuestionId,Reply,LoginId) values(@QuestionId,@Reply,@LoginId)", con);
           cmd.Parameters.AddWithValue("@QuestionId",fourms.QuestionId);
           cmd.Parameters.AddWithValue("@Reply",fourms.Reply);
           cmd.Parameters.AddWithValue("@LoginId", fourms.LoginId);
           int status = cmd.ExecuteNonQuery();
           con.Close();
          return status;
       }
       public DataTable GetAllAnsweredQuestions()
       {
           SqlDataAdapter da = new SqlDataAdapter("select f.QuestionId,f.Question,fr.Reply,L.UserName from Fourms f inner join FourmReply fr on f.LoginId=fr.LoginId inner join Login l on l.LoginId=f.LoginId", con);
           DataTable dt = new DataTable();
           da.Fill(dt);
           return dt;
       }
       public int DeleteFourms(DaFourms fourm)
       {
           con.Open();
          
           SqlCommand cmd1=new SqlCommand("delete from FourmReply where QuestionId=@QuestionId",con);
           cmd1.Parameters.AddWithValue("@QuestionId", fourm.QuestionId);
           int deletestatus2=cmd1.ExecuteNonQuery();
           SqlCommand cmd = new SqlCommand("delete from Fourms where QuestionId=@QuestionId", con);
           cmd.Parameters.AddWithValue("@QuestionId", fourm.QuestionId);
           int deletestatus1 = cmd.ExecuteNonQuery();
           int status= 0;
            con.Close();
            if (deletestatus1 > 0 && deletestatus2 > 0)
                status = 1;
            else
                 status = 0;

            return status;
          
       }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DataAcessLayer;



namespace DataAcessLayer
{
    public class DAArticles
    {
        public int ArticleId { get; set; }
        public string ArticleType { get; set; }
        public string Description { get; set; }
        public string date { get; set; }
        public string Time { get; set; }
        public int LoginId { get; set; }



        

        //connection is established to  dotnetProject database.
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dotnetProject"].ConnectionString);

        public int AutoGenerateArticleId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Articles", con);
            int cnt =(int) cmd.ExecuteScalar();
            con.Close();
            cnt = cnt + 1;
            return cnt;
        }
      public int InsertPostArticle(DAArticles article)
        {
            con.Open();
         
            SqlCommand cmd = new SqlCommand("insert into Articles values(@ArticleId,@ArticlType,@ArticleDesc,@CDate,@Time,@LognId)",con);
            cmd.Parameters.AddWithValue("@ArticleId",article.ArticleId);
            cmd.Parameters.AddWithValue("@ArticlType",article.ArticleType);
            cmd.Parameters.AddWithValue("@ArticleDesc",article.Description);
            cmd.Parameters.Add("@CDate",SqlDbType.Date).Value=article.date;
             cmd.Parameters.Add("@Time",SqlDbType.Time).Value=article.Time;
             cmd.Parameters.AddWithValue("@LognId", article.LoginId);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
      public DataTable GetAllArticles()
      {
          SqlDataAdapter da = new SqlDataAdapter("select a.ArticlType,a.ArticleDesc,a.CDate,a.Time,l.Username from Articles a inner join Login l on l.LoginId=a.LognId ", con);
          DataTable dt = new DataTable();
          da.Fill(dt);
          return dt;
      }

      public DataTable SearchArticles(DAArticles article)
      {

          DataTable dt = new DataTable();
          string articleType = article.ArticleType;
          SqlDataAdapter da = new SqlDataAdapter("select a.ArticlType,a.ArticleDesc,a.CDate,a.Time,l.Username from Articles a inner join Login l on l.LoginId=a.LognId where ArticlType like'" + articleType+"%'", con);
          da.Fill(dt);
          return dt;
      }
       
        
        
      
    }
}

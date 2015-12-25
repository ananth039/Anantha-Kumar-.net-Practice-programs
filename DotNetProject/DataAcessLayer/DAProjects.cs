using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web;

namespace DataAcessLayer
{
  public class DAProjects
    {
        public int ProjectId { get; set; }
        public string ProjectType { get; set; }
        public string  FileName { get; set; }
        public string FileType { get; set; }
        public byte[] FileData { get; set; }
        public int LoginId { get; set; }

        //connection is established to  dotnetProject database.
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dotnetProject"].ConnectionString);


        //generate question id from Forums table
        public int AutoGenerateProjectId()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select count(*) from Projects", con);

            int Projectid = (int)cmd1.ExecuteScalar();
            con.Close();
            int pid = Projectid + 1;

            return pid;

        }
        public int InsertpostProjects(DAProjects project)
        {
          
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Projects values(@projectId,@ProjectType,@FileName,@FileType,@FileData,@LoginId)", con);
                cmd.Parameters.AddWithValue("@projectId", project.ProjectId);
                cmd.Parameters.Add("@ProjectType",project.ProjectType);
                cmd.Parameters.AddWithValue("@FileName", project.FileName);
                cmd.Parameters.AddWithValue("@FileType", project.FileType);
                cmd.Parameters.AddWithValue("@FileData", project.FileData);
                cmd.Parameters.AddWithValue("@LoginId", project.LoginId);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
           
        }
     public DataTable GetAllProjects()
        {
            SqlDataAdapter da = new SqlDataAdapter("select p.projectId,p.ProjectType,p.FileName,p.filetype,l.Username from Projects p inner join Login l on l.LoginId=p.LoginId", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

     public DataTable SearchProjects(DAProjects project)
     {
         SqlDataAdapter da = new SqlDataAdapter("select p.projectId,p.ProjectType,p.FileName,p.filetype,l.Username from Projects p inner join Login l on l.LoginId=p.LoginId where ProjectType like'"+project.ProjectType+"%'", con);
         DataTable dt = new DataTable();
         da.Fill(dt);
         return dt;
     }
      public int DeleteProject(DAProjects project)
     {
         con.Open();
         SqlCommand cmd = new SqlCommand("delete from Projects where projectId=@projectId", con);
         cmd.Parameters.AddWithValue("@projectId", project.ProjectId);
         int i = cmd.ExecuteNonQuery();
         con.Close();
         return i;
     }
    }
}

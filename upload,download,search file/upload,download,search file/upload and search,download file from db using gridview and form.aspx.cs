using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace upload_download_search_file
{
    public partial class upload_and_search_download_file_from_db_using_gridview_and_form : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Project"].ToString());
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Bind();
            }
         
            
        }

        private void Bind()
        {
            con.Open();
            cmd = new SqlCommand("select * from Files", con);
            da=new SqlDataAdapter(cmd);
            ds=new DataSet();
           da.Fill(ds,"Files");
            
            
           
            GridView1.DataSource = ds;
            GridView1.DataBind();
            
            con.Close();
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            byte[] fd = new byte[FileUpload1.PostedFile.ContentLength];
            HttpPostedFile hps = FileUpload1.PostedFile;
            hps.InputStream.Read(fd, 0, FileUpload1.PostedFile.ContentLength);
            string filename = FileUpload1.FileName;
            FileInfo f1 = new FileInfo(FileUpload1.FileName);
            string filetype = f1.Extension;
            cmd = new SqlCommand("FilesAllOperations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FileId ",int.Parse(txtFileId.Text));
            cmd.Parameters.AddWithValue("@FileType", filetype);
            cmd.Parameters.AddWithValue("@FileName", filename);
            cmd.Parameters.AddWithValue("@FileContent", fd);
            cmd.Parameters.AddWithValue("@Type", 'i');
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            txtFileId.Text = "";
            Bind();
            


        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id = 0;
            if (e.CommandName == "File")
            {
                id = (int)Convert.ToInt32(e.CommandArgument);

                cmd = new SqlCommand("select FileName,FileContent from Files where FileId=@FileId", con);
                cmd.Parameters.AddWithValue("@FileId", id);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Byte[] bytes = (Byte[])dt.Rows[0][3];
                Response.Buffer = true;
                Response.Charset = "";
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.ContentType = dt.Rows[0][3].ToString();
                Response.AddHeader("Content_Disposition", "attachment;filename=" + dt.Rows[0][3].ToString());
                Response.BinaryWrite(bytes);
                Response.Flush();
                Response.End();
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Files where FileName='" + txtSearchFilename.Text + "'", con);
            ds = new DataSet();
            da.Fill(ds, "Files");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        

        

 

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
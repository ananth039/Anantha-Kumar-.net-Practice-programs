using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace asp.net_project
{
    public partial class Upload_and_download_files_from_database : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["files"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGridViewData();
            }
        }

        private void BindGridViewData()
        {
            SqlCommand cmd = new SqlCommand("Select * from FileInformation", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "FileInfo");
            GridViewFiles.DataSource = ds.Tables["FileInfo"];
            GridViewFiles.DataBind();
        }

        protected void LinkDownload_Click(object sender, EventArgs e)
        {
            LinkButton linkdbtn = sender as LinkButton;
            GridViewRow grow = linkdbtn.NamingContainer as GridViewRow;
            int field = Convert.ToInt32(GridViewFiles.DataKeys[grow.RowIndex].Value.ToString());
            string name, type;
            SqlCommand cmd = new SqlCommand("Select FileName,FileType,FileData from FileInformation where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", field);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Response.ContentType = dr["FileType"].ToString();
                Response.AddHeader("Content-Disposition", "attachment;filename=\"" + dr["FileName"] + "\"");
                Response.BinaryWrite((Byte[])dr["FileData"]);
                Response.End();
            }
           
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            Stream str = FileUpload1.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(str);
           Byte[] size=br.ReadBytes((int)str.Length);
           SqlCommand cmd = new SqlCommand("insert into FileInformation(FileName,FileType,FileData) values(@Name,@Type,@Data)", con);
           cmd.Parameters.AddWithValue("@Name", fileName);
           cmd.Parameters.AddWithValue("@Type", "Application/Word");
           cmd.Parameters.AddWithValue("@Data", size);
           con.Open();
           cmd.ExecuteNonQuery();
           con.Close();
           BindGridViewData();
            

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace save_images_into_folder_and_images_path_in_database
{
    public partial class Image_upload_form : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ImageConnection"].ConnectionString);
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if(fileuploadImage.HasFile)
            {
                 string filename=Path.GetFileName(fileuploadImage.PostedFile.FileName);
                
                 fileuploadImage.SaveAs(Server.MapPath("~/Images/" + filename));
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_InsertImage", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PhotoName",filename);
            cmd.Parameters.AddWithValue("@ImagePath", "Images/" + filename);
            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('Your image is uploaded sucessfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Please select Image');</script>");
            }
           
        }
    }
}
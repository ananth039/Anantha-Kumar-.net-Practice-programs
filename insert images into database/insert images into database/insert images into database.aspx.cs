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

namespace insert_images_into_database
{
    public partial class insert_images_into_database : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ImagConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

                if (FileUploadImage.HasFile)
                {
                   //string extension=Path.GetExtension(FileUploadImage.PostedFile.FileName);
                    int size = FileUploadImage.PostedFile.ContentLength;

                    //if(extension=="jpg"||extension=="png"||extension=="bmp"||extension=="gif")
                    //{
                        //check image file is 100kb or not
                        //if(size>=102400)
                        //{

                        string imgname = Path.GetFileName(FileUploadImage.PostedFile.FileName);
                        byte[] imgbyte = new byte[size];
                    HttpPostedFile img = FileUploadImage.PostedFile;
                    img.InputStream.Read(imgbyte, 0, size);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Images(ImageName,Image) values(@ImageName,@Image)", con);
                   
                    cmd.Parameters.Add("@ImageName", SqlDbType.NVarChar, 50).Value = imgname;
                    cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgbyte;
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        Response.Write("<script>alert('Image is sucessfully uploaded')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Image is not sucessfully uploaded')</script>");
                    }
                    Response.Redirect("Display Images.aspx");
                }
                else
                {
                    Response.Write("<script>alert('please select file');</script>");
                }

                    //}
              
                    //else
                    //{
                    //    Response.Write("<script>alert('Image file size must be lessthan or equal to 100kb');</script>");
                    //}
               
        //         }
        //else
        //       {
        
        //        Response.Write("<script>alert('upload image file only');</script>");
        //       }

           
           
        }
    }
    }

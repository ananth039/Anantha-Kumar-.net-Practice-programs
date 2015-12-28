using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;
using System.Data;
using System.IO;
public partial class Users_EditUserDetails : System.Web.UI.Page
{
    DAUsers usrs=new DAUsers();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            usrs.Username = Session["UserName"].ToString();
            GetUserDetails(usrs);
        }
    }
    public void GetUserDetails(DAUsers usrs)
    {
        usrs.Username = Session["UserName"].ToString();
        DataTable dt = usrs.GetUserDetails(usrs);

        txtName.Text = dt.Rows[0][0].ToString();
        string gender = dt.Rows[0][1].ToString();
        txtDob.Text = dt.Rows[0]["DateOfBirth"].ToString();
        txtAddress.Text = dt.Rows[0][3].ToString();
        txtZipcode.Text = dt.Rows[0][4].ToString();
        txtphno.Text = dt.Rows[0][5].ToString();
        txtEmail.Text = dt.Rows[0][6].ToString();
        txtUserName.Text = dt.Rows[0][7].ToString();

        if (gender == rbMale.Text)
        {
            rbMale.Checked = true;
        }
        else if (gender == rbFemale.Text)
        {
            rbFemale.Checked = true;

        }
        else
        {
            rbMale.Checked = false;
            rbMale.Checked = false;
        }

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
     
        string gender = null;
        if (rbMale.Checked == true)
        {
            gender = rbMale.Text;

        }
        else
        {
            gender = rbFemale.Text;
        }
        usrs.Name = txtName.Text;
        usrs.Username = txtUserName.Text;
        usrs.Gender = gender;
        usrs.DateOfBirth = txtDob.Text;
        usrs.Address = txtAddress.Text;
        usrs.ZipCode = txtZipcode.Text;
        usrs.Phno = txtphno.Text;
        usrs.Email = txtEmail.Text;
       
        int i = usrs.UpdateUserDetails(usrs);
        if (i > 0)
        {
            Response.Write("<script>alert('Details are sucessfully updated');</script>");
        }
        Response.Redirect("PersonalDetails.aspx");
    }
    protected void btnUploadImage_Click(object sender, EventArgs e)
    {
        usrs.Username = Session["UserName"].ToString();
        if(FileUploadImage.HasFile)
        {
            //get the extension of file
            string extension=Path.GetExtension(FileUploadImage.PostedFile.FileName);
            
            //check file extension 
            if (extension == ".jpg" || extension == ".bmp" || extension == ".gif" || extension == ".png")
            {
                //get the file size
                int size = FileUploadImage.PostedFile.ContentLength;

                //create byte array to store the binary image data
                byte[] imagebyte = new byte[size];

                //store the currently selected file in memory
                HttpPostedFile img = FileUploadImage.PostedFile;
                //select the binary Data
                img.InputStream.Read(imagebyte, 0, size);
                usrs.photo = imagebyte;

              int FileUploadStatus=usrs.UploadImage(usrs);

                if(FileUploadStatus>0)
                {
                    Response.Write("<script>alert('successfully uploaded');</script>");
        
                }
                else
                {
                    Response.Write("<script>alert('failure');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('please select upload Image file Only.ie; jpg,bmp,gif,png formats');</script>");
            }


        }
        else
        {
            Response.Write("<script>alert('please select file');</script>");
        }
        Response.Redirect("PersonalDetails.aspx");
    }
}

    
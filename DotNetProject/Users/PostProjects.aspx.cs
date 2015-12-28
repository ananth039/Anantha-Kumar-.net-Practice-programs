using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;
using System.IO;

public partial class Users_PostProjects_aspx : System.Web.UI.Page
{
    DAUsers usrs = new DAUsers();
    DAProjects project = new DAProjects();
    protected void Page_Load(object sender, EventArgs e)
    {
        AutoGenerateProjectId();
    }

    private void AutoGenerateProjectId()
    {
        project.ProjectId = project.AutoGenerateProjectId();
        lblDisplayProjectId.Text = project.ProjectId.ToString();
    }

    protected void btnUploadProject_Click(object sender, EventArgs e)
    {
        if (FileUploadProject.HasFile)
        {

            string filename = Path.GetFileName(FileUploadProject.PostedFile.FileName);
            string extension = Path.GetExtension(FileUploadProject.PostedFile.FileName);
            if (extension == ".jpg" || extension == ".bmp" || extension ==".gif" || extension == ".png")
            {
                 Response.Write("<script>alert('please upload Project files like as .docx,.exe,.txt,.cs and other etc ')</script>");
            
            }
              else
              {
             
            
                Stream str = FileUploadProject.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(str);
                Byte[] size = br.ReadBytes((int)str.Length);
             

                usrs.Username = Session["UserName"].ToString();
                project.LoginId = usrs.GetLoginId(usrs);

                project.FileName = filename;
                project.ProjectType = txtProjectType.Text;
                project.FileType = extension;
                project.FileData = size;
                int status = project.InsertpostProjects(project);
                if (status > 0)
                {
                    Response.Write("<script>alert('your project is successfully posted')</script>");
                }
                else
                {
                    Response.Write("<script>alert('your project is not successfully posted')</script>");
                }
                AutoGenerateProjectId();
                txtProjectType.Text = "";
            }
           

        }
        else
        {
            Response.Write("<script>alert('please select Project file')</script>");
        }
    }
}
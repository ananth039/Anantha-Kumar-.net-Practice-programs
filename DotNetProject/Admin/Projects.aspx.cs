using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAcessLayer;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_Projects : System.Web.UI.Page
{

    //connection is established to  dotnetProject database.
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dotnetProject"].ConnectionString);
    DAProjects project = new DAProjects();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayAllProjects();
        }

    }

    private void DisplayAllProjects()
    {
        GridViewProjects.DataSource = project.GetAllProjects();
        GridViewProjects.DataBind();
    }

    
     protected void ImageButtonDownloadProject_Click(object sender, ImageClickEventArgs e)
    {
    ImageButton imgbtn = sender as ImageButton;
    GridViewRow grow = imgbtn.NamingContainer as GridViewRow;
    int field = Convert.ToInt32(GridViewProjects.DataKeys[grow.RowIndex].Value.ToString());
    con.Open();
    SqlCommand cmd = new SqlCommand("select FileName,filetype,FileData from Projects where projectId=@projectId", con);
    cmd.Parameters.AddWithValue("@projectId", field);
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
        Response.ContentType = dr["filetype"].ToString();
        Response.AddHeader("Content-Disposition", "attachment;Filename=\"" + dr["FileName"] + "\"");
        Response.BinaryWrite((byte[])dr["FileData"]);
        Response.End();
}
}


     protected void ImageButtonDeleteProject_Click(object sender, ImageClickEventArgs e)
     {
         ImageButton imgbtn = sender as ImageButton;
         GridViewRow grow = imgbtn.NamingContainer as GridViewRow;
         project.ProjectId= Convert.ToInt32(GridViewProjects.DataKeys[grow.RowIndex].Value.ToString());
         int projectDeleteStatus = project.DeleteProject(project);
         if(projectDeleteStatus>0)
         {
             Response.Write("<script>alert('" + projectDeleteStatus + " is deleted successfully')</script>");
             DisplayAllProjects();
         }
         else
         {
             Response.Write("<script>alert('" + projectDeleteStatus + " is not  deleted')</script>");
             DisplayAllProjects();
             
         }
         
     }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;
using System.Data.SqlClient;
using System.Configuration;

public partial class Users_View_SearchProjects : System.Web.UI.Page
{

    //connection is established to  dotnetProject database.
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dotnetProject"].ConnectionString);

    DAProjects project = new DAProjects();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DisplayAllProjects();
        }
        
    }

    private void DisplayAllProjects()
    {
        GridViewProjects.DataSource = project.GetAllProjects();
        GridViewProjects.DataBind();
    }

    protected void linkButtonDownloadProject_Click(object sender, EventArgs e)
    {
        LinkButton linkbtn = sender as LinkButton;
        GridViewRow grow = linkbtn.NamingContainer as GridViewRow;
        int field = Convert.ToInt32(GridViewProjects.DataKeys[grow.RowIndex].Value.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select FileName,filetype,FileData from Projects where projectId=@projectId", con);
            cmd.Parameters.AddWithValue("@projectId",field);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Response.ContentType = dr["filetype"].ToString();
                Response.AddHeader("Content-Disposition", "attachment;Filename=\"" + dr["FileName"] + "\"");
                Response.BinaryWrite((byte[])dr["FileData"]);
                Response.End();
            }
        
         


    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        project.ProjectType = txtKeyword.Text;
        GridViewProjects.DataSource = project.SearchProjects(project);
       
        GridViewProjects.DataBind(); 

    }
    protected void LinkButtonViewAllProjects_Click(object sender, EventArgs e)
    {
        DisplayAllProjects();
    }
    protected void GridViewProjects_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
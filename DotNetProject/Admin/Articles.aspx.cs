using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;
using System.Data;


public partial class Admin_Articles : System.Web.UI.Page
{
    Admin admin = new Admin();
    protected void Page_Load(object sender, EventArgs e)
    {
        BindArticles();

    }

    private void BindArticles()
    {
        GridViewAllArticles.DataSource = admin.GetAllArticles();
        GridViewAllArticles.DataBind();
    }
  
    protected void ImageButtonDelete_Click(object sender, ImageClickEventArgs e)
    {
        int rowIndex = ((sender as ImageButton).NamingContainer as GridViewRow).RowIndex;
        int id = Convert.ToInt32(GridViewAllArticles.DataKeys[rowIndex].Values[0]);
        admin.ArticleId = id;
        Response.Write("<script>prompt('are you want to Delete this article')</script>");
        int deletestatus = admin.DeleteArticle(admin);
        if (deletestatus > 0)
        {
            Response.Write("<script>alert('" + deletestatus + "'Article is Deleted Successfully');</script>");
            BindArticles();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;

public partial class Users_SearchArticles : System.Web.UI.Page
{
    DAArticles articles = new DAArticles();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    
    protected void btnSearch_Click(object sender, ImageClickEventArgs e)
    {
        articles.ArticleType = txtkeyword.Text;
        GridViewArticles.DataSource = articles.SearchArticles(articles);
        GridViewArticles.DataBind();
      
     
    }
}
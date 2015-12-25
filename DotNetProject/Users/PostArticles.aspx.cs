using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using DataAcessLayer;

public partial class Users_PostArticles : System.Web.UI.Page
{
    DAArticles article = new DAArticles();
    DAUsers usrs = new DAUsers();

    protected void Page_Load(object sender, EventArgs e)
    {

        autogenerateArticleId();
        
    }

    private void autogenerateArticleId()
    {

        article.ArticleId = article.AutoGenerateArticleId();
        LblDisplayArticleId.Text = article.ArticleId.ToString();
    }



    protected void btnPostArticles_Click(object sender, EventArgs e)
    {
        usrs.Username = Session["username"].ToString();
        article.ArticleType = txtAricleType.Text;
        article.Description = txtDescription.Text;
        DateTime dt = DateTime.Now;
        article.date = dt.ToShortDateString();
        article.Time = dt.TimeOfDay.ToString() ;
        article.LoginId = usrs.GetLoginId(usrs);
        int statusOfpostQuery =(int) article.InsertPostArticle(article);
        if (statusOfpostQuery > 0)
        {
            lblmsg.Text = "your query is sucessfully posted";
            lblmsg.ForeColor = Color.Green;
            ClearControls(Page.Controls);
            autogenerateArticleId();
           

        }
        else
        {
            lblmsg.Text = "your query is not sucessfully posted";
            lblmsg.ForeColor = Color.Red;
            ClearControls(Page.Controls);
            autogenerateArticleId();
           

        }

    }
    public void ClearControls(ControlCollection ctrl)
    {
       foreach(Control ctl in ctrl)
        {
            if(ctl is TextBox)
            {
                (ctl as TextBox).Text = " ";
            }
            ClearControls(ctl.Controls);
        }
    }
}

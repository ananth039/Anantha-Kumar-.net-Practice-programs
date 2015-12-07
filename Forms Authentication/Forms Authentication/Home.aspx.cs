using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forms_Authentication
{
    public partial class Security_authentication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
           
        }

      

        protected void LinkButtonNewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("Newuser.aspx");
        }

        protected void LinkButtonLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void LinkButtonPostQuery_Click(object sender, EventArgs e)
        {
            Response.Redirect("Postquery.aspx");
        }

        protected void LinkButtonPostAnswer_Click(object sender, EventArgs e)
        {
            Response.Redirect("PostAnswer.aspx");
        }

        protected void LinkButtonDeleteQuery_Click(object sender, EventArgs e)
        {
            Response.Redirect("Secured/DeleteQuery.aspx");
        }

        

        protected void LinkButtonDeleteArticles_Click(object sender, EventArgs e)
        {
            Response.Redirect("Secured/DeleteArticles.aspx");
        }

       
    }
}
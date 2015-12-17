using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing;

namespace dot_net_community_project.Users
{
    public partial class Home : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["username"] == null)
            {
                Server.Transfer("~/Login.aspx");
            }
            else
            {
                string userName = Session["username"].ToString();
                lblWelcome.Text = "Welcome To " + userName;
                lblWelcome.ForeColor = Color.Blue;
            }
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dot_net_community_project.Users
{
    public partial class Signout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Abandon();
                Server.Transfer("~/Login.aspx");
               
            }
            else
            {
                if (Session["username"] == null)
                {
                    Server.Transfer("~/Login.aspx");
                }
            }
           
        }
    }
}
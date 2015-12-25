using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Signout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session.Abandon();
            Server.Transfer("~/Default.aspx");

        }
        else
        {
            if (Session["username"] == null)
            {
                Server.Transfer("~/Default.aspx");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Users_Signout : System.Web.UI.Page
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
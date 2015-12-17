using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing;
using DataAccessLayer;

public partial class Users_UserHomepage : System.Web.UI.MasterPage
{
    DAUsers dausrs = new DAUsers();
    protected void Page_Load(object sender, EventArgs e)
    {
        //string userName = Session["username"].ToString();
        //if (Session["username"] == null)
        //{
        //    Server.Transfer("~/Users/Login.aspx");
        //}
        //else
        //{

        //    dausrs.Username = userName;
        //    Image1.ImageUrl = dausrs.getImage(dausrs);
        //    Image1.ToolTip = userName;
        //    Image1.AlternateText = userName;
        //    Image1.Visible = true;


        //}
               
    }
}

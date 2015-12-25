using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;

public partial class Users_UserHomepage : System.Web.UI.MasterPage
{
    DAUsers dausrs = new DAUsers();
    protected void Page_Load(object sender, EventArgs e)
    {


        string userName = Session["username"].ToString();
        if (Session["username"] == null)
        {
            Server.Transfer("~/Users/Login.aspx");
        }
        else
        {

            
            dausrs.Username = userName;
            byte[] bytes = dausrs.GetImage(dausrs);
            if (bytes == null)
            {
                Image1.Visible = false;
            }
            else
            {
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);

                Image1.ImageUrl = "data:image/jpg;base64," + base64String;
                Image1.ToolTip = userName;
                Image1.AlternateText = userName;
                Image1.Visible = true;
            }
            


        }
    }
}

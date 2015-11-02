using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Employee_Registartion
{
    public partial class Home1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"]==null)
            {
                LbluserName.Visible = false;
                imguser.Visible = false;
                hplLogout.Visible = false;
            }
            else
            {
                LbluserName.Text = "Login as " + Session["Username"].ToString();
                LbluserName.Font.Size = 20;
                LbluserName.ForeColor = Color.Red;

                imguser.ImageUrl = @"images\user.png";
                hplLogout.Visible = true;
            
            }
          
          
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if(Session["Username"]==null)
            {

                Response.Redirect("Login.aspx");
            }
            else
            {
                Session["Username"] = Session["Username"];
                Response.Redirect("EditDetails.aspx");
            }
        }
    }
}
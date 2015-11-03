using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Employee_Registartion
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
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
    }
}
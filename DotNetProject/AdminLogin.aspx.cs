using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;
using System.Drawing;

public partial class AdminLogin : System.Web.UI.Page
{
    Admin admin = new Admin();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        admin.Username = txtUserName.Text;
        admin.Password = txtPassword.Text;
        int userCount = admin.LoginUserAuthentication(admin);
        Session["Adminname"] = admin.Username;
        if (userCount > 0)
        {
            Server.Transfer("~/Admin/AdminHomePage.aspx");
        }
        else
        {
            lblmsg.Text = "Invalid user name and password";
            lblmsg.ForeColor = Color.Red;
        }
    }
}
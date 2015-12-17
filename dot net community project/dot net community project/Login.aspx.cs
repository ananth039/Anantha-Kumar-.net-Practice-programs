using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using DataAccessLayer;
using System.Drawing;

namespace dot_net_community_project
{
    public partial class Login : System.Web.UI.Page
    {
        DAUsers dausr = new DAUsers();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            dausr.Username = txtUserName.Text;
            dausr.Password = txtPassword.Text;
            int userCount = dausr.LoginUserAuthentication(dausr);
            Session["username"] = dausr.Username;
            if(userCount>0)
            {
                Server.Transfer("~/Users/UserHome.aspx");    
            }
            else
            {
                lblmsg.Text = "Invalid user name and password";
                lblmsg.ForeColor = Color.Red;
            }
        }
    }
}
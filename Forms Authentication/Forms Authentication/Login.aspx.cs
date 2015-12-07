using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;

namespace Forms_Authentication
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Project"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_UserRegistration", con);
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Type", 'l');
            cmd.CommandType = CommandType.StoredProcedure;
            int i =(int) cmd.ExecuteScalar();
            if(i==1)
            {
                string uid = txtUserName.Text;
      
                FormsAuthentication.RedirectFromLoginPage(uid, true);
             
                
            }
            else 
            {
                lblmsg.Text = "Invalid username and password";
            }
        }

        protected void LinkButtonHome_Click(object sender, EventArgs e)
        {
            Server.TransferRequest("Home.aspx");
        }
    }
}
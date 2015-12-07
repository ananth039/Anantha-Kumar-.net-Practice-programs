using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Forms_Authentication
{
    public partial class Newuser : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Project"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_UserRegistration", con);
           
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Type", "i");
            cmd.CommandType = CommandType.StoredProcedure;
         

                int j = cmd.ExecuteNonQuery();

                if (j > 0)
                {
                    Response.Write("successfully registered");

                }
                else
                {
                    Response.Write("not registered");
                }

                con.Close();
                Response.Redirect("Login.aspx");

           

        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSignup_Click(object sender, EventArgs e)
    {
        Response.Redirect("Employee Registartion.aspx");
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        StringBuilder error = new StringBuilder();

        string ConnectionString = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select Username,Password from users",connection);
            using(SqlDataReader usersReader=command.ExecuteReader())
            {
                while(usersReader.Read())
                {
                    if (txtuserName.Text.Equals(usersReader["Username"]) && txtPassword.Text .Equals(usersReader["Password"]))
                    {
                    

                        Session["Username"] = usersReader["Username"];
                        Response.Redirect("default.aspx");

                    }
                    else
                    {
                        error.Append("invalid user name and password");
                        Response.Write(error);
                        break;
                    }
                }
            }

           
        }

        
       
    }
}
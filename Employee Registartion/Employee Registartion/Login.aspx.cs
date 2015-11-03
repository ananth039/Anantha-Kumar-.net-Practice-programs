using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Registartion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            

            string ConnectionString = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select Username,Password from EmpRegistration", connection);
                using (SqlDataReader usersReader = command.ExecuteReader())
                {
                    while (usersReader.Read())
                    {
                        if (txtuserName.Text.Equals(usersReader["Username"]) && txtPassword.Text.Equals(usersReader["Password"]))
                        {


                            Session["Username"] = usersReader["Username"];
                            Response.Redirect("Home.aspx");

                        }
                        else
                        {
                           lblMessage.Text= "invalid user name and password";
                           
                        }
                    }
                }


            }

        
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpRegistration.aspx");
        }

        

    }
}
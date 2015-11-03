using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;

namespace Employee_Registartion
{
    public partial class Home1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           


        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {

                Response.Redirect("Login.aspx");
            }
            else
            {
                Session["Username"] = Session["Username"];
                Response.Redirect("EditDetails.aspx");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {

                Response.Redirect("Login.aspx");
            }
            else
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;

                string LoginUserName = Session["username"].ToString();

                using (SqlConnection connection2 = new SqlConnection(connectionstring))
                {
                    connection2.Open();
                    SqlCommand deleteCommand = new SqlCommand("delete EmpRegistration where username!=@LoginUserName", connection2);


                    //dd new SqlParameters to the insertCommand.


                    deleteCommand.Parameters.Add(new SqlParameter("LoginUserName", LoginUserName));

                    try
                    {


                        deleteCommand.ExecuteNonQuery();
                        Response.Write(" sucessfully deleted");
                        Response.Redirect("Home.aspx");

                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                }



            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net_Global_variables
{
    public partial class retrive_all_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["employeedetails"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select  * from Employee", con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridViewempdetails.DataSource = dr;
            GridViewempdetails.DataBind();
            con.Close();

        }
    }
}
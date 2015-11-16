using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gridview_with_connection_oriented_architecture
{
    public partial class gridview_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["employe"].ConnectionString;
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee", con);
            SqlDataReader dr = cmd.ExecuteReader();
            Gridemp.DataSource = dr;
            Gridemp.DataBind();
            con.Close();
          
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
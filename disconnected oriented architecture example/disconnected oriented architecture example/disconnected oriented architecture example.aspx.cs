using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient; //sql commands
using System.Data; //data set

namespace disconnected_oriented_architecture_example
{
    public partial class disconnected_oriented_architecture_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["employee"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from employee", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Employee");
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DetailsView1.DataSource = ds;
            DetailsView1.DataBind();

            

        }

      
    }
}
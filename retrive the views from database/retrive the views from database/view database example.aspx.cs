using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace retrive_the_views_from_database
{
    public partial class view_database_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["employeeDetails"].ConnectionString);
            SqlCommand cmd=new SqlCommand("select * from EmpView",con);
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds,"empdetails");
            GridView1.DataSource=ds.Tables["empdetails"];
            GridView1.DataBind();
           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gridview_ex_1_with_connection_oriented_Architecture
{
    public partial class gridview_example1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["employe"].ConnectionString;
            SqlConnection con = new SqlConnection(Connectionstring);
            SqlCommand cmd = new SqlCommand("Select * from Employee", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "employee");
            GridEmp.DataSource = ds.Tables["employee"];
            GridEmp.DataBind();


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
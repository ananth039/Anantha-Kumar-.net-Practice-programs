using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace display_values_from_table_using_stored_procedures
{
    public partial class select_query_procedures : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

             String strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
             using (SqlConnection con = new SqlConnection(strConnString))
             {


                 SqlCommand cmd = new SqlCommand();
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.CommandText = "usp_Mobiles";
                 cmd.Connection = con;
                 try
                 {
                     con.Open();
                     GridView1.EmptyDataText = "No Records Found";
                     GridView1.DataSource = cmd.ExecuteReader();
                     GridView1.DataBind();
                 }
                 catch (Exception ex)
                 {
                     throw ex;
                 }
             }
        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace gidview_custmization
{
    public partial class example_1 : System.Web.UI.Page
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["emp"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employe2", con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridEmp.DataSource = dr;
            GridEmp.DataBind();
            con.Close();
           
        }
      
            

        protected void GridEmp_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
              SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            GridViewRow row = (GridViewRow)GridEmp.Rows[e.RowIndex];
            Label label1 = (Label)row.FindControl("lbldelete");
            try
            {


                int enumber = Convert.ToInt32(label1.Text);
                SqlCommand cmd = new SqlCommand("delete  employe2 where empno=" + enumber, con);

                cmd.ExecuteNonQuery();
                con.Close();
                lblmsg.Text = "Employee record is deleted sucessfully";
                Response.Redirect("example 1.aspx");
            }catch(Exception ex)
            {
                lblmsg.Text = ex.Message;
            }
            
        }
        
    }
}
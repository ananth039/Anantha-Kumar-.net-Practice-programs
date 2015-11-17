using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace gidview_custmization
{
    public partial class Edit_operation_grid_view : System.Web.UI.Page
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["emp"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                bind();


            }

        }

        private void bind()
        {
         
            SqlConnection con = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "EmpDetails");
            GridViewempEdit.DataSource = ds.Tables["EmpDetails"];
            GridViewempEdit.DataBind();
        }

        protected void GridViewempEdit_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewempEdit.EditIndex = -1;
            bind();
            lblmsg.Text = "Employee salary updated is cancelled";
        }

        protected void GridViewempEdit_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewempEdit.EditIndex = e.NewEditIndex;
            bind();
        }

        protected void GridViewempEdit_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            GridViewRow row = (GridViewRow)GridViewempEdit.Rows[e.RowIndex];
            Label l1 = (Label)row.FindControl("lbleno");
            int eno = Convert.ToInt32(l1.Text);
         
            TextBox txt4 = (TextBox)row.FindControl("txtsal");
           int sal =Convert.ToInt32(txt4.Text);
         
            GridViewempEdit.EditIndex = -1;
            SqlCommand cmd = new SqlCommand("update Employee set salary=@sal where eno=@eno", con);
           
             cmd.Parameters.AddWithValue("@sal", sal);
            
          
            
            cmd.Parameters.AddWithValue("@eno", eno);
            cmd.ExecuteNonQuery();
            con.Close();
            bind();
            lblmsg.Text = "Employe details updated";

        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gidview_custmization
{
    public partial class gridview_Edit_and_Delete : System.Web.UI.Page
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
            string connectionstring = ConfigurationManager.ConnectionStrings["emp"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridViewempEdit.DataSource = dr;
            GridViewempEdit.DataBind();
            con.Close();
        }

        protected void GridViewempEdit_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewempEdit.EditIndex = e.NewEditIndex;
            bind();
        }

        protected void GridViewempEdit_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            Update(e);
        }

        private void Update(GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            GridViewRow row = (GridViewRow)GridViewempEdit.Rows[e.RowIndex];
            Label l1 = (Label)row.FindControl("lbleno");
            int eno = Convert.ToInt32(l1.Text);
            TextBox t1 = (TextBox)row.FindControl("txtsal");
            int sal = Convert.ToInt32(t1.Text);
            GridViewempEdit.EditIndex = -1;
            SqlCommand cmd = new SqlCommand("update Employee set salary=@sal where eno=@eno", con);
            cmd.Parameters.AddWithValue("@sal", sal);
            cmd.Parameters.AddWithValue("@eno", eno);
            cmd.ExecuteNonQuery();
            con.Close();
            lblmsg.Text = "salary is updated";
        }

        protected void GridViewempEdit_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewempEdit.EditIndex=- 1;
            bind();
            lblmsg.Text = "Updating is Cancelled";
        }

        protected void GridViewempEdit_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["emp"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            GridViewRow row = (GridViewRow)GridViewempEdit.Rows[e.RowIndex];
            Label l1 = (Label)row.FindControl("lbleno");
            int eno = Convert.ToInt32(l1.Text);
            SqlCommand cmd = new SqlCommand("delete employee where eno=@eno", con);
            cmd.Parameters.AddWithValue("@eno", eno);
            cmd.ExecuteNonQuery();
            con.Close();
            bind();
            lblmsg.Text = "Employee record is Deleted";
        }

        protected void GridViewempEdit_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="Edit")
            {
                GridViewempEdit.EditIndex = e.NewEditIndex;
                if(e.CommandName=="Update")
                {
                    SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            GridViewRow row = (GridViewRow)GridViewempEdit.Rows[e.RowIndex];
            Label l1 = (Label)row.FindControl("lbleno");
            int eno = Convert.ToInt32(l1.Text);
            TextBox t1 = (TextBox)row.FindControl("txtsal");
            int sal = Convert.ToInt32(t1.Text);
            GridViewempEdit.EditIndex = -1;
            SqlCommand cmd = new SqlCommand("update Employee set salary=@sal where eno=@eno", con);
            cmd.Parameters.AddWithValue("@sal", sal);
            cmd.Parameters.AddWithValue("@eno", eno);
            cmd.ExecuteNonQuery();
            con.Close();
            lblmsg.Text = "salary is updated";
                }
                else if(e.CommandName=="Cancel")
                {
                    GridViewempEdit.EditIndex=-1;
                    bind();
                    lblmsg.Text = "updating is cancelled";

                }
                else
                {
                    lblmsg.Text = "";
                }
            }

        }
    }
}
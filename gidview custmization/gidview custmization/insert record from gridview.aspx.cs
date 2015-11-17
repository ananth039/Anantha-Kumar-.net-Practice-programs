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
    public partial class insert_record_from_gridview : System.Web.UI.Page
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
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employee", con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
            GridView1.FooterRow.Visible = false;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="Add")
            {
                GridView1.FooterRow.Visible = true;
            }
            else if(e.CommandName=="Save")
            {

                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                TextBox txtEno = (TextBox)GridView1.FooterRow.FindControl("txtEmpno");
                TextBox txtEname = (TextBox)GridView1.FooterRow.FindControl("txtEmpname");
                TextBox txtAge = (TextBox)GridView1.FooterRow.FindControl("txtage");
                TextBox txtAddress = (TextBox)GridView1.FooterRow.FindControl("txtaddress");
                TextBox txtSal = (TextBox)GridView1.FooterRow.FindControl("txtsal");
                TextBox txtDesigation = (TextBox)GridView1.FooterRow.FindControl("txtdesigation");
                int eno = Convert.ToInt32(txtEno.Text);
                string ename = txtEname.Text;
                int age = Convert.ToInt32(txtAge.Text);
                string address = txtAddress.Text;
                int sal = Convert.ToInt32(txtSal.Text);
                string designation = txtDesigation.Text;
                try
                {


                    SqlCommand cmd = new SqlCommand("insert into employee values(@eno,@ename,@age,@address,@sal,@desg)", con);
                    cmd.Parameters.AddWithValue("@eno", eno);
                    cmd.Parameters.AddWithValue("@ename", ename);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@sal", sal);
                    cmd.Parameters.AddWithValue("@desg", designation);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    lblmsg.Text = "Records inserted sucessfully";
                    bind();
                }
                catch(Exception ex)
                {
                    lblmsg.Text = "Employee id is already exist.";
                }
               
            }

        }
    }
}
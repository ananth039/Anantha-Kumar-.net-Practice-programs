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
    public partial class select_Operation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                string connectionstring = ConfigurationManager.ConnectionStrings["emp"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Employee", con);
                SqlDataReader dr = cmd.ExecuteReader();
                GridEmp.DataSource = dr;
                GridEmp.DataBind();
                con.Close();
            }
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridEmp.Rows[e.NewSelectedIndex];
            Label label1 = (Label)row.FindControl("lbleno");
            int eno = Convert.ToInt32(label1.Text);
            Label label2 = (Label)row.FindControl("lblename");
            string ename = label2.Text;
            Label label3 = (Label)row.FindControl("lblage");
            int age = Convert.ToInt32(label3.Text);
            Label label4 = (Label)row.FindControl("lbladdress");
            string address = label4.Text;
            Label label5 = (Label)row.FindControl("lblsal");
            int sal = Convert.ToInt32(label5.Text);
            Label label6 = (Label)row.FindControl("lbldesigation");
            string desgination =label6.Text;
            lblEmpno.Text ="Employee No: "+eno.ToString();
            lblEname.Text = "Employee Name:"+ename;
            lblage.Text = "Age :"+age.ToString();
            lbladdress.Text ="Adrees :"+address;
            lbldesignation.Text ="Designation: " +desgination;
           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace delete_operation
{
    public partial class delete_operation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Connectionstring = ConfigurationManager.ConnectionStrings["employee"].ConnectionString;
                SqlConnection con = new SqlConnection(Connectionstring);


                SqlCommand cmd = new SqlCommand("select * from employe2", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Empdetails");
                con.Close();
                ddlEno.DataSource = ds.Tables["Empdetails"];
                ddlEno.DataTextField = "empno";
                ddlEno.DataBind();
            }

        }
        
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["employee"].ConnectionString;
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            int eno = Convert.ToInt32(ddlEno.SelectedItem.Value);

            SqlCommand cmd = new SqlCommand("delete from employe2 where empno=@eno", con);
            cmd.Parameters.AddWithValue("@eno", eno);
            cmd.ExecuteNonQuery();
            con.Close();
            lblmsg.Text = "Employee record is deleted";
        }
    }
}
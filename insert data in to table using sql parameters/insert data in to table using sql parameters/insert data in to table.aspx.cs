using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace insert_data_in_to_table_using_sql_parameters
{
    public partial class insert_data_in_to_table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["employee"].ConnectionString;
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            int eno = Convert.ToInt32(txtempno.Text);
            string ename = txtEname.Text;
            int sal = Convert.ToInt32(txtsalary.Text);
            SqlCommand cmd = new SqlCommand("insert into employe2 values(@empno,@empname,@sal)", con);
            cmd.Parameters.AddWithValue("@empno",eno);
            cmd.Parameters.AddWithValue("@empname",ename);
            cmd.Parameters.AddWithValue("@sal",sal);

            cmd.ExecuteNonQuery();
            con.Close();
            lblmsg.Text = "Employee record is inserted";
            txtsalary.Text = "";
            txtEname.Text = "";
            txtempno.Text = "";
           

        }
    }
}